
USE Bank;
GO
CREATE PROCEDURE ShowBankTypes2 AS
BEGIN
	SELECT *
	FROM dbo.Client
	Return;
END;
EXEC ShowBankTypes2
GO

---- 2. Процедура с входными параметрами - добавление нового звания
USE Bank;
GO
CREATE PROCEDURE AddBank3
	@bank nvarchar(32),
	@id int
AS
BEGIN
	INSERT INTO Bank_Types([id_bank], [name])
	VALUES (@id, @bank)
END;
GO

SET IDENTITY_INSERT Bank_Types ON

EXEC AddBank3 'OTKRITIe',2228

select * from dbo.Bank_Types



---- 3. Процедура с выходными параметрами - подсчёт количества записей о матчах
USE Bank;
GO
CREATE PROCEDURE CountBanks
	@banksCount int OUTPUT
AS
BEGIN
	SELECT @banksCount = COUNT(id_bank)
	FROM Bank_Types
END;

GO

USE Bank;
DECLARE @banksCount int

EXEC CountBanks @banksCount OUTPUT

Print @banksCount 

select * from dbo.Bank_Types



---- 4. Процедура с входными и выходными параметрами
USE Bank;
GO
CREATE PROCEDURE GetCountSafesProc5
	@id_client int,
	@count_safes INT OUTPUT
AS
BEGIN
	Select @count_safes=count_safes from dbo.Client where id_client=@id_client
END;

GO

select * from dbo.Client

USE Bank;
DECLARE @count_safes INT

EXEC GetCountSafesProc5 10007, @count_safes OUTPUT
PRINT 'Ѕыло получено по id ' + CONVERT(VARCHAR, @count_safes)