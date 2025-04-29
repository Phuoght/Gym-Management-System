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