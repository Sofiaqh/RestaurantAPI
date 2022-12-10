INSERT INTO Client(Name,Document,Phone,Adress)
VALUES('Sofía Quiroz Henao','3167362681','Calle 50#33-02','1001390545'),('Juan Quiroz Henao','3214569696','Cra 34A #22-12','1225856652'),
('Valentina Muñoz Zapata','3052555500','Cra 98B #03-22','2558789101'),('Fernanda Acevedo Lopez','3589636565','Calle 45A #56-09','1001654120');

--Insert client without adress
INSERT INTO Client(Name,Document,Phone)
VALUES ('Felipe Perez Lopez','3214561224','111111'),
('Manuela Mora Pineda','3148859001','1001654120');

INSERT INTO Product(Name,Description)
VALUES('Hamburguesa Doble','Pan artesanal,doble carne,lechuga,cebolla,tomate'),
('Hamburguesa Tropical','Pan artesanal,lechuga,tomate,piña asada,carne,queso philadelphia,tocineta'),
('Hamburguesa Clasica','Pan artesanal,lechuga,tomate,cebolla,tocineta,carne,queso cheddar');

--Insert product without description
INSERT INTO Product(Name)
VALUES ('Hamburguesa Mexicana'),
('Hamburguesa Paisa');

INSERT INTO Orders(OrderDate,IdClient,Price)
VALUES('2022-07-08',1,'1.200'),('2022-08-08',2,'3.000'),('2022-09-08',3,'2.850'),
('2022-10-08',6,'1.800'),('2022-11-08',5,'950'),('2022-12-08',4,'2.160');

INSERT INTO DetailOrder(IdOrder,IdProduct,Quantity,Observations)
VALUES(3,1,3,'1 sin piña'),(2,1,1,'Con adicion de carne'),(4,4,2,'Sin queso'),
(6,3,1,'Con adicion de queso'),(5,2,5,'Todas sin tocineta');

SELECT * FROM Client
SELECT * FROM Product
SELECT * FROM Orders
SELECT * FROM DetailOrder

SELECT * FROM Client WHERE IdClient = 4;
SELECT * FROM Client WHERE Name = 'Sofía Quiroz Henao';

SELECT * FROM Product WHERE Name = 'Hamburguesa Paisa';
SELECT * FROM Product WHERE IdProduct = 2;

SELECT * FROM Orders WHERE IdClient = 6;
SELECT * FROM Orders WHERE OrderDate <'2022-10-08';
SELECT * FROM Orders WHERE OrderDate >='2022-11-08';

SELECT * FROM DetailOrder WHERE Quantity <= 2;
SELECT * FROM DetailOrder WHERE Quantity > 3;
SELECT * FROM DetailOrder WHERE IdOrder = 6;
SELECT * FROM DetailOrder WHERE Observations = 'Sin queso';

UPDATE Client SET Adress = 'Calle 49 #28-123' WHERE IdClient = 1;
UPDATE Client SET Phone = '2588585' WHERE IdClient = 5;
UPDATE Product SET Name = 'Hamburguesa Argentina' WHERE IdProduct = 2;
UPDATE Orders SET IdClient = 1 WHERE IdOrder = 6;
UPDATE DetailOrder SET Quantity= 6 WHERE IdOrder = 6;
UPDATE DetailOrder SET Observations = 'Sin queso, sin tomate' WHERE IdProduct = 4;

DELETE FROM DetailOrder WHERE IdDetailOrder = 11;
DELETE FROM Orders WHERE IdOrder = 1;
DELETE FROM Client WHERE IdClient = 4;

//*Inner Join*//
SELECT * FROM Orders
INNER JOIN Client
ON Client.IdClient = Orders.IdClient;

//*Left Join*//
SELECT cli.Name, ord.idOrder 
FROM Orders Ord
LEFT JOIN Client Cli
ON Ord.IdClient = Cli.IdClient

//*Union*//
SELECT IdProduct FROM Product
UNION
SELECT IdProduct FROM DetailOrder

SELECT IdOrder FROM Orders
UNION
SELECT IdOrder FROM DetailOrder

//*Case*//
SELECT Price,
CASE
WHEN Price <'1.000' THEN 'No declara'
WHEN Price BETWEEN '1.000' AND '2.000' THEN 'Declara el 10%'
WHEN Price >'2.000' THEN 'Declara el 8%'
ELSE 'l'
END AS Declarar
FROM Orders

