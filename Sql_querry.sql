
USE Gym_db
GO
/* PROC FOR PT */
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


/* PROC FOR MEMBERSHIP */
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

CREATE PROCEDURE usp_FindPriceMemberShip(
	@id int
	)
AS
BEGIN
    SELECT MemberShip_Cost
	FROM MemberShips
	WHERE MemberShip_ID = @id
END

GO


/* PROC FOR MEMBER */
CREATE PROCEDURE usp_AddMember(
    @Name NVARCHAR(50),
    @Gen nvarchar(10),
	@dob datetime,
	@jd datetime,
	@mbship int,
	@pt int,
	@phone nvarchar(10),
	@timing nvarchar(50),
	@status nvarchar(20) )
AS
BEGIN
    INSERT INTO Members (Member_Name, Member_Gen, Member_DayOfBirth, Member_Date,Member_Membership, Member_PT, Member_Phone,
	Member_Timing, Member_Status)
	VALUES(@Name, @Gen, @dob, @jd,@mbship ,@pt ,@phone,@timing ,@status )
END
GO
CREATE PROCEDURE usp_DeleteMember(@ID int )
AS
BEGIN
    DELETE FROM Members
	WHERE Member_ID = @ID
END
GO
CREATE PROCEDURE usp_UpdateMember(
	@ID int,
	@Name NVARCHAR(50),
    @Gen nvarchar(10),
	@dob datetime,
	@jd datetime,
	@mbship int,
	@pt int,
	@phone nvarchar(10),
	@timing nvarchar(50),
	@status nvarchar(20) )
AS
BEGIN
	UPDATE Members
	SET Member_Name = @Name, Member_Gen = @Gen, Member_DayOfBirth = @dob, Member_Date = @jd, Member_Membership = @mbship,
	Member_PT = @pt, Member_Phone = @phone, Member_Timing = @timing, Member_Status = @status
END
GO

CREATE PROCEDURE usp_FindMemberID(
	@memberName nvarchar(100),
	@memberPhone nvarchar(10)
	)
AS
BEGIN
    SELECT Member_ID
	FROM Members 
	WHERE Member_Name = @memberName
		AND Member_Phone = @memberPhone
END

GO

/* PROC FOR CHECKIN */

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

/* PROC FOR Equipment */

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

GO

/* PROC FOR Billing */

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

CREATE PROCEDURE usp_SaveBill(
	@receptionist int, 
	@member int,
	@date Date,
	@cost float,
	@promotion nvarchar(50),
	@total float
	)
AS
BEGIN
    INSERT INTO Bills (Bill_Receptionist, Bill_Member, Bill_Date, Bill_Cost, Bill_PromotionID, Bill_Total)
	VALUES (@receptionist, @member, @date, @cost, @promotion, @total)
END

GO
/* PROC FOR Receptionists */


CREATE PROCEDURE usp_AddReceptionist(
    @Name NVARCHAR(50),
    @Dob DATE,
	@Address NVARCHAR(150),
	@PhoneNumber NVARCHAR(10),
	@Gender NVARCHAR(10),
	@Password NVARCHAR(20),
	@Role NVARCHAR(30)
	)
AS
BEGIN
    INSERT INTO Receptionists (Receptionist_Name, Receptionist_DayOfBirth,Receptionist_Address, 
	Receptionist_Phone,Receptionist_Gen,Receptionist_Pass,Role)
	VALUES (@Name, @Dob,@Address,@PhoneNumber,@Gender,@Password, @Role )
END

GO

CREATE PROCEDURE usp_DeleteReceptionist(@ID int )
AS
BEGIN
    DELETE FROM Receptionists
	WHERE Receptionist_ID = @ID
END

GO

CREATE PROCEDURE usp_UpdateReceptionist(
	@ID int,
	@Name NVARCHAR(50),
	@Gender NVARCHAR(10),
    @Dob DATE,
	@Address NVARCHAR(150),
	@PhoneNumber NVARCHAR(10),
	@Password NVARCHAR(20)
	)

AS
BEGIN
    UPDATE Receptionists
	SET Receptionist_Name = @Name,Receptionist_Gen = @Gender, Receptionist_DayOfBirth =  @Dob, Receptionist_Address = @Address, 
	Receptionist_Phone = @PhoneNumber,Receptionist_Pass = @Password
	WHERE Receptionist_ID = @ID
END

GO

CREATE PROCEDURE usp_FindReceptionistID(
	@receptionistName nvarchar(100)
	)
AS
BEGIN
    SELECT Receptionist_ID
	FROM Receptionists 
	WHERE Receptionist_Name = @receptionistName
END

GO

/* PROC FOR Promotion */

CREATE PROCEDURE usp_AddPromotion(
	@code NVARCHAR(100), 
	@describe NVARCHAR(200), 
	@discount NVARCHAR(10), 
	@startDate Date, 
	@endDate Date
	)
AS
BEGIN
    INSERT INTO Promotions (Promotion_ID, Promotion_Discount, Promotion_Describe, Promotion_StartDate, Promotion_EndDate)
	VALUES (@code, @discount, @describe, @startDate, @endDate)

END

GO

CREATE PROCEDURE usp_DelPromotion(
	@code NVARCHAR(100)
	)
AS
BEGIN
	DELETE FROM Promotions
	WHERE Promotion_ID = @code
END

GO

CREATE PROCEDURE usp_EditPromotion(
	@code NVARCHAR(100), 
	@describe NVARCHAR(200), 
	@discount NVARCHAR(10), 
	@startDate Date, 
	@endDate Date
	)
AS
BEGIN
    UPDATE Promotions
	SET Promotion_Discount = @discount, Promotion_Describe = @describe, Promotion_StartDate = @startDate, Promotion_EndDate = @endDate
	WHERE Promotion_ID = @code
END

GO

CREATE PROCEDURE usp_GetDiscount(
	@code NVARCHAR(100)
	)
AS
BEGIN
	SELECT Promotion_Discount, Promotion_StartDate, Promotion_EndDate
    FROM Promotions
	WHERE Promotion_ID = @code
END

GO

CREATE PROCEDURE usp_GetActivePromotions(
	@nowDate date,
	@startDate date,
	@endDate date
	)
AS
BEGIN
	IF @nowDate BETWEEN @startDate AND @endDate
        SELECT 1
    ELSE
        SELECT 0
END

GO
/* PROC FOR Revenue */

CREATE PROCEDURE usp_ReportRevenue(
	@startDate Date, 
	@endDate Date
	)
AS
BEGIN
    SELECT *
	FROM Bills
	WHERE Bill_Date >= @startDate
		AND Bill_Date < DATEADD(DAY, 1, @endDate)
END

GO


