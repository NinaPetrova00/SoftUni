CREATE DATABASE [WashingMachineService]

USE [WashingMachineService]

--Section 1. DDL 
CREATE TABLE [Clients](
	[ClientId] INT PRIMARY KEY IDENTITY NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Phone] CHAR(12) NOT NULL,
	CHECK (LEN([Phone]) = 12)
)

CREATE TABLE [Mechanics](
	[MechanicId] INT PRIMARY KEY IDENTITY NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(255) NOT NULL
)

CREATE TABLE [Models](
	[ModelId] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE [Jobs](
	[JobId] INT PRIMARY KEY IDENTITY NOT NULL,
	[ModelId] INT FOREIGN KEY REFERENCES [Models]([ModelId]) NOT NULL,
	[Status] VARCHAR(11) NOT NULL DEFAULT('Pending'),
	[ClientId] INT FOREIGN KEY REFERENCES [Clients]([ClientId]) NOT NULL,
	[MechanicId] INT FOREIGN KEY REFERENCES [Mechanics]([MechanicId]),
	[IssueDate] DATE NOT NULL,
	[FinishDate] DATE,
	CHECK ([Status] IN ('Pending', 'In Progress', 'Finished'))
)


CREATE TABLE [Orders](
	[OrderId] INT PRIMARY KEY IDENTITY NOT NULL,
	[JobId] INT FOREIGN KEY REFERENCES [Jobs] ([JobId]) NOT NULL,
	[IssueDate] DATE,
	[Delivered] BIT NOT NULL DEFAULT(0)
)

CREATE TABLE [Vendors](
	[VendorId] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL UNIQUE,
)

CREATE TABLE [Parts](
	[PartId] INT PRIMARY KEY IDENTITY NOT NULL,
	[SerialNumber] VARCHAR(50) NOT NULL UNIQUE,
	[Description] VARCHAR(255),
	[Price] DECIMAL (6, 2) NOT NULL,
	[VendorId] INT FOREIGN KEY REFERENCES [Vendors]([VendorId]) NOT NULL,
	[StockQty] INT NOT NULL DEFAULT(0),
	CHECK ([Price] > 0),
	CHECK ([StockQty] >= 0)
)

CREATE TABLE [OrderParts](
	[OrderId] INT FOREIGN KEY REFERENCES [Orders]([OrderId]) NOT NULL,
	[PartId] INT FOREIGN KEY REFERENCES [Parts]([PartId]) NOT NULL,
	[Quantity] INT NOT NULL DEFAULT(1),
	PRIMARY KEY ([OrderId],[PartId]),
	CHECK ([Quantity] > 0)
)

CREATE TABLE [PartsNeeded](
	[JobId] INT FOREIGN KEY REFERENCES [Jobs]([JobId]) NOT NULL,
	[PartId] INT FOREIGN KEY REFERENCES [Parts] ([PartId]) NOT NULL,
	[Quantity] INT NOT NULL DEFAULT(1),
	PRIMARY KEY ([JobId], [PartId]),
	CHECK ([Quantity] > 0)
)

--Section 2. DML

--2.Insert
INSERT INTO [Clients]([FirstName],[LastName],[Phone])
VALUES 
('Teri','Ennaco','570-889-5187'),
('Merlyn', 'Lawler', '201-588-7810'),
('Georgene', 'Montezuma','925-615-5185'),
('Jettie', 'Mconnell', '908-802-3564'),
('Lemuel', 'Latzke', '631-748-6479'),
('Melodie', 'Knipp', '805-690-1682'),
('Candida', 'Corbley', '908-275-8357')


INSERT INTO [Parts] ([SerialNumber], [Description],[Price], [VendorId])
VALUES
('WP8182119', 'Door Boot Seal', 117.86, 2),
('W10780048', 'Suspension Rod', 42.81, 1),
('W10841140', 'Silicone Adhesive', 6.77, 4),
('WPY055980', 'High Temperature Adhesive', 13.94, 3)


--3.Update
SELECT * FROM [Mechanics]
WHERE [FirstName] = 'Ryan' AND [LastName] = 'Harnos'

--Ryan Harnos ID 3 

SELECT * FROM [Jobs]
UPDATE [Jobs]
SET [MechanicId] = 3
WHERE [Status] = 'Pending'

UPDATE [Jobs]
SET [Status] = 'In Progress'
WHERE [Status] = 'Pending'

--4.Delete
DELETE FROM [OrderParts]
WHERE [OrderId] = 19 

DELETE FROM [Orders]
WHERE [OrderId] = 19 

--Section 3. Querying
DROP DATABASE [WashingMachineService]

--5.Mechanic Assignments
SELECT CONCAT(m.[FirstName], ' ',m.[LastName]) AS [Mechanic],
			j.[Status],
			j.[IssueDate]
	FROM [Mechanics] AS m
	JOIN [Jobs] AS j
	ON m.[MechanicId] = j.[MechanicId]
ORDER BY m.[MechanicId], j.[IssueDate], j.[JobId]


--6.Current Clients
SELECT CONCAT(c.[FirstName], ' ', c.[LastName]) AS [Client],
		DATEDIFF(DAY, j.[IssueDate],'2017-04-24') AS [Days going],
		j.[Status]
FROM [Clients] AS c
JOIN [Jobs] AS j
	ON c.[ClientId] = j.[ClientId]
WHERE j.[STATUS] <> 'Finished'
ORDER BY [Days going] DESC, c.[ClientId]


--7.Mechanic Performance
SELECT [Mechanic],	
		AVG([DaysWorked]) AS [Average Days] 
	 FROM (
		SELECT  m.[MechanicId] ,
				CONCAT(m.[FirstName], ' ', m.[LastName]) AS [Mechanic],
				j.[JobId],
				DATEDIFF (DAY, j.[IssueDate], j.[FinishDate]) AS [DaysWorked]
		FROM [Mechanics] AS m
		JOIN [Jobs] AS j
			ON m.[MechanicId] = j.[MechanicId]
		WHERE j.[Status] = 'Finished'
) AS [DaysWorkedSubQuery]
GROUP BY [Mechanic], [MechanicId]
ORDER BY [MechanicId]


--8.Available Mechanics
SELECT CONCAT(m.[FirstName], ' ',m.[LastName]) AS [Mechanic]
FROM [Mechanics] AS m
LEFT JOIN [Jobs] AS j
	ON m.[MechanicId] = j.[MechanicId]
WHERE j.[Status] IS NULL OR j.[Status] = 'Finished'
ORDER BY m.[MechanicId]

--9.Past Expenses
SELECT j.[JobId],
	ISNULL(SUM(p.[Price]* op.[Quantity]), 0) AS [Total]
FROM [Jobs] AS j
LEFT JOIN [Orders] AS o
	ON j.[JobId] = o.[JobId]
LEFT JOIN [OrderParts] AS op
	ON o.[OrderId] = op.[OrderId]
LEFT JOIN [Parts] AS p
	ON op.[PartId] = p.[PartId]
WHERE j.[Status] = 'Finished'
GROUP BY j.[JobId]
ORDER BY [Total] DESC, j.[JobId]

--10.Missing Parts
SELECT * FROM (
SELECT  p.[PartId],
		p.[Description],
		pn.[Quantity] AS [Required],
		p.[StockQty] AS [In Stock],
		ISNULL(op.[Quantity], 0) AS [Ordered]
	FROM [Jobs] AS j
	LEFT JOIN [PartsNeeded] AS pn
		ON j.[JobId] = pn.[JobId]
	LEFT JOIN [Parts] AS p
		ON pn.[PartId] = p.[PartId]
	LEFT JOIN [Orders] AS o
		ON j.[JobId] = o.[JobId]
	LEFT JOIN [OrderParts] AS op
		ON o.[OrderId] = op.[OrderId]
	WHERE j.[Status] <> 'Finished' AND (o.[OrderId] = 0 OR o.[Delivered] IS NULL)
) AS [PartsQuantitySubQuery]
WHERE [Required] > [In Stock] + [Ordered]
ORDER BY [PartId]


--Section 4. Programmability

--11.Place Order