USE [hostel]
GO
/****** Object:  Table [dbo].[employeeSalary]    Script Date: 26.04.2021 14:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employeeSalary](
	[mobileNo] [varchar](20) NOT NULL,
	[fmonth] [varchar](60) NOT NULL,
	[amount] [bigint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fees]    Script Date: 26.04.2021 14:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fees](
	[mobileNo] [varchar](25) NOT NULL,
	[fmonth] [varchar](60) NOT NULL,
	[amount] [bigint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[newEmployee]    Script Date: 26.04.2021 14:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[newEmployee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[emobile] [varchar](13) NOT NULL,
	[ename] [varchar](250) NOT NULL,
	[efname] [varchar](250) NOT NULL,
	[emname] [varchar](250) NOT NULL,
	[eemail] [varchar](250) NOT NULL,
	[epaddress] [varchar](250) NOT NULL,
	[eidproof] [varchar](250) NOT NULL,
	[edesignation] [varchar](250) NOT NULL,
	[working] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[newStudent]    Script Date: 26.04.2021 14:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[newStudent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mobile] [varchar](25) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[fname] [varchar](250) NOT NULL,
	[mname] [varchar](250) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[paddress] [varchar](250) NOT NULL,
	[college] [varchar](250) NOT NULL,
	[idproof] [varchar](250) NOT NULL,
	[roomNo] [bigint] NOT NULL,
	[living] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 26.04.2021 14:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[roomNo] [bigint] NOT NULL,
	[roomStatus] [varchar](250) NOT NULL,
	[Booked] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[roomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[employeeSalary] ([mobileNo], [fmonth], [amount]) VALUES (N'555', N'Nisan 2021', 5000)
INSERT [dbo].[employeeSalary] ([mobileNo], [fmonth], [amount]) VALUES (N'3', N'Nisan 2021', 5000)
INSERT [dbo].[employeeSalary] ([mobileNo], [fmonth], [amount]) VALUES (N'3', N'Mayıs 2021', 4700)
INSERT [dbo].[employeeSalary] ([mobileNo], [fmonth], [amount]) VALUES (N'3', N'Haziran 2021', 6000)
INSERT [dbo].[employeeSalary] ([mobileNo], [fmonth], [amount]) VALUES (N'7', N'Nisan 2021', 4554)
INSERT [dbo].[employeeSalary] ([mobileNo], [fmonth], [amount]) VALUES (N'7', N'Haziran 2021', 6000)
GO
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'12', N'Nisan 2021', 6000)
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'12', N'Mayıs 2021', 23)
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'531', N'Nisan 2021', 2000)
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'531', N'Mart 2021', 780)
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'53', N'Ağustos 2021', 680)
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'78', N'Nisan 2021', 489)
INSERT [dbo].[fees] ([mobileNo], [fmonth], [amount]) VALUES (N'78', N'Mayıs 2021', 800)
GO
SET IDENTITY_INSERT [dbo].[newEmployee] ON 

INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (1, N'555', N'Can', N'Cenk', N'Ceyda', N'can@hotmail.com', N'Turkey', N'D50-C88', N'Mess Staff', N'Yes')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (2, N'65', N'Seda', N'Sami', N'Selen', N's2354@hotmail.com', N'Turkey', N'D34-Z344', N'Hostel Incharge', N'Yes')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (4, N'544', N'Selen', N'Serkan', N'Selma', N's123@hotmail.com', N'Turkey', N'C577-86', N'Accounts Manager', N'Yes')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (5, N'80', N'Gülin', N'Ahmetcan', N'Meryem', N'gulinn46@hotmail.com', N'Turkey', N'S24-6', N'Mess Staff', N'Yes')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (6, N'3', N'Zelal  Alin', N'Zahit', N'Zeynep', N'zzzz34@hotmail.com', N'Turkey', N'W34', N'Hostel Incharge', N'No')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (7, N'12', N'Elzem', N'Emir', N'Ela', N'elz45@hotmail.com', N'Turkey', N'S32', N'Cleaning Staff', N'Yes')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (8, N'7', N'Dürdane', N'Cemil', N'Asuman', N'durdan44@hotmail.com', N'Turkey', N'A2333', N'Hostel Incharge', N'Yes')
INSERT [dbo].[newEmployee] ([id], [emobile], [ename], [efname], [emname], [eemail], [epaddress], [eidproof], [edesignation], [working]) VALUES (9, N'60', N'Cansu', N'Mehmet', N'Arzu', N'canssuu@gmail.com', N'Turkey', N'F454', N'Accounts Manager', N'No')
SET IDENTITY_INSERT [dbo].[newEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[newStudent] ON 

INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (2, N'12', N'Meryem', N'Mürsel', N'Dürdane', N'm456@hotmail.com', N'Turkey', N'ITU', N'333-1234-789-56', 101, N'Yes')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (3, N'7', N'Rabia', N'Mürsel', N'Dürdane', N'rabiaa345@hotmail.com', N'Istanbul', N'Kultur', N'2111-551-678-5', 102, N'No')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (4, N'531', N'Melis Ece', N'Mehmet', N'Melda', N'melis56@hotmail.com', N'Turkey', N'IKU', N'432-167-456-34', 9088, N'Yes')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (5, N'78', N'Burak', N'Bilal', N'Beyza', N'burak_456@hotmail.com', N'Turkey', N'IKU', N'2115-785-545', 500, N'Yes')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (7, N'43', N'Mustafa', N'Musa', N'Aylin', N'm9779@hotmail.com', N'Turkey', N'IKU', N'765-123-6543-6', 56, N'Yes')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (8, N'6', N'Berra', N'Can', N'Canan', N'berra7@hotmail.com', N'Turkey', N'IKU', N'432-5678-214-6', 3, N'Yes')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (10, N'2', N'Sema', N'Sakıp', N'Sezen', N's123@hotmail.com', N'Turkey', N'IKU', N'1234-543-146-7', 77, N'No')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (11, N'5', N'Feyza', N'Fahri', N'Fatma', N'f_566@hotmail.com', N'Turkey', N'IKU', N'6543-21876-7', 1, N'Yes')
INSERT [dbo].[newStudent] ([id], [mobile], [name], [fname], [mname], [email], [paddress], [college], [idproof], [roomNo], [living]) VALUES (12, N'53', N'Batuhan', N'Cem', N'Ceyda', N'b45@hotmail.com', N'Turkey', N'IKU', N'3675-4575-134', 5, N'Yes')
SET IDENTITY_INSERT [dbo].[newStudent] OFF
GO
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (0, N'Yes', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (1, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (3, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (5, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (9, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (43, N'No', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (56, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (77, N'Yes', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (78, N'Yes', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (98, N'Yes', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (100, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (101, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (102, N'Yes', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (106, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (123, N'Yes', N'No')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (487, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (500, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (9088, N'Yes', N'Yes')
INSERT [dbo].[rooms] ([roomNo], [roomStatus], [Booked]) VALUES (676788, N'Yes', N'No')
GO
ALTER TABLE [dbo].[newEmployee] ADD  DEFAULT ('Yes') FOR [working]
GO
ALTER TABLE [dbo].[newStudent] ADD  DEFAULT ('Yes') FOR [living]
GO
ALTER TABLE [dbo].[rooms] ADD  DEFAULT ('No') FOR [Booked]
GO
ALTER TABLE [dbo].[newStudent]  WITH CHECK ADD FOREIGN KEY([roomNo])
REFERENCES [dbo].[rooms] ([roomNo])
GO
