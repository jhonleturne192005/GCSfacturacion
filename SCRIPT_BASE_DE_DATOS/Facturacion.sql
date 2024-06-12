USE [master]
GO
/****** Object:  Database [Facturacion]    Script Date: 12/06/2024 8:45:56 ******/
CREATE DATABASE [Facturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Facturacion', FILENAME = N'/var/opt/sqlserver/data/Facturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Facturacion_log', FILENAME = N'/var/opt/sqlserver/log/Facturacion_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Facturacion] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Facturacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Facturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [Facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [Facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Facturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Facturacion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Facturacion', N'ON'
GO
ALTER DATABASE [Facturacion] SET QUERY_STORE = ON
GO
ALTER DATABASE [Facturacion] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Facturacion]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [nchar](10) NOT NULL,
	[nombres] [nchar](100) NOT NULL,
	[apellidos] [nchar](100) NOT NULL,
 CONSTRAINT [pk_id_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[id_detalle_factura] [bigint] IDENTITY(1,1) NOT NULL,
	[id_factura] [bigint] NOT NULL,
	[id_producto] [bigint] NOT NULL,
	[precio_unitario] [decimal](14, 4) NOT NULL,
	[iva] [decimal](5, 2) NOT NULL,
	[cantidad] [decimal](8, 2) NOT NULL,
	[subtotal] [decimal](18, 4) NOT NULL,
	[total] [decimal](18, 4) NOT NULL,
 CONSTRAINT [pk_id_detalle_factura] PRIMARY KEY CLUSTERED 
(
	[id_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id_factura] [bigint] IDENTITY(1,1) NOT NULL,
	[id_cliente] [nchar](10) NOT NULL,
	[subtotal] [decimal](18, 4) NOT NULL,
	[total] [decimal](18, 4) NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [pk_id_factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [nchar](30) NOT NULL,
	[precio_unitario] [decimal](14, 4) NOT NULL,
	[iva] [decimal](5, 2) NOT NULL,
 CONSTRAINT [pk_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111111', N'Aa                                                                                                  ', N'Arreaga                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111113', N'a                                                                                                   ', N'a                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111114', N'a                                                                                                   ', N'a                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111115', N'a23                                                                                                 ', N'a                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111116', N'a                                                                                                   ', N'a                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111118', N'a                                                                                                   ', N'a                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111111119', N'a                                                                                                   ', N'a                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1111444489', N'Carl Jonson                                                                                         ', N'Toretto la familia                                                                                  ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1206810739', N'Anderson                                                                                            ', N'Jaime                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1207021633', N'ORLANDO JESUS                                                                                       ', N'CEDEÑO SALVATIERRA                                                                                  ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1232222123', N'Test1                                                                                               ', N'Test2                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1234569875', N'dfgg                                                                                                ', N'fdhg                                                                                                ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1250808373', N'Jhon                                                                                                ', N'Leturne                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1250808374', N'Jhon                                                                                                ', N'Leturne                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1254121452', N'1254121452                                                                                          ', N'Test1                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1254121454', N'A                                                                                                   ', N'H                                                                                                   ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1254146454', N'Test1                                                                                               ', N'Test2                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'1475852541', N'Test1                                                                                               ', N'Test1                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350452145', N'Pepe                                                                                                ', N'Rosales                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702270', N'Juan                                                                                                ', N'Pérez                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702271', N'Ana                                                                                                 ', N'Rodríguez                                                                                           ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702272', N'Carlos                                                                                              ', N'Sánchez                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702273', N'Laura                                                                                               ', N'Fernández                                                                                           ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702274', N'Pedro                                                                                               ', N'López                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702275', N'Sofía                                                                                               ', N'Martínez                                                                                            ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702276', N'Diego                                                                                               ', N'Gómez                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702277', N'Isabella                                                                                            ', N'Díaz                                                                                                ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702278', N'Manuel                                                                                              ', N'Hernández                                                                                           ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702279', N'Valentina                                                                                           ', N'Moreno                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702280', N'Lucas                                                                                               ', N'Torres                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702281', N'Mariana                                                                                             ', N'Ruiz                                                                                                ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702282', N'Matías                                                                                              ', N'Vargas                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702283', N'Catalina                                                                                            ', N'Ramírez                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702284', N'Eduardo                                                                                             ', N'Álvarez                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702285', N'Camila                                                                                              ', N'Gutiérrez                                                                                           ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702286', N'Joaquín                                                                                             ', N'Ortega                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702287', N'Isabel                                                                                              ', N'Reyes                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702288', N'Felipe                                                                                              ', N'Jiménez                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702289', N'Juliana                                                                                             ', N'Dominguez                                                                                           ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702290', N'Emiliano                                                                                            ', N'Santos                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702291', N'Fernanda                                                                                            ', N'Castro                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702292', N'Gabriel                                                                                             ', N'Navarro                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702293', N'Juana                                                                                               ', N'Pacheco                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702294', N'Francisco                                                                                           ', N'Mendoza                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702295', N'Valeria                                                                                             ', N'Luna                                                                                                ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702296', N'Lorenzo                                                                                             ', N'Guerrero                                                                                            ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702297', N'Ana                                                                                                 ', N'Morales                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702298', N'Agustín                                                                                             ', N'Silva                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702299', N'Marcela                                                                                             ', N'Rojas                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702300', N'Andrés                                                                                              ', N'Salazar                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702301', N'Mariano                                                                                             ', N'Flores                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702302', N'Constanza                                                                                           ', N'García                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702303', N'Castillo                                                                                            ', N'TEST1                                                                                               ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702304', N'Acostaa                                                                                             ', N'Ignacio                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702305', N'Rocío                                                                                               ', N'Miranda                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702306', N'Daniel                                                                                              ', N'Suárez                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702307', N'Gustavo                                                                                             ', N'Olivera                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702308', N'Carolina                                                                                            ', N'Ríos                                                                                                ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702309', N'Santiago                                                                                            ', N'Bustos                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702310', N'Julieta                                                                                             ', N'Peralta                                                                                             ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702311', N'Tomás                                                                                               ', N'Ferreira                                                                                            ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702312', N'Renataaaaaaa                                                                                        ', N'Alonso                                                                                              ')
INSERT [dbo].[Cliente] ([id_cliente], [nombres], [apellidos]) VALUES (N'2350702314', N'Paula                                                                                               ', N'Ibarra                                                                                              ')
GO
SET IDENTITY_INSERT [dbo].[DetalleFactura] ON 

INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (3, 3, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (4, 3, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (5, 4, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(15.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (6, 4, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(15.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (7, 5, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (8, 6, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (9, 6, 20, CAST(3.9900 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (10, 7, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (11, 7, 9, CAST(7.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (12, 7, 20, CAST(3.9900 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (13, 8, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (14, 8, 9, CAST(7.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (15, 8, 20, CAST(3.9900 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.9900 AS Decimal(18, 4)), CAST(4.4688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (16, 9, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(23.9600 AS Decimal(18, 4)), CAST(25.1580 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (17, 9, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(23.9600 AS Decimal(18, 4)), CAST(25.1580 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (18, 10, 4, CAST(2.7500 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(12.7500 AS Decimal(18, 4)), CAST(13.6425 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (19, 10, 14, CAST(12.7500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(12.7500 AS Decimal(18, 4)), CAST(13.6425 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (20, 11, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(5.2500 AS Decimal(18, 4)), CAST(5.6700 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (21, 11, 33, CAST(5.2500 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(5.2500 AS Decimal(18, 4)), CAST(5.6700 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (22, 12, 9, CAST(7.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(7.2500 AS Decimal(18, 4)), CAST(7.6125 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (23, 13, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(63.7500 AS Decimal(18, 4)), CAST(68.2125 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (24, 13, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(63.7500 AS Decimal(18, 4)), CAST(68.2125 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (25, 13, 5, CAST(3.4500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(63.7500 AS Decimal(18, 4)), CAST(68.2125 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (26, 13, 9, CAST(7.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(63.7500 AS Decimal(18, 4)), CAST(68.2125 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (27, 13, 14, CAST(12.7500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(5.00 AS Decimal(8, 2)), CAST(63.7500 AS Decimal(18, 4)), CAST(68.2125 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (28, 14, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(6.00 AS Decimal(8, 2)), CAST(16.4000 AS Decimal(18, 4)), CAST(17.7120 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (29, 14, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(5.00 AS Decimal(8, 2)), CAST(16.4000 AS Decimal(18, 4)), CAST(17.7120 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (30, 14, 4, CAST(2.7500 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(16.4000 AS Decimal(18, 4)), CAST(17.7120 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (31, 14, 5, CAST(3.4500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(16.4000 AS Decimal(18, 4)), CAST(17.7120 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (32, 14, 6, CAST(8.2000 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(16.4000 AS Decimal(18, 4)), CAST(17.7120 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (33, 15, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (34, 16, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(5.5000 AS Decimal(18, 4)), CAST(6.1600 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (35, 16, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(5.5000 AS Decimal(18, 4)), CAST(6.1600 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (36, 17, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(5.5000 AS Decimal(18, 4)), CAST(6.1600 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (37, 17, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(5.5000 AS Decimal(18, 4)), CAST(6.1600 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (39, 19, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (40, 19, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (41, 19, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (42, 19, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (43, 20, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (44, 20, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (45, 20, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(11.9800 AS Decimal(18, 4)), CAST(12.5790 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (46, 20, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(11.9800 AS Decimal(18, 4)), CAST(12.5790 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (49, 25, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (50, 25, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (51, 26, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (52, 26, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (53, 27, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(8.2500 AS Decimal(18, 4)), CAST(9.2400 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (54, 27, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (55, 28, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(8.2500 AS Decimal(18, 4)), CAST(9.2400 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (56, 28, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (57, 29, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(10.00 AS Decimal(8, 2)), CAST(125.8000 AS Decimal(18, 4)), CAST(140.8960 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (58, 29, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(5.5000 AS Decimal(18, 4)), CAST(6.1600 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (59, 29, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(17.9700 AS Decimal(18, 4)), CAST(18.8685 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (60, 29, 4, CAST(2.7500 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.1000 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (61, 30, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(5.00 AS Decimal(8, 2)), CAST(62.9000 AS Decimal(18, 4)), CAST(70.4480 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (62, 30, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (63, 30, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(17.9700 AS Decimal(18, 4)), CAST(18.8685 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (64, 30, 9, CAST(7.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(12.00 AS Decimal(8, 2)), CAST(87.0000 AS Decimal(18, 4)), CAST(91.3500 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (65, 31, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(12.5800 AS Decimal(18, 4)), CAST(14.0896 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (66, 31, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (67, 31, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(5.00 AS Decimal(8, 2)), CAST(29.9500 AS Decimal(18, 4)), CAST(31.4475 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (68, 32, 14, CAST(12.7500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(25.5000 AS Decimal(18, 4)), CAST(27.2850 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (69, 33, 14, CAST(12.7500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(25.5000 AS Decimal(18, 4)), CAST(27.2850 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (70, 34, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (71, 34, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (72, 35, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (73, 35, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (74, 36, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(50.3200 AS Decimal(18, 4)), CAST(56.3584 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (75, 36, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(8.2500 AS Decimal(18, 4)), CAST(9.2400 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (76, 37, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(9.00 AS Decimal(8, 2)), CAST(24.7500 AS Decimal(18, 4)), CAST(27.7200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (77, 37, 5, CAST(3.4500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)), CAST(8.00 AS Decimal(8, 2)), CAST(27.6000 AS Decimal(18, 4)), CAST(29.5320 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (78, 38, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (79, 38, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (80, 39, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(7.00 AS Decimal(8, 2)), CAST(88.0600 AS Decimal(18, 4)), CAST(98.6272 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (81, 39, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (82, 39, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(3.00 AS Decimal(8, 2)), CAST(17.9700 AS Decimal(18, 4)), CAST(18.8685 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (83, 40, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(12.5800 AS Decimal(18, 4)), CAST(14.0896 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (84, 40, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (85, 41, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(25.1600 AS Decimal(18, 4)), CAST(28.1792 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (86, 42, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(25.1600 AS Decimal(18, 4)), CAST(28.1792 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (87, 43, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(5.9900 AS Decimal(18, 4)), CAST(6.2895 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (88, 43, 15, CAST(3.2000 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(3.2000 AS Decimal(18, 4)), CAST(3.3600 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (90, 45, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(12.5800 AS Decimal(18, 4)), CAST(14.0896 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (91, 45, 65, CAST(10.0000 AS Decimal(14, 4)), CAST(2.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(10.0000 AS Decimal(18, 4)), CAST(10.2000 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (92, 46, 66, CAST(5.5000 AS Decimal(14, 4)), CAST(15.00 AS Decimal(5, 2)), CAST(90.00 AS Decimal(8, 2)), CAST(495.0000 AS Decimal(18, 4)), CAST(569.2500 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (93, 47, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(20.00 AS Decimal(8, 2)), CAST(251.6000 AS Decimal(18, 4)), CAST(281.7920 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (94, 47, 2, CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(2.7500 AS Decimal(18, 4)), CAST(3.0800 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (95, 48, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(25.1600 AS Decimal(18, 4)), CAST(28.1792 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (96, 48, 3, CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(12.00 AS Decimal(8, 2)), CAST(71.8800 AS Decimal(18, 4)), CAST(75.4740 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (97, 48, 39, CAST(10.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)), CAST(4.00 AS Decimal(8, 2)), CAST(41.0000 AS Decimal(18, 4)), CAST(43.0500 AS Decimal(18, 4)))
INSERT [dbo].[DetalleFactura] ([id_detalle_factura], [id_factura], [id_producto], [precio_unitario], [iva], [cantidad], [subtotal], [total]) VALUES (98, 49, 1, CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)), CAST(1.00 AS Decimal(8, 2)), CAST(12.5800 AS Decimal(18, 4)), CAST(14.0896 AS Decimal(18, 4)))
SET IDENTITY_INSERT [dbo].[DetalleFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (3, N'1111111116', CAST(18.0800 AS Decimal(18, 4)), CAST(20.2496 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (4, N'1111111116', CAST(18.0800 AS Decimal(18, 4)), CAST(20.2496 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (5, N'1111111116', CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (6, N'1111111118', CAST(13.9700 AS Decimal(18, 4)), CAST(15.2271 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (7, N'2350702312', CAST(17.9800 AS Decimal(18, 4)), CAST(19.6301 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (8, N'2350702312', CAST(17.9800 AS Decimal(18, 4)), CAST(19.6301 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (9, N'2350702284', CAST(60.5000 AS Decimal(18, 4)), CAST(64.4056 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (10, N'2350702312', CAST(28.2500 AS Decimal(18, 4)), CAST(30.3100 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (11, N'2350702309', CAST(23.0800 AS Decimal(18, 4)), CAST(25.4296 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (12, N'2350702289', CAST(14.5000 AS Decimal(18, 4)), CAST(15.2250 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (13, N'2350702312', CAST(194.7600 AS Decimal(18, 4)), CAST(209.2087 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (14, N'2350702289', CAST(159.5800 AS Decimal(18, 4)), CAST(174.5836 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (15, N'2350702301', CAST(75.4800 AS Decimal(18, 4)), CAST(84.5376 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (16, N'2350702301', CAST(48.7400 AS Decimal(18, 4)), CAST(54.5888 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (17, N'2350702301', CAST(5.5000 AS Decimal(18, 4)), CAST(6.1600 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (18, N'2350702301', CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (19, N'2350702312', CAST(37.7400 AS Decimal(18, 4)), CAST(42.2688 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (20, N'2350702312', CAST(34.9600 AS Decimal(18, 4)), CAST(37.4780 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (25, N'2350702312', CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (26, N'2350702312', CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (27, N'1111111116', CAST(11.0000 AS Decimal(18, 4)), CAST(12.3200 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (28, N'1111111116', CAST(19.2500 AS Decimal(18, 4)), CAST(21.5600 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (29, N'2350702291', CAST(160.2700 AS Decimal(18, 4)), CAST(178.0245 AS Decimal(18, 4)), CAST(N'2024-06-09T18:06:34.103' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (30, N'2350702312', CAST(170.6200 AS Decimal(18, 4)), CAST(183.7465 AS Decimal(18, 4)), CAST(N'2024-06-10T00:01:21.320' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (31, N'2350702312', CAST(53.5300 AS Decimal(18, 4)), CAST(57.8571 AS Decimal(18, 4)), CAST(N'2024-06-10T01:31:40.203' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (32, N'1111111111', CAST(25.5000 AS Decimal(18, 4)), CAST(27.2850 AS Decimal(18, 4)), CAST(N'2024-06-10T01:33:38.803' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (33, N'1111111111', CAST(25.5000 AS Decimal(18, 4)), CAST(27.2850 AS Decimal(18, 4)), CAST(N'2024-06-10T01:34:22.677' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (34, N'1111111111', CAST(40.4900 AS Decimal(18, 4)), CAST(45.3488 AS Decimal(18, 4)), CAST(N'2024-06-10T01:45:32.577' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (35, N'1111111113', CAST(48.7400 AS Decimal(18, 4)), CAST(54.5888 AS Decimal(18, 4)), CAST(N'2024-06-10T01:47:43.757' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (36, N'2350702312', CAST(58.5700 AS Decimal(18, 4)), CAST(65.5984 AS Decimal(18, 4)), CAST(N'2024-06-10T01:52:05.097' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (37, N'2350702312', CAST(52.3500 AS Decimal(18, 4)), CAST(57.2520 AS Decimal(18, 4)), CAST(N'2024-06-10T01:58:22.380' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (38, N'2350702311', CAST(48.7400 AS Decimal(18, 4)), CAST(54.5888 AS Decimal(18, 4)), CAST(N'2024-06-10T02:03:30.320' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (39, N'2350702312', CAST(117.0300 AS Decimal(18, 4)), CAST(129.8157 AS Decimal(18, 4)), CAST(N'2024-06-10T02:12:48.560' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (40, N'1111111111', CAST(15.3300 AS Decimal(18, 4)), CAST(17.1696 AS Decimal(18, 4)), CAST(N'2024-06-10T18:06:27.500' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (41, N'1111111111', CAST(25.1600 AS Decimal(18, 4)), CAST(28.1792 AS Decimal(18, 4)), CAST(N'2024-06-10T18:06:58.813' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (42, N'1111111111', CAST(25.1600 AS Decimal(18, 4)), CAST(28.1792 AS Decimal(18, 4)), CAST(N'2024-06-10T18:07:30.073' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (43, N'1111111111', CAST(9.1900 AS Decimal(18, 4)), CAST(9.6495 AS Decimal(18, 4)), CAST(N'2024-06-10T18:10:03.880' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (45, N'1111111118', CAST(22.5800 AS Decimal(18, 4)), CAST(24.2896 AS Decimal(18, 4)), CAST(N'2024-06-10T18:24:36.860' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (46, N'1207021633', CAST(495.0000 AS Decimal(18, 4)), CAST(569.2500 AS Decimal(18, 4)), CAST(N'2024-06-10T18:24:59.677' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (47, N'1111111118', CAST(254.3500 AS Decimal(18, 4)), CAST(284.8720 AS Decimal(18, 4)), CAST(N'2024-06-10T18:26:58.840' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (48, N'1111111111', CAST(138.0400 AS Decimal(18, 4)), CAST(146.7032 AS Decimal(18, 4)), CAST(N'2024-06-10T18:45:50.390' AS DateTime))
INSERT [dbo].[Factura] ([id_factura], [id_cliente], [subtotal], [total], [fecha]) VALUES (49, N'1111111113', CAST(12.5800 AS Decimal(18, 4)), CAST(14.0896 AS Decimal(18, 4)), CAST(N'2024-06-10T21:22:59.283' AS DateTime))
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (1, N'Arrozzzzzdd344                ', CAST(12.5800 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (2, N'Azúcara                       ', CAST(2.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (3, N'Leche                         ', CAST(5.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (4, N'Pan                           ', CAST(2.7500 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (5, N'Manzanas                      ', CAST(3.4500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (6, N'Queso                         ', CAST(8.2000 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (7, N'Cereal                        ', CAST(4.9900 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (8, N'Jugo                          ', CAST(6.5000 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (9, N'Café                          ', CAST(7.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (10, N'Yogur                         ', CAST(1.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (11, N'Huevos                        ', CAST(4.0000 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (12, N'Papel higiénico               ', CAST(3.7500 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (14, N'Pescado                       ', CAST(12.7500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (15, N'Mantequilla                   ', CAST(3.2000 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (17, N'Galletas                      ', CAST(2.5000 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (19, N'Refresco                      ', CAST(2.2500 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (20, N'Chocolate                     ', CAST(3.9900 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (21, N'Cerveza                       ', CAST(6.7500 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (22, N'Vino                          ', CAST(15.5000 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (23, N'Pasta                         ', CAST(1.7500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (24, N'Salsa de tomate               ', CAST(2.4900 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (26, N'Frijoles                      ', CAST(3.5000 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (27, N'Sopa                          ', CAST(1.9900 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (28, N'Cepillo de dientes            ', CAST(4.2500 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (29, N'Pasta de dientes              ', CAST(3.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (30, N'Shampoo                       ', CAST(8.5000 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (32, N'Jabón                         ', CAST(1.5000 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (33, N'Detergente                    ', CAST(5.2500 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (34, N'Esponja                       ', CAST(2.4900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (35, N'Toallas de papel              ', CAST(4.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (36, N'Pañuelos                      ', CAST(1.9900 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (37, N'Desodorante                   ', CAST(3.5000 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (38, N'Crema hidratante              ', CAST(7.9900 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (39, N'Protector solar               ', CAST(10.2500 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (40, N'Maquillaje                    ', CAST(12.9900 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (41, N'Cepillo para el caballo       ', CAST(3.5000 AS Decimal(14, 4)), CAST(7.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (42, N'Peine                         ', CAST(2.2500 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (43, N'Perfume                       ', CAST(20.0000 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (44, N'Velas                         ', CAST(4.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (45, N'Lámpara                       ', CAST(15.7500 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (47, N'Baterías                      ', CAST(8.9900 AS Decimal(14, 4)), CAST(10.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (48, N'Libreta                       ', CAST(1.5000 AS Decimal(14, 4)), CAST(8.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (49, N'Bolígrafo                     ', CAST(0.9900 AS Decimal(14, 4)), CAST(5.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (50, N'fsdfdssdf                     ', CAST(1.0000 AS Decimal(14, 4)), CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (51, N'fsdfdssdf                     ', CAST(1.0000 AS Decimal(14, 4)), CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (52, N'fsdfdssdf                     ', CAST(1.0000 AS Decimal(14, 4)), CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (53, N'fsdfdssdf                     ', CAST(1.0000 AS Decimal(14, 4)), CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (54, N'sdfsdsfd                      ', CAST(3.0000 AS Decimal(14, 4)), CAST(3.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (57, N'hola mundo                    ', CAST(12.0000 AS Decimal(14, 4)), CAST(200.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (58, N'kola                          ', CAST(1.0000 AS Decimal(14, 4)), CAST(12.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (59, N'dfggd                         ', CAST(1.0000 AS Decimal(14, 4)), CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (65, N'casanuevas2                   ', CAST(10.0000 AS Decimal(14, 4)), CAST(2.00 AS Decimal(5, 2)))
INSERT [dbo].[Producto] ([id_producto], [nombre_producto], [precio_unitario], [iva]) VALUES (66, N'GATORADO                      ', CAST(5.5000 AS Decimal(14, 4)), CAST(15.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [fk_detalle_factura_id_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Factura] ([id_factura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [fk_detalle_factura_id_factura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [fk_detalle_factura_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [fk_detalle_factura_id_producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [fk_factura_id_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [fk_factura_id_cliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[sp_buscar_producto]
@texto_buscar varchar(30)
as 
begin
	Select id_producto, rtrim(nombre_producto) as nombre_producto, precio_unitario, iva
	from Producto
	where rtrim(nombre_producto) like '%' + @texto_buscar + '%' 
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_cliente]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[sp_eliminar_cliente]
	@id_cliente nchar(10),
	@estado tinyint output
as
begin
	begin try 
		Delete from Cliente where id_cliente = @id_cliente;
		set @estado = 0;
	end try
	begin catch
		set @estado = 1;
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_eliminar_producto]
	@id_producto nchar(10),
	@estado tinyint output
as
begin
	begin try 
		Delete from Producto where id_producto = @id_producto;
		set @estado = 0;
	end try
	begin catch
		set @estado = 1;
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_get_cliente]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_get_cliente]
@id_cliente nchar(10)
as
begin
	Select id_cliente, rtrim(apellidos) as apellidos, rtrim(nombres) as nombres
	from Cliente
	where id_cliente = @id_cliente
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_get_producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[sp_get_producto]
@id_producto bigint
as 
begin
	Select id_producto, rtrim(nombre_producto) as nombre_producto, precio_unitario, iva
	from Producto
	where id_producto = @id_producto
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_cliente]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[sp_insertar_cliente]
    @xml_cliente XML,
	@estado tinyint output
AS
BEGIN
    --Declaración de variables
    DECLARE @cedula NCHAR(10), @nombres NCHAR(100), @apellidos NCHAR(100);
	DECLARE @id_factura bigint;
    
    --Asignación de valores del xml a las variables previamente declaradas
    SELECT
        @cedula = Cliente.value('(Id_cliente/text())[1]', 'NCHAR(10)'),
        @nombres = Cliente.value('(Nombres/text())[1]', 'NCHAR(100)'),
        @apellidos = Cliente.value('(Apellidos/text())[1]', 'NCHAR(100)')
    FROM
        @xml_cliente.nodes('Cliente') AS T(Cliente);

    --Verificar que la identificación del cliente sea única
    IF EXISTS(SELECT 1 FROM Cliente WHERE id_cliente = @cedula)
    BEGIN		
        set @estado = 1;
		return;
    END;

    --Insertar los datos del cliente desde el XML
    INSERT INTO Cliente (id_cliente, nombres, apellidos)
    SELECT @cedula, @nombres, @apellidos;

    --Establecer el estado cero que es el que indica que no hay errores
    set @estado = 0;

	--Establecer el id del cliente recién ingresado
	set @id_factura = SCOPE_IDENTITY();

	Select 
		id_cliente as Id_cliente, rtrim(nombres) as Nombres, rtrim(apellidos) as Apellidos
	from Cliente
	where id_cliente = @id_factura;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_factura]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_insertar_factura]
	 @xml_factura XML,
	 @estado tinyint output,
	 @id_factura bigint output
as
begin
	--insertar datos del producto desde XML
	Insert into Factura (id_cliente, subtotal, total, fecha)
	Select
		Factura.value('(Id_cliente/Id_cliente/text())[1]', 'NCHAR(10)') AS id_cliente,
		0 as subtotal,--Factura.value('(Subtotal/text())[1]', 'DECIMAL(14, 4)') AS subtotal,
		0 as total,--Factura.value('(Total/text())[1]', 'DECIMAL(14, 4)') AS as total
		GETDATE()
	from @xml_factura.nodes('Factura') as T(Factura);

	--Obtener el id de la factura ingresada
	set @id_factura = SCOPE_IDENTITY();

	Insert into DetalleFactura (id_factura, id_producto, cantidad)
	Select
		@id_factura,
		Detalle.value('(Producto/Id_producto/text())[1]', 'INT') AS id_producto,
		Detalle.value('(Cantidad/text())[1]', 'DECIMAL(8, 2)') AS cantidad
	from @xml_factura.nodes('Factura/Factura_Detalle/FacturaDetalle') as T(Detalle);
	
	--Estado cero para indicar que no ocurrió ningún error
	set @estado = 0;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_insertar_producto]
	 @xml_producto XML,
	 @estado tinyint output
as
begin
	
	DECLARE @nombre_producto nchar(30), @precio_unitario decimal(14,4), @iva decimal(5,2);
	
	Select
		@nombre_producto=Producto.value('(Nombre_producto/text())[1]', 'NCHAR(30)'),
		@precio_unitario=Producto.value('(Precio_unitario/text())[1]', 'DECIMAL(14,4)'),
		@iva=Producto.value('(Iva/text())[1]', 'DECIMAL(5,2)')
	from @xml_producto.nodes('Producto') as T(Producto);

	if @nombre_producto=''
	begin
		set @estado=1;
		return
	end
	
	if @iva>100
	begin
		set @estado=2;
		return
	end

	--insertar datos del producto desde XML
	Insert into Producto (nombre_producto, precio_unitario,iva)
	values(@nombre_producto,@precio_unitario,@iva)

	set @estado = 0;

end;
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_clientes]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_listar_clientes]
as
begin
	Select c.id_cliente, c.nombres,c.apellidos
	from Cliente as c
	order by c.apellidos, c.nombres
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_facturas]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   procedure [dbo].[sp_listar_facturas]
as
begin
	--Listar los campos requeridos de la tabla Factura
	--en conjunto a los de cliente.
	Select 
		f.id_factura, 
		f.id_cliente, RTRIM(c.apellidos) as apellidos, RTRIM(c.nombres) as nombre,
		f.subtotal, f.total
	from Factura as f
		inner join Cliente as c on f.id_cliente = c.id_cliente
end;

GO
/****** Object:  StoredProcedure [dbo].[sp_listar_productos]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_listar_productos]
as
begin
	Select id_producto, rtrim(nombre_producto)as nombre_producto, precio_unitario, iva
	from Producto
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_cliente]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_modificar_cliente]
	@xml_cliente xml,
	@estado tinyint output
as
begin
	Update Cliente 
	set
		Cliente.apellidos = xc.apellidos,
		Cliente.nombres = xc.nombres
    from
	(
		Select
			Cliente.value('(Id_cliente/text())[1]', 'NCHAR(10)') AS id_cliente,
			Cliente.value('(Nombres/text())[1]', 'NCHAR(100)') AS nombres,
			Cliente.value('(Apellidos/text())[1]', 'NCHAR(100)') AS apellidos
		from
			@xml_cliente.nodes('Cliente') AS T(Cliente)
	) as xc
	where Cliente.id_cliente = xc.id_cliente

	set @estado = 0;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_modificar_producto]
	 @xml_producto XML,
	 @estado tinyint output
as
begin
	--Actualizar datos del producto desde XML

	Update Producto 
	set 
	Producto.nombre_producto = xp.nombreproducto,
	Producto.precio_unitario = xp.preciounitario,
	Producto.iva = xp.iva
	from 
	(
		Select
        Producto.value('(Id_producto/text())[1]', 'BIGINT') AS idproducto,
		Producto.value('(Nombre_producto/text())[1]', 'NCHAR(30)') AS nombreproducto,
		Producto.value('(Precio_unitario/text())[1]', 'DECIMAL(14,4)') AS preciounitario,
		Producto.value('(Iva/text())[1]', 'DECIMAL(5,2)') AS iva
		from  @xml_producto.nodes('Producto') AS T(Producto)

	) as xp
	where Producto.id_producto=xp.idproducto

	set @estado = 0;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_paginacion_buscar_cliente]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_paginacion_buscar_cliente]
@texto_buscar varchar(30),
@numero_pagina int,
@numero_elementos int
as 
begin
	declare @offset int;

	--Validar, si ingresa un número negativo regresar a la primera página
	if @numero_pagina < 1 set @numero_pagina = 1;
	
	--Calcular el número de registros que deben ignorarse
	--Puesto que la cantidad de registros recibidos contiene un elemento adicional
	--Es necesario restar 1 al registro inicial de la paginación
	set @offset = @numero_elementos *  (@numero_pagina - 1) + 
		case when (@numero_pagina - 1) = 0 
			then 0 
			else -(@numero_pagina - 1) 
		end;

	Select c.id_cliente, rtrim(c.apellidos) as apellidos, rtrim(c.nombres) as nombres
	from Cliente as c	
	where rtrim(c.nombres) like '%' + @texto_buscar + '%' 
		or rtrim(c.apellidos) like '%' + @texto_buscar + '%' 
	order by c.apellidos, c.nombres
	--offset (@numero_pagina - 1) * @numero_elementos - 1 rows
	offset @offset rows
	fetch next @numero_elementos rows only;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_paginacion_buscar_facturas]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[sp_paginacion_buscar_facturas]
@numero_pagina int,
@numero_elementos int,
@texto_buscar varchar(30)
as
begin
	declare @offset int;
	
	--Validar, si ingresa un número negativo regresar a la primera página
	if @numero_pagina < 1 set @numero_pagina = 1;

	--Calcular el número de registros que deben ignorarse
	--Puesto que la cantidad de registros recibidos contiene un elemento adicional
	--Es necesario restar 1 al registro inicial de la paginación
	set @offset = @numero_elementos *  (@numero_pagina - 1) + 
		case when (@numero_pagina - 1) = 0 
			then 0 
			else -(@numero_pagina - 1) 
		end;

	Select 
		f.id_factura, 
		f.id_cliente, RTRIM(c.apellidos) as apellidos, RTRIM(c.nombres) as nombre,
		f.subtotal, f.total
	from Factura as f
		inner join Cliente as c on f.id_cliente = c.id_cliente
	where 
		f.id_cliente like '%' + @texto_buscar + '%'
		or c.apellidos like '%' + @texto_buscar + '%'
		or c.nombres like '%' + @texto_buscar + '%'
	order by f.id_factura
	--offset (@numero_pagina - 1) * @numero_elementos rows
	offset @offset rows
	fetch next @numero_elementos rows only;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_paginacion_buscar_producto]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_paginacion_buscar_producto]
@texto_buscar varchar(30),
@numero_pagina int,
@numero_elementos int
as 
begin
	declare @offset int;
	
	--Validar, si ingresa un número negativo regresar a la primera página
	if @numero_pagina < 1 set @numero_pagina = 1;

	--Calcular el número de registros que deben ignorarse
	--Puesto que la cantidad de registros recibidos contiene un elemento adicional
	--Es necesario restar 1 al registro inicial de la paginación
	set @offset = @numero_elementos *  (@numero_pagina - 1) + 
		case when (@numero_pagina - 1) = 0 
			then 0 
			else -(@numero_pagina - 1) 
		end;

	Select id_producto, rtrim(nombre_producto) as nombre_producto, precio_unitario, iva
	from Producto
	where rtrim(nombre_producto) like '%' + @texto_buscar + '%' 
	order by id_producto 
	--offset (@numero_pagina - 1) * @numero_elementos rows
	offset @offset rows
	fetch next @numero_elementos rows only;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_paginacion_listar_clientes]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_paginacion_listar_clientes]
@numero_pagina int,
@numero_elementos int
as
begin
	declare @offset int;

	--Validar, si ingresa un número negativo regresar a la primera página
	if @numero_pagina < 1 set @numero_pagina = 1;
	
	--Calcular el número de registros que deben ignorarse
	--Puesto que la cantidad de registros recibidos contiene un elemento adicional
	--Es necesario restar 1 al registro inicial de la paginación
	set @offset = @numero_elementos *  (@numero_pagina - 1) + 
		case when (@numero_pagina - 1) = 0 
			then 0 
			else -(@numero_pagina - 1) 
		end;

	
	Select c.id_cliente as ID, rtrim(c.apellidos) as Apellidos, rtrim(c.nombres) as Nombres	
	from Cliente as c
	order by c.apellidos, c.nombres
	--offset (@numero_pagina - 1) * @numero_elementos rows
	offset @offset rows
	fetch next @numero_elementos rows only;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_paginacion_listar_facturas]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_paginacion_listar_facturas]
@numero_pagina int,
@numero_elementos int
as
begin
	declare @offset int;
	
	--Validar, si ingresa un número negativo regresar a la primera página
	if @numero_pagina < 1 set @numero_pagina = 1;

	--Calcular el número de registros que deben ignorarse
	--Puesto que la cantidad de registros recibidos contiene un elemento adicional
	--Es necesario restar 1 al registro inicial de la paginación
	set @offset = @numero_elementos *  (@numero_pagina - 1) + 
		case when (@numero_pagina - 1) = 0 
			then 0 
			else -(@numero_pagina - 1) 
		end;

	Select 
		f.id_factura, 
		f.id_cliente, RTRIM(c.apellidos) as apellidos, RTRIM(c.nombres) as nombre,
		f.subtotal, f.total
	from Factura as f
		inner join Cliente as c on f.id_cliente = c.id_cliente
	order by f.id_factura
	--offset (@numero_pagina - 1) * @numero_elementos rows
	offset @offset rows
	fetch next @numero_elementos rows only;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_paginacion_listar_productos]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_paginacion_listar_productos]
@numero_pagina int,
@numero_elementos int
as
begin
	declare @offset int;

	--Validar, si ingresa un número negativo regresar a la primera página
	if @numero_pagina < 1 set @numero_pagina = 1;

	--Calcular el número de registros que deben ignorarse
	--Puesto que la cantidad de registros recibidos contiene un elemento adicional
	--Es necesario restar 1 al registro inicial de la paginación
	set @offset = @numero_elementos *  (@numero_pagina - 1) + 
		case when (@numero_pagina - 1) = 0 
			then 0 
			else -(@numero_pagina - 1) 
		end;

	Select 
		p.id_producto as ID, rtrim(p.nombre_producto) as Nombre,
		p.precio_unitario as Precio_Unitario, p.iva as Iva
	from Producto as p
	order by  p.nombre_producto 
	--offset (@numero_pagina - 1) * @numero_elementos rows
	offset @offset rows
	fetch next @numero_elementos rows only;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_rp_get_factura]    Script Date: 12/06/2024 8:45:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[sp_rp_get_factura]
    @id_factura int
as
begin
    DECLARE @xmlResult XML;

    SET @xmlResult = (
        SELECT 
            --Encabezado de la factura
            (
                SELECT 
                    f.id_factura AS 'Id_factura', 
                    f.id_cliente AS 'Id_cliente', 
                    RTRIM(c.apellidos) as 'Apellidos', 
                    RTRIM(c.nombres) as 'Nombres',
                    convert(date, f.fecha) AS 'Fecha', 
                    convert(decimal, f.subtotal) AS 'Subtotal', 
                    f.total AS 'Total'
                FROM Factura as f
                INNER JOIN Cliente as c ON f.id_cliente = c.id_cliente
                WHERE f.id_factura = @id_factura
                FOR XML PATH('Encabezado'), TYPE
            ),
            --Detalles de la factura
            (
                SELECT
                    df.id_detalle_factura AS 'Id_factura_detalle',
                    df.id_producto AS 'Id_producto',
                    RTRIM(p.nombre_producto) as 'Nombre_producto',
                    df.cantidad AS 'Cantidad',
                    (df.precio_unitario + (df.precio_unitario * df.iva/100)) AS 'Precio',
                    ROUND(df.total, 2) AS 'Total'
                FROM DetalleFactura as df
                INNER JOIN Producto as p ON df.id_producto = p.id_producto
                WHERE df.id_factura = @id_factura
                FOR XML PATH('Detalle'), TYPE, ROOT('Detalle')
            ),
            --Totales agrupados por IVA
            (
                SELECT iva AS 'IVA', SUM(total - subtotal) as 'Total'
                FROM DetalleFactura
                WHERE id_factura = @id_factura
                GROUP BY iva
                FOR XML PATH('DetalleIVA'), TYPE, ROOT('Impuestos')
            )
        FOR XML PATH('Factura'), TYPE, ELEMENTS
    );

    SELECT @xmlResult;
end;
GO
USE [master]
GO
ALTER DATABASE [Facturacion] SET  READ_WRITE 
GO
