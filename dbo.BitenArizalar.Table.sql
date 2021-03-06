USE [TeknikServis]
GO
/****** Object:  Table [dbo].[BitenArizalar]    Script Date: 15.05.2020 22:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitenArizalar](
	[id] [tinyint] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [nvarchar](50) NULL,
	[MusteriSoyadi] [nvarchar](50) NULL,
	[MusteriTel] [nvarchar](50) NULL,
	[MmusteriAdres] [nvarchar](50) NULL,
	[SeriNo] [nvarchar](50) NULL,
	[Marka] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Tutar] [nvarchar](50) NULL,
	[ArizaSebebi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
