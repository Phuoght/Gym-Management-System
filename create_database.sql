USE master
GO
CREATE DATABASE Gym_db
GO
USE Gym_db
GO
CREATE TABLE PTs (
	PT_ID INT PRIMARY KEY IDENTITY NOT NULL,
	PT_Name nvarchar(50) NOT NULL,
	PT_Gen nvarchar(10) NOT NULL,
	PT_DayOfBirth date NOT NULL,
	PT_Phone nvarchar(10) NOT NULL,
	PT_Experience int NOT NULL,
	PT_Address nvarchar(150) NOT NULL
)
GO
CREATE TABLE MemberShips(
	MemberShip_ID int PRIMARY KEY IDENTITY NOT NULL,
	MemberShip_Name nvarchar(50) NOT NULL,
	MemberShip_Duration int NOT NULL,
	MemberShip_Goal nvarchar(50) NOT NULL,
	MemberShip_Cost int NOT NULL
)
GO
CREATE TABLE Receptionists(
	Receptionist_ID int PRIMARY KEY IDENTITY NOT NULL,
	Receptionist_Name nvarchar(50) NOT NULL,
	Receptionist_Gen nvarchar(10) NOT NULL,
	Receptionist_DayOfBirth date NOT NULL,
	Receptionist_Address nvarchar(150) NOT NULL,
	Receptionist_Phone nvarchar(10) NOT NULL,
	Receptionist_Pass nvarchar(50) NOT NULL,
	Role nvarchar(30) NOT NULL
)
CREATE TABLE Billing(
	Billing_ID int PRIMARY KEY IDENTITY NOT NULL,
	Billing_Name nvarchar(50) NOT NULL,
	Billing_Duration nvarchar(50) NOT NULL,
	Billling_Goal nvarchar(150) NOT NULL,
	Billing_Cost int NOT NULL
)
GO
CREATE TABLE Members(
	Member_ID int PRIMARY KEY IDENTITY NOT NULL,
	Member_Name nvarchar(50) NOT NULL,
	Member_Gen nvarchar(10) NOT NULL,
	Member_DayOfBirth date NOT NULL,
	Member_Date date NOT NULL,
	Member_Membership int NOT NULL,
	Member_PT int NOT NULL,
	Member_Phone nvarchar(10) NOT NULL,
	Member_Timing nvarchar(50) NOT NULL,
	Member_Status nvarchar(20) NOT NULL,
	FOREIGN KEY (Member_Membership) REFERENCES dbo.Memberships(MemberShip_ID),
    FOREIGN KEY (Member_PT) REFERENCES PTs(PT_ID)
)
GO
CREATE TABLE Promotions (
	Promotion_ID nvarchar(100) PRIMARY KEY NOT NULL,
	Promotion_Discount nvarchar(10) NOT NULL,
	Promotion_Describe NVARCHAR(200) NOT NULL,
	Promotion_StartDate DATE NOT NULL,
	Promotion_EndDate DATE NOT NULL
)
GO
CREATE TABLE Bills(
	Bill_ID int PRIMARY KEY IDENTITY NOT NULL,
	Bill_Agent int NOT NULL,
	Bill_Member int NOT NULL,
	Bill_Date date NOT NULL,
	Bill_Pay float NOT NULL,
	Bill_PromotionID nvarchar(100) NOT NULL,
	Bill_Total float NOT NULL,
	FOREIGN KEY (Bill_Agent) REFERENCES dbo.Receptionists(Receptionist_ID),
	FOREIGN KEY (Bill_Member) REFERENCES dbo.Members(Member_ID),
	FOREIGN KEY (Bill_PromotionID) REFERENCES dbo.Promotions(Promotion_ID)
)
GO
CREATE TABLE CheckIn (
    CheckIN_ID INT PRIMARY KEY IDENTITY,
    CheckIN_MemberID INT,
    CheckIN_Time DATETIME,
    FOREIGN KEY (CheckIN_MemberID) REFERENCES Members(Member_ID)
)
GO
CREATE TABLE Equipments (
	Equipment_ID INT PRIMARY KEY IDENTITY NOT NULL,
	Equipment_Name NVARCHAR(100) NOT NULL,
	Equipment_Type NVARCHAR(100) NOT NULL,
	Equipment_Amount INT NOT NULL,
	Equipment_Status NVARCHAR(50) NOT NULL,
	Equipment_LastMaintain DATE NOT NULL,
	Equipment_NextMaintain DATE NOT NULL
)
GO
