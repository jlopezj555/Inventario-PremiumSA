// validate_move.js - valida un código y permite enviar movimientos
document.addEventListener('DOMContentLoaded', function(){
  const codeForm = document.getElementById('codeForm');
  const moveSection = document.getElementById('moveSection');
  const alertPlaceholder = document.getElementById('alert-placeholder');
  const moveForm = document.getElementById('moveForm');
  let validatedCode = null;

    function showAlert(message, type = 'danger', timeout = 4000) {
        alertPlaceholder.innerHTML = `<div class="alert alert-${type}" role="alert">${message}</div>`;
        if (timeout) setTimeout(() => alertPlaceholder.innerHTML = '', timeout);
    }


  codeForm.addEventListener('submit', async (e) => {
    e.preventDefault();
    alertPlaceholder.innerHTML = '';
    const code = document.getElementById('authCode').value.trim();
    if(!code){ showAlert('Introduce el código.'); return; }

    try{
      const res = await fetch('/api/auth/validate-code', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ codigo: code })
      });
      if(!res.ok){
        const err = await res.json().catch(()=>({ message: 'Error al validar' }));
        showAlert(err.message || 'Código inválido');
        return;
       }
       if (!/^\d{6}$/.test(code)) {
            showAlert('El código debe tener 6 dígitos numéricos.');
            return;
       }
      const body = await res.json();
      if(body.valid){
        validatedCode = code;
        moveSection.style.display = 'block';
        showAlert('Código válido. Ya puede registrar movimientos.', 'success');
      } else {
        const msg = body.message || 'Código no válido, usado o expirado.';
        showAlert(msg, 'warning');
      }
    } catch(err){
      console.error(err);
      showAlert('Error de conexión con la API.');
    }
  });

  moveForm.addEventListener('submit', async (e) => {
    e.preventDefault();
    alertPlaceholder.innerHTML = '';
    if(!validatedCode){ showAlert('Valida primero el código.'); return; }

    const tipo = document.getElementById('tipoMovimiento').value;
    const idBodega = document.getElementById('idBodega').value || null;
    const productosRaw = document.getElementById('productos').value.trim();
    const observaciones = document.getElementById('observaciones').value.trim();

    if(!productosRaw){ showAlert('Ingresa al menos un producto.'); return; }

    // Parse products lines: id_equipo,cantidad
    const productos = productosRaw.split('\n').map(line => {
      const parts = line.split(',').map(p => p.trim());
      return { id_equipo: parseInt(parts[0],10), cantidad: parseInt(parts[1]||'1',10) };
    }).filter(p => Number.isInteger(p.id_equipo) && Number.isInteger(p.cantidad));

    if(productos.length === 0){ showAlert('Formato de productos inválido.'); return; }

    const payload = {
      codigo_autorizacion: validatedCode,
      tipo_movimiento: tipo,
      id_bodega: idBodega ? parseInt(idBodega,10) : null,
      productos,
      observaciones
    };

    try{
      const res = await fetch('/api/movimientos', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });

      if(!res.ok){
        const err = await res.json().catch(()=>({ message: 'Error en registro' }));
        showAlert(err.message || 'No se pudo registrar movimiento.');
        return;
      }

      const body = await res.json();
      if(body.success){
        showAlert('Movimiento registrado correctamente.', 'success');
        // Opcional: marcar el código como usado en el backend o actualizar UI
        moveForm.reset();
        moveSection.style.display = 'none';
        validatedCode = null;
      } else {
        showAlert(body.message || 'Error al registrar movimiento.');
      }

    } catch(err){
      console.error(err);
      showAlert('Error de conexión al enviar movimiento.');
    }
  });
});