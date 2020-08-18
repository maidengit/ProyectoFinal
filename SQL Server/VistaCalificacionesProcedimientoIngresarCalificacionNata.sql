alter view vCalificaciones
as
SELECT c.CalificacionID,e.EstudianteID, e.Nombre,a.AsignaturaID, a.Nombre AS Materia, c.NotaParcial AS Calificacion,
g.GradoID,g.Curso AS Grado, e.Sexo,c.Parcial NumeroParcial,
CASE WHEN c.NotaParcial > 69 THEN 'Aprobado' WHEN c.NotaParcial < 70 THEN 'Reprobado' END AS Estado, 
CASE WHEN c.Parcial = '1' and g.Curso in('I BTP','II BTP','III BTP') THEN 'I Parcial, I Semestre'
WHEN c.Parcial = '2' and g.Curso in('I BTP','II BTP','III BTP') THEN 'II Parcial, I Semestre'
WHEN c.Parcial = '3' and g.Curso in('I BTP','II BTP','III BTP') THEN 'I Parcial, II Semestre'
WHEN c.Parcial = '4' and g.Curso in('I BTP','II BTP','III BTP') THEN 'II Parcial, II Semestre'
WHEN c.Parcial = '1' and g.Curso in('SEPTIMO','OCTAVO','NOVENO') THEN 'I Parcial'
WHEN c.Parcial = '2' and g.Curso in('SEPTIMO','OCTAVO','NOVENO') THEN 'II Parcial'
WHEN c.Parcial = '3' and g.Curso in('SEPTIMO','OCTAVO','NOVENO') THEN 'III Parcial'
WHEN c.Parcial = '4' and g.Curso in('SEPTIMO','OCTAVO','NOVENO') THEN 'IV Parcial'
END AS Parcial,
CASE WHEN c.NotaParcial BETWEEN 91 AND 100 THEN 'Avanzado' WHEN c.NotaParcial BETWEEN 81 AND 90 THEN 'Muy Satisfactorio'
WHEN c.NotaParcial BETWEEN 70 AND 80 THEN 'Satisfactorio' WHEN c.NotaParcial BETWEEN 0 AND 69 THEN 'Insuficiente' END AS Tipo
FROM   dbo.Calificaciones AS c INNER JOIN
             Asignatura AS a ON c.AsignaturaID = a.AsignaturaID INNER JOIN
             Grado AS g ON a.GradoID = g.GradoID INNER JOIN
             Estudiante AS e ON e.EstudianteID = c.EstudianteID
go
create procedure spAgregarCalificacion @Asignatura int,@nota float,@parcial Varchar(1),@estudiante int
as
	begin transaction
	declare @id int
	select @id = isnull(max(CalificacionID),0) from Calificaciones
	set @id = @id + 1
	insert into Calificaciones values(@id,@Asignatura,@nota,@parcial,@estudiante)
	if @@ERROR=0
		commit
	else
		rollback
go
exec spAgregarCalificacion 77,75,'1',201
select * from Estudiante  
select * from asignatura where AsignaturaID =77
select * from Calificaciones
update grado set Curso='SEPTIMO' where GradoID=7
update grado set Curso='OCTAVO' where GradoID=8
update grado set Curso='NOVENO' where GradoID=9
update grado set Curso='I BTP' where GradoID=10
update grado set Curso='II BTP' where GradoID=11
update grado set Curso='III BTP' where GradoID=12

