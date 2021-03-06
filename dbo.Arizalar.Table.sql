USE [TeknikServis]
GO
/****** Object:  Table [dbo].[Arizalar]    Script Date: 15.05.2020 22:24:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arizalar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [varchar](50) NOT NULL,
	[MusteriSoyadi] [varchar](50) NOT NULL,
	[MusteriTel] [varchar](50) NOT NULL,
	[MusteriAdres] [varchar](100) NOT NULL,
	[SeriNo] [varchar](50) NOT NULL,
	[Marka] [varchar](100) NOT NULL,
	[Model] [varchar](100) NOT NULL,
	[Tutar] [varchar](50) NOT NULL,
	[ArizaSebebi] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
