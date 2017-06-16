USE [C:\USERS\ERICK\DESKTOP\MEGA-NUVEM\PROGRAMMING\REPOSITORY\ARTIGOS-PAGE\ARTIGO\DBARTIGOS.MDF];  
GO  
EXEC sp_rename 'Usuarios.tipo_de_usuario', 'perfil', 'COLUMN';  
GO  

//revisao

ALTER TABLE [dbo].[Revisao] ADD CONSTRAINT fk_artigo_id FOREIGN KEY(id_artigo) REFERENCES Artigo(idartigo);

//Area interesse

ALTER TABLE [dbo].[Artigo] ADD CONSTRAINT fk_areaInteresse_id 
FOREIGN KEY(id_area_interesse_fk) REFERENCES Area_interesse_artigo(idarea_interesse_artigo);


ALTER TABLE [dbo].[Artigo] DROP CONSTRAINT fk_artigo_id;

insert into Revisao(nome_revisor,status,id_artigo) values('Revisor','Aprovado',13);

select a.idartigo,a.titulo, r.status
from Artigo a inner join Revisao r on a.Id = r.fk_artigo_id
where r.id_artigo = 14;

PRIMARY KEY CLUSTERED ([idartigo] ASC)

PRIMARY KEY CLUSTERED ([idarea_interesse_artigo] ASC)

    PRIMARY KEY CLUSTERED ([idartigo] ASC)

//Ver chaves estrangeiras no sqlserver

USE [C:\USERS\ERICK\DESKTOP\MEGA-NUVEM\PROGRAMMING\REPOSITORY\ARTIGOS-PAGE\ARTIGO\DBARTIGOS.MDF];    
GO  
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


