IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetCustomers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetCustomers]
GO
CREATE PROCEDURE [dbo].[Proc_GetCustomers]
AS
BEGIN
	SELECT * FROM Customers ORDER BY Code
END
GO