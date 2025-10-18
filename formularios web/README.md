# Formularios web - Inventario PremiumSA

Este directorio contiene dos formularios web sencillos (HTML + Bootstrap + JS) pensados para integrarse con una API ASP.NET Core 8 que a su vez se conecta a la base de datos local MySQL definida en `scripts/premium_inventario.sql`.

Archivos creados:
- `login.html` - formulario de login que solicita `usuario_login` y `contrasena` y recibe un código de 6 dígitos.
- `validate_and_move.html` - formulario que valida el código y permite registrar movimientos.
- `assets/js/login.js` - cliente JS para el endpoint `/api/auth/login`.
- `assets/js/validate_move.js` - cliente JS para validar códigos y enviar movimientos a `/api/movimientos`.
- `assets/css/styles.css` - estilos mínimos.

Contrato API asumido (ejemplos JSON)

1) POST /api/auth/login
Request:
{
  "usuario_login": "usuario",
  "contrasena": "secreto"
}
Response 200 ok (éxito):
{
  "success": true,
  "codigo": "123456",
  "expiresAt": "2025-10-15T12:34:56Z",
  "message": "Código generado"
}
Response 400/401 (error):
{
  "success": false,
  "message": "Credenciales inválidas"
}

2) POST /api/auth/validate-code
Request:
{
  "codigo": "123456"
}
Response success:
{
  "valid": true,
  "id_usuario": 5,
  "id_bodega": 2,
  "message": "Código válido"
}
Response invalid/used/expired:
{
  "valid": false,
  "message": "Código expirado o ya usado"
}

3) POST /api/movimientos
Payload desde el formulario (ejemplo):
{
  "codigo_autorizacion": "123456",
  "tipo_movimiento": "Retiro",
  "id_bodega": 2,
  "productos": [ { "id_equipo": 12, "cantidad": 1 }, { "id_equipo": 15, "cantidad": 2 } ],
  "observaciones": "Salida para mantenimiento"
}
Response success:
{ "success": true, "message": "Movimiento registrado" }

Notas y supuestos:
- Se asume comunicación por HTTPS entre los formularios y la API.
- La API debe validar que el código no haya sido usado y que no esté expirado, marcarlo como usado si procede, y registrar los movimientos actualizando las tablas `Movimientos` e `Inventario_Equipos`.
- Para pruebas locales puede servir los archivos estáticos con un servidor simple (ej. `python -m http.server 8080`) y apuntar el `fetch` a la URL local de la API.

Cómo probar localmente (PowerShell):

```powershell
# Desde la carpeta "formularios web":
cd "c:\PREMIUM S.A\Inventario-PremiumSA\formularios web"
# Servir archivos estáticos (requiere Python instalado):
python -m http.server 8080
# Abrir en el navegador: http://localhost:8080/login.html
```

Siguientes pasos recomendados:
- Implementar los endpoints en la API ASP.NET Core 8 según el contrato.
- Asegurar CORS para permitir peticiones desde el host donde se sirvan los formularios.
- Añadir manejo de tokens o sesiones si se desea mayor seguridad.
