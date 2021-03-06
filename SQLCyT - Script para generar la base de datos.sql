USE [CyT]
GO
/****** Object:  Table [dbo].[Origen]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Origen](
	[idOrigen] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Origen] PRIMARY KEY CLUSTERED 
(
	[idOrigen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modalidad]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modalidad](
	[idModalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Modalidad] PRIMARY KEY CLUSTERED 
(
	[idModalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[nombre] [varchar](50) NULL,
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[codigoPostal] [int] NULL,
 CONSTRAINT [pk_Localidad] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AreaProductiva]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AreaProductiva](
	[idAreaProductiva] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_AreaProductiva] PRIMARY KEY CLUSTERED 
(
	[idAreaProductiva] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Uvt]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Uvt](
	[idUvt] [int] IDENTITY(1,1) NOT NULL,
	[nombreUvt] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Uvt] PRIMARY KEY CLUSTERED 
(
	[idUvt] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoFinanciamiento]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoFinanciamiento](
	[idTipoFinanciamiento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TipoFinanciamiento] PRIMARY KEY CLUSTERED 
(
	[idTipoFinanciamiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDestinatario]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDestinatario](
	[idTipoDestinatario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TipoDestino] PRIMARY KEY CLUSTERED 
(
	[idTipoDestinatario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tematica]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tematica](
	[nombre] [varchar](50) NULL,
	[idTematica] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [pk_Tematica] PRIMARY KEY CLUSTERED 
(
	[idTematica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ViaComunicacion]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ViaComunicacion](
	[nombre] [varchar](50) NULL,
	[idViaComunicacion] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [pk_ViaComunicacion] PRIMARY KEY CLUSTERED 
(
	[idViaComunicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[tipoDocumento] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[idLocalidad] [int] NULL,
	[isInteresado] [bit] NULL,
	[isBeneficiario] [bit] NULL,
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[fechaNacimiento] [datetime] NULL,
	[empresa] [varchar](50) NULL,
	[documento] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[cuil] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [pk_Persona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fondo]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fondo](
	[idFondo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[idOrigen] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Fondo] PRIMARY KEY CLUSTERED 
(
	[idFondo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CorreoElectronico]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CorreoElectronico](
	[idCorreoElectronico] [int] IDENTITY(1,1) NOT NULL,
	[idPersona] [int] NOT NULL,
	[correoElectronico] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_CorreoElectronico] PRIMARY KEY CLUSTERED 
(
	[idCorreoElectronico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Convocatoria]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Convocatoria](
	[idConvocatoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](100) NULL,
	[objetivo] [varchar](100) NULL,
	[idFondo] [int] NULL,
	[anio] [int] NULL,
	[idTipoFinanciamiento] [int] NULL,
	[idModalidad] [int] NULL,
	[montoTotal] [numeric](18, 2) NULL,
	[montoProyecto] [numeric](18, 2) NULL,
	[fechaInicio] [datetime] NULL,
	[fechaCierre] [datetime] NULL,
	[isAbierta] [int] NULL,
	[activa] [bit] NULL,
 CONSTRAINT [PK_Convocatoria] PRIMARY KEY CLUSTERED 
(
	[idConvocatoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Actuacion]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actuacion](
	[idViaComunicacion] [int] NULL,
	[idTematica] [int] NULL,
	[idActuacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[detalle] [varchar](max) NULL,
	[idPersona] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [pk_Actuacion] PRIMARY KEY CLUSTERED 
(
	[idActuacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UvtReferentes]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UvtReferentes](
	[idUvt] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_UvtReferentes] PRIMARY KEY CLUSTERED 
(
	[idUvt] ASC,
	[idPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Telefono](
	[idTelefono] [int] IDENTITY(1,1) NOT NULL,
	[idPersona] [int] NOT NULL,
	[telefono] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[idTelefono] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyecto](
	[idProyecto] [int] IDENTITY(1,1) NOT NULL,
	[numeroExp] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[idConvocatoria] [int] NULL,
	[idUvt] [int] NULL,
	[idAreaProductiva] [int] NULL,
	[idEstado] [int] NULL,
	[montoSolicitado] [numeric](18, 2) NULL,
	[montoContraparte] [numeric](18, 2) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Priyecto] PRIMARY KEY CLUSTERED 
(
	[idProyecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ListaTipoDestinatario]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaTipoDestinatario](
	[idConvocatoria] [int] NOT NULL,
	[idTipoDestinatario] [int] NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_ListaTipoDestinatario] PRIMARY KEY CLUSTERED 
(
	[idConvocatoria] ASC,
	[idTipoDestinatario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocalidadImpacto]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocalidadImpacto](
	[idProyecto] [int] NOT NULL,
	[idLocalidad] [int] NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_LocalidadImpacto] PRIMARY KEY CLUSTERED 
(
	[idProyecto] ASC,
	[idLocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Integrantes]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Integrantes](
	[idProyecto] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Integrantes] PRIMARY KEY CLUSTERED 
(
	[idProyecto] ASC,
	[idPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etapa]    Script Date: 05/24/2016 17:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etapa](
	[idEtapa] [int] IDENTITY(1,1) NOT NULL,
	[idProyecto] [int] NULL,
	[numero] [int] NULL,
	[fechaInicio] [datetime] NULL,
	[fechaFin] [datetime] NULL,
	[montoEtapa] [numeric](18, 2) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_Etapa] PRIMARY KEY CLUSTERED 
(
	[idEtapa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Actuacion_Persona]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Actuacion]  WITH CHECK ADD  CONSTRAINT [FK_Actuacion_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Actuacion] CHECK CONSTRAINT [FK_Actuacion_Persona]
GO
/****** Object:  ForeignKey [FK_Actuacion_Tematica]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Actuacion]  WITH CHECK ADD  CONSTRAINT [FK_Actuacion_Tematica] FOREIGN KEY([idTematica])
REFERENCES [dbo].[Tematica] ([idTematica])
GO
ALTER TABLE [dbo].[Actuacion] CHECK CONSTRAINT [FK_Actuacion_Tematica]
GO
/****** Object:  ForeignKey [FK_Actuacion_ViaComunicacion]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Actuacion]  WITH CHECK ADD  CONSTRAINT [FK_Actuacion_ViaComunicacion] FOREIGN KEY([idViaComunicacion])
REFERENCES [dbo].[ViaComunicacion] ([idViaComunicacion])
GO
ALTER TABLE [dbo].[Actuacion] CHECK CONSTRAINT [FK_Actuacion_ViaComunicacion]
GO
/****** Object:  ForeignKey [FK_Convocatoria_Fondo]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Convocatoria]  WITH CHECK ADD  CONSTRAINT [FK_Convocatoria_Fondo] FOREIGN KEY([idFondo])
REFERENCES [dbo].[Fondo] ([idFondo])
GO
ALTER TABLE [dbo].[Convocatoria] CHECK CONSTRAINT [FK_Convocatoria_Fondo]
GO
/****** Object:  ForeignKey [FK_Convocatoria_Modalidad]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Convocatoria]  WITH CHECK ADD  CONSTRAINT [FK_Convocatoria_Modalidad] FOREIGN KEY([idModalidad])
REFERENCES [dbo].[Modalidad] ([idModalidad])
GO
ALTER TABLE [dbo].[Convocatoria] CHECK CONSTRAINT [FK_Convocatoria_Modalidad]
GO
/****** Object:  ForeignKey [FK_Convocatoria_TipoFinanciamiento]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Convocatoria]  WITH CHECK ADD  CONSTRAINT [FK_Convocatoria_TipoFinanciamiento] FOREIGN KEY([idTipoFinanciamiento])
REFERENCES [dbo].[TipoFinanciamiento] ([idTipoFinanciamiento])
GO
ALTER TABLE [dbo].[Convocatoria] CHECK CONSTRAINT [FK_Convocatoria_TipoFinanciamiento]
GO
/****** Object:  ForeignKey [FK_CorreoElectronico_Persona]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[CorreoElectronico]  WITH CHECK ADD  CONSTRAINT [FK_CorreoElectronico_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[CorreoElectronico] CHECK CONSTRAINT [FK_CorreoElectronico_Persona]
GO
/****** Object:  ForeignKey [FK_Etapa_Proyecto]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Etapa]  WITH CHECK ADD  CONSTRAINT [FK_Etapa_Proyecto] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[Proyecto] ([idProyecto])
GO
ALTER TABLE [dbo].[Etapa] CHECK CONSTRAINT [FK_Etapa_Proyecto]
GO
/****** Object:  ForeignKey [FK_Fondo_Origen]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Fondo]  WITH CHECK ADD  CONSTRAINT [FK_Fondo_Origen] FOREIGN KEY([idOrigen])
REFERENCES [dbo].[Origen] ([idOrigen])
GO
ALTER TABLE [dbo].[Fondo] CHECK CONSTRAINT [FK_Fondo_Origen]
GO
/****** Object:  ForeignKey [FK_Integrantes_Persona]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Integrantes]  WITH CHECK ADD  CONSTRAINT [FK_Integrantes_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Integrantes] CHECK CONSTRAINT [FK_Integrantes_Persona]
GO
/****** Object:  ForeignKey [FK_Integrantes_Proyecto]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Integrantes]  WITH CHECK ADD  CONSTRAINT [FK_Integrantes_Proyecto] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[Proyecto] ([idProyecto])
GO
ALTER TABLE [dbo].[Integrantes] CHECK CONSTRAINT [FK_Integrantes_Proyecto]
GO
/****** Object:  ForeignKey [FK_ListaTipoDestinatario_Convocatoria]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[ListaTipoDestinatario]  WITH CHECK ADD  CONSTRAINT [FK_ListaTipoDestinatario_Convocatoria] FOREIGN KEY([idConvocatoria])
REFERENCES [dbo].[Convocatoria] ([idConvocatoria])
GO
ALTER TABLE [dbo].[ListaTipoDestinatario] CHECK CONSTRAINT [FK_ListaTipoDestinatario_Convocatoria]
GO
/****** Object:  ForeignKey [FK_ListaTipoDestinatario_TipoDestinatario]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[ListaTipoDestinatario]  WITH CHECK ADD  CONSTRAINT [FK_ListaTipoDestinatario_TipoDestinatario] FOREIGN KEY([idTipoDestinatario])
REFERENCES [dbo].[TipoDestinatario] ([idTipoDestinatario])
GO
ALTER TABLE [dbo].[ListaTipoDestinatario] CHECK CONSTRAINT [FK_ListaTipoDestinatario_TipoDestinatario]
GO
/****** Object:  ForeignKey [FK_LocalidadImpacto_Localidad]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[LocalidadImpacto]  WITH CHECK ADD  CONSTRAINT [FK_LocalidadImpacto_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO
ALTER TABLE [dbo].[LocalidadImpacto] CHECK CONSTRAINT [FK_LocalidadImpacto_Localidad]
GO
/****** Object:  ForeignKey [FK_LocalidadImpacto_Proyecto]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[LocalidadImpacto]  WITH CHECK ADD  CONSTRAINT [FK_LocalidadImpacto_Proyecto] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[Proyecto] ([idProyecto])
GO
ALTER TABLE [dbo].[LocalidadImpacto] CHECK CONSTRAINT [FK_LocalidadImpacto_Proyecto]
GO
/****** Object:  ForeignKey [FK_Persona_Localidad]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_Localidad]
GO
/****** Object:  ForeignKey [FK_Proyecto_AreaProductiva]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_AreaProductiva] FOREIGN KEY([idAreaProductiva])
REFERENCES [dbo].[AreaProductiva] ([idAreaProductiva])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_AreaProductiva]
GO
/****** Object:  ForeignKey [FK_Proyecto_Convocatoria]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Convocatoria] FOREIGN KEY([idConvocatoria])
REFERENCES [dbo].[Convocatoria] ([idConvocatoria])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Convocatoria]
GO
/****** Object:  ForeignKey [FK_Proyecto_Estado]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Estado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([idEstado])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Estado]
GO
/****** Object:  ForeignKey [FK_Proyecto_Uvt]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Uvt] FOREIGN KEY([idUvt])
REFERENCES [dbo].[Uvt] ([idUvt])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Uvt]
GO
/****** Object:  ForeignKey [FK_Telefono_Persona]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_Telefono_Persona]
GO
/****** Object:  ForeignKey [FK_UvtReferentes_Persona]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[UvtReferentes]  WITH CHECK ADD  CONSTRAINT [FK_UvtReferentes_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[UvtReferentes] CHECK CONSTRAINT [FK_UvtReferentes_Persona]
GO
/****** Object:  ForeignKey [FK_UvtReferentes_Uvt]    Script Date: 05/24/2016 17:25:45 ******/
ALTER TABLE [dbo].[UvtReferentes]  WITH CHECK ADD  CONSTRAINT [FK_UvtReferentes_Uvt] FOREIGN KEY([idUvt])
REFERENCES [dbo].[Uvt] ([idUvt])
GO
ALTER TABLE [dbo].[UvtReferentes] CHECK CONSTRAINT [FK_UvtReferentes_Uvt]
GO
