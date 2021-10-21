CREATE TABLE dbo.Products(
    ID int PRIMARY KEY IDENTITY(1,1),
    Name nvarchar(128) NOT NULL
);


INSERT INTO Products(Name) VALUES('Apple');
INSERT INTO Products(Name) VALUES('Strawberry');
INSERT INTO Products(Name) VALUES('Orange');
INSERT INTO Products(Name) VALUES('Coconut');
INSERT INTO Products(Name) VALUES('Hammer');
INSERT INTO Products(Name) VALUES('Hacksaw');
INSERT INTO Products(Name) VALUES('Scissors');