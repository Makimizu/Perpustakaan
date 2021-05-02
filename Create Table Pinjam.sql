USE [PerpustakaanDB]
GO

/****** Object:  Table [dbo].[Pinjam]    Script Date: 02/05/2021 14:00:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pinjam](
	[NoPinjam] [int] IDENTITY(1,1) NOT NULL,
	[Tanggal] [date] NULL,
	[Penyewa] [nvarchar](100) NULL,
	[JenisBuku] [nvarchar](50) NULL,
	[LamaPinjam] [int] NULL,
	[TanggalKembali] [date] NULL,
	[Status] [nvarchar](20) NULL,
 CONSTRAINT [PK_Pinjam] PRIMARY KEY CLUSTERED 
(
	[NoPinjam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


