Use master 
GO
if exists (select * from sysdatabases where name = 'Zoologico')
      drop database Zoologico
      
go      
  SET DATEFORMAT dmy
      
  GO




  CREATE DATABASE Zoologico
  go

use Zoologico
  go 
CREATE TABLE Alimentos (
      Codalimento	int		not null		identity (1,1)		primary key ,
      Alimento		nvarchar (15)	not null,
      Descricao		nvarchar (150)  null
  
 )
       
insert into Alimentos (alimento,Descricao)			  
	   values ('Carne','Cortes de carne para animais carnivoros grandes')
	   
insert into Alimentos (alimento,Descricao)			  
	   values ('Capim','Para animais com dieta vegetal')

insert into Alimentos (alimento,Descricao)			  
	   values ('Frutas','Para animais com dieta frutifera')      
	   
insert into Alimentos (alimento,Descricao)			  
	   values ('Sementes','Para aves e pequenos roedores')

insert into Alimentos (alimento,Descricao)			  
	   values ('Ração','Para animais com dieta balanceada')

select * from Alimentos       
        
CREATE TABLE Animais (
        Codanimal int identity (1,1) primary key,
        Animal		nvarchar (50)not null,
        paisOrigem	nvarchar (30) not null,
		Localizacao nvarchar (30) not null,
        codalimento    int not null
)
        
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Leão','Africa','Ala Norte',1)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Leopardo','Africa','Ala Norte',1)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Tigre','Índia','Ala Norte',1)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Onça','Brasil','Ala Norte',1)
  
  
  
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Girafa','Australia','Ala Sul',2)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Canguru','Australia','Ala Leste',2)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Elefante','Índia','Ala Sul',2)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Anta','Argentina','Ala Oeste',2)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Capivara','Brasil','Ala Oeste',2)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Crocodilo','USA','Ala Oeste',1)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Raposa','Argentina','Ala Sul',3)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Lobo','Colombia','Ala Oeste',1)
		 
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Macaco','Colombia','Ala leste',3)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Mico Leão dourado','Brasil','Ala Leste',3)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Coruja','Chile','Ala Central',4)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Arara Canindé','Brasil','Ala Central',4)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Arara Azul','Brasil','Ala Central',4)
insert into Animais (Animal,paisOrigem,Localizacao,codalimento)
         values ('Pica-Pau','USA','Ala Central',4)

select * from animais
