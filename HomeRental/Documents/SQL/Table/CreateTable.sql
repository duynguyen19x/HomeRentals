IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerHomeRentals_HomeRentals]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerHomeRentals]'))
ALTER TABLE [dbo].[CustomerHomeRentals] DROP CONSTRAINT [FK_CustomerHomeRentals_HomeRentals]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CustomerHomeRentals_Customers]') AND parent_object_id = OBJECT_ID(N'[dbo].[CustomerHomeRentals]'))
ALTER TABLE [dbo].[CustomerHomeRentals] DROP CONSTRAINT [FK_CustomerHomeRentals_Customers]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[HomeRentals]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HomeRentals]') AND type in (N'U'))
DROP TABLE [dbo].[HomeRentals]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))
DROP TABLE [dbo].[Customers]
GO
/****** Object:  Table [dbo].[CustomerHomeRentals]    Script Date: 30/10/2024 18:46:56 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CustomerHomeRentals]') AND type in (N'U'))
DROP TABLE [dbo].[CustomerHomeRentals]
GO
CREATE TABLE [dbo].[CustomerHomeRentals](
	[Id] [uniqueidentifier] NOT NULL,
	[CustomerHomeRentalCode] [nvarchar](50) NOT NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[HomeRentalId] [uniqueidentifier] NULL,
	[RentalStartDate] [datetime] NULL,
	[RentalEndDate] [datetime] NULL,
	[Amount] [decimal](30, 2) NULL,
 CONSTRAINT [PK_CustomerHomeRentals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Customers](
	[Id] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[Address] [nvarchar](1028) NULL,
	[DOB] [datetime] NULL,
	[Gender] [int] NULL,
	[PhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[HomeRentals](
	[Id] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](1024) NULL,
	[Description] [nvarchar](1024) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Area] [decimal](18, 2) NOT NULL,
	[Floor] [int] NOT NULL,
	[Facing] [int] NOT NULL,
 CONSTRAINT [PK_HomeRentals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](1028) NULL,
	[Address] [nvarchar](1028) NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[DOB] [datetime] NULL,
	[Gender] [int] NULL,
	[PhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerHomeRentals]  WITH CHECK ADD  CONSTRAINT [FK_CustomerHomeRentals_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[CustomerHomeRentals] CHECK CONSTRAINT [FK_CustomerHomeRentals_Customers]
GO
ALTER TABLE [dbo].[CustomerHomeRentals]  WITH CHECK ADD  CONSTRAINT [FK_CustomerHomeRentals_HomeRentals] FOREIGN KEY([HomeRentalId])
REFERENCES [dbo].[HomeRentals] ([Id])
GO
ALTER TABLE [dbo].[CustomerHomeRentals] CHECK CONSTRAINT [FK_CustomerHomeRentals_HomeRentals]
GO
