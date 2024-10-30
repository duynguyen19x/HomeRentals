
/****** Object:  StoredProcedure [dbo].[Proc_GetHomeRentalById]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetHomeRentalById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetHomeRentalById]
GO
CREATE PROCEDURE [dbo].[Proc_GetHomeRentalById]
	@Id uniqueidentifier
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM HomeRentals WHERE Id = @Id
END
GO
