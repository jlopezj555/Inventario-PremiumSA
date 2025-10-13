-- ===========================================================
-- BASE DE DATOS
-- ===========================================================
DROP DATABASE IF EXISTS inventario_equipos;
CREATE DATABASE inventario_equipos;
USE inventario_equipos;

-- ===========================================================
-- TABLAS MAESTRAS
-- ===========================================================
CREATE TABLE Categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre_categoria VARCHAR(100) NOT NULL,
    descripcion TEXT
);

CREATE TABLE Estados_Equipos (
    id_estado INT AUTO_INCREMENT PRIMARY KEY,
    nombre_estado VARCHAR(50) NOT NULL,
    descripcion TEXT
);

CREATE TABLE Usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nombre_completo VARCHAR(150) NOT NULL,
    usuario_login VARCHAR(50) UNIQUE NOT NULL,
    contrasena VARCHAR(255) NOT NULL,
    puesto VARCHAR(100),
    departamento VARCHAR(100),
    telefono VARCHAR(20),
    correo VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Bodegas (
    id_bodega INT AUTO_INCREMENT PRIMARY KEY,
    nombre_bodega VARCHAR(100) NOT NULL,
    ubicacion_bodega VARCHAR(150),
    capacidad_bodega DOUBLE
);

-- ===========================================================
-- TABLA DE EQUIPOS
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
    fecha_garantia DATETIME DEFAULT CURRENT_TIMESTAMP,
    observaciones TEXT,
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria),
    FOREIGN KEY (id_estado) REFERENCES Estados_Equipos(id_estado),
    FOREIGN KEY (id_bodega) REFERENCES Bodegas(id_bodega)
);

-- ===========================================================
-- TABLA DE MOVIMIENTOS
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
-- TABLA DE AUTH CODES
-- ===========================================================
CREATE TABLE AuthCodes (
    id_authcode INT AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(12) UNIQUE NOT NULL,
    id_usuario INT NOT NULL,
    id_movimiento INT NULL,
    fecha_generacion DATETIME DEFAULT CURRENT_TIMESTAMP,
    fecha_expiracion DATETIME NOT NULL,
    usado BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario),
    FOREIGN KEY (id_movimiento) REFERENCES Movimientos(id_movimiento)
);

-- ===========================================================
-- TABLA DE CONTROL DE STOCK
-- ===========================================================
CREATE TABLE Inventario_Equipos (
    id_inventario INT AUTO_INCREMENT PRIMARY KEY,
    nombre_equipo VARCHAR(150) NOT NULL,
    id_categoria INT,
    marca VARCHAR(100),
    modelo VARCHAR(100),
    stock_actual INT DEFAULT 0,
    stock_minimo INT DEFAULT 1,
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria),
    UNIQUE (nombre_equipo, marca, modelo)
);

-- ===========================================================
-- TRIGGERS PARA CONTROL DE STOCK
-- ===========================================================
DELIMITER $$

-- Trigger después de INSERT en Equipos
CREATE TRIGGER trg_inventario_after_insert
AFTER INSERT ON Equipos
FOR EACH ROW
BEGIN
    UPDATE Inventario_Equipos
    SET stock_actual = stock_actual + 1
    WHERE nombre_equipo = NEW.nombre_equipo
      AND (marca = NEW.marca OR (marca IS NULL AND NEW.marca IS NULL))
      AND (modelo = NEW.modelo OR (modelo IS NULL AND NEW.modelo IS NULL));

    IF ROW_COUNT() = 0 THEN
        INSERT INTO Inventario_Equipos (nombre_equipo, id_categoria, marca, modelo, stock_actual)
        VALUES (NEW.nombre_equipo, NEW.id_categoria, NEW.marca, NEW.modelo, 1);
    END IF;
END $$

-- Trigger después de DELETE en Equipos
CREATE TRIGGER trg_inventario_after_delete
AFTER DELETE ON Equipos
FOR EACH ROW
BEGIN
    UPDATE Inventario_Equipos
    SET stock_actual = stock_actual - 1
    WHERE nombre_equipo = OLD.nombre_equipo
      AND (marca = OLD.marca OR (marca IS NULL AND OLD.marca IS NULL))
      AND (modelo = OLD.modelo OR (modelo IS NULL AND OLD.modelo IS NULL));
END $$

-- Trigger después de UPDATE en Equipos (según id_estado)
CREATE TRIGGER trg_inventario_after_update
AFTER UPDATE ON Equipos
FOR EACH ROW
BEGIN
    -- De Disponible a Retirado
    IF OLD.id_estado = 1 AND NEW.id_estado = 2 THEN
        UPDATE Inventario_Equipos
        SET stock_actual = stock_actual - 1
        WHERE nombre_equipo = NEW.nombre_equipo
          AND (marca = NEW.marca OR (marca IS NULL AND NEW.marca IS NULL))
          AND (modelo = NEW.modelo OR (modelo IS NULL AND NEW.modelo IS NULL));
    END IF;

    -- De Retirado a Disponible
    IF OLD.id_estado = 2 AND NEW.id_estado = 1 THEN
        UPDATE Inventario_Equipos
        SET stock_actual = stock_actual + 1
        WHERE nombre_equipo = NEW.nombre_equipo
          AND (marca = NEW.marca OR (marca IS NULL AND NEW.marca IS NULL))
          AND (modelo = NEW.modelo OR (modelo IS NULL AND NEW.modelo IS NULL));
    END IF;
END $$

DELIMITER ;

-- ===========================================================
-- PROCEDIMIENTO PARA REGISTRAR MOVIMIENTOS
-- ===========================================================
DELIMITER $$

CREATE PROCEDURE registrar_movimiento(
    IN p_id_equipo INT,
    IN p_id_usuario INT,
    IN p_tipo_movimiento ENUM('Retiro', 'Devolución', 'Reparación', 'Asignación', 'Baja'),
    IN p_observaciones TEXT
)
BEGIN
    DECLARE v_id_bodega INT;

    SELECT id_bodega INTO v_id_bodega FROM Equipos WHERE id_equipo = p_id_equipo;

    INSERT INTO Movimientos (id_equipo, id_usuario, id_bodega_origen, tipo_movimiento, observaciones)
    VALUES (p_id_equipo, p_id_usuario, v_id_bodega, p_tipo_movimiento, p_observaciones);

    -- Actualizar estado del equipo
    IF p_tipo_movimiento = 'Retiro' THEN
        UPDATE Equipos SET id_estado = 2 WHERE id_equipo = p_id_equipo;
    ELSEIF p_tipo_movimiento = 'Devolución' THEN
        UPDATE Equipos SET id_estado = 1 WHERE id_equipo = p_id_equipo;
    END IF;
END $$