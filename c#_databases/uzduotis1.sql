--SELECT * FROM Test.[dbo].[DARBUOTOJAS] 
--SELECT asmenskodas FROM [Test].[dbo].[DARBUOTOJAS]
--SELECT vardas, pavarde, pareigos FROM [Test].[dbo].[DARBUOTOJAS]
--SELECT DISTINCT skyrius_pavadinimas FROM [Test].[dbo].[DARBUOTOJAS]
--SELECT * FROM Test.[dbo].[DARBUOTOJAS] where skyrius_pavadinimas = 'C#'
--SELECT vardas, pareigos FROM Test.[dbo].[DARBUOTOJAS] where vardas = 'giedrius'
--SELECT * FROM Test.[dbo].[DARBUOTOJAS] where gimimometai = '1986-09-19'
--SELECT vardas FROM Test.[dbo].[DARBUOTOJAS] where pavarde = 'sabutis'
--SELECT vardas, pavarde FROM Test.[dbo].[DARBUOTOJAS] where skyrius_pavadinimas = 'java'
--10.
--INSERT INTO Test.[dbo].[DARBUOTOJAS] VALUES
--('38101122123', 'As', 'Jus', '2024-10-30', '1900-01-11', 'Testuotojas', 'Testavimo', 1)
--11.
--INSERT INTO Test.[dbo].[DARBUOTOJAS] VALUES
--('38101122123', 'Jokubas', 'Jokubaitis', '2024-10-30', '1988-01-11', NULL, NULL, NULL)
--12.UPDATE Test.[dbo].[DARBUOTOJAS]
--SET pareigos = 'Testuotojas', skyrius_pavadinimas = 'Testavimo', projektas_ID = '3'
--where vardas = 'Jokubas'
--13.
--Delete FROM Test.[dbo].[DARBUOTOJAS]
--where asmenskodas = '38101122123'
--14.
--INSERT INTO Test.[dbo].[DARBUOTOJAS] VALUES
--('38901228527', 'Pirmas', 'Antanaitis', '2024-10-21', '1988-02-11', 'Programuotojas', NULL, NULL),
--('38901228528', 'Antras', 'Antanaitis', '2024-10-22', '1988-03-11', 'Programuotojas', NULL, NULL)
--15.
--UPDATE Test.[dbo].[DARBUOTOJAS]
--SET pareigos = 'Testuotojas'
--where pavarde = 'Antanaitis'
--16.
--SELECT COUNT(PAREIGOS) AS imoneje_yra_testuotoju
--FROM Test.[dbo].[DARBUOTOJAS]
--WHERE pareigos = 'testuotojas'




