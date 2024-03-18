-- INIT DATABASE
--CREATE DATABASE BEESHOP;

--USE BEESHOP;
create table Role(
    RoleID int IDENTITY(1,1) constraint PK_Role PRIMARY KEY,
    Rolename varchar(255),
);
CREATE TABLE Users (
  UserID INT IDENTITY(1,1) CONSTRAINT PK_User PRIMARY KEY,
  Name VARCHAR(255) NOT NULL,
  Password VARCHAR(255)  NOT NULL,
  Birthdate DATE CHECK (Birthdate < CAST(GETDATE() AS DATE)),  
  Address VARCHAR(255),
  RoleID INT CONSTRAINT FK_RoleID_User REFERENCES Role(RoleID),
  Phone VARCHAR(255),
  IsActive BIT DEFAULT 1
);

CREATE TABLE Category(
    CatID int IDENTITY(1,1) constraint PK_Category PRIMARY KEY,
    CatName varchar(255) NOT NULL
);

CREATE TABLE Images(
    ImageID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT not null,
    ImageURL VARCHAR(50) not null
);

create table Product(
    ProductID int IDENTITY(1,1) PRIMARY KEY,
    UploadedDate datetime2 not null,
    Original_price int not null,
    Sell_price int not null,
    UserID int references Users(UserID),
    CatID int references Category(CatID),
);


create table Storage(
    StorageID int IDENTITY(1,1) PRIMARY KEY,
    Quantity int not null,
    ProductID int references Product(ProductID)
);

ALTER TABLE PRODUCT ADD StorageID int references Storage(StorageID)

CREATE TABLE User_Order(
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    user_id int,
    FOREIGN KEY (user_id) REFERENCES Users(UserID),
    order_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    status VARCHAR(20)
);

CREATE TABLE OrderDetail (
    OrderDetail INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT CONSTRAINT FK_OrderID_OrderDetail REFERENCES User_Order(OrderID),
    ProductID INT CONSTRAINT FK_ProductID_OrderDetail REFERENCES Product(ProductID),
    Quantity INT CHECK(Quantity > 0),
);

