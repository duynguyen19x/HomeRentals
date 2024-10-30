/****** Object:  StoredProcedure [dbo].[Proc_GetUserByUserNameAndPasswords]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetUserByUserNameAndPasswords]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetUserByUserNameAndPasswords]
GO
-- =============================================
-- Author:		Anonymous
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Proc_GetUserByUserNameAndPasswords]
	@UserName NVARCHAR(50),
	@Password NVARCHAR(512)
AS
BEGIN
	SELECT * FROM Users WHERE UserName = @UserName AND [Password] = @Password
END
GO