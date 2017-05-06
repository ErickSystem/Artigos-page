USE [C:\USERS\ERICK\DESKTOP\MEGA-NUVEM\PROGRAMMING\REPOSITORY\ARTIGOS-PAGE\ARTIGO\DBARTIGOS.MDF];  
GO  
EXEC sp_rename 'Usuarios.tipo_de_usuario', 'perfil', 'COLUMN';  
GO  

select * from Usuarios;

delete from Usuarios where id = 5;