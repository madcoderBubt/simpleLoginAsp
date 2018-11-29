USE [logDB]
GO

/****** Object:  Table [dbo].[logTb]    Script Date: 29-Nov-18 6:27:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[logTb](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[UserRoles] [nchar](10) NULL,
 CONSTRAINT [PK_logTb] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

