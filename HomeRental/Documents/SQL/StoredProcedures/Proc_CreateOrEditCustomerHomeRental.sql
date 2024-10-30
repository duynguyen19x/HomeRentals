IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_CreateOrEditCustomerHomeRental]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_CreateOrEditCustomerHomeRental]
GO
CREATE PROCEDURE [dbo].[Proc_CreateOrEditCustomerHomeRental]
	@Id uniqueidentifier,
	@CustomerHomeRentalCode NVARCHAR(50),
	@CustomerId uniqueidentifier,
	@HomeRentalId uniqueidentifier,
	@RentalStartDate DATETIME, -- Ngày bắt đầ thuê
	@RentalEndDate DATETIME, -- Ngày hết hạn thuê
	@Amount DECIMAL(30,2) --Thành tiền
AS
BEGIN
	DECLARE @ResultId TABLE (Id uniqueidentifier);

	IF(@Id IS NULL OR @Id = '00000000-0000-0000-0000-000000000000')
	BEGIN
		INSERT INTO CustomerHomeRentals 
		(
			Id,
			CustomerHomeRentalCode,
			CustomerId,
			HomeRentalId,
			RentalStartDate, -- Ngày bắt đầ thuê
			RentalEndDate, -- Ngày hết hạn thuê
			Amount --Thành tiền
		)
		OUTPUT INSERTED.Id INTO @ResultId
		VALUES
		(
			NEWID(),
			@CustomerHomeRentalCode,
			@CustomerId,
			@HomeRentalId,
			@RentalStartDate, -- Ngày bắt đầ thuê
			@RentalEndDate, -- Ngày hết hạn thuê
			@Amount --Thành tiền
		)
	END
	ELSE
	BEGIN
		UPDATE CustomerHomeRentals 
		SET CustomerHomeRentalCode = @CustomerHomeRentalCode,
			CustomerId = @CustomerId,
			HomeRentalId = @HomeRentalId,
			RentalStartDate = @RentalStartDate, -- Ngày bắt đầ thuê
			RentalEndDate = @RentalEndDate, -- Ngày hết hạn thuê
			Amount = @Amount --Thành tiền
		OUTPUT INSERTED.Id INTO @ResultId
		WHERE Id = @Id
	END

	Select * from @ResultId;
END
GO