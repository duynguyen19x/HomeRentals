IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_DeleteCustomerHomeRentalById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_DeleteCustomerHomeRentalById]
GO
CREATE PROCEDURE [dbo].[Proc_DeleteCustomerHomeRentalById]
	@Id uniqueidentifier
AS
BEGIN
	DELETE FROM CustomerHomeRentals WHERE Id = @Id
END
GO