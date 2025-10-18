// login.js - maneja el envío del formulario de login y muestra el código recibido
document.addEventListener('DOMContentLoaded', function() {
  const form = document.getElementById('loginForm');
  const alertPlaceholder = document.getElementById('alert-placeholder');
  const codigoDiv = document.getElementById('codigoResult');
  const codigoSpan = document.getElementById('codigo');
  const expiresSpan = document.getElementById('expires');

    function showAlert(message, type = 'danger', timeout = 4000) {
        alertPlaceholder.innerHTML = `<div class="alert alert-${type}" role="alert">${message}</div>`;
        if (timeout) setTimeout(() => alertPlaceholder.innerHTML = '', timeout);
    }


  form.addEventListener('submit', async (e) => {
    e.preventDefault();
    alertPlaceholder.innerHTML = '';
    const usuario = document.getElementById('usuario').value.trim();
    const contrasena = document.getElementById('contrasena').value;

    if(!usuario || !contrasena){
      showAlert('Completa usuario y contraseña.');
      return;
    }

    try{
      const res = await fetch('/api/auth/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ usuario_login: usuario, contrasena })
      });

      if(!res.ok){
        const err = await res.json().catch(()=>({ message: 'Error en la petición' }));
        showAlert(err.message || 'Error en autenticación', 'danger');
        return;
      }

      const body = await res.json();
      if(body.success){
        codigoSpan.textContent = body.codigo || '---';
        expiresSpan.textContent = body.expiresAt || '';
        codigoDiv.style.display = 'block';
        showAlert('Inicio de sesión correcto. Código generado.', 'success');
      } else {
        showAlert(body.message || 'Credenciales inválidas', 'danger');
      }

    } catch(err){
      console.error(err);
      showAlert('No se pudo conectar al servidor.');
    }
  });
});