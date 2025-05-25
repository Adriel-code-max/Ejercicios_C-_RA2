create database Practica
go
use Practica

create table Productos 
(
Id int identity (1,1) primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Marca nvarchar (100),
Precio float,
Stock int
)

insert into Productos 
values
('Gaseosa','3 litros','marcacola',7.5,24),
('Chocolate','Tableta 100 gramos','iberica',12.5,36)



CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Usuario NVARCHAR(50) UNIQUE NOT NULL,
    Contraseña NVARCHAR(50) NOT NULL
)


-- Insertar usuario admin inicial
INSERT INTO Usuarios (Usuario, Contraseña)
VALUES ('admin', 'admin123')
GO


-- 1. Para iniciar sesión
CREATE PROC sp_Login
@usuario NVARCHAR(50),
@contraseña NVARCHAR(50)
AS
BEGIN
    SELECT Id FROM Usuarios 
    WHERE Usuario = @usuario AND Contraseña = @contraseña
END
GO

-- 2. Para registrar nuevos usuarios
CREATE PROC sp_RegistrarUsuario
@usuario NVARCHAR(50),
@contraseña NVARCHAR(50)
AS
BEGIN
    INSERT INTO Usuarios (Usuario, Contraseña)
    VALUES (@usuario, @contraseña)
    
    SELECT SCOPE_IDENTITY() AS NuevoId
END
GO

---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarProductos
as
select *from Productos
go

--------------------------INSERTAR 
create proc InsetarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)
go

------------------------ELIMINAR
create proc EliminarProducto
@idpro int
as
delete from Productos where Id=@idpro
go
------------------EDITAR

create proc EditarProductos
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id
go
