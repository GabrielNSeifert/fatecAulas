create table EMPREGADOS
(
MATR		CHAR(6),
NOME		VARCHAR(12),
SOBRENOME	VARCHAR(15),
DEPT		CHAR(10),
FONE		VARCHAR(14),
DATA_ADM	DATETIME,
CARGO		CHAR(10),
SEXO		CHAR(1),
IDADE		INT,
SALARIO		NUMERIC(10,2),
COMISSAO	NUMERIC(10,2),
CONSTRAINT PK_P PRIMARY KEY  (MATR)
);

--drop table EMPREGADOS;

SELECT * FROM EMPREGADOS;

INSERT INTO EMPREGADOS VALUES
('000001', 'Gabriel', 'Neves', 'TI', '00000001', '20220915', 'CEO', 'M', 21, 3000000.00, 50000.00),
('000002', 'Juhes', 'Lotcie', 'TI', '00000002', '20220915', 'Progra', 'M', 22, 1000.00, 3000.00),
('000003', 'Suedelug', 'Myugham', 'VENDAS', '00000003', '20220915', 'Progra', 'M', 23, 20000.00, 3000.00),
('000004', 'Ushawugur', 'Haorme', 'TI', '00000004', '20220915', 'Progra', 'M', 24, 30000.00, 3000.00),
('000005', 'Arrerandir', 'Boin', 'TI', '00000005', '20220915', 'Progra', 'M', 25, 40000.00, 3000.00),
('000006', 'Doindaso', 'Noetu', 'MARKETING', '00000006', '20220915', 'Progra', 'M', 26, 50000.00, 3000.00),
('000007', 'Kaplorod', 'Ushawugur', 'TI', '00000007', '20220915', 'Progra', 'M', 27, 60000.00, 3000.00),
('000008', 'Nyemulon', 'Teum', 'TI', '00000008', '20220915', 'Progra', 'M', 28, 70000.00, 3000.00),
('000009', 'Ushawugur', 'Lotcie', 'TI', '00000009', '20220915', 'Progra', 'M', 29, 80000.00, 3000.00),
('000010', 'Teum', 'Ceuse', 'TI', '00000010', '20220915', 'Progra', 'M', 30, 90000.00, 3000.00);

-- C) SELECIONAR SOBRENOME, NOME, DEPT, DATA_ADM E SALÁRIO DE QUEM GANHA ACIMA DE 5000
SELECT NOME,SOBRENOME,DEPT,DATA_ADM,SALARIO FROM EMPREGADOS WHERE SALARIO >=5000;

-- D) QUAL A MÉDIA DOS SALÁRIOS DOS FUNCIONÁRIOS
SELECT AVG(SALARIO) AS 'MÉDIA SALARIAL DOS FUNCIONÁRIOS' FROM EMPREGADOS;

-- E) QUANTOS FUNCIONÁRIOS PERTENCEM AO DEPARTAMENTO DE TI
SELECT * FROM EMPREGADOS WHERE DEPT IN('TI');

-- F) QUANTOS FUNCIONÁRIOS TEMOS COM O CARGO DE Progra
SELECT * FROM EMPREGADOS WHERE CARGO IN('Progra');

-- G) QUAL A SOMA DOS SALÁRIOS DOS FUNCIONÁRIOS
SELECT SUM(SALARIO) AS 'SALARIO TOTAL DOS FUNCIONÁRIOS' FROM EMPREGADOS;

-- H) QUAL O MAIOR SALÁRIO
SELECT MAX(SALARIO) AS 'MAIOR SALÁRIO' FROM EMPREGADOS;

-- I) QUAL O MENOR SALÁRIO
SELECT MIN(SALARIO) AS 'MENOR SALÁRIO' FROM EMPREGADOS;

-- J) ATRIBUIR UM AUMENTO DE 5% AOS FUNCIONÁRIOS DO DEPT DE TI
UPDATE EMPREGADOS SET SALARIO=SALARIO*1.05 WHERE DEPT='TI';

-- K) SELECIONAR CARGOS SEM DUPLICIDADE
SELECT DISTINCT CARGO FROM EMPREGADOS;

--L) SELECIONAR FUNCIONÁRIOS COM IDADE ENTRE 30 E 40 ANOS(INCLUSIVE)
SELECT * FROM EMPREGADOS WHERE IDADE BETWEEN 30 AND 40;

-- M) QUAL A MÉDIA DE IDADES
SELECT AVG(IDADE) AS 'MÉDIA DAS IDADES DOS FUNCIONÁRIOS' FROM EMPREGADOS;

-- N) SELECIONAR TODOS OS FUNCIONÁRIOS ENTRE 20 E 30 ANOS(INCLUSIVE)
SELECT * FROM EMPREGADOS WHERE IDADE BETWEEN 20 AND 30;

-- O) SELECIONAR TODOS OS FUNCIONÁRIOS CUJO NOME SE INICIA COM A LETRA J
SELECT * FROM EMPREGADOS WHERE NOME LIKE 'J%';

-- P) SELECIONAR TODOS OS FUNCIONÁRIOS DOS DEPARTAMENTOS DE TI, VENDAS E MARKETING
SELECT * FROM EMPREGADOS WHERE DEPT='TI' OR DEPT='VENDAS' OR DEPT='MARKETING';
