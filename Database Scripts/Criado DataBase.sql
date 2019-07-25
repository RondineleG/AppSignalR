USE master -- Especificando a base dasdos Master
GO
IF NOT EXISTS ( --  Verificando se existe um Banco com o nome as ser criado
   SELECT name
   FROM sys.databases 
   WHERE name = N'AppSignalR' -- Checando em sys.databases se existe um dabase com esse nome
)
CREATE DATABASE AppSignalR  -- Criando banco de dados
GO -- comando que pular pra o proximo comando