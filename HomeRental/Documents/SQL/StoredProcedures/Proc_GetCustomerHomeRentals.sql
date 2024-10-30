IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetCustomerHomeRentals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetCustomerHomeRentals]
GO
CREATE PROCEDURE [dbo].[Proc_GetCustomerHomeRentals]
	@Rented INT, -- 0: Chưa cho thuê,  1 Đang thuê, 2: Đã trả
	@FromDate DATETIME,
	@ToDate DATETIME,
	@CustomerHomeRentalCurrentId uniqueidentifier = NULL
AS
BEGIN
	IF (@Rented = 1) -- Đã cho thuê
	BEGIN
		SELECT CHR.Id,
			   CHR.CustomerHomeRentalCode,
			   CHR.CustomerId,
			   CHR.HomeRentalId,
			   CHR.RentalStartDate, -- Ngày bắt đầ thuê
			   CHR.RentalEndDate, -- Ngày hết hạn thuê
			   CUS.Code AS CustomerCode,
			   CUS.[Name] AS CustomerName,
			   CUS.[Address] as CustomerAddress,
			   CUS.[PhoneNumber] as CustomerPhoneNumber,
			   HRL.Code AS HomeRentalCode, -- Mã nhà
			   HRL.[Address] AS HomeRentalAddress, -- Địa chỉ nhà
			   HRL.[Description] AS HomeRentalDescription, -- Mô tả nhà
			   HRL.Price AS HomeRentalPrice, -- Giá thuê
			   HRL.Area AS HomeRentalArea, -- Diện tích
			   HRL.[Floor] AS HomeRentalFloor, -- Tầng
			   HRL.Facing AS HomeRentalFacing, -- Hướng
			   CHR.Amount
		FROM HomeRentals AS HRL 
		INNER JOIN CustomerHomeRentals AS CHR ON HRL.Id = CHR.HomeRentalId
		INNER JOIN Customers AS CUS ON CHR.CustomerId = CUS.Id
		WHERE CHR.RentalEndDate IS NULL 
			AND CHR.RentalStartDate BETWEEN @FromDate AND @ToDate
		ORDER BY CHR.RentalStartDate
	END
	ELSE IF (@Rented = 0) -- Chưa cho thuê
	BEGIN
		SELECT NULL AS CustomerHomeRentalCode,
			   NULL AS CustomerId,
			   NULL AS HomeRentalId,
			   NULL AS RentalStartDate, -- Ngày bắt đầ thuê
			   NULL AS RentalEndDate, -- Ngày hết hạn thuê
			   NULL AS CustomerCode,
			   NULL AS CustomerName,
			   HRL.Id,
			   HRL.Code AS HomeRentalCode, -- Mã nhà
			   HRL.[Address] AS HomeRentalAddress, -- Địa chỉ nhà
			   HRL.Description AS HomeRentalDescription, -- Mô tả nhà
			   HRL.Price AS HomeRentalPrice, -- Giá thuê
			   HRL.Area AS HomeRentalArea, -- Diện tích
			   HRL.[Floor] AS HomeRentalFloor, -- Tầng
			   HRL.Facing AS HomeRentalFacing, -- Hướng 
			   0 AS Amount
		FROM HomeRentals AS HRL 
		WHERE NOT EXISTS (SELECT CHR.HomeRentalId FROM CustomerHomeRentals AS CHR WHERE CHR.RentalEndDate IS NULL AND HRL.Id = CHR.HomeRentalId)
		UNION ALL
		SELECT NULL AS CustomerHomeRentalCode,
			   NULL AS CustomerId,
			   NULL AS HomeRentalId,
			   NULL AS RentalStartDate, -- Ngày bắt đầ thuê
			   NULL AS RentalEndDate, -- Ngày hết hạn thuê
			   NULL AS CustomerCode,
			   NULL AS CustomerName,
			   HRL.Id,
			   HRL.Code AS HomeRentalCode, -- Mã nhà
			   HRL.[Address] AS HomeRentalAddress, -- Địa chỉ nhà
			   HRL.Description AS HomeRentalDescription, -- Mô tả nhà
			   HRL.Price AS HomeRentalPrice, -- Giá thuê
			   HRL.Area AS HomeRentalArea, -- Diện tích
			   HRL.[Floor] AS HomeRentalFloor, -- Tầng
			   HRL.Facing AS HomeRentalFacing, -- Hướng 
			   0 AS Amount
		FROM HomeRentals AS HRL 
		INNER JOIN CustomerHomeRentals AS CHR ON HRL.Id = CHR.HomeRentalId
		WHERE CHR.Id = @CustomerHomeRentalCurrentId
	END
	ELSE
	BEGIN
		SELECT CHR.Id,
			   CHR.CustomerHomeRentalCode,
			   CHR.CustomerId,
			   CHR.HomeRentalId,
			   CHR.RentalStartDate, -- Ngày bắt đầ thuê
			   CHR.RentalEndDate, -- Ngày hết hạn thuê
			   CUS.Code AS CustomerCode,
			   CUS.[Name] AS CustomerName,
			   CUS.[Address] as CustomerAddress,
			   CUS.[PhoneNumber] as CustomerPhoneNumber,
			   HRL.Code AS HomeRentalCode, -- Mã nhà
			   HRL.[Address] AS HomeRentalAddress, -- Địa chỉ nhà
			   HRL.[Description] AS HomeRentalDescription, -- Mô tả nhà
			   HRL.Price AS HomeRentalPrice, -- Giá thuê
			   HRL.Area AS HomeRentalArea, -- Diện tích
			   HRL.[Floor] AS HomeRentalFloor, -- Tầng
			   HRL.Facing AS HomeRentalFacing, -- Hướng
			   CHR.Amount
		FROM HomeRentals AS HRL 
		INNER JOIN CustomerHomeRentals AS CHR ON HRL.Id = CHR.HomeRentalId
		INNER JOIN Customers AS CUS ON CHR.CustomerId = CUS.Id
		WHERE CHR.RentalEndDate BETWEEN @FromDate AND @ToDate
		ORDER BY CHR.RentalStartDate
	END
END
GO