IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_DeleteHomeRentalById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_DeleteHomeRentalById]
GO
CREATE PROCEDURE [dbo].[Proc_DeleteHomeRentalById]
	@Id uniqueidentifier
AS
BEGIN
	DELETE FROM HomeRentals WHERE Id = @Id
END
GO