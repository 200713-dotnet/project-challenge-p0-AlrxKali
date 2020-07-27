CREATE DATABASE PizzaBoxDB
GO

USE PizzaBoxDB
GO

DROP SCHEMA IF EXISTS PizzaBox
DROP TABLE IF EXISTS PizzaBox.Pizzas
DROP TABLE IF EXISTS PizzaBox.Orders
DROP TABLE IF EXISTS PizzaBox.Stores
DROP TABLE IF EXISTS PizzaBox.Users
DROP TABLE IF EXISTS PizzaBox.Toppings
GO
CREATE SCHEMA PizzaBox
GO

create table PizzaBox.Pizza
(
  Pizza_id INT IDENTITY(1,1) PRIMARY KEY, 
  Crust NVARCHAR(100),
  Size NVARCHAR(100),
  [Name] NVARCHAR(200) not null
);

create table PizzaBox.Toppings
(
  ToppingItem INT IDENTITY(1,1) PRIMARY KEY,
  Pizza_id int null foreign key references PizzaBox.Pizza(Pizza_id)
);

create table PizzaBox.Orders
(
  Order_id INT IDENTITY(1,1) PRIMARY KEY,
  Pizza_id int null foreign key references PizzaBox.Pizza(Pizza_id)
);

create table PizzaBox.Stores
(
  Store_id INT IDENTITY(1,1) PRIMARY KEY,
  Order_id int null foreign key references PizzaBox.Orders(Order_id),
  StoreLocation NVARCHAR(100)
);

create table PizzaBox.Users
(
  Users_id INT IDENTITY(1,1) PRIMARY KEY,
  Stores_id int null foreign key references PizzaBox.Stores(Store_id),
  LastOrderTime TIMESTAMP NOT NULL
);
GO