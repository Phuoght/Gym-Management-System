USE Gym_db
GO
CREATE PROCEDURE usp_AddPT
    @Name NVARCHAR(50),
    @Gender NVARCHAR(10),
    @Dob DATE,
    @Phone NVARCHAR(10),
    @Experience INT,
    @Address NVARCHAR(150)
AS
BEGIN
    INSERT INTO PTs (PT_Name, PT_Gen, PT_DayOfBirth, PT_Phone, PT_Experience, PT_Address)
    VALUES (@Name, @Gender, @Dob, @Phone, @Experience, @Address)
END
GO
CREATE PROCEDURE usp_DelPT(
	@ID int 
	)
AS
BEGIN
    DELETE FROM PTs
	WHERE PT_ID = @ID
END
GO
CREATE PROCEDURE usp_UpdatePT(
	@ID int,
	@Name NVARCHAR(50),
    @Gender NVARCHAR(10),
    @Dob DATE,
    @Phone NVARCHAR(10),
    @Experience INT,
    @Address NVARCHAR(150)
	)
AS
BEGIN
    UPDATE PTs
	SET PT_Name = @Name, PT_Gen = @Gender, PT_DayOfBirth = @Dob,
		PT_Phone = @Phone, PT_Experience = @Experience, PT_Address = @Address
	WHERE PT_ID = @ID
END
GO
CREATE PROCEDURE usp_AddMembership
    @Name NVARCHAR(50),
    @Duration int,
	@Goal NVARCHAR(50),
	@Cost int
AS
BEGIN
    INSERT INTO Memberships (MemberShip_Name, MemberShip_Duration, MemberShip_Goal, MemberShip_Cost)
    VALUES (@Name, @Duration, @Goal, @Cost)
END
GO
CREATE PROCEDURE usp_DeleteMembership(@ID int )
AS
BEGIN
    DELETE FROM MemberShips
	WHERE MemberShip_ID = @ID
END
GO
CREATE PROCEDURE usp_UpdateMembership(
	@ID int,
	@Name NVARCHAR(50),
    @Duration int,
	@Goal NVARCHAR(50),
	@Cost int
	)
AS
BEGIN
    UPDATE MemberShips
	SET MemberShip_Name = @Name, MemberShip_Duration = @Duration, MemberShip_Goal = @Goal, MemberShip_Cost = @Cost
	WHERE MemberShip_ID = @ID
END
GO
CREATE PROCEDURE usp_SearchCheckin(
	@name nvarchar(50) 
	)
AS
BEGIN
    SELECT Member_ID, Member_Name, Member_Gen, Member_Membership, Member_PT,
			Member_Phone, Member_Status 
	FROM Members WHERE Member_Name LIKE N'%@name%'
END
GO
CREATE PROCEDURE usp_SaveCheckin(
	@id nvarchar(50),
	@time DATETIME
	)
AS
BEGIN
    INSERT INTO CheckIn (CheckIN_MemberID, CheckIN_Time)
	VALUES (@id, @time)
END

CREATE PROCEDURE usp_AddBilling
	@Name NVARCHAR(50),
    @Duration int,
	@Goal NVARCHAR(50),
	@Cost int
AS
BEGIN
    INSERT INTO Billings (Billing_Name, Billing_Duration, Billing_Goal, Billing_Cost)
    VALUES (@Name, @Duration, @Goal, @Cost)
END
GO

CREATE PROCEDURE usp_DeleteBilling(@ID int )
AS
BEGIN
    DELETE FROM Billings 
	WHERE Billing_ID = @ID
END
GO

CREATE PROCEDURE usp_UpdateBilling(
	@ID int,
	@Name NVARCHAR(50),
    @Duration int,
	@Goal NVARCHAR(50),
	@Cost int
	)
AS
BEGIN
    UPDATE Billings
	SET Billing_Name = @Name, Billing_Duration = @Duration, Billing_Goal = @Goal, Billing_Cost = @Cost
	WHERE Billing_ID = @ID
END
GO

CREATE PROCEDURE usp_AddReceptionits
    @Name NVARCHAR(50),
    @Dob DATE,
	@Address NVARCHAR(150),
	@PhoneNumber NVARCHAR(10),
	@Gender NVARCHAR(10),
	@Password NVARCHAR(20),
	@Role NVARCHAR(50)
AS
BEGIN
    INSERT INTO Receptionists (Receptionist_Name, Receptionist_DayOfBirth,Receptionist_Address, 
	Receptionist_Phone,Receptionist_Gen,Receptionist_Pass,Role)
	VALUES (@Name, @Dob,@Address,@PhoneNumber,@Gender,@Password,@Role )
END
GO

CREATE PROCEDURE usp_DeleteReceptionists(@ID int )
AS
BEGIN
    DELETE FROM Receptionists
	WHERE Receptionist_ID = @ID
END
GO

CREATE PROCEDURE usp_UpdateReceptionists(
	@ID int,
	@Name NVARCHAR(50),
    @Dob DATE,
	@Address NVARCHAR(150),
	@PhoneNumber NVARCHAR(10),
	@Gender NVARCHAR(10),
	@Password NVARCHAR(20),
	@Role NVARCHAR(50))
AS
BEGIN
    UPDATE Receptionists
	SET Receptionist_Name = @Name,Receptionist_DayOfBirth =  @Dob,Receptionist_Address = @Address, 
	Receptionist_Phone = @PhoneNumber,Receptionist_Gen = @Gender,Receptionist_Pass = @Password
	WHERE Receptionist_ID = @ID
END
GO
