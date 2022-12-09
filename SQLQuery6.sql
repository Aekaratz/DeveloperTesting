USE [test]
GO
/****** Object:  Table [dbo].[table_Peple]    Script Date: 12/9/2022 8:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Peple](
	[PepleID] [int] NOT NULL,
	[PepleName] [varchar](50) NULL,
	[BirthDay] [date] NULL,
	[FK_Reration] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PepleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_Rerations]    Script Date: 12/9/2022 8:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_Rerations](
	[RerationID] [int] NOT NULL,
	[RerationShip] [varchar](50) NULL,
	[Senior] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[RerationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[table_Peple] ([PepleID], [PepleName], [BirthDay], [FK_Reration]) VALUES (1, N'Lee', CAST(N'1890-05-07' AS Date), NULL)
GO
INSERT [dbo].[table_Peple] ([PepleID], [PepleName], [BirthDay], [FK_Reration]) VALUES (2, N'Robert', CAST(N'1920-07-10' AS Date), NULL)
GO
INSERT [dbo].[table_Peple] ([PepleID], [PepleName], [BirthDay], [FK_Reration]) VALUES (3, N'Kris', CAST(N'1944-12-26' AS Date), NULL)
GO
ALTER TABLE [dbo].[table_Peple]  WITH CHECK ADD FOREIGN KEY([FK_Reration])
REFERENCES [dbo].[table_Rerations] ([RerationID])
GO
