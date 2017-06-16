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

