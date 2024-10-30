IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_CreateOrEditUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_CreateOrEditUser]
GO
CREATE PROCEDURE [dbo].[Proc_CreateOrEditUser]
	@Id uniqueidentifier,
	@UserName NVARCHAR(50),
	@Password nvarchar(1028),
	@Address nvarchar(1028),
	@FirstName nvarchar(128),
	@LastName nvarchar(128),
    @DOB DateTime,
	@Gender INT,
	@PhoneNumber nvarchar(50)
AS
BEGIN
	DECLARE @ResultId TABLE (Id uniqueidentifier);

	IF(@Id IS NULL OR @Id = '00000000-0000-0000-0000-000000000000')
	BEGIN
		INSERT INTO Users 
		(
			[Id],
			[UserName],
			[Password],
			[Address],
			[FirstName],
			[LastName],
			[DOB],
			[Gender],
			[PhoneNumber]
		)
		OUTPUT INSERTED.Id INTO @ResultId
		VALUES
		(
			NEWID(),
			@UserName,
			@Password,
			@Address,
			@FirstName,
			@LastName,
			@DOB,
			@Gender,
			@PhoneNumber
		)
	END
	ELSE
	BEGIN
		UPDATE Users 
		SET [UserName] = @UserName,
			[Password] = @Password,
			[Address] = @Address,
			[FirstName] = @FirstName,
			[LastName] = @LastName,
			[DOB] = @DOB,
			[Gender] = @Gender,
			[PhoneNumber] = @PhoneNumber
		OUTPUT INSERTED.Id INTO @ResultId
		WHERE Id = @Id
	END

	Select * from @ResultId;
END
GO