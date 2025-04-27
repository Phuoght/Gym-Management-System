USE master
GO
CREATE DATABASE Gym_db
GO
USE Gym_db
GO
CREATE TABLE Coachs (
	Coach_ID INT PRIMARY KEY IDENTITY NOT NULL,
	Coach_Name nvarchar(50) NOT NULL,
	Coach_DayOfBirth date NOT NULL,
	Coach_Phone nvarchar(10) NOT NULL,
	Coach_Experience int NOT NULL,
	Coach_Address nvarchar(150) NOT NULL
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
	Receptionist_Pass nvarchar(50) NOT NULL
)
GO
CREATE TABLE Members(
	Member_ID int PRIMARY KEY IDENTITY NOT NULL,
	Member_Name nvarchar(50) NOT NULL,
	Member_Gen nvarchar(10) NOT NULL,
	Member_DayOfBirth date NOT NULL,
	Member_Date date NOT NULL,
	Member_Membership int NOT NULL,
	Member_Coach int NOT NULL,
	Member_Phone nvarchar(10) NOT NULL,
	Member_Timing nvarchar(50) NOT NULL,
	Member_Status nvarchar(20) NOT NULL,
	FOREIGN KEY (Member_Membership) REFERENCES dbo.Memberships(MemberShip_ID),
    FOREIGN KEY (Member_Coach) REFERENCES Coachs(Coach_ID)
)
GO
CREATE TABLE Bills(
	Bill_ID int PRIMARY KEY IDENTITY NOT NULL,
	Bill_Agent int NOT NULL,
	Bill_Member int NOT NULL,
	Bill_Period nvarchar(50) NOT NULL,
	Bill_Date date NOT NULL,
	Bill_Amount float NOT NULL,
	FOREIGN KEY (Bill_Agent) REFERENCES dbo.Receptionists(Receptionist_ID),
	FOREIGN KEY (Bill_Member) REFERENCES dbo.Members(Member_ID)
)