create database ProyectoFinalDb
go
use ProyectoFinalDb
go

Create Table Usuario
(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	NombreUsuario varchar(15),
	Contraseña varchar(8),
	Fecha date
);

create table Cliente 
(
	ClienteId int primary key identity(1,1),
	Nombre varchar(30),
	Email varchar(max),
	Telefono varchar(15)
);
Create Table Producto
(
	ProductoId int primary key identity(1,1),
	Descripcion varchar(max),
	Cantidad int,
	Precio decimal,
	Fecha date 
);
create table Factura
(
	FacturaId int primary key identity(1,1),
	ClienteId int,
	UsuarioId int,
	Fecha date,
	Descripcion varchar(max),
	EfectivoRecibido decimal,
	Devuelta decimal,
	Monto decimal
);
create table FacturaDetalle
(
	Id int primary key identity(1,1),
	FacturaId int,
	ProductoId int, 
	Cantidad int,
	Precio decimal,
	Descripcion varchar(max)
);