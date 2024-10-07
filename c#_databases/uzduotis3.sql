--1
SELECT d.VARDAS, d.PAVARDE, p.PAVADINIMAS
FROM DARBUOTOJAS as d
inner join PROJEKTAS as p ON d.projektas_ID = p.ID
--2
SELECT d.VARDAS, d.PAVARDE, p.PAVADINIMAS
FROM DARBUOTOJAS as d
inner join PROJEKTAS as p ON d.projektas_ID = p.ID
where d.PROJEKTAS_ID  = '3'
--3
SELECT d.VARDAS, d.PAVARDE, s.PAVADINIMAS as SKYRIUS
FROM DARBUOTOJAS as d
inner join SKYRIUS as s ON d.ASMENSKODAS = s.VADOVAS_ASMENSKODAS
where s.PAVADINIMAS = 'testavimo' and d.PROJEKTAS_ID = '2'
--4
SELECT VARDAS, PAVARDE 
FROM DARBUOTOJAS as d
inner join PROJEKTAS as p ON d.PROJEKTAS_ID = s.
where ASMENSKODAS like '4%' and PROJEKTAS_ID = '1'
--5
SELECT PROJEKTAS_ID, COUNT(ASMENSKODAS) AS Darbuotojai 
FROM DARBUOTOJAS
GROUP BY PROJEKTAS_ID
