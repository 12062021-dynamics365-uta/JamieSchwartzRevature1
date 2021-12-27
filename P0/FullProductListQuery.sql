--CREATE TABLES
CREATE TABLE FullProductList (
ProductID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ProductName nvarchar(50) NOT NULL, 
ProductPrice decimal NOT NULL,
ProductDescription nvarchar(75) NOT NULL,
ProductSection nvarchar(15) NOT NULL,
ProductCount INT);

CREATE TABLE Customer (
CustomerID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
CustName nvarchar(30) NOT NULL, 
CustEmail nvarchar(45) NOT NULL,
CustPass nvarchar(45) NOT NULL);

--figure out how to add multiple values from one table into another
--try creating a price table?
CREATE TABLE Orders(
ProductID INT NOT NULL FOREIGN KEY REFERENCES FullProductList(ProductID),
ProductPrice decimal NOT NULL FOREIGN KEY REFERENCES FullProductList(ProductPrice))


INSERT INTO FullProductList
Values ('Lego Desk', 129.99, 'DIY office space, instructions not included', 'Kiddie World', 3)
INSERT INTO FullProductList
Values ('Metal Desk', 129.99, 'More like a mortician''s table', 'Scary City', 4)
INSERT INTO FullProductList
Values ('Raising Desk', 129.99, 'If only it could raise your salary', 'Rich Penthouse', 10)
INSERT INTO FullProductList
Values ('Wooden Desk', 129.99, 'An heirloom that may or may not have woodmites', 'Rural Cabin', 1)
INSERT INTO FullProductList
Values ('Lego Chair', 49.99, 'If it hurts to step on, it might hurt to sit on', 'Kiddie World', 3)
INSERT INTO FullProductList
Values ('Metal Chair', 49.99, 'It might leave marks on your floor', 'Scary City', 4)
INSERT INTO FullProductList
Values ('Rolling Chair', 49.99, 'Not for playing Go-Carts', 'Rich Penthouse', 10)
INSERT INTO FullProductList
Values ('Wooden Chair', 49.99, 'It doesn''t look all that sturdy', 'Rural Cabin', 1)
INSERT INTO FullProductList
Values ('Lego Lamp', 29.99, 'How many legos does it take to screw in a light bulb?', 'Kiddie World', 3)
INSERT INTO FullProductList
Values ('Metal Lamp', 29.99, 'DON''T GO INTO THE LIGHT', 'Scary City', 4)
INSERT INTO FullProductList
Values ('Smart Lamp', 29.99, 'Clap on, clap off', 'Rich Penthouse', 10)
INSERT INTO FullProductList
Values ('Antique Lamp', 29.99, 'Make a wish, maybe a genie lives in there', 'Rural Cabin', 1)

SELECT*FROM FullProductList