select * from Artigo;

select * from Area_interesse_artigo;

select * from Usuarios;

select a.idartigo,a.titulo, r.status
from Artigo a inner join Revisao r on a.idartigo = r.id_artigo;


select a.idartigo, a.titulo, lower(u.areaInteresse)as "Area Interesse", ra.area FROM (
	Artigo a INNER JOIN Area_interesse_artigo ra 
	ON a.id_area_interesse_fk = ra.idarea_interesse_artigo
)
INNER JOIN Usuarios u ON a.id_usuario = u.idusuario
WHERE u.areaInteresse like '%historia%';

create view area_de_interesse_revisor_artigo


delete from Revisao;

USE [C:\USERS\ERICK\DESKTOP\MEGA-NUVEM\PROGRAMMING\REPOSITORY\ARTIGOS-PAGE\ARTIGO\DBARTIGOS.MDF];    
GO  
ALTER TABLE [dbo].[Artigo] ADD CONSTRAINT id_usuario_fk FOREIGN KEY(id_usuario) REFERENCES Usuarios(idusuario);
go

SELECT   
    f.name AS foreign_key_name  
   ,OBJECT_NAME(f.parent_object_id) AS table_name  
   ,COL_NAME(fc.parent_object_id, fc.parent_column_id) AS constraint_column_name  
   ,OBJECT_NAME (f.referenced_object_id) AS referenced_object  
   ,COL_NAME(fc.referenced_object_id, fc.referenced_column_id) AS referenced_column_name  
   ,is_disabled  
   ,delete_referential_action_desc  
   ,update_referential_action_desc  
FROM sys.foreign_keys AS f  
INNER JOIN sys.foreign_key_columns AS fc   
   ON f.object_id = fc.constraint_object_id   
WHERE f.parent_object_id = OBJECT_ID('Artigo');  
