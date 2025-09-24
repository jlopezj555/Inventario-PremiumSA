DROP DATABASE IF exists inventario_informatico_PremiumSA;
CREATE DATABASE inventario_informatico_PremiumSA;
USE inventario_informatico_PremiumSA;

CREATE TABLE tbl_proveedor (
    ID_proveedor INT PRIMARY KEY AUTO_INCREMENT,
    nombre_proveedor VARCHAR(100) NOT NULL,
    teléfono_proveedor VARCHAR(20),
    correo_proveedor VARCHAR(100),
    dirección_proveedor VARCHAR(150),
    contacto_representante VARCHAR(100)
);
CREATE TABLE tbl_empleado (
    ID_empleado INT PRIMARY KEY AUTO_INCREMENT,
    nombre_empleado VARCHAR(100) NOT NULL,
    apellido_empleado VARCHAR(100) NOT NULL,
    rol_empleado VARCHAR(50),
    usuario_login VARCHAR(50) UNIQUE,
    contraseña VARCHAR(100)
);
CREATE TABLE tbl_categoria_producto (
    ID_categoria INT PRIMARY KEY AUTO_INCREMENT,
    nombre_categoria VARCHAR(100) NOT NULL,
    descripción_categoria VARCHAR(200)
);
CREATE TABLE tbl_producto (
    ID_producto INT PRIMARY KEY AUTO_INCREMENT,
    nombre_producto VARCHAR(100) NOT NULL,
    descripcion_producto VARCHAR(200),
    marca_producto VARCHAR(50),
    modelo_producto VARCHAR(50),
    categoria_producto VARCHAR(50), -- Relación indirecta, se puede normalizar
    precio_unitario DOUBLE NOT NULL,
    stock_actual INT DEFAULT 0,
    stock_minimo INT DEFAULT 0,
    ID_proveedor INT,
    FOREIGN KEY (ID_proveedor) REFERENCES tbl_proveedor(ID_proveedor)
);
CREATE TABLE tbl_compra (
    ID_compra INT PRIMARY KEY AUTO_INCREMENT,
    fecha_compra DATETIME NOT NULL,
    total_compra DOUBLE NOT NULL,
    ID_empleado INT,
    ID_proveedor INT,
    FOREIGN KEY (ID_empleado) REFERENCES tbl_empleado(ID_empleado),
    FOREIGN KEY (ID_proveedor) REFERENCES tbl_proveedor(ID_proveedor)
);
CREATE TABLE tbl_detalle_compra (
    ID_detalle_compra INT PRIMARY KEY AUTO_INCREMENT,
    ID_compra INT,
    ID_producto INT,
    cantidad INT NOT NULL,
    costo_unitario DOUBLE NOT NULL,
    subtotal DOUBLE NOT NULL,
    FOREIGN KEY (ID_compra) REFERENCES tbl_compra(ID_compra),
    FOREIGN KEY (ID_producto) REFERENCES tbl_producto(ID_producto)
);
CREATE TABLE tbl_movimiento (
    ID_movimiento INT PRIMARY KEY AUTO_INCREMENT,
    tipo_movimiento VARCHAR(50) NOT NULL, -- Entrada / Salida
    fecha_movimiento DATETIME NOT NULL,
    ID_empleado INT,
    observacion VARCHAR(200),
    FOREIGN KEY (ID_empleado) REFERENCES tbl_empleado(ID_empleado)
);
CREATE TABLE tbl_bodega (
    ID_bodega INT PRIMARY KEY AUTO_INCREMENT,
    nombre_bodega VARCHAR(100) NOT NULL,
    ubicacion_bodega VARCHAR(150),
    capacidad_bodega DOUBLE
);
CREATE TABLE tbl_detalle_movimiento (
    ID_detalle_movimiento INT PRIMARY KEY AUTO_INCREMENT,
    ID_movimiento INT,
    ID_bodega INT,
    ID_producto INT,
    cantidad INT NOT NULL,
    observacion VARCHAR(200),
    FOREIGN KEY (ID_movimiento) REFERENCES tbl_movimiento(ID_movimiento),
    FOREIGN KEY (ID_bodega) REFERENCES tbl_bodega(ID_bodega),
    FOREIGN KEY (ID_producto) REFERENCES tbl_producto(ID_producto)
);
CREATE TABLE tbl_usuario (
    ID_usuario INT PRIMARY KEY AUTO_INCREMENT,
    nombre_usuario VARCHAR(50) UNIQUE NOT NULL,
    contraseña VARCHAR(100) NOT NULL,
    correo VARCHAR(100) UNIQUE NOT NULL,
    telefono VARCHAR(20)
);