create procedure Modificar_Atracador
@ci int,
@ciex char(3),
@nombre varchar(30),
@apePaterno varchar(30),
@apeMaterno varchar(30),
@genero char(1),
@fecNacimiento date,
@codBanda int
as begin
  update persona set ciex = @ciex,
    nombre = @nombre, apePaterno = @apePaterno, apeMaterno = @apeMaterno,
    genero = @genero, fecNacimiento = @fecNacimiento
  where ci = @c

  update atracador set codBanda @codBanda where ciP = @ci
end
