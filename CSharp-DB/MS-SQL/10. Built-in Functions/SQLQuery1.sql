USE [SoftUni]

-- Problem 1
-- 1) way -> SQL build-in functions solution method 
SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEFT([FirstName], 2) = 'Sa'

-- 2) way -> SQL build-in functions solution method 
SELECT [FirstName], [LastName] FROM [Employees]
WHERE SUBSTRING([FirstName], 1, 2) = 'Sa'

-- 3) way SQL Wildcards Characters solution method 
SELECT [FirstName], [LastName] FROM [Employees]
WHERE [FirstName] LIKE 'Sa%'


-- Problem 2 
-- 1) way -> SQL build-in functions solution method 
SELECT [FirstName], [LastName] FROM [Employees]
WHERE CHARINDEX('ei', [LastName]) <> 0 

--returns 0-> does not contain
--returns <> 0 -> do contain

-- 2) way SQL Wildcards Characters solution method 
SELECT [FirstName], [LastName] FROM [Employees]
WHERE [LastName] LIKE '%ei%'

-- Problem 3 
SELECT [FirstName] FROM [Employees]
 WHERE [DepartmentID] IN (3, 10) AND YEAR([HireDate]) BETWEEN 1995 AND 2005 --returns only the year like integer

-- Problem 4
SELECT [FirstName], [LastName] FROM [Employees]
WHERE CHARINDEX('engineer',[JobTitle]) = 0 

 -- Problem 5 
 SELECT [Name] FROM [Towns]
  WHERE LEN([Name]) IN (5,6)
  ORDER BY [Name]

-- Problem 6
-- 1) way -> SQL build-in functions solution method 
SELECT [TownID],[Name] FROM [Towns]
WHERE LEFT ([Name], 1) IN ('M', 'K', 'B', 'E')
ORDER BY [Name] 

-- 2) way SQL Wildcards Characters solution method 
SELECT [TownID],[Name] FROM [Towns]
 WHERE [Name] LIKE '[mkbe]%'
 ORDER BY [Name] 

-- Problem 7
SELECT * FROM [Towns]
WHERE LEFT ([Name], 1) NOT IN ('R', 'B', 'D')
ORDER BY [Name]

-- Problem 8
GO
CREATE VIEW [V_EmployeesHiredAfter2000] AS (
	SELECT [FirstName], [LastName] FROM [Employees]
	WHERE YEAR([HireDate])> 2000
)
GO
-- Problem 10
SELECT [EmployeeID], [FirstName], [LastName], [Salary],
	DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
 FROM [Employees]
 WHERE [Salary] BETWEEN 10000 AND 50000
ORDER BY [Salary] DESC

-- Problem 9
SELECT [FirstName], [LastName] FROM [Employees]
WHERE LEN([LastName]) IN (5)

-- Problem 11
SELECT  
* FROM ( 
		SELECT [EmployeeID], [FirstName], [LastName], [Salary],
			DENSE_RANK() OVER (PARTITION BY [Salary] ORDER BY [EmployeeID]) AS [Rank]
		FROM [Employees]
	    WHERE [Salary] BETWEEN 10000 AND 50000 
	   )
	AS [RankingTable] 
WHERE [Rank] = 2 
ORDER BY [Salary] DESC


USE [Geography]

-- Problem 12
SELECT [CountryName] AS [Country Name]
 ,[IsoCode] AS [ISO Code]
FROM [Countries]
WHERE [CountryName] LIKE '%a%a%a%'
ORDER BY [Iso Code]

-- Problem 13 
SELECT p.[PeakName],
	   r.[RiverName],
LOWER (CONCAT(LEFT(p.[PeakName], LEN (p.[PeakName]) - 1), r.[RiverName])) AS [Mix]
FROM [Peaks] AS p,
	[Rivers] AS r
WHERE LOWER(RIGHT(p.[PeakName], 1)) = LOWER (LEFT(r.[RiverName], 1))
ORDER BY [Mix] 

USE [Diablo]
-- Problem 14
SELECT TOP (50) [Name],FORMAT([Start],'yyyy-MM-dd') AS [Start] FROM [Games]
WHERE YEAR([Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name]

-- Problem 15
SELECT [Username],FORMAT([Email],'') FROM [Users]

-- Problem 16
SELECT [Username],[IpAddress] AS [IP Address] FROM [Users]
WHERE [IpAddress] LIKE '[0-9][0-9][0-9].1%.%.[0-9][0-9][0-9]'
ORDER BY [Username] 


-- Problem 17
SELECT [Name]
			AS [Game],
	   CASE	
		WHEN DATEPART(HOUR, [Start]) >= 0 AND DATEPART(HOUR, [Start]) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR, [Start]) >= 12 AND DATEPART(HOUR, [Start]) < 18 THEN 'Afternoon'
		ELSE 'Evening'
	END 
			AS [Part of the Day],
	    CASE 
			WHEN [Duration] <= 3 THEN 'Extra Short'
			WHEN [Duration] BETWEEN 4 AND 6 THEN 'Short'
			WHEN [Duration] > 6 THEN 'Long'
			ELSE 'Extra Long'
	END
			AS [Duration]
FROM [Games] AS g
ORDER BY [Game], [Duration], [Part of the Day]


-- Problem 18
USE [Online Store]
SELECT * FROM [OrderItems]
