create database ProyectoFinalDb
go

use ProyectoFinalDb
go
Create Table Usuario
(
	UsuarioID int primary key identity(1,1),
	Nombre varchar(30),
	Contraseña varchar(8),
	TotalVendido money,
	Posicion int
);

create table Cliente 
(
	ClienteID int primary key identity(1,1),
	Nombre varchar(30),
	Email varchar(max),
	Telefono varchar(15)
);

Create Table Producto
(
	ProductoID int primary key identity(1,1),
	Descripcion varchar(max),
	Cantidad int,
	Precio money,
	FechaDeRegistro date 
);

create table Factura
(
	FacturaID int primary key identity(1,1),
	ClienteID int,
	FechaFactura date,
	ProductoID int,
    Descripcion varchar(max),
	Cantidad int,
	SubTotal money,
	Iterbis money,
	Total money
);

create table FacturaDetalle
(
	FacturaID int primary key identity(1,1),
	Iterbis money,
	FacturaDetalleID money,
	IDFactura int,
	IDUsuario int,
	FechaFactura date,
	ProductoID int, 
	Cantidad int,
	Precio money,
	Importe money

);