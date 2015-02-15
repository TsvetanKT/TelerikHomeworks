CREATE TABLE Logs(
	Id int NOT NULL IDENTITY,
	LogDate datetime,
	MsgText varchar(300),
	CONSTRAINT PK_Logs_Id PRIMARY KEY (Id)
)

GO

-- 10M is too much for my laptop, i'm going with 1M
CREATE PROC usp_AddManyLogs
AS
DECLARE @counter int
SET @counter = 1;
WHILE(@counter < 1000000)
BEGIN
	DECLARE @Date datetime
	SET @Date =
	DATEADD(month, CONVERT(varbinary, newid()) % (50 * 12), getdate())
	INSERT INTO Logs (LogDate, MsgText)
	VALUES(@Date, 'LogText')
	SET @counter = @counter + 1;
END

GO



EXEC usp_AddManyLogs
-- 7 min and 20 sec to generate for 1M


CHECKPOINT; DBCC DROPCLEANBUFFERS; -- Empty the SQL Server cache


-- 01.Create a table in SQL Server with 10 000 000 log 
-- 	entries (date + text). Search in the table by date range. 
-- 	Check the speed (without caching).

SELECT l.LogDate
FROM Logs l
WHERE YEAR(l.LogDate) < 2012 AND YEAR(l.LogDate) > 2001
-- 2sec without cache



--02.Add an index to speed-up the search by date. 
--	Test the search speed (after cleaning the cache).

CREATE INDEX IDX_Logs_LogDate ON Logs(LogDate)
DROP INDEX Logs.IDX_Logs_LogDate
--indexes created for 5sec.

SELECT l.LogDate
FROM Logs l
WHERE YEAR(l.LogDate) < 2012 AND YEAR(l.LogDate) > 2001
--1sec with cahe :D


--03.Add a full text index for the text column. 
--	Try to search with and without the full-text index and compare the speed.

DROP INDEX Logs.IDX_Logs_LogDate
CREATE INDEX IDX_Logs_MsgText ON Logs(MsgText)
SELECT l.MsgText
FROM Logs l
WHERE YEAR(l.LogDate) < 2012 AND YEAR(l.LogDate) > 2001

-- create index - 8 sec

-- without cache - 2 sec 
-- with cache - 1 sec