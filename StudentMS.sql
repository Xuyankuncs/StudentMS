USE [StudentMS]
GO
/****** Object:  Table [dbo].[ADMINN]    Script Date: 2022/7/1 20:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINN](
	[ZH] [char](20) NOT NULL,
	[PSW] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ZH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 2022/7/1 20:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Cno] [char](20) NOT NULL,
	[Cre] [int] NULL,
	[Cname] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SC]    Script Date: 2022/7/1 20:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SC](
	[Cno] [char](20) NOT NULL,
	[Sno] [char](20) NOT NULL,
	[Score] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2022/7/1 20:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Sno] [char](20) NOT NULL,
	[Sname] [char](20) NULL,
	[class] [char](20) NULL,
	[Ssex] [char](5) NULL,
	[Mj] [char](20) NULL,
	[Year] [char](20) NULL,
	[PSW] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Sno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TC]    Script Date: 2022/7/1 20:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TC](
	[Tno] [char](20) NOT NULL,
	[Cno] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Tno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 2022/7/1 20:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Tno] [char](20) NOT NULL,
	[Tname] [char](20) NULL,
	[Mj] [char](20) NULL,
	[EorP] [char](20) NULL,
	[PSW] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Tno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ADMINN] ([ZH], [PSW]) VALUES (N'A1                  ', N'A1                  ')
GO
INSERT [dbo].[Courses] ([Cno], [Cre], [Cname]) VALUES (N'C01                 ', 3, N'数据库原理与应用    ')
INSERT [dbo].[Courses] ([Cno], [Cre], [Cname]) VALUES (N'C02                 ', 3, N'计算机网络          ')
INSERT [dbo].[Courses] ([Cno], [Cre], [Cname]) VALUES (N'C03                 ', 3, N'高等数学            ')
INSERT [dbo].[Courses] ([Cno], [Cre], [Cname]) VALUES (N'C04                 ', 2, N'操作系统            ')
GO
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C01                 ', N'S3                  ', 84)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C01                 ', N'S2                  ', 61)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C01                 ', N'S1                  ', 86)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C01                 ', N'S4                  ', 76)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C02                 ', N'S1                  ', 56)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C02                 ', N'S2                  ', 78)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C02                 ', N'S3                  ', 91)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C02                 ', N'S4                  ', 74)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C03                 ', N'S1                  ', 67)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C03                 ', N'S3                  ', 83)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C04                 ', N'S2                  ', 96)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C04                 ', N'S4                  ', 88)
INSERT [dbo].[SC] ([Cno], [Sno], [Score]) VALUES (N'C03                 ', N'S2                  ', 85)
GO
INSERT [dbo].[Students] ([Sno], [Sname], [class], [Ssex], [Mj], [Year], [PSW]) VALUES (N'S1                  ', N'徐一                ', N'CLA02               ', N'男   ', N'计科                ', N'2017                ', N'S1                  ')
INSERT [dbo].[Students] ([Sno], [Sname], [class], [Ssex], [Mj], [Year], [PSW]) VALUES (N'S2                  ', N'张二                ', N'CLA01               ', N'男   ', N'计科                ', N'2017                ', N'S2                  ')
INSERT [dbo].[Students] ([Sno], [Sname], [class], [Ssex], [Mj], [Year], [PSW]) VALUES (N'S3                  ', N'张三                ', N'CLA01               ', N'男   ', N'计科                ', N'2017                ', N'S3                  ')
INSERT [dbo].[Students] ([Sno], [Sname], [class], [Ssex], [Mj], [Year], [PSW]) VALUES (N'S4                  ', N'李四                ', N'CLAO5               ', N'女   ', N'软件工程            ', N'2017                ', N'S4                  ')
GO
INSERT [dbo].[Teachers] ([Tno], [Tname], [Mj], [EorP], [PSW]) VALUES (N'T2                  ', N'陈力柯              ', N'机械学院            ', N'147852              ', N'T2                  ')
INSERT [dbo].[Teachers] ([Tno], [Tname], [Mj], [EorP], [PSW]) VALUES (N'T4                  ', N'李文斌              ', N'生物工程学院        ', N'123987              ', N'T4                  ')
INSERT [dbo].[Teachers] ([Tno], [Tname], [Mj], [EorP], [PSW]) VALUES (N'T5                  ', N'刘一                ', N'人机学院            ', N'123                 ', N'T5                  ')
INSERT [dbo].[Teachers] ([Tno], [Tname], [Mj], [EorP], [PSW]) VALUES (N'T6                  ', N'王千森              ', N'设计学院            ', N'123789              ', N'T6                  ')
INSERT [dbo].[Teachers] ([Tno], [Tname], [Mj], [EorP], [PSW]) VALUES (N'T9                  ', N'李二                ', N'人工智能与计算机学院', N'13999999            ', N'T1                  ')
GO
ALTER TABLE [dbo].[SC]  WITH CHECK ADD FOREIGN KEY([Cno])
REFERENCES [dbo].[Courses] ([Cno])
GO
ALTER TABLE [dbo].[SC]  WITH CHECK ADD FOREIGN KEY([Sno])
REFERENCES [dbo].[Students] ([Sno])
GO
ALTER TABLE [dbo].[TC]  WITH CHECK ADD FOREIGN KEY([Cno])
REFERENCES [dbo].[Courses] ([Cno])
GO
ALTER TABLE [dbo].[TC]  WITH CHECK ADD FOREIGN KEY([Tno])
REFERENCES [dbo].[Teachers] ([Tno])
GO
