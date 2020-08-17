--Nombre del tutor
create function fnNombreTutor(@estudiante int) returns varchar(50) as begin declare @tutor varchar(50),
@telefono int
select
    @tutor = t.nombre
from
    Estudiante e
    join Tutor t on e.TutorID = t.TutorID
where
    EstudianteID = @estudiante return @tutor
end
go
    --Telefono del tutor
    create function fnTelefonoTutor(@estudiante int) returns int as begin declare @telefono int
select
    @telefono = t.Celular
from
    Estudiante e
    join Tutor t on e.TutorID = t.TutorID
where
    EstudianteID = @estudiante return @telefono
end
go
    create function fnEdad(@estudiante int) returns int as begin declare @edad int
select
    @edad = floor(
        (
            cast(convert(varchar(8), getdate(), 112) as int) - cast(
                convert(varchar(8), es.FechaNacimiento, 112) as int
            )
        ) / 10000
    )
from
    estudiante es
where
    EstudianteID = @estudiante return @edad
end
go