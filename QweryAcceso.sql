Use ONGs
go
Create table Usuario 
(idUsuario int primary key identity(1,1),
 Usuario varchar(50),
 contraseña varchar(50),
 rol varchar(50),
 estado varchar(50))

create procedure Insertar_Usuario
@usuario varchar(50),
@contraseña varchar(max),
@rol varchar(50)
as
insert into Usuario(usuario, contraseña, rol, estado)
values
(@usuario, ENCRYPTBYPASSPHRASE(@Contraseña, @Contraseña), @Rol, 'Habilitado')


 Select * from Usuario
 
 Create procedure Validar_Acceso
 @Usuario varchar(50),
 @Contraseña varchar(50)
 as
 if exists (Select top 1 * from Usuario where Usuario = @usuario 
                   and DECRYPTBYPASSPHRASE(@Contraseña, contraseña) = @Contraseña
				   and Estado = 'Habilitado')
				   begin
				   Select 'Acceso Exitoso'

				   end
				  else
				  Select 'Acceso Denegado'
 
 Declare @password varchar(50)
 set @password = 'sistemas2021'
 Declare @passEncriptado varchar(50)
 set @passEncriptado = ENCRYPTBYPASSPHRASE('123', @password)
 select @password
 Select cast(@passEncriptado as binary) as [Password Encriptado], cast (DECRYPTBYPASSPHRASE('123',@passEncriptado ) as varchar(50))

 Execute Insertar_Usuario 'ONG', 'Ong123', 'Administrador'

 EXEC Validar_Acceso 'ONG', 'Ong123'