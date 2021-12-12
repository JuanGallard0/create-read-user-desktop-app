-- Tabla rol
create table rol (
	idrol integer primary key identity,
	nombre varchar(50) not null unique,
	descripcion varchar(255) null,
	estado bit default(1)
);
go

-- Tabla persona
create table persona (
	idpersona integer primary key identity,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	edad integer not null,
	telefono varchar(20) null,
	idrol integer not null,
	FOREIGN KEY (idrol) REFERENCES rol(idrol) ON DELETE CASCADE
);
go

--Procedimiento Listar rol
create proc rol_listar
as
select idrol as ID, nombre as Nombre, descripcion as Descripcion, estado as Estado
from rol
order by idrol asc
go

--Procedimiento Listar persona con su rol
create proc persona_listar
as
select idpersona as ID, p.nombre as Nombre, apellido as Apellido, edad as Edad, telefono as Telefono, r.nombre as Rol
from persona as p
inner join rol as r
on p.idrol = r.idrol
order by idpersona desc
go

--Procedimiento Insertar persona
create proc persona_insertar
@nombre varchar(50),
@apellido varchar(50),
@edad integer,
@telefono varchar(20),
@idrol integer
as
insert into persona (nombre,apellido,edad,telefono,idrol) values (@nombre,@apellido,@edad,@telefono,@idrol)
go

-- Insertar algunos valores en tabla rol
insert into rol values
	('Administrador', 'puede hacer todo en el sitio', 1),
	('Gestor', 'un rol de administrador menor', 1),
	('Profesor', ' puede calificar dentro de los cursos, pero no puede editarlos', 1),
	('Estudiante', 'puede acceder y participar en cursos', 0);
go

-- Insertar algunos valores en table persona
insert into persona values 
	('Juan', 'Gallardo', 25, '22222222', 1);
go