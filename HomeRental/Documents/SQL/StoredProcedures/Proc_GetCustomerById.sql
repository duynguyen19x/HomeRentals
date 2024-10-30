IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetCustomerById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetCustomerById]
GO
CREATE PROCEDURE [dbo].[Proc_GetCustomerById]
	@Id uniqueidentifier
AS
BEGIN
	SELECT * FROM Customers WHERE Id = @Id ORDER BY Code
END
GO