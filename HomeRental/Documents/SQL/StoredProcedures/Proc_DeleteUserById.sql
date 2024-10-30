IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_DeleteUserById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_DeleteUserById]
GO
CREATE PROCEDURE [dbo].[Proc_DeleteUserById]
	@Id uniqueidentifier
AS
BEGIN
	DELETE FROM Users WHERE Id = @Id
END
GO