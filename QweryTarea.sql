create database ONGs

use ONGs


-- Tabla Asociaciones
CREATE TABLE Asociaciones (
codigo int identity(1,1) primary key,
denominacion VARCHAR(100),
direccion VARCHAR(200),
provincia VARCHAR(50),
tipo VARCHAR(50),
declarada_utilidad_publica BIT 
);

-- Tabla Socios
CREATE TABLE Socios (
dni VARCHAR(10) PRIMARY KEY,
nombre VARCHAR(100),
direccion VARCHAR(200),
provincia VARCHAR(50),
fecha_alta DATETIME,
cuota_mensual DECIMAL(10,2), 
aportacion_anual DECIMAL(10,2),
id_asociacion INT,
CONSTRAINT fk_socios_asociaciones
FOREIGN KEY (id_asociacion)
REFERENCES Asociaciones(codigo)
);

-- Tabla Trabajadores
CREATE TABLE Trabajadores (
dni VARCHAR(10) PRIMARY KEY,
nombre VARCHAR(100),
edad INT,
fecha_ingreso DATE,
tipo VARCHAR(50),
cargo VARCHAR(50),
cantidad_essalud DECIMAL(10,2),
porcentaje_impuesto_renta DECIMAL(10,2),
salario DECIMAL(10,2)
);

CREATE TABLE Voluntarios (
dni VARCHAR(10) PRIMARY KEY,
nombre VARCHAR(100),
edad INT,
profesion VARCHAR(100),
horas_dedicadas INT
);

-- Tabla Proyectos
CREATE TABLE proyectos (
id_proyecto int identity(1,1) primary key,
id_asociacion INT,
pais VARCHAR(50),
zona VARCHAR(50),
objetivo VARCHAR(200),
num_beneficiarios INT,
dni_trabajador VARCHAR(10),
FOREIGN KEY (id_asociacion) REFERENCES asociaciones (codigo),
FOREIGN KEY (dni_trabajador) REFERENCES trabajadores (dni)
);

-- Tabla Subproyectos
CREATE TABLE Subproyectos (
id int identity(1,1) primary key,
id_proyecto INT,
nombre VARCHAR(50) NOT NULL,
pais VARCHAR(50),
zona VARCHAR(50),
objetivo_subproyecto VARCHAR(200),
num_beneficiarios_subproyecto INT,
CONSTRAINT fk_subproyectos_proyectos
FOREIGN KEY (id_proyecto)
REFERENCES Proyectos(id_proyecto)
);



-- Procedimiento para insertar una asociación
ALTER PROCEDURE InsertarAsociacion
@denominacion VARCHAR(100),
@direccion VARCHAR(200),
@provincia VARCHAR(50),
@tipo VARCHAR(50),
@declarada_utilidad_publica BIT
AS
BEGIN
INSERT INTO Asociaciones (denominacion, direccion, provincia, tipo, declarada_utilidad_publica)
VALUES (@denominacion, @direccion, @provincia, @tipo, @declarada_utilidad_publica);
END;


EXEC InsertarAsociacion 'Walmart S.A','De la esquina 5 cuadras al norte','Managua',
'Comercial',1

EXEC InsertarAsociacion 'Coca-Cola','nose','Managua',
'Comercial',1


create procedure ListarAsociaciones
as
begin
select * from Asociaciones
end

EXEC ListarAsociaciones
--Socios

ALTER PROCEDURE InsertarSocio
@dni VARCHAR(10),
@nombre VARCHAR(100),
@direccion VARCHAR(200),
@provincia VARCHAR(50),

@cuota_mensual DECIMAL(10,2),
@id_asociacion INT
AS
BEGIN
DECLARE @aportacion_anual DECIMAL(10,2);
SET @aportacion_anual = @cuota_mensual * 12;

DECLARE @fecha_alta DATETIME
SET @fecha_alta = GETDATE();

DECLARE @socios varchar(10)
SET @socios = (select dni from Socios where dni = @dni);

if(@socios = @dni)
begin
 print 'Este socio ya existe'
end
else
begin
INSERT INTO Socios (dni, nombre, direccion, provincia, fecha_alta, cuota_mensual, aportacion_anual, id_asociacion)
VALUES (@dni, @nombre, @direccion, @provincia, @fecha_alta, @cuota_mensual, @aportacion_anual, @id_asociacion);
end
END;


EXEC InsertarSocio '0327059215','Jovani Vasquez','Calle falsa 123','Chiapas',2500,3

create procedure ListarSocios
as
begin
select * from Socios
end

EXEC ListarSocios


print GETDATE()

CREATE FUNCTION CalcularSalarioNeto
(
    @salarioBruto decimal(10,2),
    @descuentoESSALUD decimal(10,2),
    @porcentajeImpuestoRenta decimal(10,2)
)
RETURNS decimal(10,2)
AS
BEGIN
    DECLARE @impuestoRenta decimal(10,2)
    DECLARE @salarioNeto decimal(10,2)
    SET @impuestoRenta = (@salarioBruto - @descuentoESSALUD) * (@porcentajeImpuestoRenta / 100.00)
    SET @salarioNeto = @salarioBruto - @descuentoESSALUD - @impuestoRenta
    RETURN @salarioNeto
END
ALTER PROCEDURE InsertarTrabajador
@dni VARCHAR(10),
@nombre VARCHAR(100),
@tipo VARCHAR(50),
@edad int,
@SalarioB DECIMAL(10,2),
@cantidad_essalud DECIMAL(10,2),
@profesion VARCHAR(50),
@horasdedicadas int,
@porcentaje_impuesto_renta DECIMAL(10,2)
AS
DECLARE @fecha_ingreso DATE
SET @fecha_ingreso = GETDATE();
DECLARE @dnivalT varchar(10)
DECLARE @dnivalV varchar(10)
SET @dnivalT = (select dni from Trabajadores where dni = @dni);
SET @dnivalV = (select dni from Voluntarios where dni = @dni);

DECLARE @Salario DECIMAL(10,2)
set @Salario = (dbo.CalcularSalarioNeto(@SalarioB,@cantidad_essalud,@porcentaje_impuesto_renta))
BEGIN
IF @tipo = 'asalariado'
BEGIN

if(@dnivalT = @dni or @dnivalV = @dni )
begin
 print 'Este Trabajador ya existe'
end
else
INSERT INTO Trabajadores (dni, nombre, fecha_ingreso, tipo,edad,cargo, cantidad_essalud, porcentaje_impuesto_renta,salario)
VALUES (@dni, @nombre, @fecha_ingreso, @tipo,@edad,@profesion, @cantidad_essalud, @porcentaje_impuesto_renta,@Salario);
END
ELSE IF @tipo = 'voluntario'
BEGIN
if(@dnivalT = @dni or @dnivalV = @dni )
begin
 print 'Este Trabajador ya existe'
end
else
INSERT INTO Voluntarios (dni, nombre, edad, profesion, horas_dedicadas)
VALUES (@dni, @nombre, @edad, @profesion, @horasdedicadas);
END
END;


EXEC InsertarTrabajador '4088327414','Ernesto Gutierrez','voluntario',39,0,
'contador',6,0

EXEC InsertarTrabajador '4578214502','Fernando Perez','asalariado',26,1500,50,
'contador',0,6

ALTER procedure ListarTrabajadores
as
begin
select * from Trabajadores
end


EXEC ListarTrabajadores

create procedure ListaVon
as
begin
select * from Voluntarios
end

EXEC ListaVon


-- Procedimiento para insertar un nuevo proyecto
ALTER PROCEDURE insertar_proyecto (
@codigo_asociacion CHAR(4),
@pais VARCHAR(50),
@zona VARCHAR(50),
@objetivo VARCHAR(500),
@beneficiarios INT,
@dni VARCHAR(50)
)
AS
DECLARE @dnivalT varchar(10)
DECLARE @dnivalV varchar(10)
SET @dnivalT = (select dni from Trabajadores where dni = @dni);
SET @dnivalV = (select dni from Voluntarios where dni = @dni);
if(@dnivalT = @dni or @dnivalV = @dni )
BEGIN
INSERT INTO proyectos (id_asociacion, pais, zona, objetivo, num_beneficiarios,dni_trabajador)
VALUES (@codigo_asociacion, @pais, @zona, @objetivo, @beneficiarios,@dni);
END
else
begin
 print 'El trabajador no existe'
end


EXEC insertar_proyecto '1','Nicaragua','Managua','Que la comunidad tenga mas cercania a comprar productos',
3,'4578214502'

create procedure ListarProyectos
as
begin
select * from proyectos
end


EXEC ListarProyectos


-- Procedimiento para insertar un nuevo subproyecto
Alter PROCEDURE insertar_subproyecto
@idProyecto int,
@nombre VARCHAR(50),
@pais VARCHAR(50),
@zona VARCHAR(50),
@objetivo_sub VARCHAR(500),
@num_beneficiarios_subproyecto INT
AS
DECLARE @Proyect int

SET @Proyect = (select id_proyecto from proyectos where id_proyecto = @idProyecto);
if(@idProyecto = @Proyect)
BEGIN
    SET NOCOUNT ON;

    INSERT INTO subproyectos (id_proyecto,nombre,pais,zona, objetivo_subproyecto, num_beneficiarios_subproyecto)
    VALUES (@idProyecto,@nombre,@pais,@zona, @objetivo_sub, @num_beneficiarios_subproyecto);
END
else
begin
 print 'El proyecto no existe'
end

EXEC insertar_subproyecto 1,'Instalacion electrica','Nicaragua','Managua','Llevar a cabo el fin proyecto',150


create procedure ListarSubProyectos
as
begin
select * from Subproyectos
end

EXEC ListarSubProyectos


CREATE PROCEDURE ModificarAsociacion
@id INT,
@denominacion VARCHAR(100),
@direccion VARCHAR(200),
@provincia VARCHAR(50),
@tipo VARCHAR(50),
@declarada_utilidad_publica BIT
AS
BEGIN
-- declarar las variables necesarias
DECLARE @denominacion_antigua VARCHAR(100),
@direccion_antigua VARCHAR(200),
@provincia_antigua VARCHAR(50),
@tipo_antigua VARCHAR(50),
@declarada_utilidad_publica_antigua BIT;

-- buscar la asociación a modificar utilizando el identificador único
SELECT @denominacion_antigua = denominacion,
@direccion_antigua = direccion,
@provincia_antigua = provincia,
@tipo_antigua = tipo,
@declarada_utilidad_publica_antigua = declarada_utilidad_publica
FROM Asociaciones
WHERE codigo = @id;

-- modificar los campos de la asociación utilizando las variables declaradas
UPDATE Asociaciones
SET denominacion = COALESCE(@denominacion, @denominacion_antigua),
direccion = COALESCE(@direccion, @direccion_antigua),
provincia = COALESCE(@provincia, @provincia_antigua),
tipo = COALESCE(@tipo, @tipo_antigua),
declarada_utilidad_publica = COALESCE(@declarada_utilidad_publica, @declarada_utilidad_publica_antigua)
WHERE codigo = @id;
END;

ALTER procedure EliminarAsociacion
@id int
as
declare @subproy int
set @subproy = (select id_proyecto from proyectos where @id = id_asociacion)
begin
delete Socios where @id = id_asociacion
delete Asociaciones where @id = codigo

delete proyectos where @id = id_asociacion
delete Subproyectos where @subproy = id_proyecto
end

EliminarAsociacion 5

select * from Asociaciones


ALTER PROCEDURE ModificarSocio
@dni VARCHAR(10),
@nombre VARCHAR(100),
@direccion VARCHAR(200),
@provincia VARCHAR(50),
@cuota_mensual DECIMAL(10,2),
@id_asociacion INT
AS
BEGIN
    DECLARE @aportacion_anual DECIMAL(10,2);
    SET @aportacion_anual = @cuota_mensual * 12;

    -- verificar si el socio existe
    IF EXISTS(SELECT * FROM Socios WHERE dni = @dni)
    BEGIN
        -- realizar la actualización
        UPDATE Socios
        SET nombre = @nombre,
            direccion = @direccion,
            provincia = @provincia,
            cuota_mensual = @cuota_mensual,
            aportacion_anual = @aportacion_anual,
            id_asociacion = @id_asociacion
        WHERE dni = @dni;
        
        PRINT 'El socio se ha actualizado correctamente';
    END
    ELSE
    BEGIN
        PRINT 'No se puede actualizar, el socio no existe';
    END
END;


create procedure EliminarSocio
@dni varchar(10)
as
begin
delete Socios where @dni = dni
end


ALTER PROCEDURE ModificarTrabajador
@dni VARCHAR(10),
@nombre VARCHAR(100),
@tipo VARCHAR(50),
@edad int,
@SalarioB DECIMAL(10,2),
@cantidad_essalud DECIMAL(10,2),
@profesion VARCHAR(50) = NULL,
@horasdedicadas int = NULL,
@porcentaje_impuesto_renta DECIMAL(10,2)
AS
BEGIN
DECLARE @dnivalT varchar(10)
DECLARE @dnivalV varchar(10)
SET @dnivalT = (select dni from Trabajadores where dni = @dni);
SET @dnivalV = (select dni from Voluntarios where dni = @dni);

IF (@dnivalT IS NULL AND @dnivalV IS NULL)
BEGIN
PRINT 'Este Trabajador no existe';
END
ELSE
BEGIN
IF (@tipo IS NOT NULL AND @tipo != 'asalariado' AND @tipo != 'voluntario')
BEGIN
PRINT 'El tipo de trabajador debe ser "asalariado" o "voluntario"';
RETURN;
END
IF (@tipo = 'asalariado' AND (@SalarioB IS NOT NULL OR @cantidad_essalud IS NOT NULL OR @porcentaje_impuesto_renta IS NOT NULL))
BEGIN
    DECLARE @Salario DECIMAL(10,2)
   set @Salario = (dbo.CalcularSalarioNeto(@SalarioB,@cantidad_essalud,@porcentaje_impuesto_renta))
END

IF (@tipo = 'asalariado')
BEGIN
    IF (@dnivalT IS NOT NULL AND @dnivalT != @dni)
    BEGIN
        PRINT 'Ya existe un trabajador asalariado con el mismo DNI';
        RETURN;
    END
END

IF (@tipo = 'voluntario')
BEGIN
    IF (@dnivalV IS NOT NULL AND @dnivalV != @dni)
    BEGIN
        PRINT 'Ya existe un voluntario con el mismo DNI';
        RETURN;
    END
END

IF (@tipo IS NOT NULL)
BEGIN
    UPDATE Trabajadores SET tipo = @tipo WHERE dni = @dni;
    --UPDATE Voluntarios SET tipo = @tipo WHERE dni = @dni;
END

IF (@nombre IS NOT NULL)
BEGIN
    UPDATE Trabajadores SET nombre = @nombre WHERE dni = @dni;
    UPDATE Voluntarios SET nombre = @nombre WHERE dni = @dni;
END

IF (@edad IS NOT NULL)
BEGIN
    UPDATE Trabajadores SET edad = @edad WHERE dni = @dni;
    UPDATE Voluntarios SET edad = @edad WHERE dni = @dni;
END

IF (@SalarioB IS NOT NULL)
BEGIN
    --UPDATE Trabajadores SET salario_base = @SalarioB WHERE dni = @dni;
    UPDATE Trabajadores SET salario = @Salario WHERE dni = @dni;
END

IF (@cantidad_essalud IS NOT NULL)
BEGIN
    UPDATE Trabajadores SET cantidad_essalud = @cantidad_essalud WHERE dni = @dni;
    UPDATE Trabajadores SET salario = @Salario WHERE dni = @dni;
END

IF (@profesion IS NOT NULL)
BEGIN
    UPDATE Trabajadores SET cargo = @profesion WHERE dni = @dni;
	UPDATE Voluntarios SET profesion = @profesion WHERE dni = @dni;
END

IF (@horasdedicadas IS NOT NULL)
BEGIN
    UPDATE Voluntarios SET horas_dedicadas = @horasdedicadas WHERE dni = @dni;
END

IF (@porcentaje_impuesto_renta IS NOT NULL)
BEGIN
    UPDATE Trabajadores SET porcentaje_impuesto_renta = @porcentaje_impuesto_renta WHERE dni = @dni;
    UPDATE Trabajadores SET salario = @Salario WHERE dni = @dni;
END

PRINT 'Trabajador actualizado correctamente';
END
END;


select * from Trabajadores

select * from Voluntarios

create procedure SocioTrabajador
@dni varchar(10)
as
--declare @subproy int
--set @subproy = (select id_proyecto from proyectos where @dni = dni_trabajador)
begin
select dni from Socios where @dni = dni
end



ALTER procedure EliminarTrabajador
@dni varchar(10)
as
declare @subproy int
set @subproy = (select id_proyecto from proyectos where @dni = dni_trabajador)
begin
delete Subproyectos where @subproy = id_proyecto
delete proyectos where @dni = dni_trabajador
delete Trabajadores where @dni = dni



delete Voluntarios where @dni = dni
end


select * from proyectos

CREATE PROCEDURE modificar_proyecto (
@id_proyecto INT,
@codigo_asociacion CHAR(4),
@pais VARCHAR(50),
@zona VARCHAR(50),
@objetivo VARCHAR(500),
@beneficiarios INT,
@dni VARCHAR(50)
)
AS
BEGIN
    DECLARE @dnivalT varchar(10)
    DECLARE @dnivalV varchar(10)
    SET @dnivalT = (SELECT dni FROM Trabajadores WHERE dni = @dni);
    SET @dnivalV = (SELECT dni FROM Voluntarios WHERE dni = @dni);
    
    IF (@dnivalT = @dni OR @dnivalV = @dni)
    BEGIN
        UPDATE proyectos 
        SET 
            id_asociacion = @codigo_asociacion,
            pais = @pais,
            zona = @zona,
            objetivo = @objetivo,
            num_beneficiarios = @beneficiarios,
            dni_trabajador = @dni
        WHERE id_proyecto = @id_proyecto;
    END
    ELSE
    BEGIN
        PRINT 'El trabajador no existe';
    END
END

alter procedure EliminarProyecto
@id int
as
begin
delete subproyectos where @id = id_proyecto
delete proyectos where @id = id_proyecto
end

select * from Subproyectos

alter PROCEDURE modificar_subproyecto
@idSubproyecto int,
@id_proyecto int,
@nombre VARCHAR(50),
@pais VARCHAR(50),
@zona VARCHAR(50),
@objetivo_sub VARCHAR(500),
@num_beneficiarios_subproyecto INT
AS
DECLARE @Subproy int

SET @Subproy = (select id from subproyectos where id = @idSubproyecto);
if(@idSubproyecto = @Subproy)
BEGIN
SET NOCOUNT ON;
UPDATE subproyectos SET 
    nombre = @nombre, 
    pais = @pais, 
    zona = @zona, 
    objetivo_subproyecto = @objetivo_sub, 
    num_beneficiarios_subproyecto = @num_beneficiarios_subproyecto 
WHERE id = @idSubproyecto;
END
else
begin
print 'El subproyecto no existe'
end


create procedure EliminarSubProyecto
@id int
as
begin
delete subproyectos where @id = id

end

