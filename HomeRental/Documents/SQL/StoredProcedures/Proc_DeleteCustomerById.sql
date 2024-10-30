IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_DeleteCustomerById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_DeleteCustomerById]
GO
CREATE PROCEDURE [dbo].[Proc_DeleteCustomerById]
	@Id uniqueidentifier
AS
BEGIN
	DELETE FROM Customers WHERE Id = @Id
END
GO