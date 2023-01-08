USE [SalimJuanTPfinal]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[detalle] [varchar](5000) NOT NULL,
	[error] [bit] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[id] [int] NOT NULL,
	[detalle] [varchar](50) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuPadreHijo]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuPadreHijo](
	[padreID] [int] NOT NULL,
	[hijoID] [int] NOT NULL,
 CONSTRAINT [PK_MenuPadreHijo] PRIMARY KEY CLUSTERED 
(
	[padreID] ASC,
	[hijoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operador]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[tipo] [int] NOT NULL,
 CONSTRAINT [PK_Operador] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profecional]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profecional](
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [int] NOT NULL,
	[fecha_nacimiento] [datetime] NULL,
	[rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Profecional] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoOperador]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoOperador](
	[id] [int] NOT NULL,
	[detalle] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoOperador] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoOpmenu]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoOpmenu](
	[tipoID] [int] NOT NULL,
	[compuestoID] [int] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_TipoOpmenu_1] PRIMARY KEY CLUSTERED 
(
	[tipoID] ASC,
	[compuestoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 11/22/2022 11:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo] [varchar](50) NULL,
	[precio] [float] NULL,
	[senia] [float] NULL,
	[id_cliente] [int] NOT NULL,
	[dni_profesional] [int] NOT NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1, CAST(N'1986-06-02' AS Date), N'error', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2, CAST(N'2022-11-13' AS Date), N'La cadena de entrada no tiene el formato correcto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (3, CAST(N'2022-11-13' AS Date), N'Agregar cliente///Formato de email invalido!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (4, CAST(N'2022-11-13' AS Date), N'Cliente Agregado con exito!!', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (5, CAST(N'2022-11-13' AS Date), N'Listado de clientes  /// Se encontraron 1 cliente/s con el apellido solicitado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (6, CAST(N'2022-11-13' AS Date), N'Listado de clientes  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (7, CAST(N'2022-11-13' AS Date), N'Listado de clientes  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (8, CAST(N'2022-11-13' AS Date), N'Agregar cliente///Formato de email invalido!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (9, CAST(N'2022-11-13' AS Date), N'Listado de clientes  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (10, CAST(N'2022-11-13' AS Date), N'Listado de clientes  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (11, CAST(N'2022-11-13' AS Date), N'Listado de clientes  /// No hay un cliente seleccionado', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (12, CAST(N'2022-11-13' AS Date), N'Listado de clientes  ///  Cliente Modificado con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (13, CAST(N'2022-11-13' AS Date), N'Agregar profesional  /// La cadena de entrada no tiene el formato correcto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (14, CAST(N'2022-11-13' AS Date), N'Listado de profesionales  /// No se encontraron profesionales', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (15, CAST(N'2022-11-13' AS Date), N'Listado de profesionales  /// La cadena de entrada no tiene el formato correcto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (16, CAST(N'2022-11-13' AS Date), N'Listado de profesionales  /// Profesional Modificado con exito', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (17, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// No se encuentran turnos para la fecha seleccionada!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (18, CAST(N'2022-11-15' AS Date), N'Se elimino el turno7', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (19, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// Referencia a objeto no establecida como instancia de un objeto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (20, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// Referencia a objeto no establecida como instancia de un objeto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (21, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// Referencia a objeto no establecida como instancia de un objeto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (22, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// Referencia a objeto no establecida como instancia de un objeto.', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (23, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// No hay un cliente seleccionado', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (24, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// No hay un cliente seleccionado', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (25, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// No hay un cliente seleccionado', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (26, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// No hay un cliente seleccionado', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (27, CAST(N'2022-11-15' AS Date), N'Agregar Turno  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (28, CAST(N'2022-11-15' AS Date), N'Listado de Turno  /// No se encuentran turnos para la fecha seleccionada!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (29, CAST(N'2022-11-16' AS Date), N'Agregar Turno  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (30, CAST(N'2022-11-16' AS Date), N'Listado de Turno  /// No se encuentran turnos para la fecha seleccionada!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (31, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (32, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (33, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (34, CAST(N'2022-11-16' AS Date), N'Listado de clientes  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (35, CAST(N'2022-11-16' AS Date), N'Listado de clientes  /// Se encontraron 1 cliente/s con el apellido solicitado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (36, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (37, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (38, CAST(N'2022-11-16' AS Date), N'Listado de Turno  /// No se encuentran turnos para la fecha seleccionada!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (39, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (40, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (41, CAST(N'2022-11-16' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (42, CAST(N'2022-11-17' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (43, CAST(N'2022-11-19' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (44, CAST(N'2022-11-19' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (45, CAST(N'2022-11-19' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (46, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (47, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (48, CAST(N'2022-11-20' AS Date), N'Listado de clientes  /// Se encontraron 1 cliente/s con el apellido solicitado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (49, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (50, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (51, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (52, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (53, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (54, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (55, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (56, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (57, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (58, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (59, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (60, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (61, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (62, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (63, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (64, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (65, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (66, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (67, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (68, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (69, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (70, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (71, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (72, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (73, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (74, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (75, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (76, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (77, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (78, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (79, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (80, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (81, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (82, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (83, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (84, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (85, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Fecha no valida ', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (86, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (87, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (88, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (89, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (90, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (91, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (92, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (93, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (94, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (95, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (96, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (97, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (98, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (99, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (100, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (101, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (102, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (103, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (104, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (105, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (106, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (107, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (108, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (109, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (110, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (111, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (112, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (113, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (114, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (115, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (116, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (117, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (118, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (119, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (120, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (121, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (122, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (123, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (124, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (125, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (126, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (127, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (128, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (129, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (130, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (131, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (132, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (133, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No se encontraron clientes', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (134, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Se encontraron 1 cliente/s con el apellido solicitado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (135, CAST(N'2022-11-20' AS Date), N'Cliente Agregado con exito!!', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (136, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (137, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (138, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (139, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (140, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Fecha no valida ', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (141, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Nuevo turno agendado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (142, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (143, CAST(N'2022-11-20' AS Date), N'Cliente Agregado con exito!!', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (144, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Nuevo turno agendado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (145, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (146, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (147, CAST(N'2022-11-20' AS Date), N'Login///Usuario o contraseña invalidos', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (148, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (149, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (150, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (151, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (152, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (153, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (154, CAST(N'2022-11-20' AS Date), N'Listado de clientes  /// Se encontraron 1 cliente/s con el apellido solicitado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (155, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (156, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (157, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (158, CAST(N'2022-11-20' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (159, CAST(N'2022-11-20' AS Date), N'Listado de clientes  /// Se encontraron 1 cliente/s con el apellido solicitado', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (160, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// Usted selecciono un profesional no capasitado para el turno', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (161, CAST(N'2022-11-20' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (162, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (163, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (164, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (165, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (166, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (167, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (168, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (169, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (170, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (171, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (172, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (173, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (174, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (175, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (176, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (177, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (178, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (179, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (180, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (181, CAST(N'2022-11-21' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (182, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (183, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (184, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (185, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (186, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (187, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (188, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (189, CAST(N'2022-11-21' AS Date), N'Login///Usuario o contraseña invalidos', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (190, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (191, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (192, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (193, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (194, CAST(N'2022-11-21' AS Date), N'Login///Usuario o contraseña invalidos', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (195, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (196, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (197, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (198, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (199, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
GO
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (200, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (201, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (202, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (203, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (204, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (205, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (206, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (207, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (208, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (209, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (210, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (211, CAST(N'2022-11-21' AS Date), N'Login///Usuario o contraseña invalidos', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (212, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1210, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1211, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1212, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1213, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1214, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1215, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1216, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1217, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1218, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1219, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1220, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1221, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1222, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1223, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1224, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1225, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1226, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1227, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1228, CAST(N'2022-11-21' AS Date), N'Login///Usuario o contraseña invalidos', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1229, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1230, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1231, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1232, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1233, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1234, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1235, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1236, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1237, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1238, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1239, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1240, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1241, CAST(N'2022-11-21' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1242, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1243, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1244, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1245, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1246, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1247, CAST(N'2022-11-21' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1248, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1249, CAST(N'2022-11-22' AS Date), N'Login///El usuario  dante@sv.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1250, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1251, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1252, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1253, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (1254, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2248, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2249, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2250, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2251, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2252, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2253, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2254, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2255, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2256, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2257, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2258, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2259, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2260, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2261, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2262, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2263, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2264, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2265, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2266, CAST(N'2022-11-22' AS Date), N'Agregar Turno  /// No selecciono ningun profesional!', 1)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2267, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2268, CAST(N'2022-11-22' AS Date), N'Cliente Agregado con exito!!', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2269, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2270, CAST(N'2022-11-22' AS Date), N'Login///El usuario  juan@salim.com se logueo con exito ', 0)
INSERT [dbo].[Bitacora] ([id], [fecha], [detalle], [error]) VALUES (2271, CAST(N'2022-11-22' AS Date), N'Listado de clientes  ///  Cliente eliminado ', 0)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (1, N'juan', N'salim', N'2214777345', N'juan@salim.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2, N'javier', N'aguirre', N'123456', N'chiky@aguirre.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (3, N'javier', N'aguirre', N'123456', N'chiky@aguirre.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (4, N'pedro', N'lachota', N'5556669', N'pedro@lagarcha.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (5, N'elgato', N'conbotas', N'222555668', N'elgato@gato.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (6, N'salsa', N'mora', N'12354888', N'salsa@picante.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (7, N'elmo', N'salogarca', N'55588', N'elmo@gato.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (1002, N'gael', N'salim velay', N'4692288', N'galu@bebito.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (1003, N'pedro', N'camo', N'555522888', N'juan@salim.com.ar', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2002, N'juan', N'perez', N'221555888', N'juan@perez.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2003, N'sandro', N'langa', N'22225555', N'sandro@langa.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2004, N'orlando', N'mando', N'5558888', N'orlando@mando.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2005, N'pedro alfonso', N'mota', N'22145558', N'pedro@motta.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2006, N'juan ', N'calo', N'5555882', N'jjuan@calo.com', 1)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2007, N'pedro', N'encarnado', N'55558822', N'pedro@encarnado.com', 0)
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [telefono], [email], [estado]) VALUES (2008, N'Ernesto', N'Salitre', N'46988554', N'ernesto@salitre.com', 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (1, N'Clientes')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (2, N'Turnos')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (3, N'Profesionales')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (4, N'Administracion')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (5, N'Nuevo')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (6, N'Agregar Turno')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (7, N'Nuevo Profesional')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (8, N'Reportes')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (9, N'Listado Clientes ADM')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (10, N'Agenda de Turnos')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (11, N'Listado Profesionales ADM')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (12, N'Permisos')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (13, N'Listado Clientes')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (14, N'Turnos por Profesional')
INSERT [dbo].[Menu] ([id], [detalle]) VALUES (15, N'Listado de Profesionales')
GO
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (1, 5)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (1, 9)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (1, 13)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (2, 6)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (2, 10)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (2, 14)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (3, 7)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (3, 11)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (3, 15)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (4, 8)
INSERT [dbo].[MenuPadreHijo] ([padreID], [hijoID]) VALUES (4, 12)
GO
SET IDENTITY_INSERT [dbo].[Operador] ON 

INSERT [dbo].[Operador] ([id], [nombre], [apellido], [email], [clave], [tipo]) VALUES (1, N'juan', N'salim', N'juan@salim.com', N'1234', 1)
INSERT [dbo].[Operador] ([id], [nombre], [apellido], [email], [clave], [tipo]) VALUES (2, N'dante', N'salim velay', N'dante@sv.com', N'1111', 2)
SET IDENTITY_INSERT [dbo].[Operador] OFF
GO
INSERT [dbo].[Profecional] ([nombre], [apellido], [dni], [fecha_nacimiento], [rol]) VALUES (N'tomas', N'porlanariz', 8888956, CAST(N'1975-05-22T00:00:00.000' AS DateTime), N'Tattoo')
INSERT [dbo].[Profecional] ([nombre], [apellido], [dni], [fecha_nacimiento], [rol]) VALUES (N'Andres benito', N'camela', 55663325, CAST(N'2000-09-13T00:00:00.000' AS DateTime), N'Tattoo')
INSERT [dbo].[Profecional] ([nombre], [apellido], [dni], [fecha_nacimiento], [rol]) VALUES (N'salsa', N'prana', 88555222, CAST(N'2000-06-14T00:00:00.000' AS DateTime), N'Tattoo + Piercing')
INSERT [dbo].[Profecional] ([nombre], [apellido], [dni], [fecha_nacimiento], [rol]) VALUES (N'jorge', N'lin', 88555447, CAST(N'1986-06-02T00:00:00.000' AS DateTime), N'Piercing')
GO
INSERT [dbo].[TipoOperador] ([id], [detalle]) VALUES (1, N'administrador')
INSERT [dbo].[TipoOperador] ([id], [detalle]) VALUES (2, N'usuario')
GO
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 1, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 2, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 3, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 4, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 5, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 6, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 7, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 8, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 9, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 10, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 11, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 12, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 13, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 14, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (1, 15, 1)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 1, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 2, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 3, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 4, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 5, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 6, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 7, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 8, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 9, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 10, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 11, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 12, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 13, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 14, 2)
INSERT [dbo].[TipoOpmenu] ([tipoID], [compuestoID], [estado]) VALUES (2, 15, 2)
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([id], [fecha], [tipo], [precio], [senia], [id_cliente], [dni_profesional]) VALUES (4, CAST(N'2022-11-19' AS Date), N'Tattoo', 10000, 5000, 1, 8888956)
INSERT [dbo].[Turno] ([id], [fecha], [tipo], [precio], [senia], [id_cliente], [dni_profesional]) VALUES (9, CAST(N'2022-11-14' AS Date), N'Tattoo', 5000, 1500, 5, 88555222)
INSERT [dbo].[Turno] ([id], [fecha], [tipo], [precio], [senia], [id_cliente], [dni_profesional]) VALUES (10, CAST(N'2022-11-17' AS Date), N'Tattoo', 50000, 100, 2003, 55663325)
INSERT [dbo].[Turno] ([id], [fecha], [tipo], [precio], [senia], [id_cliente], [dni_profesional]) VALUES (11, CAST(N'2022-11-22' AS Date), N'Tattoo', 50000, 1000, 1, 8888956)
INSERT [dbo].[Turno] ([id], [fecha], [tipo], [precio], [senia], [id_cliente], [dni_profesional]) VALUES (12, CAST(N'2022-11-21' AS Date), N'Tattoo', 60000, 2000, 1, 8888956)
INSERT [dbo].[Turno] ([id], [fecha], [tipo], [precio], [senia], [id_cliente], [dni_profesional]) VALUES (13, CAST(N'2022-11-30' AS Date), N'Tattoo', 5000, 1000, 1, 88555222)
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
ALTER TABLE [dbo].[MenuPadreHijo]  WITH CHECK ADD  CONSTRAINT [FK_MenuPadreHijo_Menu] FOREIGN KEY([padreID])
REFERENCES [dbo].[Menu] ([id])
GO
ALTER TABLE [dbo].[MenuPadreHijo] CHECK CONSTRAINT [FK_MenuPadreHijo_Menu]
GO
ALTER TABLE [dbo].[MenuPadreHijo]  WITH CHECK ADD  CONSTRAINT [FK_MenuPadreHijo_Menu1] FOREIGN KEY([hijoID])
REFERENCES [dbo].[Menu] ([id])
GO
ALTER TABLE [dbo].[MenuPadreHijo] CHECK CONSTRAINT [FK_MenuPadreHijo_Menu1]
GO
ALTER TABLE [dbo].[Operador]  WITH CHECK ADD  CONSTRAINT [FK_Operador_TipoOperador] FOREIGN KEY([tipo])
REFERENCES [dbo].[TipoOperador] ([id])
GO
ALTER TABLE [dbo].[Operador] CHECK CONSTRAINT [FK_Operador_TipoOperador]
GO
ALTER TABLE [dbo].[TipoOpmenu]  WITH CHECK ADD  CONSTRAINT [FK_TipoOpmenu_Menu] FOREIGN KEY([compuestoID])
REFERENCES [dbo].[Menu] ([id])
GO
ALTER TABLE [dbo].[TipoOpmenu] CHECK CONSTRAINT [FK_TipoOpmenu_Menu]
GO
ALTER TABLE [dbo].[TipoOpmenu]  WITH CHECK ADD  CONSTRAINT [FK_TipoOpmenu_TipoOperador1] FOREIGN KEY([tipoID])
REFERENCES [dbo].[TipoOperador] ([id])
GO
ALTER TABLE [dbo].[TipoOpmenu] CHECK CONSTRAINT [FK_TipoOpmenu_TipoOperador1]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Cliente]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Profecional] FOREIGN KEY([dni_profesional])
REFERENCES [dbo].[Profecional] ([dni])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Profecional]
GO
/****** Object:  StoredProcedure [dbo].[AgregarReporte]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarReporte]
	-- Add the parameters for the stored procedure here
	@fecha date, @detalle varchar(5000),@error bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Bitacora (fecha,detalle,error) values (@fecha,@detalle,@error)
END
GO
/****** Object:  StoredProcedure [dbo].[Alta_Profecional]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Alta_Profecional] 
	
	@nombre varchar(50),@apellido varchar(50),@dni int, @fecha_nacimiento datetime, @rol varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Profecional (nombre,apellido,dni,fecha_nacimiento,rol) values (@nombre,@apellido,@dni,@fecha_nacimiento,@rol)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaCliente]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaCliente]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),@apellido varchar(50),@telefono varchar(50), @email varchar(50),@estado bit
AS


	INSERT into dbo.Cliente(nombre,apellido,telefono,email,estado)values(@nombre,@apellido,@telefono,@email,@estado)

GO
/****** Object:  StoredProcedure [dbo].[AltaTurno]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[AltaTurno]
	-- Add the parameters for the stored procedure here
	@fecha date, @tipo varchar(50), @precio float, @senia float, @id_cliente int, @dni_profesional int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.Turno (fecha,tipo,precio,senia,id_cliente, dni_profesional) values (@fecha,@tipo,@precio,@senia,@id_cliente,@dni_profesional)
END
GO
/****** Object:  StoredProcedure [dbo].[Baja_Logica]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Baja_Logica] 
	-- Add the parameters for the stored procedure here
	@id int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update dbo.Cliente set estado = 0 where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[BajaProfecional]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BajaProfecional] 
		@dni int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from dbo.Profecional where dni = @dni
END
GO
/****** Object:  StoredProcedure [dbo].[Buscar]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Buscar]
	-- Add the parameters for the stored procedure here
	@apellido varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id]   
	  ,[nombre]
      ,[apellido]
      
      ,[telefono]
      ,[email]
      
  FROM dbo.Cliente where apellido = @apellido and estado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarProf]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarProf]
	-- Add the parameters for the stored procedure here
	@apellido varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [nombre]
	,[apellido]
	,[dni]
	,[fecha_nacimiento]
	,[rol]
	from dbo.Profecional where apellido = @apellido
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarProfRol]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscarProfRol] 
	-- Add the parameters for the stored procedure here
	@rol varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;

if (@rol = 'Tattoo') 
 select [nombre],[apellido],[dni],[fecha_nacimiento],[rol] from dbo.Profecional where rol = @rol or rol = 'Tattoo + Piercing'
  
if (@rol = 'Piercing')
 select [nombre],[apellido],[dni],[fecha_nacimiento],[rol] from dbo.Profecional where rol = @rol or rol = 'Tattoo + Piercing'



   
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarTurnoFecha]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BuscarTurnoFecha] 
	@fecha date
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id]
	,[fecha]
	,[tipo]
	,[precio]
	,[senia]
	,[id_cliente]
	,[dni_profesional]
	from dbo.Turno where fecha = @fecha

END
GO
/****** Object:  StoredProcedure [dbo].[EliminarTurno]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarTurno] 
	@id int
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from dbo.Turno where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Modificar_Cliente]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Modificar_Cliente] 
	-- Add the parameters for the stored procedure here
	@id int ,@nombre varchar(50),@apellido varchar (50), @telefono varchar(50), @email varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update dbo.Cliente set nombre = @nombre, apellido = @apellido, telefono = @telefono, email = @email where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarProf]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarProf]
	-- Add the parameters for the stored procedure here
	@nombre varchar(50), @apellido varchar(50), @dni int, @fecha_nacimiento datetime, @rol varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update dbo.Profecional set nombre = @nombre, apellido = @apellido , dni = @dni, fecha_nacimiento = @fecha_nacimiento , rol = @rol
	where dni = @dni
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarTurno]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarTurno] 
	 @id int, @precio float , @senia float
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update dbo.Turno set precio = @precio , senia = @senia where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[TodosLosTurnos]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TodosLosTurnos]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
	t.fecha as fecha, t.tipo as tipo, t.precio as precio, t.senia as senia, c.nombre as cliente, p.apellido as profesional 
	from Turno t 
	inner join Cliente c on t.id_cliente = c.id 
	inner join Profecional p on t.dni_profesional = p.dni
END
GO
/****** Object:  StoredProcedure [dbo].[Traer_Menu]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Traer_Menu] 
	-- Add the parameters for the stored procedure here
	@id int
as
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@id = 0) begin
		select * 
		from Menu
		where id in (
			select M.id
			from Menu M
			left join MenuPadreHijo MPH on (M.id=MPH.padreID)
			
			where M.[id] not in(
			select hijoID
			from MenuPadreHijo
		))

	end else begin
		select *
		from menu
		where id in (

		select MPH.hijoID
		from menu M
		inner join MenuPadreHijo MPH on (M.id=MPH.padreID)
		
		where M.id=@id
		)
	end
END

GO
/****** Object:  StoredProcedure [dbo].[Traer_TipoOP]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Traer_TipoOP] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
	SET NOCOUNT ON;

    
	SELECT TipoOperador.id , TipoOperador.detalle
	from dbo.TipoOperador
END
GO
/****** Object:  StoredProcedure [dbo].[TraerClientes]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TraerClientes] 
	-- Add the parameters for the stored procedure here
	--@nombre varchar(50),@apellido varchar(50),@dni int, @telefono varchar(50), @email varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id]   
	  ,[nombre]
      ,[apellido]
      
      ,[telefono]
      ,[email]
      
  FROM dbo.Cliente where estado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[TraerOperador]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TraerOperador]
	@email varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT id, nombre, apellido, email, clave, tipo
	from dbo.Operador where email = @email

END
GO
/****** Object:  StoredProcedure [dbo].[TraerOPmenu]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TraerOPmenu] 
	-- Add the parameters for the stored procedure here
	@tipoID INT , @compuestoID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	
	from dbo.TipoOpmenu
	where tipoID = @tipoID and compuestoID = @compuestoID
END
GO
/****** Object:  StoredProcedure [dbo].[TraerProfecionales]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TraerProfecionales]
	
AS
BEGIN
	--
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [nombre]
	,[apellido]
	,[dni]
	,[fecha_nacimiento]
	,[rol]
	from dbo.Profecional
END
GO
/****** Object:  StoredProcedure [dbo].[TraerReportes]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TraerReportes] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [id]
	,[fecha]
	,[detalle]
	,[error]
	from dbo.Bitacora
END
GO
/****** Object:  StoredProcedure [dbo].[TraerTurnoId]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TraerTurnoId] 
	
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
	t.id as numero,t.fecha as fecha, t.tipo as tipo, t.precio as precio, t.senia as senia, c.nombre as cliente, p.apellido as profesional 
	from Turno t 
	inner join Cliente c on t.id_cliente = c.id 
	inner join Profecional p on t.dni_profesional = p.dni
	where t.id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[TraerTurnosFecha]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

-- =============================================
CREATE PROCEDURE [dbo].[TraerTurnosFecha] 
	@fecha date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
	t.id as numero,t.fecha as fecha, t.tipo as tipo, t.precio as precio, t.senia as senia, c.nombre as cliente, p.apellido as profesional 
	from Turno t 
	inner join Cliente c on t.id_cliente = c.id 
	inner join Profecional p on t.dni_profesional = p.dni
	where fecha = @fecha
END
GO
/****** Object:  StoredProcedure [dbo].[TurnosProfesional]    Script Date: 11/22/2022 11:13:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TurnosProfesional] 
	-- Add the parameters for the stored procedure here
	@dni_profesional int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
	t.id as numero,t.fecha as fecha, t.tipo as tipo, t.precio as precio, t.senia as senia, c.nombre as cliente, p.apellido as profesional 
	from Turno t 
	inner join Cliente c on t.id_cliente = c.id 
	inner join Profecional p on t.dni_profesional = p.dni
	where dni_profesional = @dni_profesional
END
GO
