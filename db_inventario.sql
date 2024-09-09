CREATE DATABASE IF NOT EXISTS tienda_accesorios_joyeria;
USE tienda_accesorios_joyeria;
-- Crear tabla de Categorías
CREATE TABLE Categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre_categoria VARCHAR(100) NOT NULL,
    descripcion_categoria TEXT
);

-- Crear tabla de Productos
CREATE TABLE Productos (
    id_producto INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    descripcion TEXT,
    precio DECIMAL(10,2) NOT NULL,
    cantidad_stock INT NOT NULL,
    id_categoria INT,
    FOREIGN KEY (id_categoria) REFERENCES Categorias(id_categoria)
);

-- Crear tabla de Pedidos
CREATE TABLE Pedidos (
    id_pedido INT AUTO_INCREMENT PRIMARY KEY,
    fecha_pedido DATETIME NOT NULL,
    estado_pedido VARCHAR(50) NOT NULL
);

-- Crear tabla de Detalles del Pedido
CREATE TABLE DetallesPedido (
    id_detalle INT AUTO_INCREMENT PRIMARY KEY,
    id_pedido INT,
    id_producto INT,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

-- Crear tabla de Inventario
CREATE TABLE Inventario (
    id_movimiento INT AUTO_INCREMENT PRIMARY KEY,
    id_producto INT,
    tipo_movimiento VARCHAR(50) NOT NULL,
    cantidad INT NOT NULL,
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

-- Tabla de Usuarios
CREATE TABLE users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NULL, 
    password VARCHAR(255) NULL,
    status VARCHAR(50) NULL
);

-- Tabla de Usuarios
CREATE TABLE usuarios (
    id INT PRIMARY KEY AUTO_INCREMENT,
    usuario VARCHAR(255) NULL, 
    contraseña VARCHAR(255) NULL,
    estado VARCHAR(50) NULL
);