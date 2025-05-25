
-

-- CREACIÓN DE TABLAS

CREATE TABLE Categorias (
    IdCategoria INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT,
    Estado BIT DEFAULT 1
);

CREATE TABLE Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(15),
    Correo VARCHAR(100),
    Direccion TEXT,
    Estado BIT DEFAULT 1
);

CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
    IdCategoria INT FOREIGN KEY REFERENCES Categorias(IdCategoria),
    IdProveedor INT FOREIGN KEY REFERENCES Proveedores(IdProveedor),
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL UNIQUE,
    Descripcion VARCHAR(100)
);

CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario VARCHAR(50) UNIQUE NOT NULL,
    Contraseña VARCHAR(100) NOT NULL,
    NombreCompleto VARCHAR(100),
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE UsuarioRoles (
    IdUsuario INT NOT NULL FOREIGN KEY REFERENCES Usuarios(IdUsuario),
    IdRol INT NOT NULL FOREIGN KEY REFERENCES Roles(IdRol),
    PRIMARY KEY (IdUsuario, IdRol)
);


-- PROCEDIMIENTOS

-- Login
CREATE OR ALTER PROCEDURE sp_Login
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(100)
AS
BEGIN
    SELECT 
        u.IdUsuario,
        u.NombreUsuario,
        u.NombreCompleto,
        r.Nombre AS Rol,
        r.IdRol
    FROM Usuarios u
    INNER JOIN UsuarioRoles ur ON u.IdUsuario = ur.IdUsuario
    INNER JOIN Roles r ON ur.IdRol = r.IdRol
    WHERE u.NombreUsuario = @NombreUsuario 
    AND u.Contraseña = @Contraseña
    AND u.Estado = 1;
END;


-- Registro de usuario con asignación de rol
CREATE OR ALTER PROCEDURE sp_RegistrarUsuario
    @NombreUsuario VARCHAR(50),
    @Contraseña VARCHAR(100),
    @NombreCompleto VARCHAR(100),
    @IdRol INT,
    @IdUsuarioResultado INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

       INSERT INTO Usuarios (NombreUsuario, Contraseña, NombreCompleto)
       VALUES (@NombreUsuario, @Contraseña, @NombreCompleto);

        DECLARE @IdUsuario INT = SCOPE_IDENTITY();

        INSERT INTO UsuarioRoles (IdUsuario, IdRol)
        VALUES (@IdUsuario, @IdRol);

        SET @IdUsuarioResultado = @IdUsuario;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;


-- Obtener roles
CREATE OR ALTER PROCEDURE sp_ObtenerRoles
AS
BEGIN
    SELECT IdRol, Nombre, Descripcion FROM Roles;
END;


-- Validar existencia de usuario
CREATE OR ALTER PROCEDURE sp_ExisteUsuario
    @NombreUsuario VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS Cantidad
    FROM Usuarios
    WHERE NombreUsuario = @NombreUsuario;
END;


-- CRUD Productos

CREATE OR ALTER PROCEDURE InsertarProducto
    @Nombre VARCHAR(100),
    @Descripcion TEXT,
    @Precio DECIMAL(10,2),
    @Stock INT,
    @IdCategoria INT,
    @IdProveedor INT
AS
BEGIN
    INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, IdCategoria, IdProveedor, Estado)
    VALUES (@Nombre, @Descripcion, @Precio, @Stock, @IdCategoria, @IdProveedor, 1);
END;


CREATE OR ALTER PROCEDURE MostrarProductos
AS
BEGIN
    SELECT * FROM Productos WHERE Estado = 1;
END;


CREATE OR ALTER PROCEDURE ActualizarProducto
    @IdProducto INT,
    @Nombre VARCHAR(100),
    @Descripcion TEXT,
    @Precio DECIMAL(10,2),
    @Stock INT,
    @IdCategoria INT,
    @IdProveedor INT
AS
BEGIN
    UPDATE Productos
    SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, 
        Stock = @Stock, IdCategoria = @IdCategoria, IdProveedor = @IdProveedor
    WHERE IdProducto = @IdProducto;
END;


CREATE OR ALTER PROCEDURE EliminarProducto
    @IdProducto INT
AS
BEGIN
    UPDATE Productos SET Estado = 0 WHERE IdProducto = @IdProducto;
END;


CREATE OR ALTER PROCEDURE BuscarProducto
    @Filtro VARCHAR(100)
AS
BEGIN
    SELECT 
        IdProducto, 
        Nombre, 
        Descripcion, 
        Precio, 
        Stock, 
        (SELECT Nombre FROM Categorias WHERE IdCategoria = Productos.IdCategoria) AS Categoria,
        (SELECT Nombre FROM Proveedores WHERE IdProveedor = Productos.IdProveedor) AS Proveedor
    FROM Productos
    WHERE (Nombre LIKE '%' + @Filtro + '%' OR Descripcion LIKE '%' + @Filtro + '%')
    AND Estado = 1;
END;


CREATE OR ALTER PROCEDURE ObtenerProductosConDetalles
AS
BEGIN
    SELECT 
        p.IdProducto,
        p.Nombre AS NombreProducto,  
        c.Nombre AS NombreCategoria, 
        pr.Nombre AS NombreProveedor, 
        p.Precio,
        p.Stock,
        p.Estado
    FROM Productos p
    INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
    INNER JOIN Proveedores pr ON p.IdProveedor = pr.IdProveedor
    WHERE p.Estado = 1;
END;


-- CRUD Categorías

CREATE OR ALTER PROCEDURE ObtenerCategorias
AS
BEGIN
    SELECT * FROM Categorias WHERE Estado = 1;
END;


CREATE OR ALTER PROCEDURE InsertarCategoria
    @Nombre VARCHAR(50),
    @Descripcion TEXT
AS
BEGIN
    INSERT INTO Categorias (Nombre, Descripcion, Estado) 
    VALUES (@Nombre, @Descripcion, 1);
END;


CREATE OR ALTER PROCEDURE ActualizarCategoria
    @IdCategoria INT,
    @Nombre VARCHAR(50),
    @Descripcion TEXT
AS
BEGIN
    UPDATE Categorias 
    SET Nombre = @Nombre, Descripcion = @Descripcion 
    WHERE IdCategoria = @IdCategoria AND Estado = 1;
END;


CREATE OR ALTER PROCEDURE EliminarCategoria
    @IdCategoria INT
AS
BEGIN
    UPDATE Categorias SET Estado = 0 WHERE IdCategoria = @IdCategoria;
END;


CREATE OR ALTER PROCEDURE BuscarCategoria
    @Filtro VARCHAR(50)
AS
BEGIN
    SELECT * FROM Categorias 
    WHERE Nombre LIKE '%' + @Filtro + '%' 
    AND Estado = 1;
END;


-- CRUD Proveedores

CREATE OR ALTER PROCEDURE ObtenerProveedores
AS
BEGIN
    SELECT * FROM Proveedores WHERE Estado = 1;
END;


CREATE OR ALTER PROCEDURE InsertarProveedor
    @Nombre VARCHAR(100),
    @Telefono VARCHAR(15),
    @Correo VARCHAR(100),
    @Direccion TEXT
AS
BEGIN
    INSERT INTO Proveedores (Nombre, Telefono, Correo, Direccion, Estado) 
    VALUES (@Nombre, @Telefono, @Correo, @Direccion, 1);
END;


CREATE OR ALTER PROCEDURE ActualizarProveedor
    @IdProveedor INT,
    @Nombre VARCHAR(100),
    @Telefono VARCHAR(15),
    @Correo VARCHAR(100),
    @Direccion TEXT
AS
BEGIN
    UPDATE Proveedores
    SET Nombre = @Nombre,
        Telefono = @Telefono,
        Correo = @Correo,
        Direccion = @Direccion
    WHERE IdProveedor = @IdProveedor;
END;


CREATE OR ALTER PROCEDURE EliminarProveedor
    @IdProveedor INT
AS
BEGIN
    UPDATE Proveedores
    SET Estado = 0
    WHERE IdProveedor = @IdProveedor;
END;


CREATE OR ALTER PROCEDURE BuscarProveedor
    @Texto VARCHAR(100)
AS
BEGIN
    SELECT * FROM Proveedores
    WHERE Nombre LIKE '%' + @Texto + '%' AND Estado = 1;
END;


-- DATOS DE PRUEBA

INSERT INTO Categorias (Nombre, Descripcion, Estado) VALUES
('Electrónicos', 'Productos electrónicos y gadgets', 1),
('Ropa', 'Vestimenta y accesorios', 1),
('Alimentos', 'Comestibles y productos de supermercado', 1);

INSERT INTO Proveedores (Nombre, Telefono, Correo, Direccion, Estado) VALUES
('Tech Supplies', '809-123-4567', 'contacto@techsupplies.com', 'Calle 123, Ciudad A', 1),
('Moda Express', '829-234-5678', 'info@modaexpress.com', 'Avenida B, Ciudad B', 1),
('SuperMarket', '849-345-6789', 'ventas@supermarket.com', 'Boulevard C, Ciudad C', 1);

INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, IdCategoria, IdProveedor, Estado) VALUES
('Laptop Dell', 'Laptop con procesador Intel Core i5', 750.00, 10, 1, 1, 1),
('Camiseta Nike', 'Camiseta deportiva de algodón', 25.50, 50, 2, 2, 1),
('Arroz Premium', 'Saco de arroz de 10kg', 12.75, 100, 3, 3, 1);

INSERT INTO Roles (Nombre, Descripcion) VALUES 
('Administrador', 'Acceso completo al sistema'),
('Inventario', 'Puede gestionar productos y existencias');


-- Verificar datos
SELECT * FROM Usuarios;
SELECT * FROM Roles;
SELECT * FROM UsuarioRoles;
SELECT * FROM Categorias;
SELECT * FROM Proveedores;
SELECT * FROM Productos;