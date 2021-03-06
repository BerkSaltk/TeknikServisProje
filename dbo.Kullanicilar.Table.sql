USE [TeknikServis]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 15.05.2020 22:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[tcNo] [nvarchar](50) NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[yetki] [nvarchar](50) NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[parola] [nvarchar](50) NULL,
	[eMail] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
