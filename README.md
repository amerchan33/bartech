# bartech
seguimiento de trabajador
API:Netcore 3.1
Frontend: Angular 10

I) Ejecutar Script 
------------------

USE [Bartech]
GO
/****** Object:  Table [dbo].[Systemusers]    Script Date: 5/10/2021 2:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Systemusers](
	[SystemuserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[PasswordHash] [varbinary](1024) NULL,
	[PasswordSalt] [varbinary](1024) NULL,
	[IsDeleted] [bit] NULL,
	[InsertUserId] [int] NULL,
	[InsertDate] [datetime] NULL,
	[UpdateUserId] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_Systemusers] PRIMARY KEY CLUSTERED 
(
	[SystemuserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 5/10/2021 2:25:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[WorkerId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](150) NOT NULL,
	[Coordinates] [varchar](100) NULL,
	[IsDeleted] [bit] NOT NULL,
	[InsertUserId] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateUserId] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[WorkerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Systemusers] ON 

INSERT [dbo].[Systemusers] ([SystemuserId], [Username], [PasswordHash], [PasswordSalt], [IsDeleted], [InsertUserId], [InsertDate], [UpdateUserId], [UpdateDate]) VALUES (2, N'alberto.merchan', 0x1420BEB26526A737D2F1AB7FB8697A305049A54C9D8E77F6381302698ABC704466F8149E6BF6290FF58EB0400E7A7D16731532ADBFD0BBBABCE544718693E52D, 0xC616CB7C9C86772B371920622098867808A425ED34E5E65C2B60FEA3DEE267BFAF96B234C4FA882E66C341ACD94F300CD86A28947C963D2416CA569BA63478F97CB17FF086889FD817314EC66CE373684CDF3D26EEEF0F68A35EDC4A4876E859B625F73317C2E4E5DD8E99C1862D0A5B1037DD2995147411889B30F6A9941F13, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Systemusers] OFF
GO
SET IDENTITY_INSERT [dbo].[Workers] ON 

INSERT [dbo].[Workers] ([WorkerId], [FullName], [Coordinates], [IsDeleted], [InsertUserId], [InsertDate], [UpdateUserId], [UpdateDate]) VALUES (1, N'Elder Llanos Muñoz', N'-76.99395486577004,-12.168268645868958', 0, 1, CAST(N'2021-05-10T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Workers] ([WorkerId], [FullName], [Coordinates], [IsDeleted], [InsertUserId], [InsertDate], [UpdateUserId], [UpdateDate]) VALUES (2, N'Jorge de la Cruz García', N'-12.150733271239082, -76.9809973708302', 0, 1, CAST(N'2021-05-10T00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Workers] OFF
GO


II)Dentro de API ejecutar : dotnet watch run
III) dentro de client: ng serve -o
IV) usuario: alberto.merchan
    clave: string


