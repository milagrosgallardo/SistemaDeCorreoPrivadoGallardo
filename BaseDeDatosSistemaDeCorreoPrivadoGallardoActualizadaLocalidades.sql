USE [master]
GO
/****** Object:  Database [SistemadeCorreoPrivadoGallardoMilagros]    Script Date: 15/04/2021 11:16:49 ******/
CREATE DATABASE [SistemadeCorreoPrivadoGallardoMilagros]
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemadeCorreoPrivadoGallardoMilagros].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET RECOVERY FULL 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET  MULTI_USER 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemadeCorreoPrivadoGallardoMilagros', N'ON'
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET QUERY_STORE = OFF
GO
USE [SistemadeCorreoPrivadoGallardoMilagros]
GO
/****** Object:  Table [dbo].[Costos Servicio]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Costos Servicio](
	[CostoId] [int] IDENTITY(1,1) NOT NULL,
	[ZonaId] [int] NOT NULL,
	[ModalidadId] [int] NOT NULL,
	[PesoTope] [int] NOT NULL,
	[CostoDelServicio] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Costos Servicio] PRIMARY KEY CLUSTERED 
(
	[CostoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[TipoDeDocumentoId] [int] NOT NULL,
	[NroDocumento] [nvarchar](10) NOT NULL,
	[TelefonoFijo] [nvarchar](20) NULL,
	[TelefonoMovil] [nvarchar](20) NULL,
	[CorreoElectronico] [nvarchar](150) NULL,
	[TareaId] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[EmpleadoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[LocalidadId] [int] IDENTITY(1,1) NOT NULL,
	[NombreLocalidad] [nvarchar](100) NOT NULL,
	[ProvinciaId] [int] NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[LocalidadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modalidades]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modalidades](
	[ModalidadId] [int] IDENTITY(1,1) NOT NULL,
	[NombreModalidad] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Modalidades] PRIMARY KEY CLUSTERED 
(
	[ModalidadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[ProvinciaId] [int] IDENTITY(1,1) NOT NULL,
	[NombreProvincia] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[ProvinciaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tareas]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tareas](
	[TareaId] [int] IDENTITY(1,1) NOT NULL,
	[NombreTarea] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tareas] PRIMARY KEY CLUSTERED 
(
	[TareaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposdeDocumento]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposdeDocumento](
	[TipoDeDocumentoId] [int] IDENTITY(1,1) NOT NULL,
	[NombreDocumento] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Tipos de Documento] PRIMARY KEY CLUSTERED 
(
	[TipoDeDocumentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[TipoDeDocumentoId] [int] NOT NULL,
	[NroDocumento] [nvarchar](10) NOT NULL,
	[Direccion] [nvarchar](100) NOT NULL,
	[LocalidadId] [int] NOT NULL,
	[ProvinciaId] [int] NOT NULL,
	[TelefonoFijo] [nvarchar](20) NULL,
	[TelefonoMovil] [nvarchar](20) NULL,
	[CorreoElectronico] [nvarchar](150) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zonas]    Script Date: 15/04/2021 11:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zonas](
	[ZonaId] [int] IDENTITY(1,1) NOT NULL,
	[NombreZona] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Zonas] PRIMARY KEY CLUSTERED 
(
	[ZonaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Localidades] ON 
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (1, N'Lobos', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (2, N'Cañuela', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (3, N'Azul', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (4, N'Bahía Blanca', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (5, N'Chivilcoy', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (6, N'Ezeiza', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (7, N'General Alvear', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (8, N'La Plata', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (9, N'Monte', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (10, N'Navarro', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (11, N'Roque Pérez', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (12, N'Saladillo', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (13, N'Zárate', 1)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (14, N'Belèn', 2)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (15, N'Fiambala', 2)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (16, N'Tinogasta', 2)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (17, N'Londres', 2)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (18, N'San José', 2)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (19, N'Los Varela', 2)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (20, N'Gran Resistencia', 3)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (21, N'Villa Ángela', 3)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (22, N'Charata', 3)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (23, N'Quitilipi', 3)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (24, N'La Leonesa', 3)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (25, N'Rawson', 4)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (26, N'Comodoro Rivadavia', 4)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (27, N'Trelew', 4)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (28, N'Puerto Madryn', 4)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (29, N'Esquel', 4)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (30, N'Córdoba', 5)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (31, N'Río Cuarto', 5)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (32, N'Villa María', 5)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (33, N'Cosquín', 5)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (34, N'Río Tercero', 5)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (35, N'Bella Vista', 6)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (36, N'Berón de Astrada', 6)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (37, N'Esquina', 6)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (38, N'Cerrito', 7)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (39, N'Gualeguay', 7)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (40, N'Colón', 7)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (41, N'Formosa', 8)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (42, N'Espinillo', 8)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (43, N'Clorinda', 8)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (44, N'Pirané', 8)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (45, N'	San Salvador de Jujuy', 9)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (46, N'San Pedro de Jujuy', 9)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (47, N'	Palpalá', 9)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (48, N'Santa Rosa', 10)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (49, N'General Pico', 10)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (50, N'Intendente Alvear', 10)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (51, N'Calahorra', 11)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (52, N'Logroño', 11)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (53, N'Nájera', 11)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (54, N'Mendoza', 12)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (55, N'San Rafael', 12)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (56, N'Tunuyán', 12)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (57, N'Malargüe', 12)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (58, N'Posadas ', 13)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (59, N'Eldorado', 13)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (60, N'Puerto Iguazú', 13)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (62, N'Neuquén', 14)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (63, N'Junín de los Andes', 14)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (64, N'Villa La Angostura', 14)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (65, N'Bariloche', 15)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (66, N'Roca', 15)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (67, N'Viedma', 15)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (68, N'Salta', 16)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (69, N'Orán', 16)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (70, N'Chimbas', 17)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (71, N'Rivadavia', 17)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (72, N'Santa Lucía', 17)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (73, N'San Luis', 18)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (74, N'Villa Mercedes', 18)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (75, N'Villa de Merlo', 18)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (76, N'Caleta Olivia', 19)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (77, N'El Calafate', 19)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (78, N'Puerto Deseado', 19)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (79, N'Rosario', 20)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (80, N'Santa Fe', 20)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (81, N'Esperanza', 20)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (82, N'Termas de Río Hondo', 21)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (83, N'Frías', 21)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (84, N'Añatuya', 21)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (85, N'Ushuaia', 22)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (86, N'Río Grande', 22)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (87, N'San Sebastián', 22)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (88, N'San Miguel de Tucumán,', 23)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (89, N'Yerba Buena', 23)
GO
INSERT [dbo].[Localidades] ([LocalidadId], [NombreLocalidad], [ProvinciaId]) VALUES (90, N'Concepción', 23)
GO
SET IDENTITY_INSERT [dbo].[Localidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Modalidades] ON 
GO
INSERT [dbo].[Modalidades] ([ModalidadId], [NombreModalidad]) VALUES (1, N'Encomienda simple')
GO
INSERT [dbo].[Modalidades] ([ModalidadId], [NombreModalidad]) VALUES (2, N'Prioritario')
GO
INSERT [dbo].[Modalidades] ([ModalidadId], [NombreModalidad]) VALUES (3, N'Urgente')
GO
SET IDENTITY_INSERT [dbo].[Modalidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincias] ON 
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (1, N'Buenos Aires')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (2, N'Catamarca')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (3, N'Chaco')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (4, N'Chubut')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (5, N'Córdoba')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (6, N'Corrientes')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (7, N'Entre Ríos')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (8, N'Formosa')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (9, N'Jujuy')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (10, N'La Pampa')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (11, N'La Rioja')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (12, N'Mendoza')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (13, N'Misiones')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (14, N'Neuquén')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (15, N'Río Negro')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (16, N'Salta')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (17, N'San Juan')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (18, N'San Luis')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (19, N'Santa Cruz')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (20, N'Santa Fe')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (21, N'Santiago del Estero')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (22, N'Tierra del Fuego')
GO
INSERT [dbo].[Provincias] ([ProvinciaId], [NombreProvincia]) VALUES (23, N'Tucumán')
GO
SET IDENTITY_INSERT [dbo].[Provincias] OFF
GO
SET IDENTITY_INSERT [dbo].[Tareas] ON 
GO
INSERT [dbo].[Tareas] ([TareaId], [NombreTarea]) VALUES (1, N'administrativo')
GO
INSERT [dbo].[Tareas] ([TareaId], [NombreTarea]) VALUES (2, N'Chofer')
GO
SET IDENTITY_INSERT [dbo].[Tareas] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposdeDocumento] ON 
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (2, N'CDI')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (5, N'Cedula Identidad Extranjera')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (7, N'CI BsAs RNP')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (8, N'Doc.Nac.Identidad')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (1, N'Indeterminado')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (4, N'Libreta Civica')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (3, N'Libreta de Enrrolamiento')
GO
INSERT [dbo].[TiposdeDocumento] ([TipoDeDocumentoId], [NombreDocumento]) VALUES (6, N'Pasaporte')
GO
SET IDENTITY_INSERT [dbo].[TiposdeDocumento] OFF
GO
SET IDENTITY_INSERT [dbo].[Zonas] ON 
GO
INSERT [dbo].[Zonas] ([ZonaId], [NombreZona]) VALUES (1, N'Local')
GO
INSERT [dbo].[Zonas] ([ZonaId], [NombreZona]) VALUES (2, N'Regional')
GO
INSERT [dbo].[Zonas] ([ZonaId], [NombreZona]) VALUES (3, N'Nacional 1')
GO
INSERT [dbo].[Zonas] ([ZonaId], [NombreZona]) VALUES (4, N'Nacional 2')
GO
SET IDENTITY_INSERT [dbo].[Zonas] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreLocalidadNoDuplicado]    Script Date: 15/04/2021 11:16:49 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_NombreLocalidadNoDuplicado] ON [dbo].[Localidades]
(
	[NombreLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreProvinciaNoDuplicado]    Script Date: 15/04/2021 11:16:49 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_NombreProvinciaNoDuplicado] ON [dbo].[Provincias]
(
	[NombreProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreDocumentoNoDuplicado]    Script Date: 15/04/2021 11:16:49 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_NombreDocumentoNoDuplicado] ON [dbo].[TiposdeDocumento]
(
	[NombreDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Costos Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Costos Servicio_Modalidades] FOREIGN KEY([ModalidadId])
REFERENCES [dbo].[Modalidades] ([ModalidadId])
GO
ALTER TABLE [dbo].[Costos Servicio] CHECK CONSTRAINT [FK_Costos Servicio_Modalidades]
GO
ALTER TABLE [dbo].[Costos Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Costos Servicio_Zonas] FOREIGN KEY([ZonaId])
REFERENCES [dbo].[Zonas] ([ZonaId])
GO
ALTER TABLE [dbo].[Costos Servicio] CHECK CONSTRAINT [FK_Costos Servicio_Zonas]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tareas] FOREIGN KEY([TareaId])
REFERENCES [dbo].[Tareas] ([TareaId])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tareas]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tipos de Documento] FOREIGN KEY([TipoDeDocumentoId])
REFERENCES [dbo].[TiposdeDocumento] ([TipoDeDocumentoId])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tipos de Documento]
GO
ALTER TABLE [dbo].[Localidades]  WITH CHECK ADD  CONSTRAINT [FK_Localidades_Provincias] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincias] ([ProvinciaId])
GO
ALTER TABLE [dbo].[Localidades] CHECK CONSTRAINT [FK_Localidades_Provincias]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Localidades] FOREIGN KEY([LocalidadId])
REFERENCES [dbo].[Localidades] ([LocalidadId])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Localidades]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Provincias] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincias] ([ProvinciaId])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Provincias]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Tipos de Documento] FOREIGN KEY([TipoDeDocumentoId])
REFERENCES [dbo].[TiposdeDocumento] ([TipoDeDocumentoId])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Tipos de Documento]
GO
USE [master]
GO
ALTER DATABASE [SistemadeCorreoPrivadoGallardoMilagros] SET  READ_WRITE 
GO
