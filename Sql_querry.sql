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