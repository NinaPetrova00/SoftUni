CREATE DATABASE [CigarShop]

USE [CigarShop]

--Section 1. DDL (30 pts)
CREATE TABLE [Sizes](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Length] INT NOT NULL,
	[RingRange] DECIMAL(3,2) NOT NULL,
	CHECK ([Length] BETWEEN 10 AND 25),
	CHECK ([RingRange] BETWEEN 1.5 AND 7.5)
)

CREATE TABLE [Tastes](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[TasteType] VARCHAR(20) NOT NULL,
	[TasteStrength] VARCHAR(15) NOT NULL,
	[ImageURL] NVARCHAR(100) NOT NULL,
)

CREATE TABLE [Brands](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[BrandName] VARCHAR(30) UNIQUE NOT NULL,
	[BrandDescription] VARCHAR(MAX)
)

CREATE TABLE [Addresses](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Town] VARCHAR(30) NOT NULL,
	[Country] NVARCHAR(30) NOT NULL,
	[Streat] NVARCHAR(100) NOT NULL,
	[ZIP] VARCHAR(20) NOT NULL,
)


CREATE TABLE [Cigars](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[CigarName] VARCHAR(80) NOT NULL,
	[BrandId] INT FOREIGN KEY REFERENCES [Brands]([Id]) NOT NULL,
	[TastId] INT FOREIGN KEY REFERENCES [Tastes]([Id]) NOT NULL,
	[SizeId] INT FOREIGN KEY REFERENCES [Sizes]([Id]) NOT NULL,
	[PriceForSingleCigar] MONEY NOT NULL, 
	[ImageURL] NVARCHAR(100) NOT NULL,
)

CREATE TABLE [Clients](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[FirstName] NVARCHAR(30) NOT NULL,
	[LastName] NVARCHAR(30) NOT NULL,
	[Email] NVARCHAR(50) NOT NULL,
	[AddressId] INT FOREIGN KEY REFERENCES [Addresses]([Id]) NOT NULL
)

CREATE TABLE [ClientsCigars](
	[ClientId] INT FOREIGN KEY REFERENCES [Clients]([Id]) NOT NULL,
	[CigarId] INT FOREIGN KEY REFERENCES [Cigars]([Id]) NOT NULL,
	PRIMARY KEY([ClientId],[CigarId]) 
)


--Section 2. DML (10 pts)
INSERT INTO [Cigars] ([CigarName], [BrandId], [TastId],[SizeId],[PriceForSingleCigar],[ImageURL])
VALUES
	('COHIBA ROBUSTO', 9, 1, 5, 15.50, 'cohiba-robusto-stick_18.jpg'),
	('COHIBA SIGLO I', 9, 1, 10, 410.00, 'cohiba-siglo-i-stick_12.jpg'),
	('HOYO DE MONTERREY LE HOYO DU MAIRE', 14, 5, 11, 7.50, 'hoyo-du-maire-stick_17.jpg'),
	('HOYO DE MONTERREY LE HOYO DE SAN JUAN', 14, 4, 15, 32.00, 'hoyo-de-san-juan-stick_20.jpg'),
	('TRINIDAD COLONIALES', 2, 3, 8, 85.21, 'trinidad-coloniales-stick_30.jpg')

INSERT INTO [Addresses]([Town],[Country],[Streat],[ZIP])
VALUES
	('Sofia',	'Bulgaria',	'18 Bul. Vasil levski',	'1000'),
	('Athens',	'Greece',	'4342 McDonald Avenue',	'10435'),
	('Zagreb',	'Croatia',	'4333 Lauren Drive',	'10000')

--3.Update
SELECT * FROM [Cigars]
SELECT * FROM [Tastes]

UPDATE [Cigars]
SET [PriceForSingleCigar] += [PriceForSingleCigar]*0.20
FROM [Cigars] AS c
LEFT JOIN [Tastes] AS t
	ON c.[TastId] = t.[Id]
WHERE t.[TasteType] = 'Spicy'

UPDATE [Brands]
SET [BrandDescription] = 'New description'
WHERE [BrandDescription] IS NULL

--4.Delete
DELETE FROM [Clients]
WHERE [AddressId] IN (7,8,10,23)

DELETE FROM [Addresses] 
WHERE LEFT([Country], 1) = 'C' 



--Section 3. Querying (40 pts)

--5.Cigars by Price
SELECT  [CigarName],
		[PriceForSingleCigar],
		[ImageURL]
FROM [Cigars]
ORDER BY [PriceForSingleCigar], [CigarName] DESC

--6.Cigars by Taste
SELECT  c.[Id],
		c.[CigarName],
		c.[PriceForSingleCigar],
		t.[TasteType],
		t.[TasteStrength]
FROM [Cigars] AS c
LEFT JOIN [Tastes] AS t
	ON c.[TastId] = t.[Id]
WHERE t.[TasteType] = 'Earthy' OR t.[TasteType] = 'Woody'
ORDER BY c.[PriceForSingleCigar] DESC


--7.Clients without Cigars
SELECT  c.[Id],
		CONCAT(c.[FirstName], ' ', c.[LastName]) AS  [ClientName],
		c.[Email]
FROM [Clients] AS c
LEFT JOIN [ClientsCigars] AS cc
	ON c.[Id] = cc.[ClientId]
WHERE cc.[CigarId] IS NULL
ORDER BY [ClientName] 
	
--8.First 5 Cigars
SELECT TOP (5)  c.[CigarName],
				c.[PriceForSingleCigar],
				c.[ImageURL]
FROM [Cigars] AS c
LEFT JOIN [Sizes] AS s
	ON c.[SizeId] = s.[Id]
WHERE (s.[Length] >= 12 
	AND (c.[CigarName] LIKE '%ci%'OR c.[PriceForSingleCigar] > 50)
	AND s.[RingRange] > 2.55)
ORDER BY c.[CigarName], c.[PriceForSingleCigar] DESC

--9.Clients with ZIP Codes
SELECT CONCAT(c.[FirstName],' ', c.[LastName]) AS [FullName],
		a.[Country],
		a.[ZIP],
		CONCAT('$', CAST(MAX(cig.[PriceForSingleCigar]) AS DECIMAL(5,2)) )AS [CigarPrice]
FROM [Clients] AS c
LEFT JOIN [Addresses] AS a
	ON c.[AddressId] = a.[Id]
LEFT JOIN [ClientsCigars] AS cc
	ON c.[Id] = cc.[ClientId]
LEFT JOIN [Cigars] AS cig
	ON cc.[CigarId] = cig.[Id]
WHERE (a.[ZIP] LIKE '[0-9][0-9][0-9][0-9][0-9]')
GROUP BY c.[FirstName],c.[LastName], a.[Country], a.[ZIP]
ORDER BY [FullName]

--10.Cigars by Size
SELECT c.[LastName],
		AVG(s.[Length]) AS [CiagrLength],
		CEILING(AVG(s.[RingRange])) AS [CiagrRingRange]
FROM [Clients] AS c
LEFT JOIN [ClientsCigars] AS cc
	ON c.[Id] = cc.[ClientId]
LEFT JOIN [Cigars] as cig
	ON cc.[CigarId] = cig.[Id]
LEFT JOIN [Sizes] AS s
	ON cig.[SizeId] = s.[Id]
WHERE cc.[CigarId] IS NOT NULL
GROUP BY c.[LastName]
ORDER BY [CiagrLength] DESC

--Section 4. Programmability (20 pts)
--11.	Client with Cigars


