IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_CreateOrEditCustomer]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_CreateOrEditCustomer]
GO
CREATE PROCEDURE [dbo].[Proc_CreateOrEditCustomer]
	@Id uniqueidentifier,
	@Code NVARCHAR(50),
	@Name nvarchar(256),
	@Address nvarchar(1028),
    @DOB DateTime,
	@Gender INT,
	@PhoneNumber nvarchar(50)
AS
BEGIN
	DECLARE @ResultId TABLE (Id uniqueidentifier);

	IF(@Id IS NULL OR @Id = '00000000-0000-0000-0000-000000000000')
	BEGIN
		INSERT INTO Customers 
		(
			Id,
			Code,
			Name,
			Address,
			DOB,
			Gender,
			PhoneNumber
		)
		OUTPUT INSERTED.Id INTO @ResultId
		VALUES
		(
			NEWID(),
			@Code,
			@Name,
			@Address,
			@DOB,
			@Gender,
			@PhoneNumber
		)
	END
	ELSE
	BEGIN
		UPDATE Customers 
		SET Code = @Code,
			Name = @Name,
			Address = @Address,
			DOB = @DOB,
			Gender = @Gender,
			PhoneNumber = @PhoneNumber
		OUTPUT INSERTED.Id INTO @ResultId
		WHERE Id = @Id
	END

	Select * from @ResultId;
END
GO