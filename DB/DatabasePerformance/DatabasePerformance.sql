--01-Create a table in SQL Server with 10 000 000 log entries (date + text). 
--Search in the table by date range. Check the speed (without caching).

--02-Add an index to speed-up the search by date. Test the search speed (after cleaning the cache).

--03-Add a full text index for the text column. Try to search with and without the full-text index and compare the speed.

CREATE TABLE LogEntries
(
	LogId int IDENTITY,
	LogDate date,
	Description varchar(50)
)

INSERT INTO LogEntries(LogDate,Description)
VALUES('2012-08-09','Some Description')

CHECKPOINT; 
GO 
DBCC DROPCLEANBUFFERS; 
GO

DECLARE @Counter int = 0
WHILE (SELECT COUNT(*) FROM LogEntries) < 1000000
BEGIN
  INSERT INTO LogEntries(LogDate, Description)
  SELECT DATEADD(MONTH, @Counter + 3, LogDate), Description + CONVERT(varchar, @Counter) FROM LogEntries
  SET @Counter = @Counter + 1
END

CHECKPOINT; 
GO 
DBCC DROPCLEANBUFFERS; 
GO

SELECT Description FROM LogEntries WHERE LogDate 
		BETWEEN CONVERT(datetime, '1990-01-01') AND CONVERT(datetime, '1995-01-01');

CREATE INDEX IDX_LogColIndex ON LogEntries(LogDate);

CHECKPOINT; 
GO 
DBCC DROPCLEANBUFFERS; 
GO

CREATE FULLTEXT CATALOG FullTextDescription

CREATE FULLTEXT INDEX ON Logs(Description)
KEY INDEX PK_Logs
ON FullTextDescription
WITH CHANGE_TRACKING AUTO
SELECT Description 
FROM LogEntries
WHERE LogDate BETWEEN CONVERT(datetime,'2000-01-01') AND CONVERT(datetime,'2012-05-05')
GO

CHECKPOINT; 
GO 
DBCC DROPCLEANBUFFERS; 
GO

SELECT Description
FROM LogEntries
WHERE CONTAINS(Description,'abcdefg')
GO