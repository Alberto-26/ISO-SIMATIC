USE [SIMATIC]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[NRC] [varchar](50) NOT NULL,
	[NombreCliente] [varchar](100) NOT NULL,
	[NIT] [varchar](50) NOT NULL,
	[Direccion] [varchar](500) NULL,
	[Giro] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NRC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleFacturaVenta]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleFacturaVenta](
	[NumFactura] [varchar](30) NULL,
	[CodigoProducto] [varchar](30) NULL,
	[CantidadVenta] [int] NULL,
	[Precio] [smallmoney] NULL,
	[Costo] [smallmoney] NULL,
	[Descuento] [smallmoney] NULL,
	[Iva] [smallmoney] NULL,
	[Total] [smallmoney] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EncabezadoFactura]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EncabezadoFactura](
	[NumFactura] [varchar](30) NOT NULL,
	[NRC] [varchar](50) NULL,
	[FechaVenta] [date] NULL,
	[SubTotal] [smallmoney] NULL,
	[Descuento] [smallmoney] NULL,
	[Iva] [smallmoney] NULL,
	[Total] [smallmoney] NULL,
	[NombreUsuario] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[NumFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[CodigoProducto] [varchar](30) NOT NULL,
	[NombreProducto] [varchar](100) NOT NULL,
	[Descripcion] [varchar](500) NULL,
	[Existencia] [int] NOT NULL,
	[PrecioCosto] [smallmoney] NOT NULL,
	[PrecioVenta] [smallmoney] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[CodigoProveedor] [varchar](30) NOT NULL,
	[NombreProveedor] [varchar](100) NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
	[Direccion] [varchar](500) NULL,
	[Correo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProveedoresProductos]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProveedoresProductos](
	[CodigoProveedor] [varchar](30) NULL,
	[CodigoProductos] [varchar](30) NULL,
	[Cantidad] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[IDRol] [varchar](10) NOT NULL,
	[NombreRol] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioRoles]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioRoles](
	[IDUsuario] [varchar](100) NULL,
	[IDRol] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[NombreUsuario] [varchar](100) NOT NULL,
	[ClaveUsuario] [varchar](100) NOT NULL,
	[Pregunta] [varchar](300) NOT NULL,
	[Respuesta] [varchar](300) NOT NULL,
	[Correo] [varchar](100) NULL,
	[Telefono] [varchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clientes] ([NRC], [NombreCliente], [NIT], [Direccion], [Giro]) VALUES (N'1213-6', N'Alberto Torres', N'111-111111-111-1', N'asdasdasdasdad', N'asdasdasdas')
INSERT [dbo].[Clientes] ([NRC], [NombreCliente], [NIT], [Direccion], [Giro]) VALUES (N'2312', N'Josue', N'121-111090-512-1', N'San Salvador', N'Salon de Belleza')
INSERT [dbo].[Clientes] ([NRC], [NombreCliente], [NIT], [Direccion], [Giro]) VALUES (N'34343', N'juan Torres', N'0614-081176-121-1', N'Santa Tecla', N'Venta de equipo informatico')
INSERT [dbo].[Productos] ([CodigoProducto], [NombreProducto], [Descripcion], [Existencia], [PrecioCosto], [PrecioVenta]) VALUES (N'12', N'Mouse', N'Klip Xtreme ff', 3, 4.5000, 6.9900)
INSERT [dbo].[Productos] ([CodigoProducto], [NombreProducto], [Descripcion], [Existencia], [PrecioCosto], [PrecioVenta]) VALUES (N'12123', N'USB KINGSTON', N'32 GB', 1, 5.0000, 6.0000)
INSERT [dbo].[Productos] ([CodigoProducto], [NombreProducto], [Descripcion], [Existencia], [PrecioCosto], [PrecioVenta]) VALUES (N'555666', N'Laptop Dell', N'LATITUDE 3410 I5', 1, 834.0000, 950.0000)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [NombreProveedor], [Telefono], [Direccion], [Correo]) VALUES (N'123', N'Setes', N'2222-4432', N'Boulervard Venezuela', N'setes@gmail.com')
INSERT [dbo].[Proveedores] ([CodigoProveedor], [NombreProveedor], [Telefono], [Direccion], [Correo]) VALUES (N'1231', N'Stanley Lemus', N'7654-9877', N'San Salvador', N'Slemus@outlook.com')
INSERT [dbo].[Roles] ([IDRol], [NombreRol]) VALUES (N'Admin', N'Administrador')
INSERT [dbo].[Roles] ([IDRol], [NombreRol]) VALUES (N'Empl', N'Empleado')
INSERT [dbo].[UsuarioRoles] ([IDUsuario], [IDRol]) VALUES (N'Jorge', N'Admin')
INSERT [dbo].[Usuarios] ([NombreUsuario], [ClaveUsuario], [Pregunta], [Respuesta], [Correo], [Telefono]) VALUES (N'administrador', N'admin', N'¿Nombre de la empresa?', N'Simatic', N'simaticventas@gmail.com', N'2232-1253')
INSERT [dbo].[Usuarios] ([NombreUsuario], [ClaveUsuario], [Pregunta], [Respuesta], [Correo], [Telefono]) VALUES (N'Alberto', N'123', N'¿Color favorito?', N'Verde', N'alberto@gmail.com', N'1231-2312')
INSERT [dbo].[Usuarios] ([NombreUsuario], [ClaveUsuario], [Pregunta], [Respuesta], [Correo], [Telefono]) VALUES (N'Jorge', N'5a318c', N'¿Color favorito?', N'Verde', N'jorge2604lima@gmail.com', N'6314-6524')
ALTER TABLE [dbo].[DetalleFacturaVenta]  WITH CHECK ADD FOREIGN KEY([CodigoProducto])
REFERENCES [dbo].[Productos] ([CodigoProducto])
GO
ALTER TABLE [dbo].[DetalleFacturaVenta]  WITH CHECK ADD FOREIGN KEY([NumFactura])
REFERENCES [dbo].[EncabezadoFactura] ([NumFactura])
GO
ALTER TABLE [dbo].[EncabezadoFactura]  WITH CHECK ADD FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[Usuarios] ([NombreUsuario])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[EncabezadoFactura]  WITH CHECK ADD FOREIGN KEY([NRC])
REFERENCES [dbo].[Clientes] ([NRC])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProveedoresProductos]  WITH CHECK ADD FOREIGN KEY([CodigoProveedor])
REFERENCES [dbo].[Proveedores] ([CodigoProveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProveedoresProductos]  WITH CHECK ADD FOREIGN KEY([CodigoProductos])
REFERENCES [dbo].[Productos] ([CodigoProducto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsuarioRoles]  WITH CHECK ADD FOREIGN KEY([IDRol])
REFERENCES [dbo].[Roles] ([IDRol])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsuarioRoles]  WITH CHECK ADD FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([NombreUsuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [consTelProveedores] CHECK  (([Telefono] like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [consTelProveedores]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [consTelUsuario] CHECK  (([Telefono] like '[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [consTelUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarProducto]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_InsertarProducto]
(@CodigoProducto varchar(30),
 @NombreProducto varchar(100),
 @Descripcion varchar(500),
 @Existencia int,
 @PrecioCosto smallmoney,
 @PrecioVenta smallmoney
            
)
AS
BEGIN 

if  not exists(select * from Productos p (nolock) where p.CodigoProducto=@CodigoProducto)
  begin 
    insert Productos(CodigoProducto ,
 NombreProducto ,
 Descripcion,
 Existencia ,
 PrecioCosto,
 PrecioVenta)
		     values(@CodigoProducto ,
 @NombreProducto ,
 @Descripcion,
 @Existencia ,
 @PrecioCosto,
 @PrecioVenta)
  end
END	
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarUsuarios]    Script Date: 22/4/2022 16:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_InsertarUsuarios]
(@NombreUsuario varchar(100),
 @ClaveUsuario varchar(100),
 @Pregunta varchar(300),
 @Respuesta varchar(300),
 @Correo varchar(100),
 @Telefono varchar(9)
            
)
AS
BEGIN 

if  not exists(select * from Usuarios u (nolock) where u.NombreUsuario=@NombreUsuario)
  begin 
    insert Usuarios(NombreUsuario ,
					 ClaveUsuario,
					 Pregunta,
					 Respuesta,
					 Correo,
					Telefono)
		     values(@NombreUsuario ,
					@ClaveUsuario,
					 @Pregunta,
					 @Respuesta ,
					 @Correo,
					 @Telefono)
  end
END	
GO
