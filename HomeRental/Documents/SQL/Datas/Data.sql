IF NOT EXISTS (SELECT Id FROM Users WHERE Id = '46b3baff-54b3-42aa-97ed-bdbf90952270')
BEGIN
    INSERT [dbo].[Users] ([Id], [UserName], [Password], [Address], [FirstName], [LastName], [DOB], [Gender], [PhoneNumber]) VALUES (N'46b3baff-54b3-42aa-97ed-bdbf90952270', N'admin', N'123456', N'Tài khoản ADMIN', N'Admin', N'Administrator', CAST(N'2024-10-24T21:58:03.370' AS DateTime), 0, N'0984.958.917')
END