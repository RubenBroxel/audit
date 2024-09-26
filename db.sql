-- Create Usuarios schema
CREATE SCHEMA Usuarios;
GO

-- Create Permisos table
CREATE TABLE Usuarios.Permisos (
    IdPermiso INT PRIMARY KEY,
    NombrePermiso VARCHAR(100),
    DescripcionPermiso TEXT,
    ActivoPermiso TINYINT,
    CrearPermiso DATETIME,
    ActualizarPermiso DATETIME,
    InactivarPermisos DATETIME
);
GO
-- Create Cuentas table
CREATE TABLE Usuarios.Cuentas (
    IdCuenta INT PRIMARY KEY,
    IdTipoCuenta INT,
    IdEmpleado INT,
    NombreCuenta VARCHAR(50),
    CorreoCuenta VARCHAR(150),
    ContrasenaCuenta VARCHAR(36),
    ActivoCuenta TINYINT,
    CrearCuenta DATETIME,
    ActualizarCuenta DATETIME,
    InactivarCuenta DATETIME,
    FOREIGN KEY (IdTipoCuenta) REFERENCES Usuarios.TipoCuentas(IdTipoCuenta),
    FOREIGN KEY (IdEmpleado) REFERENCES Personas.Empleados(IdEmpleado)
);
GO

-- Create TipoCuentas table
CREATE TABLE Usuarios.TipoCuentas (
    IdTipoCuenta INT PRIMARY KEY,
    NombreTipoCuenta VARCHAR(150),
    ActivoTipoCuenta TINYINT,
    CrearTipoCuenta DATETIME,
    ActualizarTipoCuenta DATETIME,
    InactivoTipoCuenta DATETIME
);
GO

-- Create AsignarPermiso table
CREATE TABLE Usuarios.AsignarPermiso (
    IdCuenta INT,
    IdPermiso INT,
    ActivoAsignar TINYINT,
    CrearAsignar DATETIME,
    ActualizarAsignar DATETIME,
    InactivarAsignar DATETIME,
    FOREIGN KEY (IdCuenta) REFERENCES Usuarios.Cuentas(IdCuenta),
    FOREIGN KEY (IdPermiso) REFERENCES Usuarios.Permisos(IdPermiso)
);
GO

-- Create Personas schema
CREATE SCHEMA Personas;
GO
-- Create Empleados table
CREATE TABLE Personas.Empleados (
    IdEmpleado INT PRIMARY KEY,
    NombreEmpleado VARCHAR(150),
    PaternoEmpleado VARCHAR(50),
    MaternoEmpleado VARCHAR(150),
    CrearEmpleado DATETIME,
    ActualizarEmpleado DATETIME,
    InactivarEmpleado DATETIME
);
GO