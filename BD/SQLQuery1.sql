
-- 1. Запрос с выборкой полей и условием
SET IDENTITY_INSERT Bank_Types ON;
SELECT id_bank as  ID,name as Название From dbo.Bank_Types
where id_bank=23

--Select * from dbo.Bank_Types

---- 2. Запрос с использованием DISTINCT
SELECT DISTINCT name FROM dbo.Bank_Types

---- 3. Запрос с использованием специальных операторов SQL (IN, BETWEEN, LIKE)
SELECT * FROM dbo.Client
where id_client in('10007','10010')

SELECT * FROM dbo.Bank_Types
WHERE id_bank BETWEEN '23' AND '28'
---- 4. Запрос с единичной агрегатной функцией (count, sum, avg, max, min)
SELECT min(age) as [Возраст] FROM dbo.Client

SELECT family as Фамилия, age as Возраст FROM dbo.Client
WHERE age = (SELECT min(age) FROM dbo.Client)

---- 5. Запрос с агрегатной функцией, группировкой и использованием условия
---- 
SELECT age FROM dbo.Client GROUP BY age
---- 
SELECT id_client, SUM(count_visit) as sum FROM dbo.[Date of Visit Client] GROUP BY id_client 
SELECT * from dbo.[Date of Visit Client]

---- 6. Запрос с внутренним соединением двух таблиц
SELECT Client.id_client as id,Client.family as Фамилия, Depatament.departament__name as Департамент
FROM dbo.Client INNER JOIN dbo.Depatament
ON Client.id_departament = Depatament.id_departament
---- 7. Запрос, использующий одно из внешних соединений двух таблиц
SELECT Client.id_client as id,Client.family as Фамилия, Depatament.departament__name as Департамент
FROM dbo.Client Right JOIN dbo.Depatament
ON Client.id_departament = Depatament.id_departament
WHERE NOT  Client.id_departament IS NULL

SELECT Client.id_client as id,Client.family as Фамилия, Depatament.departament__name as Департамент
FROM dbo.Client Right JOIN dbo.Depatament
ON Client.id_departament = Depatament.id_departament
WHERE   Client.id_departament IS NULL

SELECT Client.id_client as id,Client.family as Фамилия, Depatament.departament__name as Департамент
FROM dbo.Client LEFT JOIN dbo.Depatament
ON Client.id_departament = Depatament.id_departament

---- 8. Составной запрос

SELECT a.id_client, a.name, b.count_visit
FROM Client a, [Date of Visit Client] b
WHERE a.id_client = b.id_client AND b.count_visit <
(SELECT SUM(count_visit)
FROM dbo.[Date of Visit Client]
WHERE id_client =  '10007');
---- 9. Составные запросы с использованием операторов ANY, ALL, EXISTS
SELECT family as Фамилия, age as [Возраст] FROM dbo.Client
WHERE age > ANY -- Больше хотя бы одного из выбранных
						(SELECT age FROM dbo.Client
						WHERE age BETWEEN 23 AND 25)

						
SELECT family as Фамилия, age as [Возраст] FROM dbo.Client
WHERE age > ALL -- Больше всех из выбранных
					(SELECT age FROM dbo.Client
						WHERE age BETWEEN 25 AND 35)

--Выбираем клента у которого посещение равно 2
SELECT id_client as ID,family as Фамилия
FROM dbo.Client
WHERE EXISTS (SELECT count_visit FROM dbo.[Date of Visit Client] WHERE [Date of Visit Client].id_client = Client.id_client AND count_visit =2); 

---- 10. Соотнесённый запрос
SELECT family as Фамилия FROM dbo.Client tournament
WHERE id_client = 
			(SELECT id_client FROM [Date of Visit Client] result
				WHERE result.id_client ='10009')

--Вставка
select * from dbo.Bank_Types
--Insert  into [dbo].[Bank_Types]([id_bank],[name]) VALUES (313,'Test')
--Обновление
select * from dbo.client 
--Обновление
--UPDATE dbo.Client
--SET age = age+1
--WHERE id_client = '10010'
--Удаление
DELETE FROM dbo.Bank_Types
WHERE id_bank = '313'