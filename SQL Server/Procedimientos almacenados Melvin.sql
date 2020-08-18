create  procedure spInsertarActuarlizarTutor 
@tutorID int , @Nombre Varchar(50),@parentesco varchar(20),@Sexo varchar(1),@telefono varchar(10),@celular varchar(10),@celular2 varchar(10),
 @email varchar(20),@identidad varchar(15),@direccion varchar(60),@nacionalidad varchar(30)
as

IF NOT EXISTS (select TutorID from Tutor where TutorID=@tutorID) 

insert into Tutor values(@tutorID,@Nombre,@parentesco,@Sexo,@telefono,@celular,@celular2,@email,@identidad,@direccion,@nacionalidad)

else 
update Tutor set Nombre=@Nombre,Parentesco=@parentesco,Sexo=@Sexo,Telefono=@telefono,Celular=@celular,Celular2=@celular2
,Email=@email,Identidad=@identidad,Direccion=@direccion,Nacionalidad=@nacionalidad
where TutorID=@tutorID

go


Create function dbo.EstudianteID  (@campo int )returns int
as
	begin
			declare @ID int
			select @ID=max(EstudianteID)+1 from Estudiante
			return  @ID
	end
go

create function dbo.tutorID  (@campo int )returns int
as
	begin
			declare @ID int
			select @ID=max(TutorID)+1 from Tutor
			return  @ID
	end
	go


create  procedure  spconsultaestudiante @ID int 
as

select e.Nombre, e.Identidad, case  when MONTH(FechaNacimiento)<=MONTH(GETDATE())  then datediff(YY,FechaNacimiento,getdate()) else (datediff(YY,FechaNacimiento,getdate())-1) end Eda,t.Nombre Tutor,e.TipoDeSangre 'Tipo De Sangre'
 from Estudiante e
 inner join Tutor t on t.TutorID=e.TutorID
  where EstudianteID=@ID
  order by e.Nombre
  go


create   procedure  spconsultaestudiantes @Nombre varchar(50), @Grado int 
as

select e.Nombre, e.Identidad, case  when MONTH(FechaNacimiento)<=MONTH(GETDATE())  then datediff(YY,FechaNacimiento,getdate()) else (datediff(YY,FechaNacimiento,getdate())-1) end Eda,t.Nombre Tutor,e.TipoDeSangre 'Tipo De Sangre'
 from Estudiante e
 inner join Tutor t on t.TutorID=e.TutorID
  where (e.Nombre like '%'+@Nombre+'%' or @Nombre is null)  and (e.GradoID=@Grado or @Grado=0)
  order by e.Nombre
  go


create   procedure spconsultatutor @Nombre varchar(50)
as
select Nombre,Identidad,Telefono,Email Correo,Direccion from Tutor
where Nombre  like '%'+@Nombre+'%' or @Nombre is null
go


create  procedure speleminarestudiante @id int
as

delete from Estudiante where EstudianteID=@id
go


create   procedure speleminartutor @id int
as
delete from Tutor where TutorID=@id
go

create  procedure spIngresarAlumnos @id int, @nombre varchar(50),@sexo varchar (1), @FechaNacimiento date, @tutorid int, @identidad varchar (15),
@tipoSangre varchar (3), @fecha date, @gradoid int,@estado varchar(1)
as
insert into Estudiante values (@id, @nombre, @sexo, @FechaNacimiento, @tutorid, @identidad,@tipoSangre, @fecha, @gradoid,@estado)
go


create  procedure spInsertarActuarlizar 
@EstudianteID int , @Nombre Varchar(50),@Sexo varchar(1),@FechaNa date,@tutorid int ,@Identidad Varchar(15),@tipoSangre varchar(3),@gradoID int,@estado varchar(1)
as
declare @fecha date 
select @fecha= GETDATE()
IF NOT EXISTS (select EstudianteID from Estudiante where EstudianteID=@EstudianteID) 

insert into Estudiante values(@EstudianteID,@Nombre,@Sexo,@FechaNa,@tutorid,@Identidad,@tipoSangre,@fecha,@gradoID,@estado)
else 

update Estudiante set Nombre=@Nombre,Sexo=@Sexo,FechaNacimiento=@FechaNa,TutorID=@tutorid,
Identidad=@Identidad,TipoDeSangre=@tipoSangre,Fecha=@fecha,GradoID=@gradoID,Estado=@estado
where EstudianteID=@EstudianteID 
go






