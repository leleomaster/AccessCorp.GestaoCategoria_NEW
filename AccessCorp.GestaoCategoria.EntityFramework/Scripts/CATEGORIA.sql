USE [RDC_Dev]
GO

/****** Object:  Table [FORMULARIO].[CATEGORIA]    Script Date: 11/01/2018 11:33:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [FORMULARIO].[CATEGORIA](
	[CATEGORIA_ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [nvarchar](40) NOT NULL,
	[DESCRICAO] [nvarchar](300) NULL,
	[SLUG] [nvarchar](650) NOT NULL,
 CONSTRAINT [PK_FORMULARIO.CATEGORIA] PRIMARY KEY CLUSTERED 
(
	[CATEGORIA_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

