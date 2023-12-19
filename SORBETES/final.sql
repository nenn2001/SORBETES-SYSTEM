create database DBSYSFINAL

use  DBSYSFINAL

--Creates the user account table
CREATE TABLE UserAccount (
userId integer IDENTITY(1,1) primary key,
userName varchar (50) not null,
userPassword varchar (50) not null,
userStatus varchar (10) not NULL default 'ACTIVE',
roleId int
);
--To view the user account table

--Creates the user information table
CREATE TABLE UserInformation (
userInfoId integer IDENTITY(1,1) primary key,
userInfLname varchar (50) not null,
userInfFname varchar (50) not null,
userId integer,
FOREIGN KEY (userId) REFERENCES UserAccount(userId)
);

CREATE TABLE [dbo].[Role](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [DBSYS]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Customer', N'Customer')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Staff', N'Staff')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF

CREATE VIEW vw_addrole
AS SELECT R.roleName, UA.userName
FROM UserAccount UA 
INNER JOIN [Role] R 
ON UA.roleId = R.roleId


CREATE TABLE SALESsold (
    SaleID INT PRIMARY KEY,
    ItemID INT, 
    QuantityChocolate INT,
    QuantityStrawberry INT,
    QuantityBerry INT,
    QuantityMelon INT,
    QuantityVanilla INT,
    QuantityCherry INT,
    QuantityCreamy INT,
    QuantityMacha INT,
    ModeOfPayment VARCHAR(50),
    EAmount DECIMAL(18, 2),
    TotalCost DECIMAL(18, 2),
    ChangeAmount DECIMAL(18, 2)
    );

	CREATE VIEW vw_Sales AS
SELECT
    SaleID,
    ItemID,
    QuantityChocolate,
    QuantityStrawberry,
    QuantityBerry,
    QuantityMelon,
    QuantityVanilla,
    QuantityCherry,
    QuantityCreamy,
    QuantityMacha,
    ModeOfPayment,
    EAmount,
    TotalCost,
    ChangeAmount
FROM
    SALESsold;