IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_CreateOrEditHomeRental]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_CreateOrEditHomeRental]
GO
CREATE PROCEDURE [dbo].[Proc_CreateOrEditHomeRental]
	@Id uniqueidentifier,
	@Code nvarchar(50),
	@Address nvarchar(1024),
	@Description nvarchar(1024),
	@Price decimal(18, 0), -- Giá thuê
	@Area decimal(18, 2), -- Diện tích
	@Floor int, -- Tầng
	@Facing int -- Hướng
AS
BEGIN
	DECLARE @ResultId TABLE (Id uniqueidentifier);

	IF(@Id IS NULL OR @Id = '00000000-0000-0000-0000-000000000000')
	BEGIN
		INSERT INTO HomeRentals 
		(
			[Id],
			Code,
			Address,
			Description,
			Price, -- Giá thuê
			Area, -- Diện tích
			Floor, -- Tầng
			Facing -- Hướng
		)
		OUTPUT INSERTED.Id INTO @ResultId
		VALUES
		(
			NEWID(),
			@Code,
			@Address,
			@Description,
			@Price, -- Giá thuê
			@Area, -- Diện tích
			@Floor, -- Tầng
			@Facing -- Hướng
		)
	END
	ELSE
	BEGIN
		UPDATE HomeRentals 
		SET Code = @Code,
			Address = @Address,
			Description = @Description,
			Price = @Price, -- Giá thuê
			Area = @Area, -- Diện tích
			Floor = @Floor, -- Tầng
			Facing = @Facing -- Hướng
		OUTPUT INSERTED.Id INTO @ResultId
		WHERE Id = @Id
	END

	Select * from @ResultId;
END
GO