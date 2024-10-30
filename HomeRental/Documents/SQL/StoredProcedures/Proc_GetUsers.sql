/****** Object:  StoredProcedure [dbo].[Proc_GetUsers]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proc_GetUsers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Proc_GetUsers]
GO
-- =============================================
-- Author:		Anonymous
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Proc_GetUsers]
AS
BEGIN
	SELECT * FROM Users ORDER BY UserName
END
GO