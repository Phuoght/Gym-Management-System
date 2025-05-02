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
GO
CREATE PROCEDURE usp_AddEquipment(
	@name NVARCHAR(100),
	@type NVARCHAR(100),
	@amount INT,
	@status NVARCHAR(100),
	@lastMainTain DATETIME,
	@nextMainTain DATETIME
	)
AS
BEGIN
    INSERT INTO Equipments (Equipment_Name, Equipment_Type, Equipment_Amount, Equipment_Status, Equipment_LastMaintain, Equipment_NextMaintain)
	VALUES (@name, @type, @amount, @status, @lastMainTain, @nextMainTain)
END
GO
CREATE PROCEDURE usp_DelEquipment(
	@id INT
	)
AS
BEGIN
    DELETE FROM Equipments
	WHERE Equipment_ID = @id
END
GO
CREATE PROCEDURE usp_EditEquipment(
	@id INT,
	@name NVARCHAR(100),
	@type NVARCHAR(100),
	@amount INT,
	@status NVARCHAR(100),
	@lastMainTain DATETIME,
	@nextMainTain DATETIME
	)
AS
BEGIN
    UPDATE Equipments
	SET Equipment_Name = @name, Equipment_Type = @type, Equipment_Amount = @amount, Equipment_Status = @status, Equipment_LastMaintain = @lastMainTain, Equipment_NextMaintain = @nextMainTain
	WHERE Equipment_ID = @id
END