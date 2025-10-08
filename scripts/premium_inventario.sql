DROP DATABASE IF EXISTS inventario_equipos;
CREATE DATABASE inventario_equipos;
USE inventario_equipos;

-- ===========================================================
-- TABLA: Categorías
-- Clasifica los equipos (Laptops, Monitores, Impresoras, etc.)
-- ===========================================================
CREATE TABLE Categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre_categoria VARCHAR(100) NOT NULL,
    descripcion TEXT
);

-- ===========================================================
-- TABLA: Estados_Equipos
-- Define los posibles estados del equipo
-- ===========================================================
CREATE TABLE Estados_Equipos (
    id_estado INT AUTO_INCREMENT PRIMARY KEY,
    nombre_estado VARCHAR(50) NOT NULL,
    descripcion TEXT
);

-- ===========================================================
-- TABLA: Usuarios
-- Registra a las personas que pueden retirar o devolver equipos
-- ===========================================================
CREATE TABLE Usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre_completo VARCHAR(150) NOT NULL,
    usuario_login VARCHAR(50) UNIQUE NOT NULL,
    contraseña VARCHAR(255) NOT NULL, -- para almacenamiento seguro (hash)
    puesto VARCHAR(100),
    departamento VARCHAR(100),
    telefono VARCHAR(20),
    correo VARCHAR(100) UNIQUE NOT NULL
);

-- ===========================================================
-- TABLA: Bodegas
-- Almacena la información de las bodegas físicas
-- ===========================================================
CREATE TABLE Bodegas (
    id_bodega INT AUTO_INCREMENT PRIMARY KEY,
    nombre_bodega VARCHAR(100) NOT NULL,
    ubicacion_bodega VARCHAR(150),
    capacidad_bodega DOUBLE
);

-- ===========================================================
-- TABLA: Equipos
-- Información detallada de cada equipo del inventario
-- ===========================================================
CREATE TABLE Equipos (
    id_equipo INT AUTO_INCREMENT PRIMARY KEY,
    codigo_inventario VARCHAR(50) UNIQUE NOT NULL,
    nombre_equipo VARCHAR(150) NOT NULL,
    marca VARCHAR(100),
    modelo VARCHAR(100),
    numero_serie VARCHAR(100),
    descripcion TEXT,
    id_categoria INT,
    id_estado INT,
    id_bodega INT,
    fecha_ingreso DATETIME DEFAULT CURRENT_TIMESTAMP,
    observaciones TEXT,
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria),
    FOREIGN KEY (id_estado) REFERENCES Estados_Equipos(id_estado),
    FOREIGN KEY (id_bodega) REFERENCES Bodegas(id_bodega)
);

-- ===========================================================
-- TABLA: Movimientos
-- Registra los retiros, devoluciones o cambios de estado
-- ===========================================================
CREATE TABLE Movimientos (
    id_movimiento INT AUTO_INCREMENT PRIMARY KEY,
    id_equipo INT NOT NULL,
    id_usuario INT NOT NULL,
    id_bodega_origen INT NULL,
    id_bodega_destino INT NULL,
    tipo_movimiento ENUM('Retiro', 'Devolución', 'Reparación', 'Asignación', 'Baja') NOT NULL,
    fecha_movimiento DATETIME DEFAULT CURRENT_TIMESTAMP,
    observaciones TEXT,
    FOREIGN KEY (id_equipo) REFERENCES Equipos(id_equipo),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_bodega_origen) REFERENCES Bodegas(id_bodega),
    FOREIGN KEY (id_bodega_destino) REFERENCES Bodegas(id_bodega)
);

-- ===========================================================
-- TABLA: AuthCodes
-- Guarda códigos/token temporales para acceso a bodega
-- ===========================================================
CREATE TABLE AuthCodes (
    id_authcode INT AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(12) UNIQUE NOT NULL, -- código único generado
    id_usuario INT NOT NULL,            -- usuario que solicita acceso
    id_movimiento INT NULL,             -- movimiento asociado (opcional)
    fecha_generacion DATETIME DEFAULT CURRENT_TIMESTAMP,
    fecha_expiracion DATETIME NOT NULL, -- cuándo expira el código
    usado BOOLEAN DEFAULT FALSE,        -- si ya se usó
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_movimiento) REFERENCES Movimientos(id_movimiento)
);