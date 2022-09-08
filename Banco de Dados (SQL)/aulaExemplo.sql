create table Exemplo
(
CodigoCliente	int,
Nome			varchar(40),
Idade			int,
Data_Cad		datetime,
Cidade			varchar(40),
Valor_Apl		numeric(10,2),
constraint Pk_Cod primary key (CodigoCliente)
); 

-- Selecionar os dados da tabela
select * from Exemplo;

-- Inserir dados na tabela
insert into Exemplo values
(123,'Gabriel S Neves',21,'20220908','Mauá',500.50),
(456,'Vanessa',20,'20220908','Mauá',500.50),
(789,'Douglas',50,'20220908','Mauá',500.50);

-- Apagar tabela e registros
-- drop table Exemplo;

--Inserir código e nome do cliente
insert into Exemplo (CodigoCliente, Nome) values
(4,'Mariana');

--Aplicando critérios
--Selecionar todos com idade até 18 anos
select * from Exemplo
where Idade >= 18;

--Selecionar nome e cidade de todos com idade
--Até 18
select Nome,Cidade from Exemplo where Idade >=18;
