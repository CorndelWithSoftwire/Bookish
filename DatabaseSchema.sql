CREATE DATABASE Bookish
GO

USE Bookish
GO

CREATE TABLE Books (
	Id int IDENTITY NOT NULL PRIMARY KEY,
	Title nvarchar(MAX) NOT NULL,
	Author nvarchar(MAX) NULL,
	ISBN nchar(14) NULL) -- ISBNs are 10 or 13 characters, but are sometimes written with a "-" after the first 3 digits so we allow 14 characters
GO

CREATE TABLE Copies (
	Id int IDENTITY NOT NULL PRIMARY KEY, -- This is used as the barcode, which will be printed and stuck on the book copy
	BookId int,
	Borrower nvarchar(MAX) NULL, -- Only set if the book is borrowed
	DueDate datetime NULL -- Only set if the book is borrowed
)
GO

ALTER TABLE Copies ADD CONSTRAINT FK_Copies_Book FOREIGN KEY (BookId) REFERENCES Books (Id)
GO
