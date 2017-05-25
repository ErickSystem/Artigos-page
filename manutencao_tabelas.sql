USE [C:\USERS\ERICK\DESKTOP\MEGA-NUVEM\PROGRAMMING\REPOSITORY\ARTIGOS-PAGE\ARTIGO\DBARTIGOS.MDF];  
GO  
EXEC sp_rename 'Usuarios.tipo_de_usuario', 'perfil', 'COLUMN';  
GO  

ALTER TABLE [dbo].[Revisao] ADD CONSTRAINT fk_artigo_id FOREIGN KEY(id_artigo) REFERENCES Artigo(Id);


ALTER TABLE [dbo].[Artigo] DROP CONSTRAINT fk_artigo_id;

insert into Revisao(nome_revisor,status,id_artigo) values('Revisor','Aprovado',13);

select * from Revisao;
select * from Artigo;

delete from Revisao;

select a.titulo, r.status,r.nome_revisor
from Artigo a inner join Revisao r on a.Id = r.fk_artigo_id 
where r.id_artigo = 14;

PRIMARY KEY CLUSTERED ([idartigo] ASC)