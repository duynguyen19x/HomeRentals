/****** Object:  StoredProcedure [dbo].[Proc_GetRpt001]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetRpt001]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetRpt001]
GO
CREATE PROCEDURE [dbo].[Proc_GetRpt001]
	@FromDate DATETIME,
	@ToDate DATETIME
AS
BEGIN
	SELECT CHR.Id,
		   CHR.CustomerHomeRentalCode,
		   CHR.CustomerId,
		   CHR.HomeRentalId,
		   CHR.RentalStartDate, -- Ngày bắt đầ thuê
		   CHR.RentalEndDate, -- Ngày hết hạn thuê
		   CUS.Code AS CustomerCode,
		   CUS.[Name] AS CustomerName,
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
GO