create table Produtos
(
codigoProduto	int,
descriçao		varchar(20),
preco			numeric(9,2),
quantidade		int,
cor				char(20),
constraint Pk_CodP primary key (codigoProduto)
); 

insert into Produtos values
(1,'prod1',5,1,'Vermelho'),
(2,'prod2',100,2,'Azul'),
(3,'prod3',200,3,'Amarelo'),
(4,'prod4',300,4,'Roxo'),
(5,'prod5',400,5,'Vermelho'),
(6,'prod6',500,6,'Preto'),
(7,'prod7',600,7,'Branco'),
(8,'prod8',700,8,'Verde'),
(9,'prod9',800,9,'Marron'),
(10,'prod10',900,10,'Vermelho');

-- Apagar tabela e registros
--drop table Produtos;

-- C) Quantos produtos temos no cadastro?
select * from Produtos;

-- D)Selecionar os produtos com preço entre 10 e 50 reais.
select * from Produtos where preco >=10 and preco<=50 ;

-- E) Qual o valor do produto mais caro?
select Max(preco) from Produtos

-- F) Qual o valor do produto mais barato?
select Min(preco) from Produtos

-- G) Qual a média de preços?
select Avg(preco) from Produtos

-- H) Quantos produtos vermelhos temos no cadastro?
select * from Produtos where cor= 'Vermelho';

-- I) Atualizar o preço dos produtos com preço abaixo de 10.00 acrescentando 15%
update Produtos  set preco = preco * 1.15 where preco<=10;

-- J) Atualizar o preço dos produtos com preço acima de 500.00 com um desconto de 5%
update Produtos set preco = preco * 0.95 where preco>=500.00;

-- K)Excluir todos os produtos com qtde abaixo de 5
delete from Produtos where quantidade<5;

-- L)Listar  as cores sem duplicidade
select  distinct cor from Produtos;

-- M)Selecionar todos os produtos de cor Azul, vermelho, branco e preto.
select * from Produtos where cor= 'Vermelho' or cor='Azul' or cor='Branco' or cor='Preto';

-- N)Qual o somatório das quantidades?
select sum(quantidade) as 'Total' from Produtos;

-- O)Listar todos os produtos que tem descrição iniciado em ‘A’.
select*from Produtos where descriçao like 'A%';

