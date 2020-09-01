CREATE TABLE [dbo].[Table]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [CostPrice] DECIMAL NOT NULL, 
    [DateAdded] DATETIME NOT NULL
)
