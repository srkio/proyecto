-- use EntidadBancaria;

-- insert into persona(ciex, nombre, apePaterno, apeMaterno, genero, fecNacimiento) values ('lol', 'nombre', 'apellido', 'apellido', 'F', '01/01/01');

alter procedure Guardar_Atracador
@ciex char(3),
@nombre varchar(30),
@apePaterno varchar(30),
@apeMaterno varchar(30),
@genero char(1),
@fecNacimiento date,
@codBanda int
as begin
	declare @idPersona int

	insert into Persona	values (@ciex, @nombre, @apePaterno, @apeMaterno, @genero, @fecNacimiento);
	set @idPersona = (select IDENT_CURRENT('Persona'));
	insert into Atracador values (@idPersona, @codBanda);
end


alter procedure Eliminar_Atracador
@ci int
as begin
	delete from Atracador where ciP = @ci;
	delete from Persona where ci = @ci;
end