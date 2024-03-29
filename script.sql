USE [master]
GO
/****** Object:  Database [sispunto_de_ventas]    Script Date: 6/29/2023 3:00:08 PM ******/
CREATE DATABASE [sispunto_de_ventas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sispunto_de_ventas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\sispunto_de_ventas.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sispunto_de_ventas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\sispunto_de_ventas_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [sispunto_de_ventas] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sispunto_de_ventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sispunto_de_ventas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET ARITHABORT OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [sispunto_de_ventas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sispunto_de_ventas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sispunto_de_ventas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sispunto_de_ventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sispunto_de_ventas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sispunto_de_ventas] SET  MULTI_USER 
GO
ALTER DATABASE [sispunto_de_ventas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sispunto_de_ventas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sispunto_de_ventas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sispunto_de_ventas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [sispunto_de_ventas] SET DELAYED_DURABILITY = DISABLED 
GO
USE [sispunto_de_ventas]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comentario](
	[IdComentario] [int] NOT NULL,
	[IdPublicacion] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Comentario] PRIMARY KEY CLUSTERED 
(
	[IdComentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_almacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_almacen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [decimal](18, 2) NULL,
	[idProducto] [int] NULL,
	[lote] [varchar](50) NULL,
	[Und] [decimal](18, 2) NULL,
 CONSTRAINT [PK_db_almacen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_caja_abierta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_caja_abierta](
	[id_hora] [int] IDENTITY(1,1) NOT NULL,
	[caja_abierta] [varchar](50) NULL,
	[id_usuario] [int] NULL,
	[cierre] [varchar](50) NULL,
 CONSTRAINT [PK_db_caja_abierta] PRIMARY KEY CLUSTERED 
(
	[id_hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_caja_diaria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_caja_diaria](
	[id_cajadiaria] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Hora] [varchar](10) NULL,
	[Tipo_de_movimiento] [varchar](50) NULL,
	[Tipo_Operacion] [varchar](50) NULL,
	[Importe] [decimal](18, 2) NULL,
	[Medio_de_pago] [varchar](50) NULL,
	[Tipo_Moneda] [varchar](50) NULL,
	[Valor_de_Cambio] [decimal](18, 2) NULL,
	[idcajero] [int] NULL,
	[Terminal] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[ganancia] [decimal](18, 2) NULL,
	[id_venta] [int] NULL,
	[cierre] [varchar](50) NULL,
 CONSTRAINT [PK_db_caja_diaria] PRIMARY KEY CLUSTERED 
(
	[id_cajadiaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_categorias]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_db_categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_cierre_de_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_cierre_de_caja](
	[id_cierre_de_caja] [int] IDENTITY(1,1) NOT NULL,
	[dinero_en_caja] [decimal](18, 2) NULL,
	[devoluciones] [int] NULL,
	[fecha] [date] NULL,
	[usuario] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[turno] [varchar](50) NULL,
	[id_usuario] [int] NULL,
	[ventas_del_dia] [decimal](18, 2) NULL,
	[retirados] [decimal](18, 2) NULL,
	[valor_en_efectivo_de_caja] [decimal](18, 2) NULL,
	[total_retirados] [decimal](18, 2) NULL,
	[restante] [varchar](50) NULL,
	[totalGomera] [decimal](18, 2) NULL,
	[totalBar] [decimal](18, 2) NULL,
	[tarjeta] [decimal](18, 2) NULL,
 CONSTRAINT [PK_db_cierre_de_caja] PRIMARY KEY CLUSTERED 
(
	[id_cierre_de_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_clientes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_y_apellido] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](200) NULL,
	[dni] [varchar](50) NULL,
 CONSTRAINT [PK_db_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_combo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_combo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[cantidad] [decimal](18, 2) NULL,
	[verifica] [varchar](50) NULL,
	[idCombo] [int] NULL,
 CONSTRAINT [PK_db_combo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_compras]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_compras](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [decimal](18, 2) NULL,
	[comprobante] [varchar](50) NULL,
	[precio] [decimal](18, 2) NULL,
	[numero_doc] [varchar](50) NULL,
	[proveedor] [varchar](50) NULL,
	[tipo_de_ingreso] [varchar](50) NULL,
	[fecha] [date] NULL,
	[Articulo] [varchar](50) NULL,
	[codigo_de_barra] [varchar](50) NULL,
 CONSTRAINT [PK_db_compras] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_comprobantes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_comprobantes](
	[id_comprobantes] [int] IDENTITY(1,1) NOT NULL,
	[comprobantes] [int] NULL,
 CONSTRAINT [PK_db_comprobantes] PRIMARY KEY CLUSTERED 
(
	[id_comprobantes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_desbloqueo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_desbloqueo](
	[id_pass] [int] NOT NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_db_desbloqueo] PRIMARY KEY CLUSTERED 
(
	[id_pass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_detalle_de_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_detalle_de_venta](
	[id_detalle_de_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NULL,
	[id_producto] [int] NULL,
	[cantidad] [decimal](18, 2) NULL,
	[itbis] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[precio] [decimal](18, 2) NULL,
	[ganancia] [decimal](18, 2) NULL,
	[estado] [varchar](50) NULL,
	[descuento] [decimal](18, 2) NULL,
	[categoria] [varchar](50) NULL,
	[cierre] [varchar](50) NULL,
	[idCajero] [int] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_db_detalle_de_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_de_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_dinero_en_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_dinero_en_caja](
	[id_dinero_en_caja] [int] IDENTITY(1,1) NOT NULL,
	[dinero_en_caja] [decimal](18, 2) NULL,
	[id_usuario] [int] NULL,
 CONSTRAINT [PK_db_dinero_en_caja] PRIMARY KEY CLUSTERED 
(
	[id_dinero_en_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_fondo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_fondo](
	[id_fondo] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[fondo] [decimal](18, 2) NULL,
 CONSTRAINT [PK_db_fondo] PRIMARY KEY CLUSTERED 
(
	[id_fondo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_gastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_gastos](
	[id_gasto] [int] IDENTITY(1,1) NOT NULL,
	[Total_sin_itbis] [decimal](18, 2) NULL,
	[Total_con_itbis] [decimal](18, 2) NULL,
	[Itbis] [decimal](18, 2) NULL,
	[Description] [varchar](50) NULL,
	[fecha] [date] NULL,
	[categoria] [varchar](50) NULL,
 CONSTRAINT [PK_db_gastos] PRIMARY KEY CLUSTERED 
(
	[id_gasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_inventario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_inventario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[cantidad] [int] NULL,
	[diferencia] [varchar](50) NULL,
	[importe] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[flag] [varchar](50) NULL,
	[idInventory] [int] NULL,
 CONSTRAINT [PK_db_inventario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_liquido_cobro]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_liquido_cobro](
	[id_liquido] [int] IDENTITY(1,1) NOT NULL,
	[monto] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[motivo] [varchar](50) NULL,
 CONSTRAINT [PK_db_liquido_cobro] PRIMARY KEY CLUSTERED 
(
	[id_liquido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_permisos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_permisos](
	[id_permisos] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[permiso] [varchar](50) NULL,
 CONSTRAINT [PK_db_permisos] PRIMARY KEY CLUSTERED 
(
	[id_permisos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_producto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Codigo_de_Barra] [varchar](50) NULL,
	[Se_vende_por] [varchar](50) NULL,
	[Precio_de_Compra] [decimal](18, 2) NULL,
	[Precio_de_Venta] [decimal](18, 2) NULL,
	[Precio_Mayoreo] [decimal](18, 2) NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[Punto_de_Reorden] [int] NULL,
	[Fecha_de_Venc] [varchar](50) NULL,
	[imagen] [image] NULL,
	[Ganancia] [decimal](18, 2) NULL,
	[cantidad_por_mayoreo] [decimal](18, 2) NULL,
	[itbis] [decimal](18, 2) NULL,
	[ganacia_por_mayoreo] [decimal](18, 2) NULL,
	[precio_con_descuento] [decimal](18, 2) NULL,
	[activo] [varchar](50) NULL,
 CONSTRAINT [PK_db_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_proveedores]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_o_razon_social] [varchar](50) NULL,
	[tipo_de_documento] [varchar](50) NULL,
	[numero_de_doc] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
 CONSTRAINT [PK_db_proveedores] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_retiros]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_retiros](
	[id_retiros] [int] IDENTITY(1,1) NOT NULL,
	[motivo] [varchar](200) NULL,
	[monto] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[cierre] [varchar](50) NULL,
 CONSTRAINT [PK_db_retiros] PRIMARY KEY CLUSTERED 
(
	[id_retiros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_total]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_total](
	[id_total] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NULL,
	[sub_total] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[cliente] [varchar](50) NULL,
	[descuento] [decimal](18, 2) NULL,
	[descuento_porciento] [varchar](50) NULL,
	[recibido] [decimal](18, 2) NULL,
	[cambio] [decimal](18, 2) NULL,
	[total_de_articulos] [int] NULL,
	[le_atendio] [varchar](50) NULL,
	[hora] [varchar](50) NULL,
	[fecha] [date] NULL,
	[turno] [varchar](50) NULL,
	[rnc_cliente] [varchar](50) NULL,
	[ncf] [varchar](50) NULL,
	[nombre_o_empresa] [varchar](50) NULL,
	[pendiente] [decimal](18, 2) NULL,
	[pagado] [decimal](18, 2) NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_db_total] PRIMARY KEY CLUSTERED 
(
	[id_total] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_total_desde_gastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_total_desde_gastos](
	[idTotal] [int] IDENTITY(1,1) NOT NULL,
	[fechaDesde] [date] NULL,
	[fechaHasta] [date] NULL,
	[TotalSinItbis] [decimal](18, 2) NULL,
	[TotalConItbis] [decimal](18, 2) NULL,
	[sumaDeItbis] [decimal](18, 2) NULL,
 CONSTRAINT [PK_db_total_desde_gastos] PRIMARY KEY CLUSTERED 
(
	[idTotal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_total_inventory]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_total_inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idInventory] [int] NULL,
	[TotalPerdida] [decimal](18, 2) NULL,
	[TotalTienda] [decimal](18, 2) NULL,
	[TotalPorHaber] [decimal](18, 2) NULL,
 CONSTRAINT [PK_db_total_inventory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_ultimo_comprobante]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_ultimo_comprobante](
	[id_ultimo_comprobante] [int] IDENTITY(1,1) NOT NULL,
	[ultimo_comprobante] [int] NULL,
 CONSTRAINT [PK_db_ultimo_comprobante] PRIMARY KEY CLUSTERED 
(
	[id_ultimo_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_usuario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[nombre_de_usuario] [varchar](50) NULL,
	[turno] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[permiso] [varchar](50) NULL,
 CONSTRAINT [PK_db_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[db_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[db_venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK_db_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[db_venta_final]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[db_venta_final](
	[id_venta_final] [int] IDENTITY(1,1) NOT NULL,
	[cliente] [varchar](50) NULL,
	[articulos] [int] NULL,
	[importe] [decimal](18, 2) NULL,
	[documento] [varchar](50) NULL,
	[condicion] [varchar](50) NULL,
	[fecha] [date] NULL,
	[id_venta] [int] NULL,
	[pendiente] [decimal](18, 2) NULL,
	[pagado] [decimal](18, 2) NULL,
	[descuento] [decimal](18, 2) NULL,
 CONSTRAINT [PK_db_venta_final] PRIMARY KEY CLUSTERED 
(
	[id_venta_final] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Publicacion]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Publicacion](
	[IdPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [varchar](1000) NOT NULL,
	[Imagen] [varchar](500) NULL,
 CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED 
(
	[IdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [varchar](10) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Comentario]  WITH NOCHECK ADD  CONSTRAINT [FK_Comentario_Publicacion] FOREIGN KEY([IdPublicacion])
REFERENCES [dbo].[Publicacion] ([IdPublicacion])
GO
ALTER TABLE [dbo].[Comentario] CHECK CONSTRAINT [FK_Comentario_Publicacion]
GO
ALTER TABLE [dbo].[Comentario]  WITH NOCHECK ADD  CONSTRAINT [FK_Comentario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Comentario] CHECK CONSTRAINT [FK_Comentario_Usuario]
GO
ALTER TABLE [dbo].[Publicacion]  WITH NOCHECK ADD  CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[actilizar_todas_las_imagen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actilizar_todas_las_imagen]
@img image
as
update db_producto set imagen=@img






GO
/****** Object:  StoredProcedure [dbo].[actualizar_al_cerrar_hora]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_al_cerrar_hora]
@id_usuario int
as
update db_caja_abierta set cierre='CIERRE DE CAJA' where id_usuario=@id_usuario and cierre='SIN CIERRE'







GO
/****** Object:  StoredProcedure [dbo].[actualizar_cantidad_detalle_de_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_cantidad_detalle_de_venta]
@id_venta int,
@id_producto int,
@cantidad int
as
update db_detalle_de_venta set cantidad=cantidad+@cantidad where id_venta=@id_venta and id_producto=@id_producto








GO
/****** Object:  StoredProcedure [dbo].[actualizar_dinero_en_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_dinero_en_caja]
@id_dinero int,
@dinero decimal(18,2),
@id_usuario int
as
update db_dinero_en_caja set dinero_en_caja=dinero_en_caja+@dinero where id_dinero_en_caja=@id_dinero and id_usuario=@id_usuario









GO
/****** Object:  StoredProcedure [dbo].[actualizar_estado_articulos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_estado_articulos]
@id_venta int
as
update db_detalle_de_venta set estado='VENDIDO' where id_venta=@id_venta









GO
/****** Object:  StoredProcedure [dbo].[actualizar_fondo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_fondo]
@id_usuario int,
@fondo decimal(18,2)
as
update db_fondo set fondo=fondo+@fondo where id_usuario=@id_usuario







GO
/****** Object:  StoredProcedure [dbo].[actualizar_importe_reporte]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_importe_reporte]
@id_venta int,

@pendiente decimal(18,2),
@pagado decimal(18,2)
as
update db_total set pendiente=pendiente-@pendiente , pagado=pagado+@pagado where id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[actualizar_importe_venta_final]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_importe_venta_final]
@id_venta int,
@importe decimal(18,2),
@pendiente decimal(18,2),
@pagado decimal(18,2)
as
update db_venta_final set importe=importe+@importe , pendiente=pendiente-@pendiente,pagado=pagado+@pagado where id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[actualizar_monto_si_existe_el_articulo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_monto_si_existe_el_articulo]
@id_venta int,
@id_producto int,
@precio decimal(18,2),
@importe decimal(18,2),
@cantidad decimal(18,2),
@ganancia decimal(18,2),
@itbis decimal(18,2),
@descuento decimal(18,2)
as
update db_detalle_de_venta set descuento=@descuento, itbis=@itbis,cantidad=cantidad+@cantidad,precio=@precio,total=@importe,ganancia=@ganancia where id_venta=@id_venta and id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[actualizar_precio_de_compra]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_precio_de_compra]
@id_producto int,
@precio_de_compra decimal(18,2)
as
update db_producto set Precio_de_Compra=@precio_de_compra where id_producto=@id_producto






GO
/****** Object:  StoredProcedure [dbo].[actualizar_ultimo_disponible]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_ultimo_disponible]
@id_ultimo_comprobante int,
@ultimo_comprobante int
as
update db_ultimo_comprobante set ultimo_comprobante=@ultimo_comprobante where id_ultimo_comprobante=@id_ultimo_comprobante







GO
/****** Object:  StoredProcedure [dbo].[actualizarAlmacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[actualizarAlmacen]
@id int,
@cantidad decimal(18,2),
@lote varchar(50),
@und decimal(18,2)
as
update  db_almacen set cantidad=@cantidad,lote=@lote,Und=@und where id=@id


GO
/****** Object:  StoredProcedure [dbo].[actualizarComboids]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizarComboids]

@idCombo int
as
update db_combo set idProducto =@idCombo where  idCombo=@idCombo



GO
/****** Object:  StoredProcedure [dbo].[actualizarGasto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizarGasto]
@id_gasto int,
@total_sin_itbis decimal(18,2),
@total_con_itbis decimal(18,2),
@itbis decimal(18,2),
@description varchar(50),
@categoria varchar(50)
as
update db_gastos set Total_con_itbis=@total_con_itbis,Total_sin_itbis=@total_sin_itbis,Itbis=@itbis,Description=@description,categoria=@categoria where id_gasto=@id_gasto






GO
/****** Object:  StoredProcedure [dbo].[anular_ticket]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[anular_ticket]
@id_venta int,
@importe decimal(18,2),
@ganancia decimal(18,2)
as
update db_caja_diaria set ganancia=ganancia-@ganancia,Importe=Importe-@importe,Estado='ANULADO',Tipo_de_movimiento='SALIDA' where id_venta=@id_venta









GO
/****** Object:  StoredProcedure [dbo].[anular_ticket_a_credito]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[anular_ticket_a_credito]
@id_venta int,
@importe decimal(18,2),
@pendiente decimal(18,2),
@pagado decimal(18,2)
as
update db_venta_final set pendiente=pendiente+@pendiente,importe=importe-@importe,pagado=pagado-@pagado where id_venta=@id_venta





GO
/****** Object:  StoredProcedure [dbo].[anular_ticket_a_credito_reporte]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[anular_ticket_a_credito_reporte]
@id_venta int,

@pendiente decimal(18,2),
@pagado decimal(18,2)
as
update db_total set pendiente=pendiente+@pendiente,pagado=pagado-@pagado where id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[anular_ticketCredito]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[anular_ticketCredito]
@id_caja int,
@importe decimal(18,2),
@ganancia decimal(18,2)
as
update db_caja_diaria set ganancia=ganancia-@ganancia,Importe=Importe-@importe,Estado='ANULADO',Tipo_de_movimiento='SALIDA' where id_cajadiaria=@id_caja


GO
/****** Object:  StoredProcedure [dbo].[aumentar_stock]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aumentar_stock]
@id_producto int,
@cantidad decimal(18,2)
as
update db_producto set Cantidad=Cantidad+@cantidad where id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_cliente]
@filtro varchar(200)
as
select id_cliente,nombre_y_apellido as Nombre_y_apellido,telefono as Telefono,dni as DNI from db_clientes where nombre_y_apellido like @filtro +'%' order by id_cliente desc









GO
/****** Object:  StoredProcedure [dbo].[buscar_clientes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_clientes]
@filtro varchar(200)
as
select id_cliente,nombre_y_apellido as Nombre,telefono as Telefono,dni as Dni,direccion as Direccion from db_clientes where nombre_y_apellido like @filtro +'%' order by id_cliente desc









GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_facturas_a_creditos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BUSCAR_facturas_a_creditos]
@FILTRO VARCHAR(50)
as
select id_venta as ID_FACTURA,fecha AS FECHA,cliente as CLIENTE, importe as IMPORTE,documento as TIPO_DE_FACTURA,condicion as CONDICION,pendiente as Pendiente,pagado as Pagado from db_venta_final where condicion='A CREDITO' and id_venta like @FILTRO +'%' order by id_venta_final desc







GO
/****** Object:  StoredProcedure [dbo].[buscar_hostorial_de_compras]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_hostorial_de_compras]
@fecha1 date,
@fecha2 date
as
select id_compra  as No_compra ,Articulo,codigo_de_barra as Codigo_de_barra,cantidad as Cantidad,precio as Importe,proveedor as Proveedor,fecha,tipo_de_ingreso from db_compras where fecha between @fecha1 and @fecha2  order by id_compra desc









GO
/****** Object:  StoredProcedure [dbo].[buscar_hostorial_de_compras_por_codigos_dE_barra]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_hostorial_de_compras_por_codigos_dE_barra]
@fecha1 date,
@fecha2 date,
@filtro varchar(200)
as
select id_compra  as No_compra ,Articulo,codigo_de_barra as Codigo_de_barra,cantidad as Cantidad,precio as Importe,proveedor as Proveedor,fecha,tipo_de_ingreso from db_compras where   fecha<= @fecha1  or fecha >=  @fecha2   and Articulo like @filtro +'%' or codigo_de_barra like @filtro + '%'  order by id_compra desc







GO
/****** Object:  StoredProcedure [dbo].[buscar_productos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_productos]
@filtro varchar(200)
as
select id_producto,Descripcion,Codigo_de_Barra,Categoria,Precio_de_Compra,Precio_de_Venta,Precio_Mayoreo as Precio_al_por_Mayor,cantidad_por_mayoreo as Cantidad_por_Mayoreo,Cantidad as Existencia,Punto_de_Reorden,Fecha_de_Venc as Fecha_de_vencieminto,imagen,Se_vende_por,activo as Estado_descuento,precio_con_descuento as Precio_con_descuento from db_producto where  Descripcion like @filtro +'%'or Codigo_de_Barra like @filtro +'%' order by id_producto desc









GO
/****** Object:  StoredProcedure [dbo].[buscar_productos_en_compras]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_productos_en_compras]
@filtro varchar(200)
as
select id_producto,Descripcion,Codigo_de_Barra,Precio_de_Compra from db_producto where Descripcion like @filtro +'%' or Codigo_de_Barra like @filtro +'%' order by id_producto desc









GO
/****** Object:  StoredProcedure [dbo].[buscar_productos_en_punto_de_reorden]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_productos_en_punto_de_reorden]
@filtro varchar(200)
as
select id_producto,Descripcion,Codigo_de_Barra,Categoria,Precio_de_Compra,Precio_de_Venta,Precio_Mayoreo as Precio_al_por_Mayor,cantidad_por_mayoreo as Cantidad_por_Mayoreo,Cantidad as Existencia,Punto_de_Reorden,Fecha_de_Venc as Fecha_de_vencieminto,imagen,Se_vende_por from db_producto where  Codigo_de_Barra like @filtro +'%'and Punto_de_Reorden>=Cantidad order by id_producto desc










GO
/****** Object:  StoredProcedure [dbo].[buscar_productos_en_punto_de_reorden_por_descripcion]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_productos_en_punto_de_reorden_por_descripcion]
@filtro varchar(200)
as
select id_producto,Descripcion,Codigo_de_Barra,Categoria,Precio_de_Compra,Precio_de_Venta,Precio_Mayoreo as Precio_al_por_Mayor,cantidad_por_mayoreo as Cantidad_por_Mayoreo,Cantidad as Existencia,Punto_de_Reorden,Fecha_de_Venc as Fecha_de_vencieminto,imagen,Se_vende_por from db_producto where  Descripcion like @filtro +'%'and Punto_de_Reorden>=Cantidad  order by id_producto desc










GO
/****** Object:  StoredProcedure [dbo].[buscar_productos_para_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_productos_para_venta]
@filtro varchar(200)
as
select id_producto,Descripcion,Codigo_de_Barra,Cantidad AS Existencia,Precio_de_Venta,Precio_Mayoreo,cantidad_por_mayoreo,Ganancia,Fecha_de_Venc,itbis,precio_con_descuento,activo,Categoria from db_producto where Descripcion like @filtro +'%' or Codigo_de_Barra like @filtro +'%'  order by id_producto desc


GO
/****** Object:  StoredProcedure [dbo].[buscar_proveedores]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_proveedores]
@filtro varchar(200)
as
select id_proveedor as ID,nombre_o_razon_social as Nombre_o_razon_social ,tipo_de_documento as Tipo_de_documento,numero_de_doc as Numero_de_documento,telefono as Telefono from db_proveedores where nombre_o_razon_social like @filtro +'%' order by id_proveedor desc









GO
/****** Object:  StoredProcedure [dbo].[buscar_retiros]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_retiros]
@fecha1 date,
@fecha2 date
as
select  id_retiros as No,motivo as Motivo,monto as Retirado,fecha as Fecha from db_retiros where fecha between @fecha1 and @fecha2 order by id_retiros desc 









GO
/****** Object:  StoredProcedure [dbo].[buscar_ticket]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ticket]
@id_cajero int,
@id_venta int
as
select id_venta as No_ticket,Fecha,Hora,ganancia,Importe,Tipo_Operacion,Tipo_de_movimiento,Terminal,Estado,Medio_de_pago from db_caja_diaria where Tipo_de_movimiento='Ingreso' and Estado='VALIDO'and cierre='SIN CIERRE' and id_venta=@id_venta and idcajero=@id_cajero









GO
/****** Object:  StoredProcedure [dbo].[buscar_usuarios]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_usuarios]
@filtro varchar(200)
as
select id_usuario,usuario as Usuario,nombre_de_usuario as Nombre_y_apellido,turno as Turno,password as Contraseña ,permiso AS Permiso from db_usuario  where nombre_de_usuario like @filtro +'%'  order by id_usuario desc








GO
/****** Object:  StoredProcedure [dbo].[buscar_ventas_final]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_ventas_final]
@filtro varchar(200)
as
select id_venta as ID_FACTURA,fecha AS FECHA,cliente as EMPLEADO, importe as IMPORTE,documento as TIPO_DE_FACTURA,condicion as CONDICION,pendiente as Pendiente,pagado as Pagado,descuento AS Descuento from db_venta_final where id_venta like @filtro +'%' or cliente like @filtro + '%' order by id_venta_final desc





GO
/****** Object:  StoredProcedure [dbo].[buscarEmAlmacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscarEmAlmacen]
@filtro varchar(200)
as
select dbo.db_almacen.idProducto,dbo.db_almacen.id,dbo.db_producto.Descripcion ,dbo.db_almacen.lote as 'Und/Lote'  ,dbo.db_almacen.cantidad as Cantidad,dbo.db_almacen.Und   from db_almacen inner join dbo.db_producto on dbo.db_producto.id_producto= dbo.db_almacen.idProducto where dbo.db_producto.Descripcion  like @filtro +'%'   order by id desc


GO
/****** Object:  StoredProcedure [dbo].[buscaVentasPorFecha]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscaVentasPorFecha]
@fecha1 date,
@fecha2 date
as
select id_venta as ID_FACTURA,fecha AS FECHA,cliente as EMPLEADO, importe as IMPORTE,documento as TIPO_DE_FACTURA,condicion as CONDICION,pendiente as Pendiente,pagado as Pagado,descuento AS Descuento from db_venta_final where fecha between @fecha1 and @fecha2 order by id_venta_final desc


GO
/****** Object:  StoredProcedure [dbo].[cambiar_password_admin]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cambiar_password_admin]
@id_pass int,
@password varchar(50)
as
update db_desbloqueo set password=@password where id_pass=@id_pass







GO
/****** Object:  StoredProcedure [dbo].[cerrar_turno_caja_diaria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cerrar_turno_caja_diaria]
@id_usuario int
as
update db_caja_diaria set cierre='CIERRE DE CAJA' where cierre='SIN CIERRE' and idcajero=@id_usuario









GO
/****** Object:  StoredProcedure [dbo].[cerrarCajaDiaria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cerrarCajaDiaria]
as
update db_caja_diaria set cierre='CIERRE DE CAJA' where cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[compras_de_la_semana]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[compras_de_la_semana]
as
select sum(precio) as total_compras from db_compras where DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=7 









GO
/****** Object:  StoredProcedure [dbo].[compras_de_la_semana_desde]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[compras_de_la_semana_desde]
@fecha1 date,
@fecha2 date
as
select sum(precio) as compreas_desde from db_compras where fecha between @fecha1 and @fecha2









GO
/****** Object:  StoredProcedure [dbo].[compras_del_mes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[compras_del_mes]
as
select sum(precio) as total_compras_del_mes from db_compras where DATEDIFF(day,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=30









GO
/****** Object:  StoredProcedure [dbo].[desbloquear]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[desbloquear]
@pass varchar(50)
as
select id_pass,password from db_desbloqueo where password=@pass








GO
/****** Object:  StoredProcedure [dbo].[devoluciones]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[devoluciones]
@id_cajero int
as
select count(*) as devoluciones_del_dia from db_caja_diaria where Tipo_de_movimiento='SALIDA' and Estado='ANULADO' and cierre='SIN CIERRE' and idcajero=@id_cajero









GO
/****** Object:  StoredProcedure [dbo].[dinero_de_ventas_del_dia]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[dinero_de_ventas_del_dia]
@id_cajero int
as
select sum(Importe) as ventas_del_dia from db_caja_diaria where Tipo_de_movimiento='Ingreso' and Estado='VALIDO' and cierre='SIN CIERRE' and idcajero=@id_cajero










GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_stock]
@id_producto int,
@cantidad decimal(18,2)
as
update db_producto set Cantidad=Cantidad-@cantidad where id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_cliente]
@id_cliente int,
@nombre_y_apellido varchar(50),
@dni varchar(50),
@telefoo varchar(50),
@direccion varchar(200)
as
update db_clientes set nombre_y_apellido=@nombre_y_apellido,dni=@dni,telefono=@telefoo,direccion=@direccion where id_cliente=@id_cliente









GO
/****** Object:  StoredProcedure [dbo].[editar_producto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_producto]
@id_producto int,
@description varchar(50),
@categoria varchar(50),
@codigo_de_barra varchar(50),
@se_vende_por varchar(50),
@precio_de_compra decimal(18,2),
@precio_de_venta decimal(18,2),
@precio_mayoreo decimal(18,2),
@cantidad decimal(18,2),
@punto_de_reorden int,
@fecha_de_venc varchar(50),
@ganancia decimal(18,2),
@cantidad_por_mayoreo decimal(18,2),
@imgagen image,
@itbis decimal(18,2),
@ganancia_por_mayor decimal(18,2),
@precio_con_descuento decimal(18,2),
@activo varchar(50)
as
update db_producto set activo=@activo,precio_con_descuento=@precio_con_descuento,ganacia_por_mayoreo=@ganancia_por_mayor, itbis=@itbis, imagen=@imgagen,Descripcion=@description,Categoria=@categoria,Codigo_de_Barra=@codigo_de_barra,Se_vende_por=@se_vende_por,Precio_de_Compra=@precio_de_compra,Precio_de_Venta=@precio_de_venta,Precio_Mayoreo=@precio_mayoreo,Cantidad=@cantidad,Punto_de_Reorden=@punto_de_reorden,Fecha_de_Venc=@fecha_de_venc,Ganancia=@ganancia,cantidad_por_mayoreo=@cantidad_por_mayoreo where id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[editar_proveedor]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_proveedor]
@id_proveedor int,
@nombre_o_razon_social varchar(50),
@tipo_de_documento varchar(50),
@numero_de_doc varchar(50),
@telefono varchar(50)
as
update db_proveedores set nombre_o_razon_social=@nombre_o_razon_social,tipo_de_documento=@tipo_de_documento,numero_de_doc=@numero_de_doc,telefono=@telefono where id_proveedor=@id_proveedor









GO
/****** Object:  StoredProcedure [dbo].[editar_usaurio]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_usaurio]
@id_usuario int,
@usuario varchar(50),
@nombre_y_apellido varchar(50),
@turno varchar(50),
@password varchar(50),
@permiso varchar(50)
as
update db_usuario set nombre_de_usuario=@nombre_y_apellido,usuario=@usuario,turno=@turno,password=@password,permiso=@permiso where id_usuario=@id_usuario







GO
/****** Object:  StoredProcedure [dbo].[elimiarComboSelecion]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[elimiarComboSelecion]
@id int
as
delete from db_combo where id=@id



GO
/****** Object:  StoredProcedure [dbo].[eliminar_articulo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_articulo]
@id_detalle_de_venta int
as
delete from db_detalle_de_venta where id_detalle_de_venta=@id_detalle_de_venta









GO
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_categoria]
@id_categoria int
as
delete from db_categorias where id_categoria=@id_categoria









GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_cliente]
@id_cliente int
as
delete from db_clientes where id_cliente=@id_cliente









GO
/****** Object:  StoredProcedure [dbo].[eliminar_compra]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_compra]
@id_compra int
as
delete from db_compras where id_compra=@id_compra






GO
/****** Object:  StoredProcedure [dbo].[eliminar_comprobante_usado]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_comprobante_usado]
@combrobante int
as
delete from db_comprobantes where comprobantes=@combrobante







GO
/****** Object:  StoredProcedure [dbo].[eliminar_gasto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_gasto]
@id_gasto integer
as
delete from db_gastos where id_gasto=@id_gasto






GO
/****** Object:  StoredProcedure [dbo].[eliminar_permiso]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_permiso]
@id_usuario int,
@id_permiso int
as
delete from db_permisos where id_permisos=@id_permiso and id_usuario=@id_usuario






GO
/****** Object:  StoredProcedure [dbo].[eliminar_prodcuto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_prodcuto] 
@id_producto int
as
delete from db_producto where id_producto =@id_producto









GO
/****** Object:  StoredProcedure [dbo].[eliminar_proveedor]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_proveedor]
@id_proveedor int
as
delete from db_proveedores where id_proveedor =@id_proveedor









GO
/****** Object:  StoredProcedure [dbo].[eliminar_todos_los_articulos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_todos_los_articulos]
@id_venta int
as
delete from db_detalle_de_venta where id_venta=@id_venta









GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_venta]
@id_venta int
as
delete from db_venta_final where id_venta=@id_venta









GO
/****** Object:  StoredProcedure [dbo].[eliminarComboPorIdCombo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarComboPorIdCombo]
@idCombo int
as
delete from db_combo where idCombo=@idCombo



GO
/****** Object:  StoredProcedure [dbo].[eliminardeAlmacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminardeAlmacen]
@id int
as
delete from db_almacen where id=@id


GO
/****** Object:  StoredProcedure [dbo].[eliminarProducto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminarProducto]
@idProducto int
as
delete from db_combo where idCombo=@idProducto and verifica='no'



GO
/****** Object:  StoredProcedure [dbo].[ganancia_al_por_mayor]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ganancia_al_por_mayor]
@id_producto int
as
select Ganancia,ganacia_por_mayoreo from db_producto where id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[ganancias_de_la_semana]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ganancias_de_la_semana]
as
select sum(ganancia) as total_ganancias_de_la_Semana from db_caja_diaria where DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=7









GO
/****** Object:  StoredProcedure [dbo].[ganancias_del_dia]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ganancias_del_dia]
@id_cajero int
as
select sum(ganancia) as ganancias_del_dia from db_caja_diaria where Tipo_de_movimiento='Ingreso' and Estado='VALIDO' and cierre='SIN CIERRE' and idcajero=@id_cajero









GO
/****** Object:  StoredProcedure [dbo].[ganancias_del_mes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ganancias_del_mes]
as
select sum(ganancia) as total_ganancias_del_mes from db_caja_diaria where DATEDIFF(day,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=30









GO
/****** Object:  StoredProcedure [dbo].[gananciaS_desde]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gananciaS_desde]
@fecha1 date,
@fecha2 date
as
select sum(ganancia) as ganancias_desde from db_caja_diaria where fecha between @fecha1 and @fecha2 and Estado='VALIDO'









GO
/****** Object:  StoredProcedure [dbo].[getProdByCount]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getProdByCount]
@idProducto int
as
select * from db_inventario where idProducto=@idProducto and flag='active'


GO
/****** Object:  StoredProcedure [dbo].[getProdById]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getProdById]
@idProd int
as
select Cantidad,Precio_de_Compra from db_producto where id_producto=@idProd


GO
/****** Object:  StoredProcedure [dbo].[id_de_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[id_de_venta]
as
select id_venta from db_venta









GO
/****** Object:  StoredProcedure [dbo].[iniciar_sesion]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[iniciar_sesion]
@passworrd varchar(50),
@usuario varchar(50)
as
select  usuario,id_usuario,nombre_de_usuario,turno,password,permiso from db_usuario where password=@passworrd and usuario=@usuario









GO
/****** Object:  StoredProcedure [dbo].[inserta_usaurio]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[inserta_usaurio]
@usuario varchar(50),
@nombre_y_apellido varchar(50),
@turno varchar(50),
@password varchar(50),
@permiso varchar(50)
as
insert into db_usuario(usuario,nombre_de_usuario,turno,password,permiso)values(@usuario,@nombre_y_apellido,@turno,@password,@permiso)







GO
/****** Object:  StoredProcedure [dbo].[insertar_caja_diaria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_caja_diaria]
@fecha date,
@hora varchar(50),
@tipo_de_movimineto varchar(50),
@tipo_oprecion varchar(50),
@importe decimal(18,2),
@medio_de_pago varchar(50),
@tipo_de_moneta varchar(50),
@valor_de_cambio decimal(18,2),
@id_cajero int,
@terminal varchar(50),
@estado varchar(50),
@ganancia decimal(18,2),
@id_venta int,
@cierre varchar(50)
as
insert into db_caja_diaria(Fecha,Hora,Tipo_de_movimiento,Tipo_Operacion,Importe,Medio_de_pago,Tipo_Moneda,Valor_de_Cambio,idcajero,Terminal,Estado,ganancia,id_venta,cierre) values(@fecha,@hora,@tipo_de_movimineto,@tipo_oprecion,@importe,@medio_de_pago,@tipo_de_moneta,@valor_de_cambio,@id_cajero,@terminal,@estado,@ganancia,@id_venta,@cierre)









GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_categoria]
@nombre varchar(50)
as
insert into db_categorias(nombre) values(@nombre)









GO
/****** Object:  StoredProcedure [dbo].[insertar_cierre_de_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_cierre_de_caja]
@dinero_en_caja decimal(18,2),
@devoluciones int,
@fecha date,
@usuario varchar(50),
@hora varchar(50),
@turno varchar(50),
@id_usuario int,
@retirados decimal(18,2),
@total_ventas_del_dia decimal(18,2),
@valor_en_efectivo_de_la_caja decimal(18,2),
@total_retirados decimal(18,2),
@restante varchar(50),
@totalBar decimal(18,2),
@totalGomera decimal(18,2),
@tarjeta decimal(18,2)
as
insert into db_cierre_de_caja(dinero_en_caja,devoluciones,fecha,usuario,hora,turno,id_usuario,retirados,ventas_del_dia,valor_en_efectivo_de_caja,total_retirados,restante,totalBar,totalGomera,tarjeta)values(@dinero_en_caja,@devoluciones,@fecha,@usuario,@hora,@turno,@id_usuario,@retirados,@total_ventas_del_dia,@valor_en_efectivo_de_la_caja,@total_retirados,@restante,@totalBar,@totalGomera,@tarjeta)






GO
/****** Object:  StoredProcedure [dbo].[insertar_clientes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_clientes]
@nombre_y_apellido varchar(50),
@dni varchar(50),
@telefoo varchar(50),
@direccion varchar(200)
as
insert into db_clientes(nombre_y_apellido,dni,telefono,direccion)values(@nombre_y_apellido,@dni,@telefoo,@direccion)









GO
/****** Object:  StoredProcedure [dbo].[insertar_compra]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_compra]
@cantida decimal(18,2),
@comprobante varchar(50),
@precio decimal(18,2),
@numero_doc varchar(50),
@proveedor varchar(50),
@tipo_de_ingreso varchar(50),
@fecha date,
@articulo varchar(50),
@codigo_de_barra varchar(50)

as
insert into db_compras(cantidad,comprobante,precio,numero_doc,proveedor,tipo_de_ingreso,fecha,Articulo,codigo_de_barra)values(@cantida,@comprobante,@precio,@numero_doc,@proveedor,@tipo_de_ingreso,@fecha,@articulo,@codigo_de_barra)








GO
/****** Object:  StoredProcedure [dbo].[insertar_comprobantes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_comprobantes]
@numero_de_comprobante int
as
insert into db_comprobantes(comprobantes)values(@numero_de_comprobante)







GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_de_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detalle_de_venta]
@id_venta int,
@id_producto int,
@cantidad decimal(18,2),
@itbis decimal(18,2),
@total decimal(18,2),
@precio decimal(18,2),
@ganancia decimal(18,2),
@estado varchar(50),
@descuento decimal(18,2),
@categoria varchar(50),
@idCajero int,
@fecha date

as
insert into db_detalle_de_venta(id_venta,id_producto,cantidad,itbis,total,precio,ganancia,estado,descuento,categoria,cierre,idCajero,fecha) values(@id_venta,@id_producto,@cantidad,@itbis,@total,@precio,@ganancia,@estado,@descuento,@categoria,'SIN CIERRE',@idCajero,@fecha)



GO
/****** Object:  StoredProcedure [dbo].[insertar_dinero_en_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_dinero_en_caja]
@dinero decimal(18,2),
@id_usuario int
as
insert into db_dinero_en_caja(dinero_en_caja,id_usuario)values(@dinero,@id_usuario)









GO
/****** Object:  StoredProcedure [dbo].[insertar_fondo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_fondo]
@id_usuario int,
@fondo decimal(18,2)
as
insert into db_fondo(fondo,id_usuario)values(@fondo,@id_usuario)







GO
/****** Object:  StoredProcedure [dbo].[insertar_gastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_gastos]
@total_sin_itbis decimal(18,2),
@total_con_itbis decimal(18,2),
@itbis decimal(18,2),
@description varchar(50),
@fecha date,
@categoria varchar(50)
as
insert into db_gastos(Total_sin_itbis,Total_con_itbis,Itbis,Description,fecha,categoria)values(@total_sin_itbis,@total_con_itbis,@itbis,@description,@fecha,@categoria)






GO
/****** Object:  StoredProcedure [dbo].[insertar_hora_caja_abierta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_hora_caja_abierta]
@id_usuario int,
@caja_abierta varchar(50)
as
insert into db_caja_abierta(id_usuario,cierre,caja_abierta)values(@id_usuario,'SIN CIERRE',@caja_abierta)







GO
/****** Object:  StoredProcedure [dbo].[insertar_liquido]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_liquido]
@fecha date,
@monto decimal(18,2),
@motivo varchar(50)
as
insert into db_liquido_cobro(fecha,monto,motivo)values(@fecha,@monto,@motivo)








GO
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_producto]
@description varchar(50),
@categoria varchar (50),
@codigo_de_barra varchar(50),
@se_vende_por varchar(50),
@precio_de_compra decimal(18,2),
@precio_de_venta decimal(18,2),
@precio_mayoreo decimal(18,2),
@cantidad decimal(18,2),
@punto_de_reorden int,
@fecha_de_venc varchar(50),
@imgagen image,
@ganancia decimal(18,2),
@cantidad_por_mayoreo decimal(18,2),
@itbis decimal(18,2),
@ganancia_al_por_mayor decimal(18,2),
@precio_con_descuento decimal(18,2),
@descuento_activo varchar(50)
as
insert into db_producto(Descripcion,Categoria,Codigo_de_Barra,Se_vende_por,Precio_de_Compra,Precio_de_Venta,Precio_Mayoreo,Cantidad,Punto_de_Reorden,Fecha_de_Venc,Ganancia,cantidad_por_mayoreo,imagen,itbis,ganacia_por_mayoreo,precio_con_descuento,activo)values(@description,@categoria,@codigo_de_barra,@se_vende_por,@precio_de_compra,@precio_de_venta,@precio_mayoreo,@cantidad,@punto_de_reorden,@fecha_de_venc,@ganancia,@cantidad_por_mayoreo,@imgagen,@itbis,@ganancia_al_por_mayor,@precio_con_descuento,@descuento_activo)








GO
/****** Object:  StoredProcedure [dbo].[insertar_proveedores]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_proveedores]
@nombre_o_razon_social varchar(50),
@tipo_de_documento varchar(50),
@numero_de_doc varchar(50),
@telefono varchar(50)
as
insert into db_proveedores(nombre_o_razon_social,tipo_de_documento,numero_de_doc,telefono)values(@nombre_o_razon_social,@tipo_de_documento,@numero_de_doc,@telefono)









GO
/****** Object:  StoredProcedure [dbo].[insertar_retiro]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_retiro]
@motivo varchar(200),
@retiro decimal(18,2),
@fecha date
as
insert into db_retiros(motivo,monto,fecha,cierre)values(@motivo,@retiro,@fecha,'SIN CIERRE')









GO
/****** Object:  StoredProcedure [dbo].[insertar_total]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_total]
@id_venta int,
@sub_total decimal(18,2),
@total decimal(18,2),
@cliente varchar(50),
@descuento decimal(18,2),
@descuento_por_siento varchar(50),
@recibido decimal(18,2),
@cambio decimal(18,2),
@total_de_articulos int,
@le_atendio varchar(50),
@fecha date,
@hora varchar(50),
@turno varchar(50),
@rnc_cliente varchar(50),
@ncf varchar(50),
@nombre_o_empresa varchar(50),
@pendiente decimal(18,2),
@pagado decimal(18,2),
@tipo varchar(50)
as
insert into db_total (id_venta,sub_total,total,cliente,descuento,descuento_porciento,recibido,cambio,total_de_articulos,le_atendio,fecha,hora,turno,rnc_cliente,ncf,nombre_o_empresa,pendiente,pagado,tipo) values(@id_venta,@sub_total,@total,@cliente,@descuento,@descuento_por_siento,@recibido,@cambio,@total_de_articulos,@le_atendio,@fecha,@hora,@turno,@rnc_cliente,@ncf,@nombre_o_empresa,@pendiente,@pagado,@tipo)







GO
/****** Object:  StoredProcedure [dbo].[insertar_ultimo_comprobante]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_ultimo_comprobante]
@numero_de_ultimo_comprobante int
as
insert into db_ultimo_comprobante(ultimo_comprobante)values(@numero_de_ultimo_comprobante)







GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_venta]
@fecha date
as
insert into db_venta(fecha) values(@fecha)









GO
/****** Object:  StoredProcedure [dbo].[insertar_venta_final]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_venta_final]
@cliente varchar(50),
@articulos int,
@importe decimal(18,2),
@documento varchar(50),
@descuento decimal(18,2),
@condicion varchar(50),
@fecha date,
@id_venta int,
@pendiente decimal(18,2),
@pagado decimal(18,2)
as
insert into db_venta_final(cliente,articulos,importe,documento,descuento,condicion,fecha,id_venta,pendiente,pagado)values(@cliente,@articulos,@importe,@documento,@descuento,@condicion,@fecha,@id_venta,@pendiente,@pagado)







GO
/****** Object:  StoredProcedure [dbo].[insertar_venta_llenar_tabla]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_venta_llenar_tabla]
@cliente varchar(50),
@articulos int,
@importe decimal(18,2),
@documento varchar(50),
@descuento decimal(18,2),
@condicion varchar(50),
@fecha date,
@id_venta int
as
insert into db_venta_final(cliente,articulos,importe,documento,descuento,condicion,fecha,id_venta)values(@cliente,@articulos,@importe,@documento,@descuento,@condicion,@fecha,@id_venta)







GO
/****** Object:  StoredProcedure [dbo].[insertarAlmacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarAlmacen]
@cantidad decimal(18,2),
@idProducto int,
@lote varchar(50),
@und decimal(18,2)
as
insert into  db_almacen(cantidad,idProducto,lote,Und)values(@cantidad,@idProducto,@lote,@und)


GO
/****** Object:  StoredProcedure [dbo].[insertarCombo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarCombo]
@idProducto int,
@cantidad decimal(18,2),
@idCombo int
as
insert into db_combo(idProducto,cantidad,verifica,idCombo) values(@idProducto,@cantidad,'no',@idCombo)



GO
/****** Object:  StoredProcedure [dbo].[insertarInventario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarInventario]
@idProducto int,
@cantidad int,
@diferencia varchar(50),
@importe decimal(18,2),
@total decimal(18,2),
@idInventory decimal(18,2)
as
insert into db_inventario (idProducto,cantidad,diferencia,importe,total,idInventory,flag) values (@idProducto,@cantidad,@diferencia,@importe,@total,@idInventory,'active')


GO
/****** Object:  StoredProcedure [dbo].[insertarTotal]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarTotal]
@idInventory int,
@totalPerdida decimal(18,2),
@totalTienda decimal(18,2),
@totalPorHaber decimal(18,2)
as
insert into db_total_inventory(idInventory,TotalPerdida,TotalTienda,TotalPorHaber)values(@idInventory,@totalPerdida,@totalTienda,@totalPorHaber)


GO
/****** Object:  StoredProcedure [dbo].[insertarTotalSumaGastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarTotalSumaGastos]
@fechadesde date,
@fechaHasta date,
@totalSinItbis decimal(18,2),
@totalConitbis decimal(18,2),
@sumaDeitbis decimal(18,2)
as
insert into db_total_desde_gastos values(@fechadesde,@fechaHasta,@totalSinItbis,@totalConitbis,@sumaDeitbis)






GO
/****** Object:  StoredProcedure [dbo].[InventoryClose]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InventoryClose]
as
update db_inventario set flag='inactive' where flag='active'


GO
/****** Object:  StoredProcedure [dbo].[listar_cierre_de_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listar_cierre_de_caja]
as
select id_cierre_de_caja from db_cierre_de_caja 









GO
/****** Object:  StoredProcedure [dbo].[mantenimiento_desde_fechas]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mantenimiento_desde_fechas]
@fecha1 date,
@fecha2 date
as
select sum(monto) as MANTENIMINETO from db_liquido_cobro where motivo='MANTENIMIENTO' and fecha between @fecha1 and @fecha2








GO
/****** Object:  StoredProcedure [dbo].[monto_negativo_en_positivo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[monto_negativo_en_positivo]
as
update db_dinero_en_caja set dinero_en_caja=0 where dinero_en_caja<=-1








GO
/****** Object:  StoredProcedure [dbo].[mostraCaja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[mostraCaja]
@idVenta int
as
select ganancia,Importe,id_cajadiaria from db_caja_diaria where id_venta=@idVenta


GO
/****** Object:  StoredProcedure [dbo].[mostrar_articulos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_articulos]
@id_venta int
as
select dbo.db_detalle_de_venta.id_detalle_de_venta,dbo.db_producto.Descripcion,dbo.db_detalle_de_venta.precio as Precio,dbo.db_detalle_de_venta.cantidad as Cantidad,dbo.db_detalle_de_venta.itbis as ITBIS,dbo.db_detalle_de_venta.total as Total,dbo.db_detalle_de_venta.id_producto,dbo.db_detalle_de_venta.ganancia,dbo.db_detalle_de_venta.descuento,dbo.db_detalle_de_venta.categoria from db_detalle_de_venta inner join dbo.db_producto on dbo.db_detalle_de_venta.id_producto=dbo.db_producto.id_producto where id_venta=@id_venta








GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_categoria]
as
select id_categoria as ID,nombre as Categoria from db_categorias order by id_categoria desc









GO
/****** Object:  StoredProcedure [dbo].[mostrar_cobro_liquido_o_mantenimiento]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_cobro_liquido_o_mantenimiento]
as
select id_liquido,monto,fecha from db_liquido_cobro







GO
/****** Object:  StoredProcedure [dbo].[mostrar_dinero_en_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_dinero_en_caja]
@id_usaurio int
as
select id_dinero_en_caja,dinero_en_caja from db_dinero_en_caja where id_usuario=@id_usaurio









GO
/****** Object:  StoredProcedure [dbo].[mostrar_facturas_a_creditos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_facturas_a_creditos]
as
select id_venta as ID_FACTURA,fecha AS FECHA,cliente as CLIENTE, importe as IMPORTE,documento as TIPO_DE_FACTURA,condicion as CONDICION,pendiente as Pendiente,pagado as Pagado from db_venta_final where condicion='A CREDITO' order by id_venta_final desc







GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_gastos]
as
select id_gasto,Description,fecha,Total_con_itbis,Total_sin_itbis,Itbis from db_gastos order by id_gasto desc






GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_fecha]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_gastos_por_fecha]
@fecha1 date,
@fecha2 date
as
select id_gasto,Description,fecha,Total_con_itbis,Total_sin_itbis,Itbis from db_gastos where fecha between @fecha1 and @fecha2






GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_fechaConCategoria]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_gastos_por_fechaConCategoria]
@fecha1 date,
@fecha2 date,
@categoria varchar(50)
as
select id_gasto,Description,fecha,Total_con_itbis,Total_sin_itbis,Itbis from db_gastos where fecha between @fecha1 and @fecha2 and categoria=@categoria



GO
/****** Object:  StoredProcedure [dbo].[mostrar_hostorial_de_compras]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_hostorial_de_compras]
as
select id_compra  as No_compra ,Articulo,codigo_de_barra as Codigo_de_barra,cantidad as Cantidad,precio as Importe,proveedor as Proveedor,fecha,tipo_de_ingreso from db_compras order by id_compra desc









GO
/****** Object:  StoredProcedure [dbo].[mostrar_listado_ingreso_del_dia]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_listado_ingreso_del_dia]
@id_cajero int
as
select Fecha,Hora,Importe,Tipo_Operacion,Tipo_de_movimiento,Terminal,Estado from db_caja_diaria where  cierre='SIN CIERRE' and idcajero=@id_cajero









GO
/****** Object:  StoredProcedure [dbo].[mostrar_precio_de_compra]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_precio_de_compra]
@id_producto int
as
select precio_con_descuento,Precio_de_Compra from db_producto where id_producto=@id_producto







GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos]
as
select id_producto,Descripcion,Codigo_de_Barra,Categoria,Precio_de_Compra,Precio_de_Venta,Precio_Mayoreo as Precio_al_por_Mayor,cantidad_por_mayoreo as Cantidad_por_Mayoreo,Cantidad as Existencia,Punto_de_Reorden,Fecha_de_Venc as Fecha_de_vencieminto,imagen,Se_vende_por,activo as Estado_descuento,precio_con_descuento as Precio_con_descuento from db_producto order by id_producto desc









GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_en_punto_de_reorden]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_productos_en_punto_de_reorden]
as
select id_producto,Descripcion,Codigo_de_Barra,Categoria,Precio_de_Compra,Precio_de_Venta,Precio_Mayoreo as Precio_al_por_Mayor,cantidad_por_mayoreo as Cantidad_por_Mayoreo,Cantidad as Existencia,Punto_de_Reorden,Fecha_de_Venc as Fecha_de_vencieminto,imagen,Se_vende_por from db_producto where Punto_de_Reorden>=Cantidad order by id_producto desc









GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_para_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_productos_para_venta]
as
select id_producto,Descripcion,Codigo_de_Barra,Cantidad as Existencia,Precio_de_Venta,Precio_Mayoreo,cantidad_por_mayoreo,Ganancia,Fecha_de_Venc,itbis,precio_con_descuento,activo,Categoria from db_producto order by id_producto desc





GO
/****** Object:  StoredProcedure [dbo].[mostrar_proveedores]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_proveedores]
as
select id_proveedor as ID,nombre_o_razon_social as Nombre_o_razon_social ,tipo_de_documento as Tipo_de_documento,numero_de_doc as Numero_de_documento,telefono as Telefono from db_proveedores order by id_proveedor desc









GO
/****** Object:  StoredProcedure [dbo].[mostrar_reporte_cotizacion]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_reporte_cotizacion]
@id_venta int
as
select dbo.db_total.tipo,dbo.db_total.id_venta,dbo.db_total.turno,dbo.db_total.fecha,dbo.db_total.hora,dbo.db_total.le_atendio,dbo.db_total.total_de_articulos,dbo.db_total.cliente,dbo.db_total.total as Total_cuenta,dbo.db_total.sub_total,dbo.db_total.id_venta,dbo.db_detalle_de_venta.cantidad,dbo.db_detalle_de_venta.itbis,dbo.db_detalle_de_venta.precio,dbo.db_detalle_de_venta.total,dbo.db_producto.Descripcion from db_total inner join dbo.db_detalle_de_venta on dbo.db_total.id_venta=dbo.db_detalle_de_venta.id_venta inner join dbo.db_producto on dbo.db_producto.id_producto=dbo.db_detalle_de_venta.id_producto where dbo.db_detalle_de_venta.id_venta=@id_venta






GO
/****** Object:  StoredProcedure [dbo].[mostrar_reporte_desde_hasta_gastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_reporte_desde_hasta_gastos]
@id_desde int,
@fecha_desde date,
@fecha_hasta date
as
select db_gastos.Description,db_gastos.fecha,db_gastos.Itbis,db_gastos.Total_con_itbis,db_gastos.Total_sin_itbis,db_total_desde_gastos.fechaDesde,db_total_desde_gastos.fechaHasta,db_total_desde_gastos.fechaHasta,db_total_desde_gastos.sumaDeItbis,db_total_desde_gastos.TotalConItbis,db_total_desde_gastos.TotalSinItbis from db_gastos inner join db_total_desde_gastos on db_total_desde_gastos.idTotal=@id_desde where fecha between @fecha_desde and @fecha_hasta






GO
/****** Object:  StoredProcedure [dbo].[mostrar_reporte_retiros]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_reporte_retiros]
@id_reporte int
as
select id_retiros,motivo,monto,fecha from db_retiros where id_retiros=@id_reporte








GO
/****** Object:  StoredProcedure [dbo].[mostrar_reporte_venta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_reporte_venta]
@id_venta int
as
select dbo.db_total.tipo,dbo.db_total.rnc_cliente,dbo.db_total.ncf,dbo.db_total.nombre_o_empresa,dbo.db_total.id_venta,dbo.db_total.turno,dbo.db_total.fecha,dbo.db_total.hora,dbo.db_total.le_atendio,dbo.db_total.total_de_articulos,dbo.db_total.cambio,dbo.db_total.recibido,dbo.db_total.descuento_porciento,dbo.db_total.descuento,dbo.db_total.cliente,dbo.db_total.total,dbo.db_total.sub_total,dbo.db_total.id_venta,dbo.db_detalle_de_venta.cantidad,dbo.db_detalle_de_venta.itbis,dbo.db_detalle_de_venta.precio,dbo.db_detalle_de_venta.total,dbo.db_producto.Descripcion from db_total inner join dbo.db_detalle_de_venta on dbo.db_total.id_venta=dbo.db_detalle_de_venta.id_venta inner join dbo.db_producto on dbo.db_producto.id_producto=dbo.db_detalle_de_venta.id_producto where dbo.db_detalle_de_venta.id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[mostrar_reporte_venta_a_creditos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_reporte_venta_a_creditos]
@id_venta int
as
select dbo.db_total.rnc_cliente,dbo.db_total.ncf,dbo.db_total.nombre_o_empresa,dbo.db_total.id_venta,dbo.db_total.turno,dbo.db_total.fecha,dbo.db_total.hora,dbo.db_total.le_atendio,dbo.db_total.total_de_articulos,dbo.db_total.cambio,dbo.db_total.recibido,dbo.db_total.descuento_porciento,dbo.db_total.descuento,dbo.db_total.cliente,dbo.db_total.total,dbo.db_total.sub_total,dbo.db_total.id_venta,dbo.db_detalle_de_venta.cantidad,dbo.db_detalle_de_venta.itbis,dbo.db_detalle_de_venta.precio,dbo.db_detalle_de_venta.total,dbo.db_producto.Descripcion,dbo.db_total.pendiente,dbo.db_total.pagado,dbo.db_total.tipo from db_total inner join dbo.db_detalle_de_venta on dbo.db_total.id_venta=dbo.db_detalle_de_venta.id_venta inner join dbo.db_producto on dbo.db_producto.id_producto=dbo.db_detalle_de_venta.id_producto where dbo.db_detalle_de_venta.id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[mostrar_retiros]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_retiros]
as
select  id_retiros as No,motivo as Motivo,monto as Retirado,fecha as Fecha from db_retiros where cierre='SIN CIERRE'  order by id_retiros desc 









GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuarios]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_usuarios]
as
select id_usuario,usuario as Usuario,nombre_de_usuario as Nombre_y_apellido,turno as Turno,password as Contraseña ,permiso AS Permiso from db_usuario order by id_usuario desc







GO
/****** Object:  StoredProcedure [dbo].[mostrar_venta_final]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_venta_final]
as
select id_venta as ID_FACTURA,fecha AS FECHA,cliente as EMPLEADO, importe as IMPORTE,documento as TIPO_DE_FACTURA,condicion as CONDICION,pendiente as Pendiente,pagado as Pagado,descuento AS Descuento from db_venta_final order by id_venta_final desc









GO
/****** Object:  StoredProcedure [dbo].[mostrarAlmacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarAlmacen]
as
select dbo.db_almacen.idProducto,dbo.db_almacen.id,dbo.db_producto.Descripcion ,dbo.db_almacen.lote as 'Und/Lote'  ,dbo.db_almacen.cantidad as Cantidad,dbo.db_almacen.Und   from db_almacen inner join dbo.db_producto on dbo.db_producto.id_producto= dbo.db_almacen.idProducto order by id desc


GO
/****** Object:  StoredProcedure [dbo].[mostrarAlmacenPorIdProducto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarAlmacenPorIdProducto]
@idProducto int
as
select dbo.db_almacen.idProducto,dbo.db_almacen.id,dbo.db_producto.Descripcion ,dbo.db_almacen.lote as 'Und/Lote'  ,dbo.db_almacen.cantidad as Cantidad,dbo.db_almacen.Und   from db_almacen inner join dbo.db_producto on dbo.db_producto.id_producto= dbo.db_almacen.idProducto where dbo.db_almacen.idProducto=@idProducto order by id desc


GO
/****** Object:  StoredProcedure [dbo].[mostrarInventario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarInventario]
as
select dbo.db_producto.Descripcion,dbo.db_producto.Cantidad as Existencia , dbo.db_inventario.cantidad as Contado, dbo.db_inventario.diferencia , dbo.db_inventario.importe as TotalParcial , dbo.db_inventario.total as TotalFinal  from dbo.db_producto inner join dbo.db_inventario on dbo.db_producto.id_producto= dbo.db_inventario.idProducto order by dbo.db_inventario.id desc


GO
/****** Object:  StoredProcedure [dbo].[mostrarProductoAcendente]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarProductoAcendente]
as
select id_producto from db_producto order by id_producto desc



GO
/****** Object:  StoredProcedure [dbo].[mostrarProductoSCombo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarProductoSCombo]
as

select  dbo.db_combo.id,dbo.db_producto.id_producto,dbo.db_producto.Descripcion as DESCRIPTION ,dbo.db_combo.cantidad as CANTIDAD from dbo.db_producto inner join db_combo on dbo.db_combo.idProducto=id_producto and dbo.db_combo.verifica='no' order by db_combo.id desc




GO
/****** Object:  StoredProcedure [dbo].[mostrarReporteIngresos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarReporteIngresos]
@id_reporte int
as
select * from db_reporte_ingresos where id_reporte=@id_reporte




GO
/****** Object:  StoredProcedure [dbo].[motrar_clientes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[motrar_clientes]
as
select id_cliente,nombre_y_apellido as Nombre,telefono as Telefono,dni as Dni,direccion as Direccion from db_clientes order by id_cliente desc









GO
/****** Object:  StoredProcedure [dbo].[numeros_de_comprobantes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[numeros_de_comprobantes]
as
select comprobantes from db_comprobantes






GO
/****** Object:  StoredProcedure [dbo].[poner_en_cierre_retirados]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[poner_en_cierre_retirados]
as
update db_retiros set cierre='CIERRE DE CAJA' where cierre='SIN CIERRE'








GO
/****** Object:  StoredProcedure [dbo].[poner_en_credito]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[poner_en_credito]
as
update db_venta_final set condicion='A CREDITO' where pendiente>0







GO
/****** Object:  StoredProcedure [dbo].[poner_en_positivo_creditos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[poner_en_positivo_creditos]
as
update db_venta_final set pendiente=0 where pendiente<0







GO
/****** Object:  StoredProcedure [dbo].[poner_en_positivos_reporte_credito]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[poner_en_positivos_reporte_credito]
as
update db_total set pendiente=0 where pendiente<0







GO
/****** Object:  StoredProcedure [dbo].[ponerEnCierreDetalles]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ponerEnCierreDetalles]

as
update db_detalle_de_venta set cierre='CIERRE DE CAJA' where cierre='SIN CIERRE'



GO
/****** Object:  StoredProcedure [dbo].[probando_backup]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[probando_backup]
as
select * from db_usuario








GO
/****** Object:  StoredProcedure [dbo].[QUITAR_DE_CREDITO]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[QUITAR_DE_CREDITO]
AS
UPDATE db_venta_final SET condicion='CONTADO' where pendiente=0 and condicion='A CREDITO'







GO
/****** Object:  StoredProcedure [dbo].[reabastecer_por_id]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reabastecer_por_id]
@id_producto int,
@cantidaad int
as
update db_producto set Cantidad=Cantidad+@cantidaad where id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[recargas_desde_fechas]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[recargas_desde_fechas]
@fecha1 date,
@fecha2 date
as
select sum(monto) as recarga from db_liquido_cobro where motivo='RECARGA' and fecha between @fecha1 and @fecha2








GO
/****** Object:  StoredProcedure [dbo].[reeabastecer_por_nombre]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[reeabastecer_por_nombre]
@nombre varchar(50),
@cantidad decimal(18,2)
as
update db_producto set Cantidad=Cantidad+ @cantidad where Descripcion=@nombre








GO
/****** Object:  StoredProcedure [dbo].[reporte_cierre_de_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[reporte_cierre_de_caja]
@id_cierre as int
as
select db_cierre_de_caja.tarjeta, dbo.db_cierre_de_caja.totalBar,dbo.db_cierre_de_caja.totalGomera,dbo.db_cierre_de_caja.restante,dbo.db_cierre_de_caja.total_retirados,id_cierre_de_caja,dinero_en_caja,devoluciones,dbo.db_cierre_de_caja.fecha,dbo.db_cierre_de_caja.hora,usuario,turno,id_usuario,ventas_del_dia,retirados,valor_en_efectivo_de_caja from db_cierre_de_caja  where id_cierre_de_caja=@id_cierre









GO
/****** Object:  StoredProcedure [dbo].[reporteInventory]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reporteInventory]
@id int
as
select dbo.db_total_inventory.TotalPerdida,dbo.db_total_inventory.TotalTienda,dbo.db_total_inventory.TotalPorHaber, dbo.db_producto.Descripcion,dbo.db_producto.Cantidad, dbo.db_inventario.cantidad as contado,dbo.db_inventario.diferencia,dbo.db_inventario.importe,dbo.db_inventario.total from dbo.db_total_inventory inner join dbo.db_inventario on dbo.db_inventario.idInventory =dbo.db_total_inventory.idInventory inner join db_producto on dbo.db_producto.id_producto=dbo.db_inventario.idProducto where dbo.db_total_inventory.idInventory=@id


GO
/****** Object:  StoredProcedure [dbo].[restarAlmacen]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[restarAlmacen]
@idProducto int,
@und decimal(18,2)
as
update db_almacen set Und=Und-@und where idProducto=@idProducto


GO
/****** Object:  StoredProcedure [dbo].[retirar_dinero]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[retirar_dinero]
@id_dinero int,
@retiro decimal(18,2),
@id_ususario int
as
update db_dinero_en_caja set dinero_en_caja=dinero_en_caja-@retiro where id_dinero_en_caja=@id_dinero and id_usuario=@id_ususario









GO
/****** Object:  StoredProcedure [dbo].[sacar_id_reporte_retiros]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sacar_id_reporte_retiros]
as
select id_retiros,motivo,monto,fecha from db_retiros 








GO
/****** Object:  StoredProcedure [dbo].[sacar_los_fondos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sacar_los_fondos]
@id_usuario int,
@fondo decimal(18,2)
as
update db_fondo set fondo=fondo-@fondo where id_usuario=@id_usuario







GO
/****** Object:  StoredProcedure [dbo].[sacarDineroCaja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sacarDineroCaja]
as
update db_dinero_en_caja set dinero_en_caja=0 where dinero_en_caja>0


GO
/****** Object:  StoredProcedure [dbo].[sacarFondos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sacarFondos]
as
update db_fondo set fondo=0 where fondo>0


GO
/****** Object:  StoredProcedure [dbo].[sacarUltimoIDGastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sacarUltimoIDGastos]
as
select * from db_total_desde_gastos






GO
/****** Object:  StoredProcedure [dbo].[seleccionar_ultimo_comprobante]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[seleccionar_ultimo_comprobante]
as
select id_ultimo_comprobante,ultimo_comprobante from db_ultimo_comprobante







GO
/****** Object:  StoredProcedure [dbo].[selecionar_hora_caja_abierta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selecionar_hora_caja_abierta]
@id_usaurio int
as
select caja_abierta from db_caja_abierta where cierre='SIN CIERRE' and id_usuario=@id_usaurio







GO
/****** Object:  StoredProcedure [dbo].[selecionar_permisos_dados]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selecionar_permisos_dados]
@id_usuario int

as
select * from db_permisos where id_usuario=@id_usuario






GO
/****** Object:  StoredProcedure [dbo].[selecionarProducto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selecionarProducto]
@idProducto int
as
select Precio_de_Compra,Precio_de_Venta,Cantidad ,Descripcion from db_producto where id_producto=@idProducto



GO
/****** Object:  StoredProcedure [dbo].[selecionarUsuario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selecionarUsuario]
@idUser int
as
select * from db_usuario where id_usuario=@idUser


GO
/****** Object:  StoredProcedure [dbo].[selectIdInventory]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[selectIdInventory]
as
select * from db_total_inventory

GO
/****** Object:  StoredProcedure [dbo].[SUMAR_GANANCIAS_EN_VENTA]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUMAR_GANANCIAS_EN_VENTA]
@id_producto int,
@id_venta int
as
select sum(ganancia) as total_ganancia from db_detalle_de_venta where id_producto=@id_producto and id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[sumar_liquidos_por_30_dias]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumar_liquidos_por_30_dias]
as
select sum(monto) as ingresos_liquidos_por_30_dias from db_liquido_cobro where motivo='RECARGA'and DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=30 








GO
/****** Object:  StoredProcedure [dbo].[sumar_liquidos_por_semana]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_liquidos_por_semana]
as
select sum(monto) as ingresos_liquidos_por_semanas from db_liquido_cobro where motivo='RECARGA'and DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=7 








GO
/****** Object:  StoredProcedure [dbo].[sumar_mantenimiento_por_30_dias]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_mantenimiento_por_30_dias]
as
select sum(monto) as ingresos_mantenimiento_por30_dias from db_liquido_cobro where motivo='MANTENIMIENTO'and DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=30 








GO
/****** Object:  StoredProcedure [dbo].[sumar_mantenimiento_por_7_dias]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumar_mantenimiento_por_7_dias]
as
select sum(monto) as ingresos_mantenimiento_por7_dias from db_liquido_cobro where motivo='MANTENIMIENTO'and DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=7 








GO
/****** Object:  StoredProcedure [dbo].[SUMAR_RETIROS_DEL_DIA]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUMAR_RETIROS_DEL_DIA]
AS
SELECT SUM(monto) retiros_del_dia from db_retiros where cierre='SIN CIERRE'








GO
/****** Object:  StoredProcedure [dbo].[sumar_retiros_desde]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumar_retiros_desde]
@fecha1 date,
@fecha2 date
as
select SUM(monto) as total_retiros from db_retiros where fecha between @fecha1 and @fecha2







GO
/****** Object:  StoredProcedure [dbo].[sumar_ventas_del_mes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_ventas_del_mes]
as
select sum(precio) as compras_del_mes from db_compras where DATEDIFF(MONTH,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) =0









GO
/****** Object:  StoredProcedure [dbo].[sumarBar]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumarBar]
@idUser int
as
select sum(total) as totalBar from db_detalle_de_venta  where categoria<>'GOMERA' and idCajero=@idUser and cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[sumarBarPorFecha]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarBarPorFecha]
@fecha1 date,
@fecha2 date
as
select sum(total)as total from db_detalle_de_venta where categoria='BAR' and fecha between @fecha1 and @fecha2 


GO
/****** Object:  StoredProcedure [dbo].[sumarCapital]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarCapital]
as
select sum(importe) as total from db_inventario where importe >0 and flag='active' 


GO
/****** Object:  StoredProcedure [dbo].[sumarGastos]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarGastos]
@fechaDesde date,
@fechaHasta date
as
select Total_con_itbis,Total_sin_itbis,Itbis from db_gastos where fecha between @fechaDesde and @fechaHasta






GO
/****** Object:  StoredProcedure [dbo].[sumarGastosInversion]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumarGastosInversion]
@fecha1 date,
@fecha2 date
as
select sum(Total_con_itbis) as total from db_gastos where categoria='INVERSION' and fecha between @fecha1 and @fecha2



GO
/****** Object:  StoredProcedure [dbo].[sumarGastosOtros]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarGastosOtros]
@fecha1 date,
@fecha2 date
as
select sum(Total_con_itbis) as total from db_gastos where categoria='OTRO' and fecha between @fecha1 and @fecha2



GO
/****** Object:  StoredProcedure [dbo].[sumarGomera]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumarGomera]
@idUser int
as
select sum(total) as total from db_detalle_de_venta  where categoria='GOMERA' and idCajero=@idUser and cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[sumarGomeraPorFecha]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumarGomeraPorFecha]
@fecha1 date,
@fecha2 date
as
select sum(total)as total from db_detalle_de_venta where categoria='GOMERA' and fecha between @fecha1 and @fecha2 


GO
/****** Object:  StoredProcedure [dbo].[sumarPerdidas]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumarPerdidas]
as
select sum(importe) as total from db_inventario where importe <=0 and flag='active' 


GO
/****** Object:  StoredProcedure [dbo].[sumarTarjeta]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sumarTarjeta]
@cajeroId int
as
select sum(importe) as tarjeta from db_caja_diaria where idcajero=@cajeroId AND Medio_de_pago='TARJETA' and cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[sumarVentasDeldiaBar]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarVentasDeldiaBar]
as
select sum(total) as total from db_detalle_de_venta where categoria='BAR' and cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[sumarVentasDeldiaGomera]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarVentasDeldiaGomera]
as
select sum(total) as total from db_detalle_de_venta where categoria='GOMERA' and cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[sumarVentasTotales]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumarVentasTotales]
as
select sum(total) as total from db_detalle_de_venta where  cierre='SIN CIERRE'


GO
/****** Object:  StoredProcedure [dbo].[updateIdCombo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateIdCombo]
@idProducto int
as
update db_combo set idProducto =@idProducto where  idCombo=0



GO
/****** Object:  StoredProcedure [dbo].[updateInventario]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateInventario]
@idProducto int,
@cantidad int,
@diferencia varchar(50),
@importe decimal(18,2),
@total decimal(18,2)
as
update db_inventario set cantidad=@cantidad,diferencia=@diferencia,importe=@importe,total=@total  where idProducto=@idProducto



GO
/****** Object:  StoredProcedure [dbo].[ventas_de_la_semana]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ventas_de_la_semana]
as
select sum(Importe) as ventas_de_la_semana from db_caja_diaria where DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=7









GO
/****** Object:  StoredProcedure [dbo].[ventas_del_mes]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ventas_del_mes]
as
select sum(Importe) as ventas_del_mes from db_caja_diaria where DATEDIFF(DAY,CONVERT(date, fecha, 103), CONVERT(date, GETDATE(), 103)) <=30









GO
/****** Object:  StoredProcedure [dbo].[ventas_desde]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ventas_desde]
@fecha1 date,
@fecha2 date
as
select sum(Importe) as vendas_desde from db_caja_diaria where fecha between @fecha1 and @fecha2 and Estado='VALIDO'









GO
/****** Object:  StoredProcedure [dbo].[ver_cantidad]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ver_cantidad]
@id_producto int
as
select Cantidad from db_producto where id_producto=@id_producto









GO
/****** Object:  StoredProcedure [dbo].[verifiacar_si_lleva_rnc]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verifiacar_si_lleva_rnc]
@id_venta int
as
select * from db_total where rnc_cliente!='' and id_venta=@id_venta






GO
/****** Object:  StoredProcedure [dbo].[verifiacar_si_lleva_rnc_con_credito]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verifiacar_si_lleva_rnc_con_credito]
@id_venta int
as
select * from db_total where rnc_cliente!='' and id_venta=@id_venta and tipo='A CREDITO'






GO
/****** Object:  StoredProcedure [dbo].[verificar_producto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificar_producto]
@id_producto int
as
select Cantidad,Descripcion from db_producto where id_producto=@id_producto




GO
/****** Object:  StoredProcedure [dbo].[verificar_si_el_producto_tiene_codigo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificar_si_el_producto_tiene_codigo]
@codigo_de_barra varchar(50),
@id_producto int
as
SELECT * FROM db_producto where Codigo_de_Barra =@codigo_de_barra and id_producto=@id_producto






GO
/****** Object:  StoredProcedure [dbo].[VERIFICAR_SI_EL_REPORTE_ES_ACREDITO]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[VERIFICAR_SI_EL_REPORTE_ES_ACREDITO]
@id_venta int
as
select * from db_total where tipo='A CREDITO'  and id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[verificar_si_existe_codigo_de_barra]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verificar_si_existe_codigo_de_barra]
@codigo_de_barra varchar(50)
as
select * from db_producto where Codigo_de_Barra=@codigo_de_barra and Codigo_de_Barra!=''






GO
/****** Object:  StoredProcedure [dbo].[verificar_si_existe_el_articulo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verificar_si_existe_el_articulo]
@id_venta int,
@id_producto int
as
select id_venta,id_producto,precio,cantidad  from db_detalle_de_venta  where id_producto=@id_producto and id_venta=@id_venta







GO
/****** Object:  StoredProcedure [dbo].[verificar_si_existe_la_hora]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificar_si_existe_la_hora]
@id_usuario int
as
select * from db_caja_abierta where cierre='SIN CIERRE' and id_usuario=@id_usuario







GO
/****** Object:  StoredProcedure [dbo].[verificar_si_existe_producto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verificar_si_existe_producto]
@codigo_de_barra varchar(50),
@descripcion varchar(50)
as

select * from db_producto where Codigo_de_Barra=@codigo_de_barra or Descripcion=@descripcion






GO
/****** Object:  StoredProcedure [dbo].[verificar_si_exite_el_producto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verificar_si_exite_el_producto]
@nombre varchar(50)
as
select id_producto,Descripcion,Codigo_de_Barra,Precio_de_Compra from db_producto where Descripcion=@nombre 






GO
/****** Object:  StoredProcedure [dbo].[verificar_si_hay_fondo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificar_si_hay_fondo]
@id_usuario int
as
select * from db_fondo where id_usuario=@id_usuario







GO
/****** Object:  StoredProcedure [dbo].[verificar_si_hay_registro]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verificar_si_hay_registro]
@id_usuario int
as
select id_dinero_en_caja,dinero_en_caja from db_dinero_en_caja where id_usuario=@id_usuario









GO
/****** Object:  StoredProcedure [dbo].[verificar_si_no_esta_vendido]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verificar_si_no_esta_vendido]
as
SELECT id_venta,id_producto,cantidad From db_detalle_de_venta where estado='SIN VENDER'









GO
/****** Object:  StoredProcedure [dbo].[verificar_si_tiene_fondo_el_usuario_en_caja]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificar_si_tiene_fondo_el_usuario_en_caja]
@id_usuario int
as
select * from db_fondo where fondo>0 and id_usuario=@id_usuario







GO
/****** Object:  StoredProcedure [dbo].[verificarProductoCombo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificarProductoCombo]
@idCombo int
as
select idProducto,cantidad from db_combo where idCombo=@idCombo



GO
/****** Object:  StoredProcedure [dbo].[verificarSiEstaElProducto]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificarSiEstaElProducto]
@idProducto int
as
select * from db_combo where idProducto=@idProducto and verifica='no'



GO
/****** Object:  StoredProcedure [dbo].[verificarSiEstaElproductoEncombo]    Script Date: 6/29/2023 3:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[verificarSiEstaElproductoEncombo]
@idProducto int
as
select * from db_combo where idProducto=@idProducto and idCombo=0



GO
USE [master]
GO
ALTER DATABASE [sispunto_de_ventas] SET  READ_WRITE 
GO
