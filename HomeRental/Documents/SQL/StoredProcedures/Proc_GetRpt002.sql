/****** Object:  StoredProcedure [dbo].[Proc_GetRpt002]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetRpt002]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetRpt002]
GO
CREATE PROCEDURE [dbo].[Proc_GetRpt002]
AS
BEGIN
	SELECT HRL.Id,
		   HRL.Code AS HomeRentalCode, -- Mã nhà
		   HRL.[Address] AS HomeRentalAddress, -- Địa chỉ nhà
		   HRL.Description AS HomeRentalDescription, -- Mô tả nhà
		   HRL.Price AS HomeRentalPrice, -- Giá thuê
		   HRL.Area AS HomeRentalArea, -- Diện tích
		   HRL.[Floor] AS HomeRentalFloor, -- Tầng
		   HRL.Facing AS HomeRentalFacing -- Hướng 
	FROM HomeRentals AS HRL 
	WHERE NOT EXISTS (SELECT CHR.HomeRentalId FROM CustomerHomeRentals AS CHR WHERE CHR.RentalEndDate IS NULL AND HRL.Id = CHR.HomeRentalId)
	ORDER BY HRL.Code
END
GO