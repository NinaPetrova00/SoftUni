CREATE DATABASE [EntityRelations]

USE [EntityRelations]

--Problem 1 One-To-One Relationship
		-- STEPS:
	--1.create passports table
	--2.create persons table
	--3. relate them 

CREATE TABLE [Passports] (
	[PassportID] INT PRIMARY KEY NOT NULL,
	[PassportNumber] CHAR(8) NOT NULL,
)

CREATE TABLE [Persons] (
	[PersonID] INT PRIMARY KEY IDENTITY NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[Salary] DECIMAL (8,2) NOT NULL,
	[PassportID] INT FOREIGN KEY REFERENCES [Passports] ([PassportID]) UNIQUE NOT NULL
)

INSERT INTO [Passports] ([PassportID], [PassportNumber])
	VALUES 
		(101, 'N34FG21B'),
		(102, 'K65LO4R7'),
		(103, 'ZE657QP2')

INSERT INTO [Persons] ([FirstName], [Salary], [PassportID])
	VALUES 
		('Roberto', 43300.00,102),
		('Tom', 56100.00, 103),
		('Yana', 60200.00, 101)


--Problem 2 One-To-Many Relationship

CREATE TABLE [Manufacturers](
	[ManufacturerID] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[EstablishedOn] DATE NOT NULL
)

CREATE TABLE [Models](
	[ModelID] INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[ManufacturerID] INT FOREIGN KEY REFERENCES [Manufacturers] ([ManufacturerID]) NOT NULL
)

INSERT INTO [Manufacturers] ([Name], [EstablishedOn])
	VALUES
		('BMW', '07/03/1916'),
		('Tesla', '01/01/2003'),
		('Lada', '01/05/1966')

INSERT INTO [Models]([Name], [ManufacturerID])
	VALUES
	('X1', 1),
	('i6', 1),
	('Model S', 2),
	('Model X', 2),
	('Model 3', 2),
	('Nova', 3)

--Problem 3 Many-To-Many Relationship
 CREATE TABLE [Students](
	[StudentID] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Exams](
	[ExamID] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[Name] NVARCHAR(75) NOT NULL
)

CREATE TABLE [StudentsExams](
	[StudentID] INT FOREIGN KEY REFERENCES [Students] ([StudentID]) NOT NULL,
	[ExamID] INT FOREIGN KEY REFERENCES [Exams] ([ExamID]) NOT NULL,
	PRIMARY KEY ([StudentID], [ExamID])
)

INSERT INTO [Students] ([Name])
	VALUES
		('Mila'),
		('Toni'),
		('Ron')

INSERT INTO [Exams] ([Name])
	VALUES
		('SpringMVC'),
		('Neo4j'),
		('Oracle 11g')

INSERT INTO [StudentsExams] ([StudentID], [ExamID])
	VALUES
		(1,101),
		(1,102),
		(2,101),
		(3,103),
		(2,102),
		(2,103)

SELECT * FROM [Exams]
SELECT * FROM [Students]
SELECT * FROM [StudentsExams]

--Problem 4 Self-Referencing Relationship
CREATE TABLE [Teachers](
	[TeacherID] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[ManagerID] INT FOREIGN KEY REFERENCES [Teachers] ([TeacherID])
)

INSERT INTO [Teachers] ([Name], [ManagerID])
	VALUES
		('John',NULL),
		('Maya', 106),
		('Silvia', 106),
		('Ted', 105),
		('Mark', 101),
		('Greta', 101)


--Problem 5
CREATE DATABASE [Online Store]

USE [Online Store]

-- one-to-many
CREATE TABLE [ItemTypes](
	[ItemTypeID] INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Items](
	[ItemID] INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[ItemTypeID] INT FOREIGN KEY REFERENCES [ItemTypes] ([ItemTypeID]) NOT NULL
)
	
-- one-to-many
CREATE TABLE [Cities](
	[CityID] INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Customers](
	[CustomerID] INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[CityID] INT FOREIGN KEY REFERENCES [Cities]([CityID]) NOT NULL
)

--one-to-many
CREATE TABLE [Orders](
	[OrderID] INT PRIMARY KEY NOT NULL,
	[CustomerID] INT FOREIGN KEY REFERENCES [Customers] ([CustomerID]) NOT NULL
)

--many-to-many
CREATE TABLE [OrderItems] (
	[OrderID] INT FOREIGN KEY REFERENCES [Orders]( [OrderID]) NOT NULL,
	[ItemID] INT FOREIGN KEY REFERENCES [Items]([ItemID]) NOT NULL,
	PRIMARY KEY ([OrderID], [ItemID] )
)

--Problem 6
CREATE DATABASE [University]

USE [University]

--many-to-many
CREATE TABLE [Subjects](
	[SubjectID] INT PRIMARY KEY IDENTITY NOT NULL,
	[SubjcetName] VARCHAR(50) NOT NULL
)

CREATE TABLE [Majors](
	[MajorID] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(50)
)
CREATE TABLE [Students](
	[StudentID] INT PRIMARY KEY IDENTITY NOT NULL,
	[StudentNumber] INT NOT NULL,
	[StudentName] VARCHAR(50) NOT NULL,
	[MajorID] INT FOREIGN KEY REFERENCES [Majors] (MajorID) NOT NULL
)

CREATE TABLE [Agenda](
	[StudentID] INT FOREIGN KEY REFERENCES [Students] ([StudentID]) NOT NULL,
	[SubjectID] INT FOREIGN KEY REFERENCES [Subjects] ([SubjectID]) NOT NULL,
	PRIMARY KEY ([StudentID], [SubjectID])
)

CREATE TABLE [Payments](
	[PaymentID] INT PRIMARY KEY IDENTITY NOT NULL,
	[PaymentDate] DATE NOT NULL,
	[PaymentAmount] INT NOT NULL,
	[StudentID] INT FOREIGN KEY REFERENCES [Students]( [StudentID]) NOT NULL
)

-- Problem 9 
USE [Geography]

SELECT m.MountainRange, p.PeakName, p.Elevation
FROM [Mountains] AS m
JOIN [Peaks] AS p ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC
