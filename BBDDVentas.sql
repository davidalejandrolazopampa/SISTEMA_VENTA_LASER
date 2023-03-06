--CREAREMOS LA BASE DE DATOS PARA PROYECTO SISTEMA DE VENTAS
CREATE DATABASE SistemaVentasLASER
GO
--USAREMOS LA BASE DE DATOS CREADA ANTERIORMENTE
USE SistemaVentasLASER
GO
--***************************************************************
--COMENSAMOS A CREAR LAS TABLAS**********************************
--***************************************************************
--******************
/*TABLA CATEGORIA*/
--******************
CREATE TABLE categoria(
idcategoria int identity (1,1) primary key not null,
nombre_categoria varchar(50) not null)
go
--******************
/*TABLA CLIENTE*/
--******************
CREATE TABLE cliente(
idcliente int identity (1,1) primary key not null,
nombre varchar(50) not null,
apellidos varchar(50) not null,
direccion varchar(100) not null,
telefono varchar(9) not null,
dni varchar(8) not null,
imagen image not null)
go
--******************
/*TABLA VENTA*/
--******************
CREATE TABLE venta(
idventa int identity (1,1) primary key not null,
idcliente int not null FOREIGN KEY REFERENCES cliente ON UPDATE CASCADE ON DELETE CASCADE,
fecha_venta date not null,
tipo_documento varchar(50) not null,
num_documento varchar(50) not null)
go
--******************
/*TABLA PRODUCTO*/
--******************
CREATE TABLE producto(
idproducto int identity (1,1) primary key not null,
idcategoria int not null FOREIGN KEY REFERENCES categoria ON UPDATE CASCADE ON DELETE CASCADE,
nombre varchar(50) not null,
descripcion varchar(255) not null,
stock decimal (18,2) not null,
precio_compra decimal (18,2) not null,
precio_venta decimal (18,2) not null,
fecha_vencimiento date not null,
imagen image not null)
go
--**************************
/*TABLA DETALLE DE VENTA*/
--**************************
CREATE TABLE detalle_venta(
iddetalle_venta int identity (1,1) primary key not null,
idventa int not null FOREIGN KEY REFERENCES venta ON UPDATE CASCADE ON DELETE CASCADE,
idproducto int not null FOREIGN KEY REFERENCES producto ON UPDATE CASCADE ON DELETE CASCADE,
cantidad decimal(18,2) not null,
precio_unitario decimal(18,2) not null)
go
--**************************
/*TABLA SERVICIO TECNICO************/
--**************************
CREATE TABLE servicio_tecnico(
idservicio int identity (1,1) primary key not null,
idcliente int not null FOREIGN KEY REFERENCES cliente ON UPDATE CASCADE ON DELETE CASCADE,
idproducto int not null FOREIGN KEY REFERENCES producto ON UPDATE CASCADE ON DELETE CASCADE,
fecha_servicio date not null,
descripcion varchar(max)not null)
go
--**************************
/*TABLA USUARIO************/
--**************************
create table usuario
(users varchar(50) not null,
passwords varchar(10) not null,
nivel varchar(30) not null
)
go
insert into usuario values ('David Alejandro Lazo Pampa','123','Administrador')
insert into usuario values ('Lothar Arturo Aguirre Mejia','123','Administrador')
insert into usuario values ('Amilcar Santiago Escalante Garate','123','Vendedor')
insert into usuario values ('Joel Santivañez Santibañez','123','Vendedor')
select * from usuario 
--*************************************************************************************
--*************************** PROCEDIMIENTOS *** ALMACENADOS **************************
--*************************************************************************************

--**********************************
/**********TABLA---CLIENTES PS******/
--**********************************
--------------mostrar--------------
create proc mostrar_cliente
as
select * from cliente order by idcliente desc
go
----------insertar------------
create proc insertar_cliente
@nombre varchar(50),
@apellidos varchar(50),
@direccion varchar(100),
@telefono varchar(9),
@dni varchar(8),
@imagen image
as
insert into cliente(nombre, apellidos,direccion,telefono,dni,imagen) values (@nombre, @apellidos,@direccion,@telefono,@dni,@imagen)  
go
------------editar-----------
create proc editar_cliente
@idcliente int,
@nombre varchar(50),
@apellidos varchar(50),
@direccion varchar(100),
@telefono varchar(9),
@dni varchar(8),
@imagen image
as
update cliente set nombre=@nombre, apellidos=@apellidos,direccion=@direccion,telefono=@telefono,dni=@dni,imagen=@imagen
where idcliente = @idcliente
go
------------eliminar-----------
create proc eliminar_cliente
@idcliente integer
as
delete from cliente where idcliente=@idcliente 
go

--**************************************
/*-----------TABLA Categoria PS-------*/
--**************************************
--------------mostrar------------------
create proc mostrar_categoria
as
select* from categoria order by idcategoria desc
go
-------------insertar---------------------
create proc insertar_categoria
@nombre_categoria varchar(50)
as
insert into categoria (nombre_categoria) values (@nombre_categoria)
go
-------------editar------------------------
create proc editar_categoria
@idcategoria integer,
@nombre_categoria varchar(50)
as
update categoria set nombre_categoria=@nombre_categoria 
where idcategoria=@idcategoria 
go
-------------eliminar------------------------
create proc eliminar_categoria
@idcategoria integer
as
delete from categoria where idcategoria=@idcategoria
go

--*******************************************
/*--------------TABLA PRODUCTOS PS -------*/
--*******************************************

------------mostrar PS_PRODUCTOS-----------
/*crearemos iner join para crear unir tablas producto--procedimientos almacenados*/
create proc mostrar_producto
as
select producto.idproducto,producto.idcategoria,categoria.nombre_categoria,producto.nombre,producto.descripcion,
producto.stock,producto.precio_compra,producto.precio_venta,producto.fecha_vencimiento,producto.imagen
from producto inner join categoria on producto.idcategoria=categoria.idcategoria 
order by producto.idproducto desc
go
----------insertar PS_PRODUCTOS------------
create proc insertar_producto
@idcategoria integer,
@nombre varchar(50),
@descripcion varchar(50),
@stock decimal (18,2),
@precio_compra decimal (18,2),
@precio_venta decimal (18,2),
@fecha_vencimiento date,
@imagen image
as
insert into producto (idcategoria,nombre,descripcion,stock,precio_compra,precio_venta,fecha_vencimiento,imagen)
values (@idcategoria,@nombre,@descripcion,@stock,@precio_compra,@precio_venta,@fecha_vencimiento,@imagen)
go
----------------editar PS_PRODUCTOS-----------------
create proc editar_producto
@idproducto integer,
@idcategoria integer,
@nombre varchar(50),
@descripcion varchar(50),
@stock decimal (18,2),
@precio_compra decimal (18,2),
@precio_venta decimal (18,2),
@fecha_vencimiento date,
@imagen image
as
update producto set idcategoria=@idcategoria,nombre=@nombre,descripcion=@descripcion, stock=@stock,
precio_compra=@precio_compra,precio_venta=@precio_venta,fecha_vencimiento=@fecha_vencimiento,imagen=@imagen 
where idproducto=@idproducto 
go
--------------eliminar PS_PRODUCTOS----------------
create proc eliminar_producto
@idproducto integer
as
delete from producto where idproducto=@idproducto
go
--*******************************************
------------TABLA-PS_VENTAS----------------
--*******************************************
-----------------MOSTAR--------------------
--nesecitamos unir tablas cliente y venta
create proc mostrar_venta
as
SELECT dbo.venta.idventa, dbo.venta.idcliente, dbo.cliente.apellidos, dbo.cliente.dni,
dbo.venta.fecha_venta, dbo.venta.tipo_documento, dbo.venta.num_documento
FROM dbo.cliente INNER JOIN dbo.venta ON dbo.cliente.idcliente = dbo.venta.idcliente
order by dbo.venta.idventa desc
go
--------------------INSERTAR----------------
create proc insertar_venta
@idcliente as integer,
@fecha_venta as date,
@tipo_documento as varchar(50),
@num_documento as varchar(50)
as
insert into venta (idcliente,fecha_venta,tipo_documento,num_documento)
values (@idcliente,@fecha_venta,@tipo_documento,@num_documento)
go
---------------------EDITAR-----------------
create proc editar_venta
@idventa as integer,
@idcliente as integer,
@fecha_venta as date,
@tipo_documento as varchar(50),
@num_documento as varchar(50)
as
update venta set idcliente=@idcliente,fecha_venta=@fecha_venta,
tipo_documento=@tipo_documento,num_documento=num_documento
where idventa=@idventa
go
------------------ELIMINAR-----------------
create proc eliminar_venta
@idventa as integer
as
delete from venta where idventa=@idventa
go
--********************************************
-----------/*TABLA-Detalle-venta-PS*/---------
--********************************************
-----------------insertar---------------------
create proc insertar_detalle_venta
@idventa as integer,
@idproducto as integer,
@cantidad as decimal(18,2),
@precio_unitario as decimal (18,2)
as
insert into detalle_venta (idventa,idproducto,cantidad,precio_unitario)
values (@idventa,@idproducto,@cantidad,@precio_unitario)
go
--------------------editar-----------------
create proc editar_detalle_venta
@iddetalle_venta as integer,
@idventa as integer,
@idproducto as integer,
@cantidad as decimal (18,2),
@precio_unitarioas decimal (18,2)
as
update detalle_venta set idventa=@idventa,idproducto=@idproducto,cantidad=@cantidad,
precio_unitario=@precio_unitarioas
where iddetalle_venta=@iddetalle_venta
go
-----------------eliminar---------------
create proc eliminar_detalle_venta
@iddetalle_venta as integer
as
delete from detalle_venta where iddetalle_venta=@iddetalle_venta
go
-----------------mostrar------------------

create proc mostar_detalle_venta
as
SELECT        dbo.detalle_venta.iddetalle_venta, dbo.detalle_venta.idventa, dbo.detalle_venta.idproducto, dbo.producto.nombre, dbo.producto.imagen, dbo.detalle_venta.cantidad, dbo.detalle_venta.precio_unitario
FROM            dbo.detalle_venta INNER JOIN
                         dbo.producto ON dbo.detalle_venta.idproducto = dbo.producto.idproducto
				order	by 
					dbo.detalle_venta.iddetalle_venta desc
go
/***************************************************/
/*-------------STOCK DE DETALLE VENTA-------------*/
/***************************************************/
/*almacen PS*/
--------------aumentar STOCk------------------
create proc aumentar_stock
@idproducto as integer,
@cantidad as decimal (18,2)
as
update producto set stock=stock+@cantidad where idproducto=@idproducto 
go
-------------disminuir stock-------------------
create proc disminuir_stock
@idproducto as integer,
@cantidad as decimal (18,2)
as
update producto set stock=stock-@cantidad where idproducto=@idproducto 
go
/************************************************************************/
------Para imprimir usamos un comprobante en procedimiento almacendo
/************************************************************************/
create proc generar_comprobante
@idventa int
as
SELECT        dbo.venta.idventa, dbo.cliente.nombre, dbo.cliente.apellidos, dbo.cliente.direccion, dbo.cliente.dni, dbo.cliente.telefono, dbo.cliente.imagen, dbo.venta.fecha_venta, dbo.venta.tipo_documento, 
                         dbo.venta.num_documento, dbo.producto.nombre AS Descripcion, dbo.detalle_venta.cantidad, dbo.detalle_venta.cantidad * dbo.producto.precio_venta AS Total_Parcial, dbo.detalle_venta.precio_unitario, 
                         dbo.producto.imagen AS Imagen_Producto
FROM            dbo.producto INNER JOIN
                         dbo.detalle_venta ON dbo.producto.idproducto = dbo.detalle_venta.idproducto INNER JOIN
                         dbo.venta ON dbo.detalle_venta.idventa = dbo.venta.idventa INNER JOIN
                         dbo.cliente ON dbo.venta.idcliente = dbo.cliente.idcliente
where dbo.venta.idventa=@idventa
go

--************************************
/**********TABLA---SERVICIOS PS******/
--************************************
--------------mostrar-----------------
create proc mostrar_servicio
as
SELECT dbo.servicio_tecnico.idservicio, dbo.cliente.idcliente, dbo.cliente.nombre, dbo.producto.idproducto, dbo.producto.idcategoria, dbo.servicio_tecnico.descripcion, dbo.servicio_tecnico.fecha_servicio
FROM dbo.cliente INNER JOIN dbo.servicio_tecnico ON dbo.cliente.idcliente = dbo.servicio_tecnico.idcliente INNER JOIN
dbo.producto ON dbo.servicio_tecnico.idproducto = dbo.producto.idproducto
order by dbo.servicio_tecnico.idservicio desc
go
----------insertar-------------------
create proc insertar_servicio
@idcliente integer,
@idproducto integer,
@fecha_servicio date,
@descripcion varchar(max)
as
insert into servicio_tecnico ( idcliente,idproducto,fecha_servicio,descripcion) values ( @idcliente,@idproducto,@fecha_servicio,@descripcion)  
go
------------editar--------------------
create proc editar_servicio
@idservicio integer,
@idcliente integer,
@idproducto integer,
@fecha_servicio date,
@descripcion varchar(max)
as
update servicio_tecnico  set idcliente=@idcliente,idproducto=@idproducto,fecha_servicio=@fecha_servicio,descripcion=@descripcion 
where idservicio=@idservicio
go

------------eliminar-----------
create proc eliminar_servicio
@idservicio integer
as
delete from servicio_tecnico where idservicio=@idservicio
go


-------------Gernerar comprobante de servicio tecnico----------------
create proc generar_comprobante_servicio
@idservicio int
as
SELECT dbo.servicio_tecnico.idservicio, dbo.cliente.nombre, dbo.cliente.apellidos, dbo.cliente.direccion, dbo.cliente.telefono, dbo.producto.nombre AS Nombre_Producto, dbo.servicio_tecnico.descripcion, 
 dbo.servicio_tecnico.fecha_servicio
FROM  dbo.cliente INNER JOIN
 dbo.servicio_tecnico ON dbo.cliente.idcliente = dbo.servicio_tecnico.idcliente INNER JOIN
 dbo.producto ON dbo.servicio_tecnico.idproducto = dbo.producto.idproducto
where dbo.servicio_tecnico.idservicio=@idservicio
go
/********************************************/
/*Crear el Procedimiento Crear Usuario*/
/********************************************/
create proc _iniciosesion
@users varchar(50),
@passwords varchar(10)
as
select *from  usuario where
users=@users and passwords=@passwords
go
-------------------------
--*******************************************
/*--------------TABLA Usuario PS -------*/
--*******************************************
-------------MOSTRAR------------------
create proc mostrar_usarios
as
select * from usuario order by users desc
go
-------------INSERTAR-----------------
create proc insertar_usarios
@users varchar(50),
@passwords varchar(50),
@nivel varchar(50)
as
insert into usuario (users,passwords,nivel) values (@users,@passwords,@nivel)
go
----------------EDITAR----------------
create proc editar_usarios
@users varchar(50),
@passwords varchar(50),
@nivel varchar(50)
as
update usuario set users=@users, passwords=@passwords, nivel=@nivel
where users =@users
go

-------eliminar---------
create proc eliminar_usarios
@users varchar(50)
as
delete from usuario where users=@users
go 
/********************************************/
----Proceidmeinto almacena para un backat----
/********************************************/
drop proc backup_base 

CREATE PROC backup_base
AS
BACKUP DATABASE [SistemaVentasLASER]

TO DISK =N'D:\Sistema_Venta_LASER\BackUp_LASER\BackUp_LASER.bak'
with description = N'Respaldo de la base de datos del Sistema de ventas',
NOFORMAT,
INIT,
NAME=N'BackUp_LASER',
SKIP,
NOREWIND,
NOUNLOAD,
STATS=10,
CHECKSUM
GO
-------------------------------------
-------------------------------------


