/****** Object:  StoredProcedure [dbo].[Proc_GetUserById]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetUserById]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetUserById]
GO
-- =============================================
-- Author:		Anonymous
-- Create date: 25/10/2024
-- Description:	Lấy người dùng theo Id
-- =============================================
CREATE PROCEDURE [dbo].[Proc_GetUserById]
	@Id uniqueidentifier
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM Users WHERE Id = @Id
END
GO
