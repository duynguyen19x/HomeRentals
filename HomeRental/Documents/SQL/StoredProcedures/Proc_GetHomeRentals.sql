/****** Object:  StoredProcedure [dbo].[Proc_GetHomeRentals]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetHomeRentals]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetHomeRentals]
GO
CREATE PROCEDURE [dbo].[Proc_GetHomeRentals]
AS
BEGIN
	SELECT * FROM HomeRentals ORDER BY Code
END
GO