USE [master]
GO
/****** Object:  Database [BASEADACURSO]    Script Date: 21/08/2021 15:52:37 ******/
CREATE DATABASE [BASEADACURSO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BASEADACURSO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BASEADACURSO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BASEADACURSO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BASEADACURSO_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BASEADACURSO] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BASEADACURSO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BASEADACURSO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BASEADACURSO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BASEADACURSO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BASEADACURSO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BASEADACURSO] SET ARITHABORT OFF 
GO
ALTER DATABASE [BASEADACURSO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BASEADACURSO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BASEADACURSO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BASEADACURSO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BASEADACURSO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BASEADACURSO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BASEADACURSO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BASEADACURSO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BASEADACURSO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BASEADACURSO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BASEADACURSO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BASEADACURSO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BASEADACURSO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BASEADACURSO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BASEADACURSO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BASEADACURSO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BASEADACURSO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BASEADACURSO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BASEADACURSO] SET  MULTI_USER 
GO
ALTER DATABASE [BASEADACURSO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BASEADACURSO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BASEADACURSO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BASEADACURSO] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BASEADACURSO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BASEADACURSO] SET QUERY_STORE = OFF
GO
USE [BASEADACURSO]
GO
/****** Object:  User [pruebas2020]    Script Date: 21/08/2021 15:52:37 ******/
CREATE USER [pruebas2020] FOR LOGIN [pruebas2020] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [pruebas2020]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[Id_Caja] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Tema] [varchar](50) NULL,
	[Serial_PC] [varchar](max) NULL,
	[Impresora_Ticket] [varchar](max) NULL,
	[Impresora_A4] [varchar](max) NULL,
	[Estado] [varchar](50) NULL,
	[Tipo] [varchar](50) NULL,
	[PuertoBalanza] [varchar](max) NULL,
	[EstadoBalanza] [varchar](50) NULL,
 CONSTRAINT [PK_Caja_1] PRIMARY KEY CLUSTERED 
(
	[Id_Caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idclientev] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Direccion] [varchar](max) NULL,
	[IdentificadorFiscal] [varchar](max) NULL,
	[Celular] [varchar](max) NULL,
	[Estado] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idclientev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodigosProdSunat]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigosProdSunat](
	[Codigo] [varchar](8) NULL,
	[Descripcion] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Codigosubigeos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Codigosubigeos](
	[Departamento] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[Distrito] [varchar](50) NULL,
	[Ubigeo] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[Idcompra] [int] IDENTITY(1,1) NOT NULL,
	[fechacompra] [datetime] NULL,
	[Total] [numeric](18, 2) NULL,
	[Comprobante] [varchar](max) NULL,
	[IdProveedor] [int] NULL,
	[Idcaja] [int] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[Idcompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conceptos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conceptos](
	[Id_concepto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_Conceptos] PRIMARY KEY CLUSTERED 
(
	[Id_concepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlCobros]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlCobros](
	[IdcontrolCobro] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [numeric](18, 2) NULL,
	[Fecha] [datetime] NULL,
	[Detalle] [varchar](max) NULL,
	[IdCliente] [int] NULL,
	[IdUsuario] [int] NULL,
	[IdCaja] [int] NULL,
	[Comprobante] [varchar](max) NULL,
	[Efectivo] [numeric](18, 2) NULL,
	[Tarjeta] [numeric](18, 2) NULL,
 CONSTRAINT [PK_ControlCobros] PRIMARY KEY CLUSTERED 
(
	[IdcontrolCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorreoBase]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorreoBase](
	[IdCorreo] [int] IDENTITY(1,1) NOT NULL,
	[Correo] [varchar](max) NULL,
	[Password] [varchar](max) NULL,
	[EstadoEnvio] [varchar](50) NULL,
 CONSTRAINT [PK_CorreoBase] PRIMARY KEY CLUSTERED 
(
	[IdCorreo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditoPorCobrar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditoPorCobrar](
	[Id_credito] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Fecha_registro] [datetime] NULL,
	[Fecha_vencimiento] [datetime] NULL,
	[Total] [numeric](18, 2) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Estado] [varchar](max) NULL,
	[Id_caja] [int] NULL,
	[Id_cliente] [int] NULL,
 CONSTRAINT [PK_CreditoPorCobrar] PRIMARY KEY CLUSTERED 
(
	[Id_credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditoPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditoPorPagar](
	[Id_credito] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Fecha_registro] [datetime] NULL,
	[Fecha_vencimiento] [date] NULL,
	[Total] [numeric](18, 2) NULL,
	[Saldo] [numeric](18, 2) NULL,
	[Estado] [varchar](max) NULL,
	[Id_caja] [int] NULL,
	[Id_Proveedor] [int] NULL,
 CONSTRAINT [PK_CreditoPorPagar] PRIMARY KEY CLUSTERED 
(
	[Id_credito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[iddetalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[idventa] [int] NULL,
	[Id_producto] [int] NULL,
	[cantidad] [numeric](18, 2) NULL,
	[preciounitario] [money] NULL,
	[Moneda] [varchar](50) NULL,
	[Total_a_pagar]  AS ([preciounitario]*[cantidad]),
	[Unidad_de_medida] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Codigo] [varchar](50) NULL,
	[Costo] [money] NULL,
	[Ganancia]  AS ([cantidad]*[preciounitario]-[cantidad]*[costo]),
	[CodProdSunat] [varchar](10) NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[iddetalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[IdDetallecompra] [int] IDENTITY(1,1) NOT NULL,
	[IdCompra] [int] NULL,
	[Cantidad] [numeric](18, 2) NULL,
	[Costo] [numeric](18, 2) NULL,
	[Moneda] [varchar](50) NULL,
	[IdProducto] [int] NULL,
	[Descripcion] [varchar](max) NULL,
	[Total]  AS ([Costo]*[Cantidad]),
 CONSTRAINT [PK_DetalleCompra] PRIMARY KEY CLUSTERED 
(
	[IdDetallecompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[Id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[Logo] [image] NULL,
	[Impuesto] [varchar](50) NULL,
	[Porcentaje_impuesto] [numeric](18, 0) NULL,
	[SimboloMoneda] [varchar](50) NULL,
	[Trabajas_con_impuestos] [varchar](50) NULL,
	[Modo_de_busqueda] [varchar](50) NULL,
	[Carpeta_para_copias_de_seguridad] [varchar](max) NULL,
	[Correo_para_envio_de_reportes] [varchar](50) NULL,
	[Ultima_fecha_de_copia_de_seguridad] [varchar](50) NULL,
	[Ultima_fecha_de_copia_date] [datetime] NULL,
	[Frecuencia_de_copias] [int] NULL,
	[VersionUbl] [varchar](3) NULL,
	[VersionEstDoc] [varchar](3) NULL,
	[Ruc] [varchar](11) NULL,
	[RazonSocial] [varchar](max) NULL,
	[DireccionFiscal] [varchar](max) NULL,
	[Ubigeo] [varchar](50) NULL,
	[ConectarSunat] [varchar](2) NULL,
	[Servidor] [varchar](max) NULL,
	[CarpetaCertificado] [varchar](max) NULL,
	[Passcertificado] [varchar](max) NULL,
	[UserSecundario] [varchar](max) NULL,
	[PassSecundario] [varchar](max) NULL,
	[CodMoneda] [varchar](10) NULL,
 CONSTRAINT [PK_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[Id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gastos_varios]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos_varios](
	[Id_gasto] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Nro_documento] [varchar](max) NULL,
	[Tipo_comprobante] [varchar](max) NULL,
	[Importe] [numeric](18, 2) NULL,
	[Descripcion] [varchar](max) NULL,
	[Id_caja] [int] NULL,
	[Id_concepto] [int] NULL,
 CONSTRAINT [PK_Gastos_varios] PRIMARY KEY CLUSTERED 
(
	[Id_gasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupo_de_Productos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo_de_Productos](
	[Idline] [int] IDENTITY(1,1) NOT NULL,
	[Linea] [varchar](50) NULL,
	[Por_defecto] [varchar](50) NULL,
 CONSTRAINT [PK_linea] PRIMARY KEY CLUSTERED 
(
	[Idline] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingresos_varios]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos_varios](
	[Id_ingreso] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Nro_comprobante] [varchar](max) NULL,
	[Tipo_comprobante] [varchar](max) NULL,
	[Importe] [numeric](18, 2) NULL,
	[Descripcion] [varchar](max) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_Ingresos_varios] PRIMARY KEY CLUSTERED 
(
	[Id_ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inicios_de_sesion_por_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inicios_de_sesion_por_caja](
	[Id_inicio_sesion] [int] IDENTITY(1,1) NOT NULL,
	[Id_serial_Pc] [varchar](max) NULL,
	[Id_usuario] [int] NULL,
 CONSTRAINT [PK_Inicios_de_sesion] PRIMARY KEY CLUSTERED 
(
	[Id_inicio_sesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KARDEX]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KARDEX](
	[Id_kardex] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Motivo] [varchar](max) NULL,
	[Cantidad] [numeric](18, 2) NULL,
	[Id_producto] [int] NULL,
	[Id_usuario] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Total]  AS ([Cantidad]*[Costo_unt]),
	[Costo_unt] [numeric](18, 2) NULL,
	[Habia] [numeric](18, 2) NULL,
	[Hay] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_KARDEX] PRIMARY KEY CLUSTERED 
(
	[Id_kardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcan]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcan](
	[Id_marca] [int] IDENTITY(1,1) NOT NULL,
	[S] [varchar](max) NULL,
	[F] [varchar](max) NULL,
	[E] [varchar](max) NULL,
	[FA] [varchar](max) NULL,
 CONSTRAINT [PK_Licencias] PRIMARY KEY CLUSTERED 
(
	[Id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIMIENTOCAJACIERRE]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOCAJACIERRE](
	[idcierrecaja] [int] IDENTITY(1,1) NOT NULL,
	[fechainicio] [datetime] NULL,
	[fechafin] [datetime] NULL,
	[fechacierre] [datetime] NULL,
	[ingresos] [numeric](18, 2) NULL,
	[egresos] [numeric](18, 2) NULL,
	[Saldo_queda_en_caja] [numeric](18, 2) NULL,
	[Id_usuario] [int] NULL,
	[Total_calculado] [numeric](18, 2) NULL,
	[Total_real] [numeric](18, 2) NULL,
	[Estado] [varchar](50) NULL,
	[Diferencia] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
 CONSTRAINT [PK_MOVIMIENTOCAJACIERRE] PRIMARY KEY CLUSTERED 
(
	[idcierrecaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaCredito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaCredito](
	[Idnotacredito] [int] IDENTITY(1,1) NOT NULL,
	[Idventa] [int] NULL,
	[Serie] [varchar](4) NULL,
	[Correlativo] [varchar](8) NULL,
	[EstadoSunat] [varchar](50) NULL,
	[Idcomprobante] [int] NULL,
	[CodTipo] [varchar](2) NULL,
 CONSTRAINT [PK_NotaCredito] PRIMARY KEY CLUSTERED 
(
	[Idnotacredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaDebito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaDebito](
	[Idnotadebito] [int] IDENTITY(1,1) NOT NULL,
	[Idventa] [int] NULL,
	[Serie] [varchar](4) NULL,
	[Correlativo] [varchar](8) NULL,
	[EstadoSunat] [varchar](50) NULL,
	[Idcomprobante] [int] NULL,
	[CodTipo] [varchar](2) NULL,
 CONSTRAINT [PK_NotaDebito] PRIMARY KEY CLUSTERED 
(
	[Idnotadebito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto1]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto1](
	[Id_Producto1] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Id_grupo] [int] NULL,
	[Usa_inventarios] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Precio_de_compra] [numeric](18, 2) NULL,
	[Fecha_de_vencimiento] [varchar](50) NULL,
	[Precio_de_venta] [numeric](18, 2) NULL,
	[Codigo] [varchar](50) NULL,
	[Se_vende_a] [varchar](50) NULL,
	[Stock_minimo] [numeric](18, 2) NULL,
	[Precio_mayoreo] [numeric](18, 2) NULL,
	[A_partir_de] [numeric](18, 2) NULL,
	[CodigoSunat] [varchar](8) NULL,
	[CodUm] [varchar](5) NULL,
 CONSTRAINT [PK_Producto1] PRIMARY KEY CLUSTERED 
(
	[Id_Producto1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Direccion] [varchar](max) NULL,
	[IdentificadorFiscal] [varchar](max) NULL,
	[Celular] [varchar](max) NULL,
	[Estado] [varchar](50) NULL,
	[Saldo] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serializacion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serializacion](
	[Id_serializacion] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [varchar](50) NULL,
	[Cantidad_de_numeros] [varchar](50) NULL,
	[numerofin] [int] NULL,
	[Destino] [varchar](50) NULL,
	[tipodoc] [varchar](50) NULL,
	[Por_defecto] [varchar](50) NULL,
	[Codigo] [varchar](2) NULL,
 CONSTRAINT [PK_Serializacion] PRIMARY KEY CLUSTERED 
(
	[Id_serializacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SunatTipoFactura]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SunatTipoFactura](
	[Idtipooperacion] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](2) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_SunatTipooperacion] PRIMARY KEY CLUSTERED 
(
	[Idtipooperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id_ticket] [int] IDENTITY(1,1) NOT NULL,
	[Id_Empresa] [int] NULL,
	[Nombre_de_Moneda] [varchar](max) NULL,
	[Agradecimiento] [varchar](max) NULL,
	[pagina_Web_Facebook] [varchar](max) NULL,
	[Anuncio] [varchar](max) NULL,
	[Datos_fiscales_de_autorizacion] [varchar](max) NULL,
	[Por_defecto] [varchar](max) NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id_ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tiposnotacredito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tiposnotacredito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Tposnotacredito] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tiposnotadebito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tiposnotadebito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Tiposnotadebito] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadesMedida]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadesMedida](
	[Idunidad] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_UnidadesMedida] PRIMARY KEY CLUSTERED 
(
	[Idunidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO2]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO2](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombres_y_Apellidos] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Icono] [image] NULL,
	[Nombre_de_icono] [varchar](max) NULL,
	[Correo] [varchar](max) NULL,
	[Rol] [varchar](max) NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIO2] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[idclientev] [int] NULL,
	[fecha_venta] [datetime] NULL,
	[Monto_total] [money] NULL,
	[Tipo_de_pago] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[TotalIgv] [money] NULL,
	[Id_usuario] [int] NULL,
	[Fecha_de_pago] [datetime] NULL,
	[ACCION] [varchar](50) NULL,
	[Saldo] [money] NULL,
	[Pago_con] [money] NULL,
	[Porcentaje_IGV] [numeric](18, 2) NULL,
	[Id_caja] [int] NULL,
	[Referencia_tarjeta] [varchar](50) NULL,
	[Vuelto] [money] NULL,
	[Efectivo] [money] NULL,
	[Credito] [money] NULL,
	[Tarjeta] [money] NULL,
	[Idcomprobante] [int] NULL,
	[Serie] [varchar](4) NULL,
	[Correlativo] [varchar](8) NULL,
	[Idempresa] [int] NULL,
	[ContadorProductos] [int] NULL,
	[TotSubtotal] [money] NULL,
	[Estadosunat] [varchar](50) NULL,
 CONSTRAINT [PK_ventas] PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ControlCobros]  WITH CHECK ADD  CONSTRAINT [FK_ControlCobros_Caja] FOREIGN KEY([IdCaja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[ControlCobros] CHECK CONSTRAINT [FK_ControlCobros_Caja]
GO
ALTER TABLE [dbo].[ControlCobros]  WITH CHECK ADD  CONSTRAINT [FK_ControlCobros_clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[clientes] ([idclientev])
GO
ALTER TABLE [dbo].[ControlCobros] CHECK CONSTRAINT [FK_ControlCobros_clientes]
GO
ALTER TABLE [dbo].[ControlCobros]  WITH CHECK ADD  CONSTRAINT [FK_ControlCobros_USUARIO2] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
GO
ALTER TABLE [dbo].[ControlCobros] CHECK CONSTRAINT [FK_ControlCobros_USUARIO2]
GO
ALTER TABLE [dbo].[CreditoPorCobrar]  WITH CHECK ADD  CONSTRAINT [FK_CreditoPorCobrar_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[CreditoPorCobrar] CHECK CONSTRAINT [FK_CreditoPorCobrar_Caja]
GO
ALTER TABLE [dbo].[CreditoPorCobrar]  WITH CHECK ADD  CONSTRAINT [FK_CreditoPorCobrar_clientes] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[clientes] ([idclientev])
GO
ALTER TABLE [dbo].[CreditoPorCobrar] CHECK CONSTRAINT [FK_CreditoPorCobrar_clientes]
GO
ALTER TABLE [dbo].[CreditoPorPagar]  WITH CHECK ADD  CONSTRAINT [FK_CreditoPorPagar_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[CreditoPorPagar] CHECK CONSTRAINT [FK_CreditoPorPagar_Caja]
GO
ALTER TABLE [dbo].[CreditoPorPagar]  WITH CHECK ADD  CONSTRAINT [FK_CreditoPorPagar_Proveedores] FOREIGN KEY([Id_Proveedor])
REFERENCES [dbo].[Proveedores] ([IdProveedor])
GO
ALTER TABLE [dbo].[CreditoPorPagar] CHECK CONSTRAINT [FK_CreditoPorPagar_Proveedores]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_ventas] FOREIGN KEY([idventa])
REFERENCES [dbo].[ventas] ([idventa])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_ventas]
GO
ALTER TABLE [dbo].[Gastos_varios]  WITH CHECK ADD  CONSTRAINT [FK_Gastos_varios_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[Gastos_varios] CHECK CONSTRAINT [FK_Gastos_varios_Caja]
GO
ALTER TABLE [dbo].[Gastos_varios]  WITH CHECK ADD  CONSTRAINT [FK_Gastos_varios_Conceptos] FOREIGN KEY([Id_concepto])
REFERENCES [dbo].[Conceptos] ([Id_concepto])
GO
ALTER TABLE [dbo].[Gastos_varios] CHECK CONSTRAINT [FK_Gastos_varios_Conceptos]
GO
ALTER TABLE [dbo].[Ingresos_varios]  WITH CHECK ADD  CONSTRAINT [FK_Ingresos_varios_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[Ingresos_varios] CHECK CONSTRAINT [FK_Ingresos_varios_Caja]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_Caja]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_Producto1] FOREIGN KEY([Id_producto])
REFERENCES [dbo].[Producto1] ([Id_Producto1])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_Producto1]
GO
ALTER TABLE [dbo].[KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_KARDEX_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KARDEX] CHECK CONSTRAINT [FK_KARDEX_USUARIO2]
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE] CHECK CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_Caja]
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE]  WITH CHECK ADD  CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
GO
ALTER TABLE [dbo].[MOVIMIENTOCAJACIERRE] CHECK CONSTRAINT [FK_MOVIMIENTOCAJACIERRE_USUARIO2]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_Caja] FOREIGN KEY([Id_caja])
REFERENCES [dbo].[Caja] ([Id_Caja])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_Caja]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_clientes] FOREIGN KEY([idclientev])
REFERENCES [dbo].[clientes] ([idclientev])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_clientes]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_USUARIO2] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[USUARIO2] ([idUsuario])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_USUARIO2]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_serializacion_mas_uno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_serializacion_mas_uno]
@idserie as int  
as 
update Serializacion set  numerofin=numerofin+1          
where Id_serializacion=@idserie 














GO
/****** Object:  StoredProcedure [dbo].[aplicar_precio_mayoreo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aplicar_precio_mayoreo]
@idproducto int,
@iddetalleventa int
as
declare @preciomayoreo numeric(18,2)
set @preciomayoreo= (select Precio_mayoreo from Producto1 where Producto1.Id_Producto1 = @idproducto )
if Exists(select Precio_mayoreo,Id_Producto1 from Producto1 where Precio_mayoreo=0 and Producto1.Id_Producto1 =@idproducto)
Raiserror('No se configuro un precio al moyero para este producto',16,1)
else

update detalle_venta set preciounitario=@preciomayoreo
where Id_producto =@idproducto and detalle_venta.iddetalle_venta =@iddetalleventa 






GO
/****** Object:  StoredProcedure [dbo].[aumentar_saldo_a_cliente]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[aumentar_saldo_a_cliente]
@idcliente as integer,
@Saldo numeric(18,2)          
as 
update clientes set          
			Saldo =Saldo+@Saldo 
where idclientev =@idcliente 

















GO
/****** Object:  StoredProcedure [dbo].[aumentarStock]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[aumentarStock]
@idproducto int,
@cantidad numeric(18,2)
as
Update Producto1 set Stock = Stock+@cantidad 
where Id_Producto1=@idproducto and Usa_inventarios = 'SI'






GO
/****** Object:  StoredProcedure [dbo].[buscar_clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_clientes]
@letra varchar(max)
As
SELECT        idclientev , Nombre, Direccion, IdentificadorFiscal as [Identificador Fiscal] , Celular, Estado, Saldo
FROM            dbo.clientes
where Nombre+IdentificadorFiscal+Celular   Like '%' + @letra + '%'  AND Nombre<>'GENERICO'











GO
/****** Object:  StoredProcedure [dbo].[buscar_conceptos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_conceptos]
@letra varchar(max)
as
select Id_concepto,Descripcion as Concepto from Conceptos
where Descripcion  Like '%' + @letra + '%' 













GO
/****** Object:  StoredProcedure [dbo].[Buscar_id_USUARIOS]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Buscar_id_USUARIOS]
@Nombre_y_Apelllidos varchar(50)
as
select * from USUARIO2 
where Nombres_y_Apellidos =@Nombre_y_Apelllidos
order by idUsuario desc























GO
/****** Object:  StoredProcedure [dbo].[buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[buscar_MOVIMIENTOS_DE_KARDEX_filtros_acumulado]
@fecha date,
@tipo varchar(50),
@Id_usuario int 
AS BEGIN
SELECT     Producto1.Descripcion ,KARDEX.Tipo ,sum (KARDEX.Cantidad) Cantidad_Total ,@fecha as fecha, USUARIO2.Nombres_y_Apellidos,@tipo as Tipo_consultado
 FROM            dbo.KARDEX INNER JOIN Producto1 on Producto1.Id_Producto1=KARDEX.Id_producto inner join USUARIO2 on USUARIO2.idUsuario =KARDEX.Id_usuario 
         
				 
WHEre KARDEX.Id_usuario =@Id_usuario and (KARDEX.Tipo=@tipo or @tipo ='-Todos-') and convert(date,KARDEX.Fecha) =convert(date,@fecha )
group by Producto1.Descripcion,KARDEX.Tipo,USUARIO2.Nombres_y_Apellidos
ORDER BY sum (KARDEX.Cantidad) DESC
END






















GO
/****** Object:  StoredProcedure [dbo].[buscar_Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscar_Proveedores]
@letra varchar(max)
As
SELECT        IdProveedor, Nombre, Direccion, IdentificadorFiscal as [Identificador Fiscal] , Celular, Estado, Saldo
FROM            dbo.Proveedores
where Nombre+IdentificadorFiscal+Celular   Like '%' + @letra + '%' and Nombre <>'GENERICO'











GO
/****** Object:  StoredProcedure [dbo].[buscar_Tipo_de_documentos_para_insertar_en_ventas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_Tipo_de_documentos_para_insertar_en_ventas]
@letra VARCHAR(50)
AS BEGIN

SELECT        Serializacion.tipodoc   AS COMPROBANTE ,
dbo.Serializacion.Serie ,dbo.Serializacion.Cantidad_de_numeros  , dbo.Serializacion.numerofin ,
dbo.Serializacion.Id_serializacion ,
(dbo.Serializacion.Serie  +' - '+ dbo.Serializacion.Cantidad_de_numeros + dbo.Serializacion.numerofin) as serie_completa
FROM            dbo.Serializacion 
 
 WHEre Serializacion.tipodoc =@letra  and dbo.Serializacion .Destino  ='VENTAS'
 end


















GO
/****** Object:  StoredProcedure [dbo].[buscar_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_usuario]
@letra varchar(50)
as
select  idUsuario,Nombres_y_Apellidos AS Nombres,Login,Password
,Icono ,Nombre_de_icono ,Correo ,rol  FROM USUARIO2

where Nombres_y_Apellidos + Login      LIKE '%'+ @letra +'%' AND Estado='ACTIVO'























GO
/****** Object:  StoredProcedure [dbo].[buscar_USUARIO_por_correo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[buscar_USUARIO_por_correo]
@correo VARCHAR(max)

AS 
SELECT        Password 
FROM            dbo.USUARIO2						 
WHEre Correo =@correo























GO
/****** Object:  StoredProcedure [dbo].[buscarCodProdSunat]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarCodProdSunat]
@buscador varchar(max)
As
select top 10 Descripcion + '-' + Codigo,Codigo from CodigosProdSunat

where Descripcion+Codigo Like '%' + @buscador + '%'  

GO
/****** Object:  StoredProcedure [dbo].[buscarCompras]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscarCompras]
@buscar varchar(50)
as
select * from Compras 
where Comprobante  Like '%' + @buscar + '%'






GO
/****** Object:  StoredProcedure [dbo].[buscarFacturasBoletas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarFacturasBoletas]
@buscador varchar(50),
@Codigo varchar(8)
as
select top 30 ventas.Serie +'-'+ ventas.Correlativo as Comprobante
,ventas.Estadosunat ,ventas.fecha_venta, clientes.Nombre as cliente
,Serializacion.tipodoc as [Tipo comprobante]
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join clientes on clientes.idclientev=ventas.idclientev
where ventas.Serie +'-'+ ventas.Correlativo LIKE '%'+ @buscador +'%' and
Serializacion.Codigo=@Codigo




GO
/****** Object:  StoredProcedure [dbo].[BuscarprodInvent]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[BuscarprodInvent]

@buscador varchar(50)
as 
select top 10 Id_Producto1, Descripcion
from Producto1
where  Descripcion+ Codigo  LIKE  '%' + @buscador+'%' and Usa_inventarios ='SI'








GO
/****** Object:  StoredProcedure [dbo].[buscarProductos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[buscarProductos]
@buscador varchar(50)
AS
select top 10 Id_Producto1,Descripcion,Stock,Precio_de_venta as [P venta],
Precio_de_compra as [P compra]
FROM  Producto1 
WHEre Descripcion+Codigo LIKE  '%' + @buscador+'%' ORDER BY DBO.Producto1.Descripcion  asc























GO
/****** Object:  StoredProcedure [dbo].[buscarVentas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarVentas]
@buscador varchar(max)
as
select Serializacion.tipodoc, ventas.Serie+'-'+Correlativo,idventa,Serializacion.Codigo
,ventas.Serie,ventas.Correlativo
from ventas
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
where ventas.Serie+'-'+Correlativo  Like '%' + @buscador + '%' 



GO
/****** Object:  StoredProcedure [dbo].[cambio_de_Caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cambio_de_Caja]
@idcaja int, 
@idventa int
as
update ventas set Id_caja = @idcaja 
where idventa=@idcaja 














GO
/****** Object:  StoredProcedure [dbo].[cerrarCaja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cerrarCaja]

@fechafin As datetime,
@fechacierre As datetime,
@ingresos As numeric(18,2),
@egresos As numeric(18,2),
@Saldo_queda_en_caja As numeric(18,2),
@Id_usuario As int,
@Total_calculado As numeric(18,2),
@Total_real As numeric(18,2),
@Estado As varchar(50),
@Diferencia As numeric(18,2),
@Id_caja As int
As
UPDATE MOVIMIENTOCAJACIERRE Set


fechafin=@fechafin,
fechacierre=@fechacierre,
ingresos=@ingresos,
egresos=@egresos,
Saldo_queda_en_caja=@Saldo_queda_en_caja,
Id_usuario=@Id_usuario,
Total_calculado=@Total_calculado,
Total_real=@Total_real,
Estado=@Estado,
Diferencia=@Diferencia
Where Id_caja =@Id_caja








GO
/****** Object:  StoredProcedure [dbo].[Confirmar_venta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Confirmar_venta]
@idventa int,
@idcliente int,
@fecha_venta datetime,
@Monto_total as money,
@Tipo_de_pago varchar(50),
@TotalIgv as money,
@Id_usuario Int,
@Fecha_de_pago datetime,
@Saldo money,
@Pago_con money,
@Id_caja int,
@Referencia_tarjeta varchar(50),
@Vuelto  money,
@Efectivo  money,
@Credito money,
@Tarjeta money,
@Idcomprobante int,
@ContadorProductos int,
@TotSubtotal money,
@Porcentaje_IGV numeric(18,2)
as
declare @Estado varchar(50)
set @Estado ='TERMINADO'
declare @Serie varchar(4)
set @Serie=(select Serie from Serializacion where Id_serializacion=@Idcomprobante)
declare @Correlativo varchar(8)
set @Correlativo=(select FORMAT(numerofin,'00000000') from Serializacion where Id_serializacion=@Idcomprobante)


update ventas set idclientev=@idcliente,fecha_venta=@fecha_venta
,Monto_total =@Monto_total,Tipo_de_pago=@Tipo_de_pago,TotalIgv=@TotalIgv,
Id_usuario=@Id_usuario,Fecha_de_pago =@Fecha_de_pago,Saldo=@Saldo,
Pago_con=@Pago_con,Id_caja =@Id_caja,Referencia_tarjeta=@Referencia_tarjeta,
Vuelto=@Vuelto ,Efectivo=@Efectivo,Credito=@Credito,Tarjeta=@Tarjeta 
,Idcomprobante=@Idcomprobante,Serie=@Serie, Correlativo=@Correlativo,ContadorProductos=@ContadorProductos,
TotSubtotal=@TotSubtotal,Estado =@Estado
,Porcentaje_IGV=@Porcentaje_IGV
where idventa =@idventa 

update Serializacion set numerofin=numerofin+1
where Id_serializacion=@Idcomprobante

















GO
/****** Object:  StoredProcedure [dbo].[confirmarCompra]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[confirmarCompra]
@Idcompra int,
@Total numeric(18,2),
@Idcaja int,
@Idproveedor int,
@fechacompra datetime
as
declare @Comprobante varchar(max)

update Serializacion set numerofin=numerofin+1
where Serie='TC'
set @Comprobante=(select (tipodoc +'-'+Serie+numerofin) from Serializacion where Serie='TC')
update Compras set Total=@Total ,
Comprobante=@Comprobante,
IdProveedor =@Idproveedor ,
fechacompra=@fechacompra 
where Idcompra=@Idcompra and Idcaja =@Idcaja  






GO
/****** Object:  StoredProcedure [dbo].[ConfirmarSunatNc]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[mostrarVentasXidventa]    Script Date: 08/08/2021 11:34:45 ******/
CREATE proc [dbo].[ConfirmarSunatNc]
@idventa int
as
update NotaCredito set EstadoSunat='ACEPTADA'
where  idventa =@idventa



GO
/****** Object:  StoredProcedure [dbo].[ConfirmarSunatNd]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[mostrarVentasXidventa]    Script Date: 08/08/2021 11:34:45 ******/
create proc [dbo].[ConfirmarSunatNd]
@idventa int
as
update NotaDebito set EstadoSunat='ACEPTADA'
where  idventa =@idventa


GO
/****** Object:  StoredProcedure [dbo].[contar_productos_vencidos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[contar_productos_vencidos]
as
select 
count (Id_Producto1 )as  id
from Producto1 where Fecha_de_vencimiento <>'NO APLICA' and Fecha_de_vencimiento <= CONVERT (DATE,GETDATE())



















GO
/****** Object:  StoredProcedure [dbo].[ContarprodDv]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ContarprodDv]
@idventa as int
as
SELECT  count( detalle_venta.cantidad) 
						 
FROM            dbo.detalle_venta INNER JOIN
                         ventas ON dbo.detalle_venta.idventa = ventas.idventa 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 


GO
/****** Object:  StoredProcedure [dbo].[contarVentasEspera]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[contarVentasEspera]
as
Select count (idventa) from ventas 
where Estado='EN ESPERA'






GO
/****** Object:  StoredProcedure [dbo].[ContFBAprobadas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ContFBAprobadas]
@Codigo varchar(8)
as
select Count(idventa)
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join clientes on clientes.idclientev=ventas.idclientev
where  Estadosunat='ACEPTADA' and Serializacion.Codigo=@Codigo

GO
/****** Object:  StoredProcedure [dbo].[ContFBPendientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ContFBPendientes]
@Codigo varchar(8)
as
select Count(idventa)
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join clientes on clientes.idclientev=ventas.idclientev
where 
Serializacion.Codigo=@Codigo and Estadosunat='PENDIENTE'

GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[disminuir_stock]
@idproducto as int,
@cantidad as numeric (18,2)
as
declare @cant numeric(18,2)
set @cant=(select Stock from Producto1 where Id_Producto1=@idproducto)
if(@cantidad<=@cant)
update Producto1 set Stock =Stock -@cantidad
where Id_Producto1=@idproducto and Usa_inventarios ='SI' and Stock >=@cantidad 
else
Raiserror('Se esta restando mas de lo que hay en Stock',16,1)














GO
/****** Object:  StoredProcedure [dbo].[disminuirSaldocliente]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
create proc [dbo].[disminuirSaldocliente]
@idcliente int,
@monto numeric(18,2)
as
update clientes set Saldo = Saldo - @monto 
where idclientev=@idcliente 






GO
/****** Object:  StoredProcedure [dbo].[editar_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[editar_caja]
@idcaja integer,
@descripcion varchar(50)

 as       
 if EXISTS (SELECT Descripcion  FROM Caja  where (Descripcion  = @descripcion and Id_Caja  <>@idcaja ) )

RAISERROR ('YA EXISTE UN REGISTRO  CON ESTE NOMBRE, POR FAVOR INGRESE DE NUEVO', 16,1)
else          		
 
update Caja set 
Descripcion  =@descripcion 

where Id_Caja    =@idcaja   



















GO
/****** Object:  StoredProcedure [dbo].[editar_caja_impresoras]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_caja_impresoras]
@idcaja integer,


	   @Impresora_Ticket varchar(max),
	   @Impresora_A4 varchar(max)
        
           		
as 
update Caja set 
 Impresora_Ticket=@Impresora_Ticket
 ,Impresora_A4= @Impresora_A4
where Id_Caja    =@idcaja    










GO
/****** Object:  StoredProcedure [dbo].[editar_clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[editar_clientes]
@Idcliente As int,
@Nombre As varchar(MAX),
@Direccion As varchar(MAX),
@IdentificadorFiscal As varchar(MAX),
@Celular As varchar(MAX)
As
if EXISTS(select Nombre  from clientes where Nombre=@Nombre and idclientev  <> @Idcliente )
RAISERROR('Registro ya existente', 16,1)
else
UPDATE clientes Set

Nombre=@Nombre,
Direccion=@Direccion,
IdentificadorFiscal=@IdentificadorFiscal,
Celular=@Celular
Where idclientev =@Idcliente












GO
/****** Object:  StoredProcedure [dbo].[editar_Conceptos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_Conceptos]
@Id_concepto As int,
@Descripcion As varchar(MAX)
As
if Exists(select Descripcion  from Conceptos where Descripcion =@Descripcion and Id_concepto<>@Id_concepto   )
Raiserror('Concepto ya registrado',16,1 )
else
UPDATE Conceptos Set

Descripcion=@Descripcion
Where Id_concepto=@Id_concepto













GO
/****** Object:  StoredProcedure [dbo].[editar_correo_base]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[editar_correo_base]
@Correo varchar(max),
@Password varchar(max),
@Estado_De_envio varchar(50)

as

update  CorreoBase set Correo =@Correo,
Password=@Password,EstadoEnvio=@Estado_De_envio








GO
/****** Object:  StoredProcedure [dbo].[editar_CreditoPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[editar_CreditoPorPagar]
@Id_credito As int,
@Descripcion As varchar(MAX),
@Fecha_registro As datetime,
@Fecha_vencimiento As date,
@Total As numeric(18,2),
@Saldo As numeric(18,2),
@Estado As varchar(MAX),
@Id_caja As int,
@Id_Proveedor As int
As
UPDATE CreditoPorPagar Set

Descripcion=@Descripcion,
Fecha_registro=@Fecha_registro,
Fecha_vencimiento=@Fecha_vencimiento,
Total=@Total,
Saldo=@Saldo,
Estado=@Estado,
Id_caja=@Id_caja,
Id_Proveedor=@Id_Proveedor
Where Id_credito=@Id_credito












GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_compra_Cantidad]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_detalle_compra_Cantidad]
@cantidad as numeric(18, 2),
@Id_producto varchar(50)   
,@Idcompra  as int
as
update DetalleCompra set 
cantidad=@cantidad 
where DetalleCompra.IdProducto = @Id_producto and DetalleCompra.IdCompra=@Idcompra


















GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_compra_Precio]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[editar_detalle_compra_Precio]
@precio as numeric(18, 2),
@Id_producto varchar(50)   
,@Idcompra  as int
as
update DetalleCompra set 
Costo=@precio 
where DetalleCompra.IdProducto = @Id_producto and DetalleCompra.IdCompra=@Idcompra


















GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_compra_restar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_detalle_compra_restar]
@cantidad as numeric(18, 2),
@Id_producto varchar(50)   
,@Idcompra  as int
as
update DetalleCompra set 
cantidad=cantidad-@cantidad 
where DetalleCompra.IdProducto = @Id_producto and DetalleCompra.IdCompra=@Idcompra



delete from DetalleCompra where  DetalleCompra.IdCompra =@Idcompra and cantidad <=0



















GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_compra_sumar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_detalle_compra_sumar]
@Id_producto int,
@cantidad as numeric(18,2),
@Idcompra as int
as
update DetalleCompra set 
cantidad=cantidad + @cantidad 
where DetalleCompra.IdProducto =@Id_producto and DetalleCompra.IdCompra =@Idcompra 





GO
/****** Object:  StoredProcedure [dbo].[editar_dinero_caja_inicial]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_dinero_caja_inicial]
@Id_caja as integer,
@saldo numeric(18,2)


as
update MOVIMIENTOCAJACIERRE  set  Saldo_queda_en_caja =@saldo
where Id_caja =@Id_caja AND Estado ='CAJA APERTURADA'























GO
/****** Object:  StoredProcedure [dbo].[editar_eleccion_impresoras]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_eleccion_impresoras]
@idcaja integer,
@Impresora_Ticket varchar(max)	                     		
as 
update Caja set 
 Impresora_Ticket=@Impresora_Ticket
where Id_Caja    =@idcaja  

















GO
/****** Object:  StoredProcedure [dbo].[editar_Empresa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Empresa]
@Razonsocial  varchar(max),
@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),
@SimboloMoneda varchar(50),
@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50),
@Carpeta_para_copias_de_seguridad varchar(max),
@Correo_para_envio_de_reportes varchar(50),
@ConectarSunat varchar(2)
as
update  EMPRESA set RazonSocial=@Razonsocial,Logo=@logo ,Impuesto=@Impuesto ,
Porcentaje_impuesto=@Porcentaje_impuesto,SimboloMoneda=@SimboloMoneda,Trabajas_con_impuestos=@Trabajas_con_impuestos
,Modo_de_busqueda=@Modo_de_busqueda 
,Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad 
,Correo_para_envio_de_reportes =@Correo_para_envio_de_reportes 
,ConectarSunat=@ConectarSunat




















GO
/****** Object:  StoredProcedure [dbo].[editar_Gastos_varios]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[editar_Gastos_varios]
@Id_gasto As int,
@Fecha As datetime,
@Nro_documento As varchar(MAX),
@Tipo_comprobante As varchar(MAX),
@Importe As numeric(18,2),
@Descripcion As varchar(MAX),
@Id_caja As int,
@Id_concepto As int
As
UPDATE Gastos_varios Set

Fecha=@Fecha,
Nro_documento=@Nro_documento,
Tipo_comprobante=@Tipo_comprobante,
Importe=@Importe,
Descripcion=@Descripcion,
Id_caja=@Id_caja,
Id_concepto=@Id_concepto
Where Id_gasto=@Id_gasto













GO
/****** Object:  StoredProcedure [dbo].[editar_Grupo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_Grupo]
@id int,
@Grupo varchar(50)

as
if EXISTS (SELECT Linea FROM Grupo_de_Productos  where Linea = @Grupo and Idline<>@id  )
RAISERROR ('YA EXISTE UN GRUPO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
update  Grupo_de_Productos set Linea=@grupo
where Idline=@id
























GO
/****** Object:  StoredProcedure [dbo].[editar_inicio_De_sesion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_inicio_De_sesion]

 
 @Id_serial_Pc varchar(max),
 @id_usuario int
  as
update Inicios_de_sesion_por_caja set 
Id_usuario =@id_usuario 
where Id_serial_Pc=@Id_serial_Pc 









GO
/****** Object:  StoredProcedure [dbo].[EDITAR_marcan_a]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EDITAR_marcan_a]

	@e varchar(max),
	@fa varchar(max),
	@f  varchar(max),
	@s varchar(max)
    as
	
    UPDATE Marcan SET E=@e, FA=@fa, F=@f 
	where S=@s 







GO
/****** Object:  StoredProcedure [dbo].[editar_Producto1]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_Producto1]
@Id_Producto1 int,
 @Descripcion varchar(50),         
          @Id_grupo INT,
		  @Usa_inventarios varchar(50),
	  @Stock varchar(50),
           @Precio_de_compra numeric(18,2),
           @Fecha_de_vencimiento varchar(50),
           @Precio_de_venta numeric(18,2),
           @Codigo varchar(50),
           @Se_vende_a varchar(50),
           @Stock_minimo numeric(18,2),
           @Precio_mayoreo numeric(18,2)
		 	,@A_partir_de numeric(18,2),
			@CodigoSunat varchar(8),
			@CodUm varchar(5)
as 

if EXISTS (SELECT Descripcion FROM Producto1  where (Descripcion = @Descripcion and Id_Producto1 <>@Id_Producto1 ) )

RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NOMBRE, POR FAVOR INGRESE DE NUEVO', 16,1)

else if EXISTS (SELECT Codigo  FROM Producto1  where (Codigo  = @Codigo  and Id_Producto1 <>@Id_Producto1 ))

RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE CODIGO, POR FAVOR INGRESE DE NUEVO/ SE GENERARA CODIGO AUTOMATICO', 16,1)

else if EXISTS (SELECT Descripcion,Codigo  FROM Producto1  where (Id_Producto1 =@Id_Producto1 ))

update Producto1 set  

      Descripcion =@Descripcion ,
				         
         
         Id_grupo = @Id_grupo 	,
		  Usa_inventarios =@Usa_inventarios ,
		  Stock = @Stock ,
           Precio_de_compra =@Precio_de_compra ,
        Fecha_de_vencimiento =   @Fecha_de_vencimiento ,
          Precio_de_venta = @Precio_de_venta ,
         Codigo =  @Codigo ,
         Se_vende_a =  @Se_vende_a ,
           Stock_minimo =@Stock_minimo ,
         Precio_mayoreo =  @Precio_mayoreo 
		 	,A_partir_de=@A_partir_de ,
			CodigoSunat=@CodigoSunat,
			CodUm=@CodUm
where id_Producto1=@Id_Producto1




























GO
/****** Object:  StoredProcedure [dbo].[editar_Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[editar_Proveedores]
@IdProveedor As int,
@Nombre As varchar(MAX),
@Direccion As varchar(MAX),
@IdentificadorFiscal As varchar(MAX),
@Celular As varchar(MAX)
As
if EXISTS(select Nombre  from Proveedores where Nombre=@Nombre and IdProveedor <> @IdProveedor )
RAISERROR('Registro ya existente', 16,1)
else
UPDATE Proveedores Set

Nombre=@Nombre,
Direccion=@Direccion,
IdentificadorFiscal=@IdentificadorFiscal,
Celular=@Celular
Where IdProveedor=@IdProveedor












GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_serializacion]
@serie VARCHAR(50)  ,
@Cantidad_de_numeros AS VARCHAR(50)    ,
@numerofin as varchar(50) ,
@Tipo as varchar(50), 
   @Id_serie as int
as 
update Serializacion set  Serie =@serie   ,Cantidad_de_numeros=@Cantidad_de_numeros ,numerofin=@numerofin-1   
         ,tipodoc =@Tipo 
where Id_serializacion=@Id_serie 





GO
/****** Object:  StoredProcedure [dbo].[editar_serializacion_POR_DEFECTO]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_serializacion_POR_DEFECTO]


   @Id_serie as int
as 

BEGIN
update Serializacion set  Por_defecto  ='-' 
     END


	 BEGIN
	 update Serializacion set  Por_defecto  ='SI'
where Id_serializacion=@Id_serie 

END




















GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[editar_usuario]
@idUsuario int,
@nombres varchar(50) ,
@Login varchar(50),
@Password VARCHAR(50),
@Icono image,
@Nombre_de_icono varchar(max),
@Correo varchar(max),
@Rol varchar(max)
as
if EXISTS (SELECT Login,idUsuario FROM USUARIO2 where (Login  = @login  AND idUsuario<>@idUsuario and Estado='ACTIVO') or (Nombres_y_Apellidos   = @nombres  AND idUsuario<>@idUsuario and Estado='ACTIVO'))
raiserror('YA EXISTE UN USUARIO CON ESE LOGIN O CON ESE ICONO, POR FAVOR INGRESE DE NUEVO',16,1 )

ELSE

update USUARIO2 set Nombres_y_Apellidos=@nombres ,Password =@Password , Icono=@Icono ,Nombre_de_icono =@Nombre_de_icono
 ,Correo =@Correo , Rol=@rol , Login =@Login
 where idUsuario=@idUsuario 
























GO
/****** Object:  StoredProcedure [dbo].[EditarBascula]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditarBascula]
@idcaja int,
@Puerto varchar(max),
@Estado varchar(50)

as
update Caja set   PuertoBalanza=@Puerto , EstadoBalanza = @Estado 
where Id_Caja = @idcaja






GO
/****** Object:  StoredProcedure [dbo].[editarDvrestar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarDvrestar]
@Iddv as int
,@idventa int
as
update detalle_venta set 
cantidad=cantidad - 1 
where iddetalle_venta =@Iddv

delete from detalle_venta where  idventa =@idventa and cantidad <=0

GO
/****** Object:  StoredProcedure [dbo].[editarDvsumar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarDvsumar]
@Iddv as int
as
update detalle_venta set 
cantidad=cantidad + 1 
where iddetalle_venta =@Iddv

GO
/****** Object:  StoredProcedure [dbo].[editarEstadoSunatVenta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarEstadoSunatVenta]
@Idventa int
as
update ventas set Estadosunat='ACEPTADA'
where idventa=@Idventa

GO
/****** Object:  StoredProcedure [dbo].[EditarPreciosProductos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EditarPreciosProductos]
@idproducto int,
@precioventa numeric(18,2),
@costo numeric(18,2),
@preciomayoreo numeric(18,2),
@cantidadAgregada numeric(18,2)

as
update Producto1 set 
Precio_de_venta=@precioventa ,
Precio_de_compra = @costo ,
Precio_mayoreo=@preciomayoreo ,
Stock = Stock + @cantidadAgregada
where Id_Producto1=@idproducto and Usa_inventarios = 'SI'






GO
/****** Object:  StoredProcedure [dbo].[editarPrecioVenta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarPrecioVenta]
@iddetalleventa int,
@precio numeric(18,2)
as
update detalle_venta set preciounitario=@precio 
where iddetalle_venta=@iddetalleventa 






GO
/****** Object:  StoredProcedure [dbo].[editarRespaldos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editarRespaldos]

@Ultima_fecha_de_copia_de_seguridad  varchar(50),
@Carpeta_para_copias_de_seguridad varchar (max),
@Ultima_fecha_de_copia_date datetime,
@Frecuencia_de_copias int
as
update EMPRESA  set Ultima_fecha_de_copia_de_seguridad =@Ultima_fecha_de_copia_de_seguridad ,
Carpeta_para_copias_de_seguridad =@Carpeta_para_copias_de_seguridad ,Ultima_fecha_de_copia_date=@Ultima_fecha_de_copia_date
,Frecuencia_de_copias= @Frecuencia_de_copias 









GO
/****** Object:  StoredProcedure [dbo].[EditarserializacionInc]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarserializacionInc]
as
update Serializacion set numerofin=numerofin+1
where Serie='TC'





GO
/****** Object:  StoredProcedure [dbo].[editarSunatEmpresa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editarSunatEmpresa]
@Ruc  varchar(50),
@DireccionFiscal varchar(MAX),
@Ubigeo varchar(50),
@Servidor varchar(max),
@CarpetaCertificado varchar(max),
@Passcertificado varchar(max),
@UserSecundario varchar(max),
@PassSecundario varchar(max),
@Codmoneda varchar(10)
as
update  EMPRESA set Ruc=@Ruc ,DireccionFiscal=@DireccionFiscal ,
Ubigeo=@Ubigeo,Servidor=@Servidor
,CarpetaCertificado=@CarpetaCertificado 
,Passcertificado =@Passcertificado 
,UserSecundario =@UserSecundario 
,PassSecundario=@PassSecundario,
CodMoneda = @CodMoneda 



















GO
/****** Object:  StoredProcedure [dbo].[EditarTemaCaja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarTemaCaja]
@idcaja int, 
@tema varchar(50)
as
update Caja set Tema= @tema 
where Id_Caja=@idcaja 






GO
/****** Object:  StoredProcedure [dbo].[editarVenta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarVenta]
@idventa int,
@monto numeric(18,2)
as
if @monto <>0
update ventas set Monto_total=@monto 
where idventa = @idventa 
else
delete from ventas 
where idventa = @idventa 






GO
/****** Object:  StoredProcedure [dbo].[editarVentaAnulada]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarVentaAnulada]
@Idventa int
as
update ventas set Estadosunat='ANULADA'
where idventa=@Idventa

GO
/****** Object:  StoredProcedure [dbo].[eliminar_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_caja]
@idcaja integer
as
update Caja set
Estado  ='Caja Eliminada'
where Id_Caja    =@idcaja



















GO
/****** Object:  StoredProcedure [dbo].[eliminar_clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[eliminar_clientes]
@Idcliente As int

As
update   clientes
set Estado ='ELIMINADO'
WHERE idclientev =@Idcliente











GO
/****** Object:  StoredProcedure [dbo].[eliminar_CreditoPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[eliminar_CreditoPorPagar]
@Id_credito As int

As
DELETE FROM CreditoPorPagar
WHERE Id_credito=@Id_credito











GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_compra]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_detalle_compra]
@iddetallecompra as int
as
delete DetalleCompra where IdDetallecompra=@iddetallecompra 



















GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_detalle_venta]
@iddetalleventa as int
as
delete detalle_venta where iddetalle_venta=@iddetalleventa 



















GO
/****** Object:  StoredProcedure [dbo].[eliminar_gasto]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_gasto]
@idgasto integer
as
delete from Gastos_varios   where Id_gasto  =@idgasto 











GO
/****** Object:  StoredProcedure [dbo].[eliminar_ingreso]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_ingreso]
@idingreso integer
as
delete from Ingresos_varios    where Id_ingreso  =@idingreso 












GO
/****** Object:  StoredProcedure [dbo].[eliminar_Producto1]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_Producto1]
@id  int
as
delete from Producto1  where Id_Producto1 =@id 






















GO
/****** Object:  StoredProcedure [dbo].[eliminar_Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[eliminar_Proveedores]
@IdProveedor As int

As
update   Proveedores
set Estado ='ELIMINADO'
WHERE IdProveedor=@IdProveedor











GO
/****** Object:  StoredProcedure [dbo].[eliminar_Serializacion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_Serializacion]
@id integer
as
if EXISTS (SELECT Destino FROM Serializacion  where Destino <>'OTROS' AND ID_SERIALIZACION=@id )
RAISERROR ('Este Comprobante no se Eliminara ya que generaria Error', 16,1)
else
delete from Serializacion   where Id_serializacion   =@id and Destino='OTROS'























GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_usuario]
@idusuario int,
@login varchar(50)
as
if exists(select login from USUARIO2 where @login ='admin')
raiserror('El Usuario *Admin* es Inborrable, si se borraria Eliminarias el Acceso al Sistema de porvida, Accion Denegada', 16,1)
else
UPDATE  USUARIO2 SET Estado='ELIMINADO'
 WHERE idUsuario =@idusuario and Login <>'admin'
























GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_venta]
@idventa as integer
as
delete from ventas where idventa=@idventa 



















GO
/****** Object:  StoredProcedure [dbo].[eliminarComprasvacias]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarComprasvacias]
@Idcaja int
as
delete from Compras where Idcaja =@Idcaja and Total=0





GO
/****** Object:  StoredProcedure [dbo].[eliminarControlCobro]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarControlCobro]
@idcontrol int 
as
delete from ControlCobros
where IdcontrolCobro=@idcontrol 






GO
/****** Object:  StoredProcedure [dbo].[EliminarNcXerror]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarNcXerror]
@idventa int
as
delete from NotaCredito 
where  idventa =@idventa



GO
/****** Object:  StoredProcedure [dbo].[eliminarVentasIncomp]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarVentasIncomp]
@Idcaja as integer
as
delete from ventas where Id_caja=@Idcaja
and Estado='EN ESPERA'


GO
/****** Object:  StoredProcedure [dbo].[Insertar_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_caja]

	
	@descripcion varchar(50),


	 @Tema varchar(50),
	  @Serial_PC varchar(max),
	   @Impresora_Ticket varchar(max),
	   @Impresora_A4 varchar(max),
	   @Tipo varchar(50)
    as
		declare @PuertoBalanza varchar(max)
	declare @EstadoBalanza varchar(50)
	set @PuertoBalanza='-'
	set @EstadoBalanza = 'PENDIENTE'
if EXISTS (SELECT  Descripcion,Serial_PC      FROM Caja    where  Descripcion=@descripcion and Serial_PC =@Serial_PC   )
RAISERROR ('Ya Existe una Caja con ese Nombre', 16,1)
else

declare @Estado as varchar(50)
set @Estado ='RECIEN CREADA'

    INSERT INTO Caja values 
	(@descripcion,@Tema ,@Serial_PC ,@Impresora_Ticket,@Impresora_A4,@Estado,@Tipo,@PuertoBalanza,@EstadoBalanza )











GO
/****** Object:  StoredProcedure [dbo].[insertar_clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[insertar_clientes]
@Nombre As varchar(MAX),
@Direccion As varchar(MAX),
@IdentificadorFiscal As varchar(MAX),
@Celular As varchar(MAX),
@Estado As varchar(50),
@Saldo As numeric(18,2)
As
if EXISTS(select Nombre  from clientes  where Nombre=@Nombre )
RAISERROR('Registro ya existente', 16,1)
else
INSERT INTO clientes
Values (
@Nombre,
@Direccion,
@IdentificadorFiscal,
@Celular,
@Estado,
@Saldo)











GO
/****** Object:  StoredProcedure [dbo].[insertar_Compras]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[insertar_Compras]
@Idcaja int,
@fechacompra As datetime,
@Estado varchar(50),
/*Parametros de detallecompras*/
@Cantidad As numeric(18,2),
@Costo As numeric(18,2),
@Moneda As varchar(50),
@IdProducto As int,
@Descripcion As varchar(MAX)
as
/*Parametros de compras*/
declare @Total As numeric(18,2)
declare @Comprobante As varchar(MAX)
declare @IdProveedor As int
set @Total=0
set @Comprobante='-'
set @IdProveedor = (select IdProveedor  from Proveedores where Estado='0')
/*Parametros de detallecompra*/
declare @IdCompra As int

if (@Estado = 'COMPRA NUEVA')
INSERT INTO Compras
Values (
@fechacompra,
@Total,
@Comprobante,
@IdProveedor,
@Idcaja)
select  @IdCompra = scope_identity()


 
if(@Estado = 'COMPRA GENERADA')
set @IdCompra = (select top 1 Max(Idcompra) from Compras where Idcaja=@Idcaja)
if EXISTS (SELECT IdProducto,IdCompra   FROM DetalleCompra 
inner join Producto1 on Producto1.Id_Producto1=DetalleCompra.IdProducto 
  where Producto1.Id_Producto1  = @IdProducto AND IdCompra=@IdCompra  ) 
update DetalleCompra set 
cantidad =cantidad +@cantidad
where IdProducto =@IdProducto and IdCompra=@IdCompra
else
INSERT INTO DetalleCompra
Values (
@IdCompra,
@Cantidad,
@Costo,
@Moneda,
@IdProducto,
@Descripcion)









GO
/****** Object:  StoredProcedure [dbo].[insertar_Conceptos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Conceptos]
@Descripcion As varchar(MAX)
As
if Exists(select Descripcion  from Conceptos where Descripcion =@Descripcion  )
Raiserror('Concepto ya registrado',16,1 )
else
INSERT INTO Conceptos
Values (
@Descripcion)













GO
/****** Object:  StoredProcedure [dbo].[insertar_ControlCobros]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[insertar_ControlCobros]
@Monto As numeric(18,2),
@Fecha As datetime,
@Detalle As varchar(MAX),
@IdCliente As int,
@IdUsuario As int,
@IdCaja As int,
@Comprobante As varchar(MAX),
@efectivo numeric(18,2),
@tarjeta numeric(18,2)
As
INSERT INTO ControlCobros
Values (
@Monto,
@Fecha,
@Detalle,
@IdCliente,
@IdUsuario,
@IdCaja,
@Comprobante,
@efectivo,
@tarjeta)






GO
/****** Object:  StoredProcedure [dbo].[insertar_CreditoPorCobrar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_CreditoPorCobrar]
@Descripcion As varchar(MAX),
@Fecha_registro As datetime,
@Fecha_vencimiento As date,
@Total As numeric(18,2),
@Saldo As numeric(18,2),
@Estado As varchar(MAX),
@Id_caja As int,
@Id_cliente As int
As
INSERT INTO CreditoPorCobrar
Values (
@Descripcion,
@Fecha_registro,
@Fecha_vencimiento,
@Total,
@Saldo,
@Estado,
@Id_caja,
@Id_cliente)











GO
/****** Object:  StoredProcedure [dbo].[insertar_CreditoPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[insertar_CreditoPorPagar]
@Descripcion As varchar(MAX),
@Fecha_registro As datetime,
@Fecha_vencimiento As date,
@Total As numeric(18,2),
@Saldo As numeric(18,2),
@Estado As varchar(MAX),
@Id_caja As int,
@Id_Proveedor As int
As
INSERT INTO CreditoPorPagar
Values (
@Descripcion,
@Fecha_registro,
@Fecha_vencimiento,
@Total,
@Saldo,
@Estado,
@Id_caja,
@Id_Proveedor)












GO
/****** Object:  StoredProcedure [dbo].[insertar_DETALLE_cierre_de_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_DETALLE_cierre_de_caja]
	@fechaini datetime,
	 @fechafin datetime,
	 @fechacierre datetime, 
	  @ingresos numeric(18,2), 
    @egresos numeric(18,2),
	@saldo numeric(18,2),
	@idusuario int,
	 @totalcaluclado numeric(18,2),
	  @totalreal numeric(18,2), 
	 
	 @estado as varchar(50),
	 @diferencia as numeric(18,2)	,
	 @id_caja as int   
  AS BEGIN

if EXISTS (SELECT Estado FROM MOVIMIENTOCAJACIERRE 
 where  MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' and Id_caja =@id_caja )
RAISERROR ('Ya Fue Iniciado el Turno de esta Caja', 16,1)
else
BEGIN
    INSERT INTO MOVIMIENTOCAJACIERRE values 
	(@fechaini ,
	 @fechafin ,
	 @fechacierre , 
	  @ingresos , 
    @egresos ,
	@saldo ,
	@idusuario ,
	 @totalcaluclado ,
	  @totalreal , 
	
	 @estado ,
	 @diferencia ,
	 @id_caja )


	 end
	 end
























GO
/****** Object:  StoredProcedure [dbo].[insertar_DetalleCompra]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[insertar_DetalleCompra]
@IdCompra As int,
@Cantidad As numeric(18,2),
@Costo As numeric(18,2),
@Moneda As varchar(50),
@IdProducto As int,
@Descripcion As varchar(MAX)
As
if EXISTS (SELECT IdProducto,IdCompra   FROM DetalleCompra 
inner join Producto1 on Producto1.Id_Producto1=DetalleCompra.IdProducto 
  where Producto1.Id_Producto1  = @IdProducto AND IdCompra=@IdCompra  ) 
update DetalleCompra set 
cantidad =cantidad +@cantidad
where IdProducto =@IdProducto 

INSERT INTO DetalleCompra
Values (
@IdCompra,
@Cantidad,
@Costo,
@Moneda,
@IdProducto,
@Descripcion)





GO
/****** Object:  StoredProcedure [dbo].[insertar_Empresa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Empresa]
@RazonSocial varchar(max),
@logo as image,
@Impuesto varchar(50),
@Porcentaje_impuesto numeric(18,0),
@SimboloMoneda varchar(50),
@Trabajas_con_impuestos VARCHAR(50),
@Modo_de_busqueda VARCHAR(50),
@Carpeta_para_copias_de_seguridad varchar(max),
@Correo_para_envio_de_reportes varchar(50)
as
declare @VersionUbl varchar(3) set @VersionUbl='2.1'
declare @VersionEstDoc varchar(3) set @VersionEstDoc='2.0'
declare @Ruc varchar(11) set @Ruc='-'
declare @DireccionFiscal varchar(max) set @DireccionFiscal='-'
declare @Ubigeo varchar(50) set @Ubigeo='020111'
declare @ConectarSunat varchar(2) set @ConectarSunat='NO'
declare @Servidor varchar(max) set @Servidor='-'
declare @CarpetaCertificado varchar(max) set @CarpetaCertificado='-'
declare @Passcertificado varchar(max) set @Passcertificado='-'
declare @UserSecundario varchar(max) set @UserSecundario='-'
declare @PassSecundario varchar(max) set @PassSecundario='-'
declare @Frecuencia_de_copias int set @Frecuencia_de_copias=1
declare @Ultima_fecha_de_copia_de_seguridad varchar(50) set @Ultima_fecha_de_copia_de_seguridad='Ninguna'
declare @Ultima_fecha_de_copia_date datetime set @Ultima_fecha_de_copia_date=getdate()
declare @CodMoneda varchar(10) set @CodMoneda = '-'

insert into EMPRESA 
VALUES (@logo,@Impuesto,@Porcentaje_impuesto,@SimboloMoneda,@Trabajas_con_impuestos,@Modo_de_busqueda,
@Carpeta_para_copias_de_seguridad,@Correo_para_envio_de_reportes,@Ultima_fecha_de_copia_de_seguridad,
@Ultima_fecha_de_copia_date ,
@Frecuencia_de_copias ,
@VersionUbl,@VersionEstDoc,@Ruc,@RazonSocial,@DireccionFiscal,@Ubigeo,@ConectarSunat,
@Servidor,@CarpetaCertificado,@Passcertificado,@UserSecundario,@PassSecundario,@CodMoneda)





















GO
/****** Object:  StoredProcedure [dbo].[insertar_Gastos_varios]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[insertar_Gastos_varios]
@Fecha As datetime,
@Nro_documento As varchar(MAX),
@Tipo_comprobante As varchar(MAX),
@Importe As numeric(18,2),
@Descripcion As varchar(MAX),
@Id_caja As int,
@Id_concepto As int
As
INSERT INTO Gastos_varios
Values (
@Fecha,
@Nro_documento,
@Tipo_comprobante,
@Importe,
@Descripcion,
@Id_caja,
@Id_concepto)













GO
/****** Object:  StoredProcedure [dbo].[insertar_Grupo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Grupo]
@Grupo varchar(50),
@Por_defecto varchar(50)
as
if EXISTS (SELECT Linea FROM Grupo_de_Productos  where Linea = @Grupo  )
RAISERROR ('YA EXISTE UN GRUPO CON ESTE NOMBRE, Ingrese de nuevo', 16,1)
else
insert into Grupo_de_Productos  values (@Grupo, @Por_defecto)























GO
/****** Object:  StoredProcedure [dbo].[insertar_Ingresos_varios]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[insertar_Ingresos_varios]
@Fecha As datetime,
@Nro_comprobante As varchar(MAX),
@Tipo_comprobante As varchar(MAX),
@Importe As numeric(18,2),
@Descripcion As varchar(MAX),
@Id_caja As int
As
INSERT INTO Ingresos_varios
Values (
@Fecha,
@Nro_comprobante,
@Tipo_comprobante,
@Importe,
@Descripcion,
@Id_caja)













GO
/****** Object:  StoredProcedure [dbo].[insertar_inicio_De_sesion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[insertar_inicio_De_sesion]

 
 @Id_serial_Pc varchar(max)

  as
  declare @id_usuario_nuevo as int
  set @id_usuario_nuevo = (SELECT max(idUsuario)  FROM USUARIO2  )

insert into Inicios_de_sesion_por_caja

values (@Id_serial_Pc,@id_usuario_nuevo )





















GO
/****** Object:  StoredProcedure [dbo].[insertar_KARDEX_Entrada]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_KARDEX_Entrada]
           @Fecha datetime,
		   @Motivo varchar(max),
		   @Cantidad as numeric(18,2),
		   @Id_producto int	,
	       @Id_usuario as int,
		   @Tipo as varchar(50),
		    @Estado varchar(50),
			@Id_caja int
			as
			declare @Hay as numeric(18,2)
			declare @Habia as numeric(18,2)
			declare @Costo_unt numeric(18,2)
			set @Hay = (select Stock  from Producto1 where Id_Producto1 =@Id_producto and Usa_inventarios ='SI')
			set @Costo_unt=(select Precio_de_compra   from Producto1 where Id_Producto1 =@Id_producto and Usa_inventarios ='SI')
			set @Habia = @Hay-@Cantidad 

			insert into KARDEX 
			Values(
			 @Fecha ,
		     @Motivo ,			         
             @Cantidad 	,
	         @Id_producto 	,
	         @Id_usuario ,	
	         @Tipo,
		     @Estado ,@Costo_unt, @Habia ,@Hay ,@Id_caja)






GO
/****** Object:  StoredProcedure [dbo].[insertar_KARDEX_SALIDA]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_KARDEX_SALIDA]
           @Fecha datetime,
		   @Motivo varchar(max),
		   @Cantidad as numeric(18,2),
		   @Id_producto int	,
	       @Id_usuario as int,
		   @Tipo as varchar(50),
		    @Estado varchar(50),
			@Id_caja int
			as
			declare @Hay as numeric(18,2)
			declare @Habia as numeric(18,2)
			declare @Costo_unt numeric(18,2)
			set @Hay = (select Stock  from Producto1 where Id_Producto1 =@Id_producto and Usa_inventarios ='SI')
			set @Costo_unt=(select Precio_de_compra   from Producto1 where Id_Producto1 =@Id_producto and Usa_inventarios ='SI')
			set @Habia = @Hay+@Cantidad 

			insert into KARDEX 
			Values(
			 @Fecha ,
		     @Motivo ,			         
             @Cantidad 	,
	         @Id_producto 	,
	         @Id_usuario ,	
	         @Tipo,
		     @Estado ,@Costo_unt, @Habia ,@Hay ,@Id_caja)

	














GO
/****** Object:  StoredProcedure [dbo].[Insertar_marcan]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Insertar_marcan]

	
	@s varchar(MAX),
	@f varchar(MAX),
	@e varchar(MAX),
	@fa varchar(MAX)
    as
	
    INSERT INTO Marcan values 
	(@s,@f,@e ,@fa)





















GO
/****** Object:  StoredProcedure [dbo].[insertar_Producto]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Producto]   
           --Empezamos a declara primero los parametros para Productos
           @Descripcion varchar(50),         
           @Id_grupo as int	,
		   @Usa_inventarios varchar(50),
		   @Stock varchar(50),
           @Precio_de_compra numeric(18,2),
           @Fecha_de_vencimiento varchar(50),
           @Precio_de_venta numeric(18,2),
           @Codigo varchar(50),
           @Se_vende_a varchar(50),
           @Stock_minimo numeric(18,2),
           @Precio_mayoreo numeric(18,2)
	,@A_partir_de numeric(18,2),
	--Ahora declaramos los parametros para el Ingreso a Kardex que es donde se controla el Inventario
	@Fecha datetime,
		    @Motivo varchar(200),			               
          @Cantidad as numeric(18,2)	,
	 
	   @Id_usuario as int,	
	   @Tipo as varchar(50),
	   @Estado varchar(50)	,   	   		
		@Id_caja int,
		@CodigoSunat varchar(8),
		@CodUm varchar(5)
		   AS 
		   --Ahora VALIDAMOS para que no se agregen productos con el mismo nombre y codigo de barras
		   BEGIN
		
if EXISTS (SELECT Descripcion,Codigo  FROM Producto1  where Descripcion = @Descripcion and Codigo=@Codigo  )
RAISERROR ('YA EXISTE UN PRODUCTO  CON ESTE NOMBRE/CODIGO, POR FAVOR INGRESE DE NUEVO/ SE GENERARA CODIGO AUTOMATICO', 16,1)
else
BEGIN
DECLARE  @Id_producto  INT
		   INSERT INTO Producto1
     VALUES
		    (
           @Descripcion        
		    ,@Id_grupo 
		,@Usa_inventarios	,
		@Stock ,
           @Precio_de_compra ,
           @Fecha_de_vencimiento ,
           @Precio_de_venta ,
           @Codigo ,
           @Se_vende_a ,
           @Stock_minimo ,
           @Precio_mayoreo,
		   @A_partir_de,
		   @CodigoSunat,
		   @CodUm
		 )
		 --Ahora Obtenemos el Id del producto que se acaba de ingresar
		    SELECT  @id_producto = scope_identity()
			 --Ahora Obtenemos los datos del producto ingresado para que sean insertados en la Tabla KARDEX
			  DECLARE @Hay AS numeric(18,2)
		 DECLARE @Habia as numeric(18,2)
		 declare @Costo_unt numeric(18,2)
		
       SET @Hay = (SELECT Stock  FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
       SET @Costo_unt = (SELECT Producto1.Precio_de_compra   FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )		   
       SET @Habia = 0
	   --Ahora vamos a saber si el Producto usa Inventarios o no
		  set @Usa_inventarios = (SELECT Usa_inventarios   FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
		 --Ahora en caso si Use inventarios Entonces Pasamos a Insertar datos en la Tabla Kardex
		   if @Usa_inventarios ='SI'
		   BEGIN	 
		   INSERT INTO KARDEX
        VALUES
		    (
        @Fecha ,
		    @Motivo ,			                  
          @Cantidad 	,

	  @Id_producto 	,
	   @Id_usuario ,	
	   @Tipo,		
		@Estado ,@Costo_unt, @Habia ,@Hay ,@Id_caja)
		END
		
END
END























GO
/****** Object:  StoredProcedure [dbo].[insertar_Producto_Importacion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_Producto_Importacion]   
           --Empezamos a declara primero los parametros para Productos
           @Descripcion varchar(50),
		    @Imagen varchar(50),			         
         
     
		  @Usa_inventarios varchar(50),
		   @Stock varchar(50),
           @Precio_de_compra numeric(18,2),
           @Fecha_de_vencimiento varchar(50),
           @Precio_de_venta numeric(18,2),
           @Codigo varchar(50),
           @Se_vende_a varchar(50),
           @Impuesto varchar(50),
           @Stock_minimo numeric(18,2),
           @Precio_mayoreo numeric(18,2)
	,@A_partir_de numeric(18,2),
	--Ahora declaramos los parametros para el Ingreso a Kardex que es donde se controla el Inventario
	@Fecha datetime,
		    @Motivo varchar(200),			               
          @Cantidad as numeric(18,0)	,
	 
	   @Id_usuario as int,	
	   @Tipo as varchar(50),
	   @Estado varchar(50)	,   	   		
		@Id_caja int
		   AS 
		    declare    @Id_grupo as int	
			set @Id_grupo= (Select Idline  from Grupo_de_Productos where Grupo_de_Productos.Linea= 'General')
		   --Ahora VALIDAMOS para que no se agregen productos con el mismo nombre y codigo de barras
		   BEGIN
		
if EXISTS (SELECT Descripcion,Codigo  FROM Producto1  where (Descripcion = @Descripcion and Codigo=@Codigo) or Descripcion ='' )
select top 0 *from Producto1
else
BEGIN
DECLARE  @Id_producto  INT
		   INSERT INTO Producto1
     VALUES
		    (
           @Descripcion        
           ,@Imagen         
		    ,@Id_grupo 
		,@Usa_inventarios	,
		@Stock ,
           @Precio_de_compra ,
           @Fecha_de_vencimiento ,
           @Precio_de_venta ,
           @Codigo ,
           @Se_vende_a ,
           @Impuesto ,
           @Stock_minimo ,
           @Precio_mayoreo,
		   @A_partir_de
		 )
		 --Ahora Obtenemos el Id del producto que se acaba de ingresar
		    SELECT  @id_producto = scope_identity()
			 --Ahora Obtenemos los datos del producto ingresado para que sean insertados en la Tabla KARDEX
			  DECLARE @Hay AS numeric(18,2)
		 DECLARE @Habia as numeric(18,2)
		 declare @Costo_unt numeric(18,2)
		
       SET @Hay = (SELECT Stock  FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
       SET @Costo_unt = (SELECT Producto1.Precio_de_compra   FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )		   
       SET @Habia = 0
	   --Ahora vamos a saber si el Producto usa Inventarios o no
		  set @Usa_inventarios = (SELECT Usa_inventarios   FROM Producto1 WHERE Producto1.Id_Producto1   =@Id_producto and Producto1.Usa_inventarios ='SI' )
		 --Ahora en caso si Use inventarios Entonces Pasamos a Insertar datos en la Tabla Kardex
		   if @Usa_inventarios ='SI'

		   

		   BEGIN	 
		   INSERT INTO KARDEX
        VALUES
		    (
        @Fecha ,
		    @Motivo ,			                  
          @Cantidad 	,

	  @Id_producto 	,
	   @Id_usuario ,	
	   @Tipo,		
		@Estado ,@Costo_unt, @Habia ,@Hay ,@Id_caja)
		END
		
		begin
		update Producto1 set Codigo=Id_Producto1 
		where Codigo = 'VACIO@'
		end

		begin
		delete from Producto1 where Descripcion ='VACIO@'
		end

		begin
		delete from Producto1 where Descripcion ='Descripcion'
		end

END
END























GO
/****** Object:  StoredProcedure [dbo].[insertar_Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_Proveedores]
@Nombre As varchar(MAX),
@Direccion As varchar(MAX),
@IdentificadorFiscal As varchar(MAX),
@Celular As varchar(MAX),
@Estado As varchar(50),
@Saldo As numeric(18,2)
As
if EXISTS(select Nombre  from Proveedores where Nombre=@Nombre )
RAISERROR('Registro ya existente', 16,1)
else
INSERT INTO Proveedores
Values (
@Nombre,
@Direccion,
@IdentificadorFiscal,
@Celular,
@Estado,
@Saldo)











GO
/****** Object:  StoredProcedure [dbo].[insertar_Serializacion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_Serializacion]
as 
insert into Serializacion  (Serie,Cantidad_de_numeros,numerofin,Destino,tipodoc,Por_defecto,Codigo)
values
('FA01','8',1,'VENTAS','FACTURA','-','01'),
('B001','8',1,'VENTAS','BOLETA DE VENTA','-','03'),
('FC01','8',1,'FB','NOTA DE CREDITO','-','07'),
('FD01','8',1,'FB','NOTA DE DEBITO','-','08'),
('T001','8',1,'VENTAS','TICKET','SI','T1')



















GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertar_usuario]
@nombres varchar(50) ,
@Login varchar(50),
@Password VARCHAR(50),
@Icono image,
@Nombre_de_icono varchar(max),
@Correo varchar(max),
@Rol varchar(max),
@Estado varchar(50)
as
if exists (select Login FROM USUARIO2 where Login=@Login and Estado='ACTIVO')
raiserror('YA EXISTE UN USUARIO CON ESE LOGIN O CON ESE ICONO, POR FAVOR INGRESE DE NUEVO',16,1 )
ELSE

insert into USUARIO2 
values(@nombres,@Login,@Password,@Icono,@Nombre_de_icono,@Correo,@Rol,@Estado  )























GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_venta]
@Id_usuario int,
@Idcaja int
as 

declare @vuelto money
declare @Efectivo money
declare @Credito money
declare @Tarjeta money
declare @Estado varchar(50)
declare @Monto_total money
declare @Tipo_de_pago as varchar(50)
declare @idcliente int
declare @TotalIgv money
declare @ACCION varchar(50)
declare @Saldo money
declare @Pago_con money
declare @Porcentaje_IGV numeric(18,2)
declare @Referencia_tarjeta varchar(50)
declare @Idcomprobante int
declare @Serie varchar(4)
declare @Correlativo varchar(8)
declare @ContadorProductos int
declare @fecha_venta as datetime
declare @Fecha_de_pago datetime
declare @Idempresa int
declare @TotSubtotal money
declare @Estadosunat varchar(50)
declare @Idventagenerada int
set @TotSubtotal=0
set @Fecha_de_pago=(getdate())
set @fecha_venta =(getdate())
set @ContadorProductos=0
set @Serie='-'
set @Correlativo ='-'
set @Idempresa=(select Id_empresa from EMPRESA )
set @Idcomprobante = (select Id_serializacion from Serializacion where tipodoc ='TICKET')
set @Referencia_tarjeta='-'
set @Porcentaje_IGV=(select Porcentaje_impuesto from EMPRESA )
set @Pago_con =0
set @Saldo =0
set @ACCION='VENTA'
set @TotalIgv=0 
set @idcliente=(select idclientev from clientes where Estado='0')
set @Tipo_de_pago='-'
set @Monto_total =0
SET @vuelto =0
SET @Efectivo =0
SET @Credito =0
SET @Tarjeta =0
set @Estado='EN ESPERA'
set @Estadosunat = 'PENDIENTE'

insert into ventas 
values (@idcliente,@fecha_venta,@Monto_total,@Tipo_de_pago,@Estado,@TotalIgv,@Id_usuario,
@Fecha_de_pago,@ACCION,@Saldo,@Pago_con,@Porcentaje_IGV,@Idcaja,@Referencia_tarjeta,
@vuelto ,@Efectivo,@Credito,@Tarjeta,@Idcomprobante,@Serie,@Correlativo,@Idempresa,@ContadorProductos,
@TotSubtotal,@Estadosunat)
select @Idventagenerada= scope_identity() 
select @Idventagenerada from ventas


















GO
/****** Object:  StoredProcedure [dbo].[insertarCorreoBase]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarCorreoBase]
@Correo varchar(max),
@Password varchar(max),
@Estado_De_envio varchar(50)
as
Insert into CorreoBase values(@Correo,@Password,@Estado_De_envio)








GO
/****** Object:  StoredProcedure [dbo].[insertarDetalleventa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertarDetalleventa]
@idventa as integer,
@Id_producto as int,
@cantidad as numeric(18, 2)
as
declare @Unidad_de_medida as varchar(50)
declare @CodProdSunat varchar(10)
declare @Codigo varchar(50)
declare @Descripcion varchar(50)
declare @preciounitario as money
declare @Costo money
declare @moneda as varchar(50)
declare @Estado as varchar(50)

set @Estado ='EN ESPERA'
set @moneda =(select CodMoneda from EMPRESA )
set @Unidad_de_medida= (Select CodUm from Producto1 where Id_Producto1=@Id_producto)
set @CodProdSunat= (Select CodigoSunat from Producto1 where Id_Producto1=@Id_producto)
set @Codigo= (Select Codigo from Producto1 where Id_Producto1=@Id_producto)
set @Descripcion= (Select Descripcion from Producto1 where Id_Producto1=@Id_producto)
set @preciounitario= (Select Precio_de_venta from Producto1 where Id_Producto1=@Id_producto)
set @Costo= (Select Precio_de_compra from Producto1 where Id_Producto1=@Id_producto)

BEGIN
if EXISTS (SELECT Id_producto,idventa   FROM detalle_venta 
inner join Producto1 on Producto1.Id_Producto1=detalle_venta.Id_producto 
  where Producto1. Id_Producto1  = @Id_producto AND idventa=@idventa  ) 
update detalle_venta set 
cantidad    =cantidad +@cantidad 
where Id_producto =@Id_producto
else
BEGIN
insert into detalle_venta 
 values (@idventa,@Id_producto ,@cantidad,@preciounitario,@moneda,@Unidad_de_medida
,@Estado,@Descripcion,@Codigo ,@Costo,@CodProdSunat)
END
END




















GO
/****** Object:  StoredProcedure [dbo].[InsertarNotaCredito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarNotaCredito]
@Idventa int,
@Idcomprobante int,
@CodTipo varchar(2)
as
declare @EstadoSunat varchar(50)
set @EstadoSunat='PENDIENTE'
declare @Serie varchar(4)
set @Serie=(select Serie from Serializacion where Id_serializacion=@Idcomprobante)
declare @Correlativo varchar(8)
set @Correlativo=(select FORMAT(numerofin,'00000000') from Serializacion where Id_serializacion=@Idcomprobante)
insert into NotaCredito
values(
@Idventa,
@Serie,
@Correlativo,
@EstadoSunat,
@Idcomprobante,
@CodTipo)

update Serializacion set numerofin=numerofin+1
where Id_serializacion=@Idcomprobante


GO
/****** Object:  StoredProcedure [dbo].[InsertarNotaDebito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarNotaDebito]
@Idventa int,
@Idcomprobante int,
@CodTipo varchar(2)
as
declare @EstadoSunat varchar(50)
set @EstadoSunat='PENDIENTE'
declare @Serie varchar(4)
set @Serie=(select Serie from Serializacion where Id_serializacion=@Idcomprobante)
declare @Correlativo varchar(8)
set @Correlativo=(select FORMAT(numerofin,'00000000') from Serializacion where Id_serializacion=@Idcomprobante)
insert into NotaDebito
values(
@Idventa,
@Serie,
@Correlativo,
@EstadoSunat,
@Idcomprobante,
@CodTipo)

update Serializacion set numerofin=numerofin+1
where Id_serializacion=@Idcomprobante


GO
/****** Object:  StoredProcedure [dbo].[InsertarTicket]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertarTicket]
as
declare @Idempresa int set @Idempresa=(select Id_empresa from EMPRESA)
insert into Ticket (Id_Empresa,Nombre_de_Moneda,Agradecimiento,
pagina_Web_Facebook,Anuncio,Datos_fiscales_de_autorizacion,Por_defecto)
values(@Idempresa,'SOLES','Agradecimiento',
'Pagina web/ facebook', 'Anuncio',
'Datos fiscales','Ticket No Fiscal')

insert into CorreoBase (Correo,Password,EstadoEnvio)
values ('-','-','Sin confirmar')




















GO
/****** Object:  StoredProcedure [dbo].[InsertarTipoNc]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarTipoNc]
as
insert into Tiposnotacredito (Codigo,Descripcion)
values
('01','ANULACION DE LA OPERACION'),
('02','ANULACION POR ERROR EN EL RUC'),
('03','CORRECCION POR ERROR EN LA DESCRIPCION'),
('04','DESCUENTO GLOBAL'),
('05','DESCUENTO POR ITEM'),
('06','DEVOLUCION TOTAL'),
('07','DEVOLUCION POR ITEM'),
('08','BONIFICACION'),
('09','DISMINUCION EN EL VALOR')


GO
/****** Object:  StoredProcedure [dbo].[InsertarTipoNd]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarTipoNd]
as
insert into Tiposnotadebito (Codigo,Descripcion)
values
('01','INTERESES POR MORA'),
('02','AUMENTO EN EL VALOR'),
('03','PENALIDADES/ OTROS CONCEPTOS')

GO
/****** Object:  StoredProcedure [dbo].[InsertarUmedida]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarUmedida]
as
insert into UnidadesMedida
(Codigo,Descripcion)
values
('NIU','UNIDAD (BIENES)'),
('ZZ','UNIDAD (SERVICIOS)'),
('KGM','KILOGRAMO'),
('LTR','LITRO'),
('MTR','METRO'),
('BG','BOLSA')

GO
/****** Object:  StoredProcedure [dbo].[M_ventas_credito_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[M_ventas_credito_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Credito) from ventas 
where (fecha_venta >=@fi and fecha_venta <=@ff) and Id_caja=@idcaja











GO
/****** Object:  StoredProcedure [dbo].[M_ventas_Tarjeta_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[M_ventas_Tarjeta_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Tarjeta) from ventas 
where (fecha_venta >=@fi and fecha_venta <=@ff) and Id_caja=@idcaja 











GO
/****** Object:  StoredProcedure [dbo].[MarcanVencidas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MarcanVencidas]
@E varchar(max)
as
update Marcan set E=@E






GO
/****** Object:  StoredProcedure [dbo].[Mostrar_caja_principal]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Mostrar_caja_principal]
as
if Exists(Select MOVIMIENTOCAJACIERRE.Id_caja   from MOVIMIENTOCAJACIERRE inner join 
Caja on caja.Id_Caja=MOVIMIENTOCAJACIERRE.Id_caja where Caja.tipo='PRINCIPAL' )

Select Caja.*, USUARIO2.Nombres_y_Apellidos  ,MAX(MOVIMIENTOCAJACIERRE.idcierrecaja )    
from MOVIMIENTOCAJACIERRE inner join 
Caja on caja.Id_Caja=MOVIMIENTOCAJACIERRE.Id_caja 
inner join USUARIO2 on USUARIO2.idUsuario= MOVIMIENTOCAJACIERRE.Id_usuario 
where Caja.tipo='PRINCIPAL' 
GROUP BY Caja.Serial_PC, Caja.Id_Caja,Caja.Descripcion,Caja.Tema,Caja.Impresora_A4,Caja.Impresora_Ticket 
,Caja.Estado,CAJA.Tipo  , USUARIO2.Nombres_y_Apellidos, Caja.PuertoBalanza , Caja.EstadoBalanza 

else

Select Caja.*, USUARIO2.Nombres_y_Apellidos  from Caja
cross join USUARIO2 
 where tipo='PRINCIPAL' and USUARIO2.Login  ='admin'







GO
/****** Object:  StoredProcedure [dbo].[Mostrar_caja_remota]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Mostrar_caja_remota]
as
if Exists(Select MOVIMIENTOCAJACIERRE.Id_caja   from MOVIMIENTOCAJACIERRE inner join 
Caja on caja.Id_Caja=MOVIMIENTOCAJACIERRE.Id_caja where Caja.tipo='SECUNDARIA' )

Select Caja.*, USUARIO2.Nombres_y_Apellidos   ,MAX(MOVIMIENTOCAJACIERRE.idcierrecaja )    
from MOVIMIENTOCAJACIERRE inner join 
Caja on caja.Id_Caja=MOVIMIENTOCAJACIERRE.Id_caja 
inner join USUARIO2 on USUARIO2.idUsuario= MOVIMIENTOCAJACIERRE.Id_usuario 
where Caja.tipo='SECUNDARIA' 
GROUP BY Caja.Serial_PC, Caja.Id_Caja,Caja.Descripcion,Caja.Tema,Caja.Impresora_A4,Caja.Impresora_Ticket 
,Caja.Estado,CAJA.Tipo  , USUARIO2.Nombres_y_Apellidos ,Caja.PuertoBalanza , Caja.EstadoBalanza
else

Select Caja.*, USUARIO2.Nombres_y_Apellidos  from Caja
cross join USUARIO2 
 where tipo='SECUNDARIA' and USUARIO2.Login  ='admin'






















GO
/****** Object:  StoredProcedure [dbo].[mostrar_cajas_por_Serial_de_DiscoDuro]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[mostrar_cajas_por_Serial_de_DiscoDuro]
@Serial as varchar(max)
as
select Id_Caja  ,Descripcion ,Impresora_Ticket,Impresora_A4,Estado,Tipo,Tema
from Caja 
where Serial_PC =@Serial









GO
/****** Object:  StoredProcedure [dbo].[mostrar_cierre_de_caja_pendiente]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cierre_de_caja_pendiente]
@idcaja int
as
select Id_caja,fechainicio,Saldo_queda_en_caja as SaldoInicial from MOVIMIENTOCAJACIERRE 
where Id_caja=@idcaja and Estado='CAJA APERTURADA'











GO
/****** Object:  StoredProcedure [dbo].[mostrar_clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_clientes]
As
SELECT        idclientev , Nombre, Direccion, IdentificadorFiscal as [Identificador Fiscal] , Celular, Estado, Saldo
FROM            dbo.clientes where Nombre<>'GENERICO'











GO
/****** Object:  StoredProcedure [dbo].[mostrar_cobros_en_efectivo_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_cobros_en_efectivo_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Efectivo ) from ControlCobros  
where (Fecha >=@fi and Fecha <=@ff) and IdCaja =@idcaja 







GO
/****** Object:  StoredProcedure [dbo].[mostrar_cobros_tarjeta_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_cobros_tarjeta_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Tarjeta ) from ControlCobros  
where (Fecha >=@fi and Fecha <=@ff) and IdCaja =@idcaja 






GO
/****** Object:  StoredProcedure [dbo].[mostrar_ControlCobros]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[mostrar_ControlCobros]
As
Select * FROM ControlCobros







GO
/****** Object:  StoredProcedure [dbo].[mostrar_CreditoPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[mostrar_CreditoPorPagar]
As
Select * FROM CreditoPorPagar













GO
/****** Object:  StoredProcedure [dbo].[mostrar_descripcion_produco_sin_repetir]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_descripcion_produco_sin_repetir]

@buscar varchar(50)
as begin
select TOP 10 Descripcion  from Producto1  Where Descripcion  LIKE  '%' + @buscar +'%'
end























GO
/****** Object:  StoredProcedure [dbo].[mostrar_DetalleCompra]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROC [dbo].[mostrar_DetalleCompra]
@Idcompra int
As

Select IdDetallecompra,IdCompra,Producto1.Id_Producto1,Producto1.Descripcion,Cantidad,
Costo,convert(numeric(18,2), Total) as Total,Producto1.Se_vende_a,Producto1.Usa_inventarios
FROM DetalleCompra
inner join Producto1 on Producto1.Id_Producto1=DetalleCompra.IdProducto
where IdCompra=@Idcompra 






GO
/****** Object:  StoredProcedure [dbo].[mostrar_Empresa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_Empresa]
as
select *,(Impuesto + ' ('+  CONVERT(VARCHAR(50),Porcentaje_impuesto) + ')') Impuesto 

from Empresa



















GO
/****** Object:  StoredProcedure [dbo].[mostrar_gastos_por_turnos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_gastos_por_turnos]
@idcaja int,
@fi as datetime,
@ff as datetime
as
SELECT        dbo.Gastos_varios.Id_gasto, dbo.Gastos_varios.Fecha, dbo.Conceptos.Descripcion Concepto,
dbo.Gastos_varios.Descripcion , dbo.Gastos_varios.Importe
FROM            dbo.Conceptos INNER JOIN
                         dbo.Gastos_varios ON dbo.Conceptos.Id_concepto = dbo.Gastos_varios.Id_concepto
						 where Gastos_varios.Id_caja = @idcaja and (Fecha >=@fi and Fecha <=@ff)











GO
/****** Object:  StoredProcedure [dbo].[mostrar_grupos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_grupos]

@buscar varchar(50)
as begin
select Idline,Linea  as Grupo from Grupo_de_Productos  Where Linea  LIKE  '%' + @buscar +'%'
end






















GO
/****** Object:  StoredProcedure [dbo].[mostrar_id_venta_por_Id_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_id_venta_por_Id_caja]
@Id_caja int
as
select Max(idventa) from ventas 
where Id_caja=@Id_caja 



















GO
/****** Object:  StoredProcedure [dbo].[mostrar_impresoras_por_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_impresoras_por_caja]
@Serial as varchar(max)
as
select Impresora_Ticket 
from Caja 
where Serial_PC =@Serial




















GO
/****** Object:  StoredProcedure [dbo].[mostrar_ingresos_por_turnos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_ingresos_por_turnos]
@idcaja int,
@fi as datetime,
@ff as datetime
as
SELECT        Id_ingreso , Fecha,
Descripcion ,Importe
FROM   Ingresos_varios          

where Id_caja = @idcaja and (Fecha >=@fi and Fecha <=@ff)











GO
/****** Object:  StoredProcedure [dbo].[mostrar_inicio_De_sesion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[mostrar_inicio_De_sesion]
  @id_serial_pc as varchar(max)
  as
select  Inicios_de_sesion_por_caja.Id_usuario ,USUARIO2.Nombres_y_Apellidos  
from Inicios_de_sesion_por_caja inner join 
USUARIO2 on USUARIO2.idUsuario=Inicios_de_sesion_por_caja.Id_usuario 

where Id_serial_Pc =@id_serial_pc 







GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL]

@serial varchar(max)

AS
SELECT USUARIO2.Login,USUARIO2.Nombres_y_Apellidos     FROM MOVIMIENTOCAJACIERRE 
inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' 












GO
/****** Object:  StoredProcedure [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[MOSTRAR_MOVIMIENTOS_DE_CAJA_POR_SERIAL_y_usuario]

@serial varchar(50),
@idusuario int

AS
SELECT USUARIO2.Login,USUARIO2.Nombres_y_Apellidos    FROM MOVIMIENTOCAJACIERRE inner join USUARIO2 on USUARIO2.idUsuario=MOVIMIENTOCAJACIERRE.Id_usuario
 inner join Caja on Caja.Id_Caja =MOVIMIENTOCAJACIERRE.Id_caja 
 where Caja.Serial_PC = @serial    AND MOVIMIENTOCAJACIERRE.Estado='CAJA APERTURADA' and MOVIMIENTOCAJACIERRE.Id_usuario =@idusuario and USUARIO2.Estado ='ACTIVO'
























GO
/****** Object:  StoredProcedure [dbo].[mostrar_notas_por_alumno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[mostrar_notas_por_alumno]
@Id_alumno int
AS
 Select dbo.NOTAS.*, dbo.Alumnos.Nombres +' ' + dbo.Alumnos.Apellido_Paterno + ' ' + Apellido_Materno  , dbo.Alumnos.Nombres, dbo.Alumnos.Codigo
 from NOTAS inner join Alumnos on Alumnos.idalumno =NOTAS.Id_alumno 
 
where NOTAS.Id_alumno =@Id_alumno  order by NOTAS.Id_notas  desc





















GO
/****** Object:  StoredProcedure [dbo].[mostrar_permisos_por_usuario_ROL_UNICO]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_permisos_por_usuario_ROL_UNICO]
@idusario int
as 
select 
USUARIO2.Rol 
from USUARIO2 
where USUARIO2.idUsuario  =@idusario and USUARIO2.Estado ='ACTIVO'












GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_vencidos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[mostrar_productos_vencidos]
as

select Id_Producto1,Codigo ,Descripcion 

,Fecha_de_vencimiento as F_vencimiento ,Stock
,datediff(day,Fecha_de_vencimiento,CONVERT(DATE,GETDATE ()))as [Dias Vencidos] from Producto1 

where   Fecha_de_vencimiento <>'NO APLICA' AND Fecha_de_vencimiento <= CONVERT(DATE,GETDATE ()) 























GO
/****** Object:  StoredProcedure [dbo].[mostrar_productos_vencidos_en_menos_de_30_dias]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[mostrar_productos_vencidos_en_menos_de_30_dias]

as

select Id_Producto1,Codigo ,Descripcion 

,Fecha_de_vencimiento as F_vencimiento ,Stock
,(datediff(day,Fecha_de_vencimiento,CONVERT(DATE,GETDATE ())))*(-1)as [Dias a Vencer] from Producto1 

where   Fecha_de_vencimiento <>'NO APLICA' AND Fecha_de_vencimiento > CONVERT(DATE,GETDATE ()) and (datediff(day,Fecha_de_vencimiento,CONVERT(DATE,GETDATE ())))*(-1) <=30
order by (datediff(day,Fecha_de_vencimiento,CONVERT(DATE,GETDATE ())))*(-1) asc






















GO
/****** Object:  StoredProcedure [dbo].[mostrar_Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_Proveedores]
As
SELECT        IdProveedor, Nombre, Direccion, IdentificadorFiscal as [Identificador Fiscal] , Celular, Estado, Saldo
FROM            dbo.Proveedores











GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_usuario]
as
select  idUsuario,Nombres_y_Apellidos AS Nombres,Login,Password
,Icono ,Nombre_de_icono ,Correo ,rol  FROM USUARIO2 Where Estado='ACTIVO'
























GO
/****** Object:  StoredProcedure [dbo].[mostrar_ventas_en_efectivo_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_ventas_en_efectivo_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Efectivo) from ventas 
where (fecha_venta >=@fi and fecha_venta <=@ff) and Id_caja=@idcaja 











GO
/****** Object:  StoredProcedure [dbo].[mostrarCodSunatXCod]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarCodSunatXCod]
@codigo varchar(10)
as
select * from CodigosProdSunat
where Codigo=@codigo

GO
/****** Object:  StoredProcedure [dbo].[mostrarDetalleventa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarDetalleventa]
@idventa as int
as
SELECT      detalle_venta . Codigo ,( detalle_venta.Descripcion ) as Producto,
 dbo.detalle_venta.cantidad as Cant, 
dbo.detalle_venta.preciounitario as P_Unit ,
convert(numeric(18,2),dbo.detalle_venta.Total_a_pagar) as Importe,
						  detalle_venta .Id_producto  ,detalle_venta.iddetalle_venta ,dbo.ventas.Estado 
						 ,dbo.detalle_venta.cantidad ,ventas.idclientev
						 ,detalle_venta.idventa ,Unidad_de_medida,
						 CodProdSunat
						 
FROM            dbo.detalle_venta INNER JOIN
ventas ON dbo.detalle_venta.idventa = ventas.idventa 
where dbo.detalle_venta .idventa =@idventa AND detalle_venta.cantidad >0 order by 
detalle_venta.iddetalle_venta desc



















GO
/****** Object:  StoredProcedure [dbo].[mostrarInventarios]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[mostrarInventarios]
AS 
SELECT    Codigo ,Descripcion,Precio_de_compra as Costo,Precio_de_venta as [Precio_Venta], Stock, Stock_minimo as [Stock_Minimo]
,Grupo_de_Productos.Linea  AS Categoria ,Precio_de_compra*Stock as Importe,
EMPRESA.RazonSocial as Nombre_Empresa ,EMPRESA.Logo 
FROM         
Producto1 
cross join EMPRESA
inner join Grupo_de_Productos on Grupo_de_Productos.Idline=Producto1.Id_grupo 
where Producto1.Usa_inventarios ='SI'






GO
/****** Object:  StoredProcedure [dbo].[mostrarNotasCacep]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarNotasCacep]
as
select * from NotaCredito
where EstadoSunat='APROBADA'


GO
/****** Object:  StoredProcedure [dbo].[mostrarNotascredito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarNotascredito]
@letra varchar(50)
as
select Serializacion.tipodoc as  [Tipo comprobante], NotaCredito.Serie+'-'+Serializacion.Codigo+'-'+NotaCredito.Correlativo  as Comprobante
,NotaCredito.EstadoSunat as [Estado envio sunat],
(ventas.Serie +'-'+ ventas.Correlativo) as Afecta
from NotaCredito 
inner join Serializacion on Serializacion.Id_serializacion=NotaCredito.Idcomprobante
inner join ventas on ventas.idventa = NotaCredito.Idventa

where NotaCredito.Serie+'-'+Serializacion.Codigo+'-'+NotaCredito.Correlativo LIKE '%'+ @letra +'%'



GO
/****** Object:  StoredProcedure [dbo].[mostrarNotascreditoXidventa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarNotascreditoXidventa]
@Idventa int
as
select Top 1 *,Serializacion.Codigo,EMPRESA.Ruc,RazonSocial,
EMPRESA.DireccionFiscal,clientes.IdentificadorFiscal,clientes.Nombre, clientes.Direccion
,EMPRESA.Ubigeo,NotaCredito.Serie as SerieNc,NotaCredito.Correlativo as CorrelativoNc
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join EMPRESA  on EMPRESA.Id_empresa = ventas.Idempresa
inner join clientes on clientes.idclientev = ventas.idclientev
inner join NotaCredito on NotaCredito.Idventa=ventas.idventa
where ventas.idventa=@Idventa


GO
/****** Object:  StoredProcedure [dbo].[mostrarNotasdebito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarNotasdebito]
@letra varchar(50)
as
select Serializacion.tipodoc as  [Tipo comprobante], NotaDebito.Serie+'-'+Serializacion.Codigo+'-'+NotaDebito.Correlativo  as Comprobante
,NotaDebito.EstadoSunat as [Estado envio sunat],
(ventas.Serie +'-'+ ventas.Correlativo) as Afecta
from NotaDebito 
inner join Serializacion on Serializacion.Id_serializacion=NotaDebito.Idcomprobante
inner join ventas on ventas.idventa = NotaDebito.Idventa

where NotaDebito.Serie+'-'+Serializacion.Codigo+'-'+NotaDebito.Correlativo LIKE '%'+ @letra +'%'



GO
/****** Object:  StoredProcedure [dbo].[mostrarNotasdebitoXidventa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarNotasdebitoXidventa]
@Idventa int
as
select Top 1 *,Serializacion.Codigo,EMPRESA.Ruc,RazonSocial,
EMPRESA.DireccionFiscal,clientes.IdentificadorFiscal,clientes.Nombre, clientes.Direccion
,EMPRESA.Ubigeo,NotaDebito.Serie as SerieNc,NotaDebito.Correlativo as CorrelativoNc
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join EMPRESA  on EMPRESA.Id_empresa = ventas.Idempresa
inner join clientes on clientes.idclientev = ventas.idclientev
inner join NotaDebito on NotaDebito.Idventa=ventas.idventa
where ventas.idventa=@Idventa


GO
/****** Object:  StoredProcedure [dbo].[mostrarPmasVendidos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarPmasVendidos]
as
select Top 5 sum(detalle_venta.cantidad) as Cantidad, Producto1.Descripcion 
from detalle_venta inner join Producto1 on Producto1.Id_Producto1 = detalle_venta.Id_producto 
group by Producto1.Descripcion






GO
/****** Object:  StoredProcedure [dbo].[mostrarProdXid]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarProdXid]
@Idproducto int
as
select *,Grupo_de_Productos.Linea as grupo
from  Producto1 inner join Grupo_de_Productos
on Grupo_de_Productos.Idline=Producto1.Id_grupo
where Id_Producto1=@Idproducto




















GO
/****** Object:  StoredProcedure [dbo].[mostrarPuertos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarPuertos]
@idcaja int
as
select PuertoBalanza,EstadoBalanza from Caja 
where Id_Caja=@idcaja






GO
/****** Object:  StoredProcedure [dbo].[mostrarSerializacion]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarSerializacion]
as

SELECT  *,numerofin+1 as [Iniciara en] ,tipodoc as Comprobante,Por_defecto as [Por defecto]
FROM Serializacion where destino='VENTAS' OR destino='OTROS'




GO
/****** Object:  StoredProcedure [dbo].[mostrarTemaCaja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarTemaCaja]
@idcaja int
as
select Tema  from Caja
where Id_Caja=@idcaja 






GO
/****** Object:  StoredProcedure [dbo].[mostrarTiposnotaCredito]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarTiposnotaCredito]
as
select *from Tiposnotacredito


GO
/****** Object:  StoredProcedure [dbo].[mostrarUdmXcod]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarUdmXcod]
@codigo varchar(8)
as
select * from UnidadesMedida
where Codigo=@codigo





















GO
/****** Object:  StoredProcedure [dbo].[MostrarUltimoIdcompra]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarUltimoIdcompra]
@Idcaja int
as
select max(Idcompra) from Compras 
where Idcaja =@Idcaja 





GO
/****** Object:  StoredProcedure [dbo].[mostrarVentasGrafica]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarVentasGrafica]
as
declare @anio int
set @anio = DATEPART (YEAR, GETDATE())
select (datename(MONTH, fecha_venta) + ' ' + datename(YEAR,fecha_venta )) as fecha
,sum(Monto_total) as Total
from ventas 
where DATEPART(YEAR,fecha_venta)=@anio 
group by datename(MONTH , fecha_venta), DATENAME (YEAR ,fecha_venta )






GO
/****** Object:  StoredProcedure [dbo].[mostrarVentasGraficaFechas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarVentasGraficaFechas]
@fi date,
@ff date
as
select (datename(MONTH, fecha_venta) + ' ' + datename(YEAR,fecha_venta )) as fecha
,sum(Monto_total) as Total
from ventas 
where convert(date,fecha_venta)>=@fi and CONVERT(date,fecha_venta)<=@ff
group by datename(MONTH , fecha_venta), DATENAME (YEAR ,fecha_venta )






GO
/****** Object:  StoredProcedure [dbo].[MostrarventasPend]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarventasPend]
@Codigo varchar(8)
as
select idventa
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join clientes on clientes.idclientev=ventas.idclientev
where  Estadosunat='PENDIENTE' and Serializacion.Codigo=@Codigo

GO
/****** Object:  StoredProcedure [dbo].[mostrarVentasXidcaja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrarVentasXidcaja]
@Id_caja int
as
select Top 1 *,Serializacion.Codigo,EMPRESA.Ruc,RazonSocial,
EMPRESA.DireccionFiscal,clientes.IdentificadorFiscal,clientes.Nombre, clientes.Direccion
,EMPRESA.Ubigeo
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join EMPRESA  on EMPRESA.Id_empresa = ventas.Idempresa
inner join clientes on clientes.idclientev = ventas.idclientev
where Id_caja=@Id_caja order by  ventas.idventa desc




GO
/****** Object:  StoredProcedure [dbo].[mostrarVentasXidventa]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrarVentasXidventa]
@Idventa int
as
select Top 1 *,Serializacion.Codigo,EMPRESA.Ruc,RazonSocial,
EMPRESA.DireccionFiscal,clientes.IdentificadorFiscal,clientes.Nombre, clientes.Direccion
,EMPRESA.Ubigeo
from ventas 
inner join Serializacion on Serializacion.Id_serializacion=ventas.Idcomprobante
inner join EMPRESA  on EMPRESA.Id_empresa = ventas.Idempresa
inner join clientes on clientes.idclientev = ventas.idclientev
where ventas.idventa=@Idventa




GO
/****** Object:  StoredProcedure [dbo].[ObtenercodigoUbigeo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ObtenercodigoUbigeo]
@Depa varchar(50),
@Prov varchar(50),
@Dist varchar(50)
as
select Ubigeo from Codigosubigeos 
where Departamento=@Depa and Provincia=@Prov and Distrito=@Dist


GO
/****** Object:  StoredProcedure [dbo].[ObtenerdatosProductos]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[ObtenerdatosProductos]

@Idproducto int
as
select * from Producto1
where Id_Producto1=@Idproducto



















GO
/****** Object:  StoredProcedure [dbo].[ObtenerUbicaionXubigeo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ObtenerUbicaionXubigeo]
@CodUbigeo char(6)
as
select * from Codigosubigeos 
where CONVERT(char(6), Ubigeo)=@CodUbigeo


GO
/****** Object:  StoredProcedure [dbo].[ReporteCuestasPorCobrar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteCuestasPorCobrar]
as
select Nombre,Celular, Saldo  from clientes 
where Saldo > 0






GO
/****** Object:  StoredProcedure [dbo].[ReporteCuestasPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteCuestasPorPagar]
as
select Nombre,Celular, Saldo  from Proveedores 
where Saldo > 0






GO
/****** Object:  StoredProcedure [dbo].[ReporteGanancias]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteGanancias]
as
select convert(numeric(18,2), sum(Ganancia )) from detalle_venta   






GO
/****** Object:  StoredProcedure [dbo].[ReporteGananciasFecha]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteGananciasFecha]
@fi date,
@ff date
as
select convert(numeric(18,2), sum(Ganancia )) from detalle_venta   
inner join ventas on ventas.idventa  = detalle_venta.idventa  
where CONVERT (date,fecha_venta)>=@fi and CONVERT(date,fecha_venta)<=@ff






GO
/****** Object:  StoredProcedure [dbo].[ReporteGastosAnioCombo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteGastosAnioCombo]

as
set Nocount On;
select Distinct DATEPART (year,Fecha) as anio from Gastos_varios 






GO
/****** Object:  StoredProcedure [dbo].[ReporteGastosAnioGrafica]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteGastosAnioGrafica]
@anio as int
as
select top 5 Conceptos.Descripcion , SUM(Gastos_varios.Importe) as Monto
from Gastos_varios inner join Conceptos on Conceptos.Id_concepto = Gastos_varios.Id_concepto
where DATEPART (YEAR, Fecha)=@anio 
group by Conceptos.Descripcion 
Order by SUM (Importe) desc






GO
/****** Object:  StoredProcedure [dbo].[ReporteGastosAnioMesGrafica]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteGastosAnioMesGrafica]
@anio as int,
@mes as varchar(50)
as
select top 5 Conceptos.Descripcion , SUM(Gastos_varios.Importe) as Monto
from Gastos_varios inner join Conceptos on Conceptos.Id_concepto = Gastos_varios.Id_concepto
where DATEPART (YEAR, Fecha)=@anio and DATENAME(MONTH ,Fecha)=@mes 
group by Conceptos.Descripcion 
Order by SUM (Importe) desc






GO
/****** Object:  StoredProcedure [dbo].[ReporteGastosMesCombo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteGastosMesCombo]
@anio int
as
set Nocount On;
select Distinct datename (MONTH,Fecha) as mes from Gastos_varios 
where datepart(year, Fecha) = @anio






GO
/****** Object:  StoredProcedure [dbo].[ReporteInvBajoMin]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteInvBajoMin]
as
select *,Stock*Precio_de_compra as Importe from Producto1 where 
Usa_inventarios='SI' and Stock <= Stock_minimo
GO
/****** Object:  StoredProcedure [dbo].[ReportePorCobrar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReportePorCobrar]
as
select sum(Saldo) from clientes 






GO
/****** Object:  StoredProcedure [dbo].[ReportePorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReportePorPagar]
as
select sum(Saldo) from Proveedores  






GO
/****** Object:  StoredProcedure [dbo].[ReporteProductoBajoMinimo]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteProductoBajoMinimo]
as
select count(Id_Producto1 ),Codigo,Descripcion,Stock,Stock_minimo from Producto1    
Where Stock<=Stock_minimo and Usa_inventarios ='SI'
group by Codigo,Descripcion,Stock,Stock_minimo






GO
/****** Object:  StoredProcedure [dbo].[ReporteResumenVentasEmpleadoFechas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteResumenVentasEmpleadoFechas]
@idEmpleado int,
@fi date,
@ff date
as

select convert(date, ventas.fecha_venta) as fecha_venta, sum(ventas.Monto_total) as Monto,
sum(detalle_venta.Costo * detalle_venta.cantidad ) as Costo,
sum(detalle_venta.Ganancia) as Ganancia, @fi as fi, @ff as ff,USUARIO2.Nombres_y_Apellidos as Empleado
from ventas inner join detalle_venta on detalle_venta.idventa = ventas.idventa
inner join USUARIO2 on USUARIO2.idUsuario = ventas.Id_usuario
Where ventas.Monto_total >0 and ventas.Id_usuario = @idEmpleado and 
(convert(date,ventas.fecha_venta)>=@fi and convert(date,ventas.fecha_venta)<=@ff)

group by convert(date, ventas.fecha_venta),USUARIO2.Nombres_y_Apellidos






GO
/****** Object:  StoredProcedure [dbo].[ReporteResumenVentasFechas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteResumenVentasFechas]
@fi date,
@ff date
as
declare @empleado varchar(50)
set @empleado = 'Todos'
select convert(date, ventas.fecha_venta) as fecha_venta, sum(ventas.Monto_total) as Monto,
sum(detalle_venta.Costo * detalle_venta.cantidad ) as Costo,
sum(detalle_venta.Ganancia) as Ganancia, @fi as fi, @ff as ff,@empleado as Empleado
from ventas inner join detalle_venta on detalle_venta.idventa = ventas.idventa
Where ventas.Monto_total >0 and (convert(date,ventas.fecha_venta)>=@fi and convert(date,ventas.fecha_venta)<=@ff)

group by convert(date, ventas.fecha_venta)






GO
/****** Object:  StoredProcedure [dbo].[ReporteResumenVentasHoy]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteResumenVentasHoy]
as
declare @fi as varchar(50)
set @fi = 'Siempre'
declare @ff as varchar(50)
set @ff= Convert(varchar(50), GetDate())
declare @empleado varchar(50)
set @empleado = 'Todos'

select convert(date, ventas.fecha_venta) as fecha_venta, sum(ventas.Monto_total) as Monto,
sum(detalle_venta.Costo * detalle_venta.cantidad ) as Costo,
sum(detalle_venta.Ganancia) as Ganancia, @fi as fi, @ff as ff, @empleado as Empleado
from ventas inner join detalle_venta on detalle_venta.idventa = ventas.idventa
Where ventas.Monto_total >0

group by convert(date, ventas.fecha_venta)






GO
/****** Object:  StoredProcedure [dbo].[ReporteResumenVentasHoyEmpleado]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteResumenVentasHoyEmpleado]
@idEmpleado int
as

declare @fi as varchar(50)
set @fi = 'Siempre'
declare @ff as varchar(50)
set @ff= Convert(varchar(50), GetDate())

select convert(date, ventas.fecha_venta) as fecha_venta, sum(ventas.Monto_total) as Monto,
sum(detalle_venta.Costo * detalle_venta.cantidad ) as Costo,
sum(detalle_venta.Ganancia) as Ganancia, @fi as fi, @ff as ff,USUARIO2.Nombres_y_Apellidos as Empleado
from ventas inner join detalle_venta on detalle_venta.idventa = ventas.idventa
inner join USUARIO2 on USUARIO2.idUsuario = ventas.Id_usuario
Where ventas.Monto_total >0 and ventas.Id_usuario = @idEmpleado 

group by convert(date, ventas.fecha_venta),USUARIO2.Nombres_y_Apellidos






GO
/****** Object:  StoredProcedure [dbo].[ReporteTicket]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ReporteTicket]
@Idventa int
as
select EMPRESA.Logo,EMPRESA.RazonSocial as Empresa,EMPRESA.Ruc as Identificador_fiscal,
EMPRESA.DireccionFiscal as Direccion,ventas.Serie + '-'+ ventas.Correlativo as Numero_de_doc,
ventas.Monto_total,USUARIO2.Nombres_y_Apellidos as Usuario,
ventas.fecha_venta as fecha,clientes.Nombre,
detalle_venta.cantidad as Cant, detalle_venta.Descripcion as Producto,detalle_venta.Total_a_pagar as Importe,
EMPRESA.SimboloMoneda as Moneda,ventas.TotalIgv as Subtotal_Impuesto,
ventas.Monto_total, Ticket.Agradecimiento,Ticket.pagina_Web_Facebook,Ticket.Anuncio,
Ticket.Datos_fiscales_de_autorizacion ,EMPRESA.Porcentaje_impuesto as Impuesto
from ventas
inner join detalle_venta on detalle_venta.idventa=ventas.idventa
inner join USUARIO2 on USUARIO2.idUsuario=ventas.Id_usuario
inner join clientes on clientes.idclientev=ventas.idclientev
cross join Ticket
cross join EMPRESA
where ventas.idventa=@Idventa 
GO
/****** Object:  StoredProcedure [dbo].[ReporteTotalVentas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteTotalVentas]
as
select sum( Monto_total) FROM dbo.ventas 






GO
/****** Object:  StoredProcedure [dbo].[ReporteTotalVentasFechas]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReporteTotalVentasFechas]
@fi date,
@ff date
as
select sum( Monto_total) FROM dbo.ventas 
where CONVERT (date,fecha_venta)>=@fi and CONVERT(date,fecha_venta)<=@ff






GO
/****** Object:  StoredProcedure [dbo].[ReportKardexMov]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ReportKardexMov]

@idProducto int
AS
SELECT       KARDEX.Fecha ,Producto1.Descripcion ,KARDEX.Motivo as Movimiento, 
KARDEX.Cantidad ,KARDEX.Tipo ,KARDEX.Hay  as Hay ,
USUARIO2.Nombres_y_Apellidos as Cajero ,Grupo_de_Productos .linea as Categoria,
KARDEX.Costo_unt , convert(numeric(18,2), Producto1.Stock * KARDEX.Costo_unt) as Total
,Grupo_de_Productos .linea ,EMPRESA.RazonSocial,EMPRESA.Logo ,Producto1.Stock,
convert(numeric(18,2), Producto1.Stock * KARDEX.Costo_unt) as TotalInventario
FROM            dbo.KARDEX INNER JOIN Producto1 on Producto1.Id_Producto1=KARDEX.Id_producto 
inner join USUARIO2 on USUARIO2.idUsuario =KARDEX.Id_usuario 
             cross join EMPRESA
			 inner join Grupo_de_Productos on Grupo_de_Productos.Idline=Producto1.Id_grupo 
			where    Producto1.Id_Producto1=@idProducto
			
			 order by KARDEX.Id_kardex  Desc 






GO
/****** Object:  StoredProcedure [dbo].[restaurar_caja]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[restaurar_caja]
@idcaja integer
as
update Caja set
Estado  ='Caja Restaurada'
where Id_Caja    =@idcaja



















GO
/****** Object:  StoredProcedure [dbo].[restaurar_clientes]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[restaurar_clientes]
@Idcliente As int

As
update   clientes 
set Estado ='ACTIVO'
WHERE idclientev =@Idcliente











GO
/****** Object:  StoredProcedure [dbo].[restaurar_Proveedores]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[restaurar_Proveedores]
@IdProveedor As int

As
update   Proveedores
set Estado ='ACTIVO'
WHERE IdProveedor=@IdProveedor











GO
/****** Object:  StoredProcedure [dbo].[sumar_CreditoPorCobrar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_CreditoPorCobrar]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Saldo ) from CreditoPorCobrar 
where (Fecha_registro >=@fi and Fecha_registro <=@ff) and Id_caja=@idcaja 











GO
/****** Object:  StoredProcedure [dbo].[sumar_CreditoPorPagar]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_CreditoPorPagar]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Saldo ) from CreditoPorPagar 
where (Fecha_registro >=@fi and Fecha_registro <=@ff) and Id_caja=@idcaja 











GO
/****** Object:  StoredProcedure [dbo].[sumar_gastos_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_gastos_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Importe ) from Gastos_varios 
where (Fecha >=@fi and Fecha <=@ff) and Id_caja=@idcaja 











GO
/****** Object:  StoredProcedure [dbo].[sumar_ingresos_por_turno]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sumar_ingresos_por_turno]
@idcaja int, 
@fi datetime,
@ff datetime
as
select sum(Importe ) from Ingresos_varios 
where (Fecha >=@fi and Fecha <=@ff) and Id_caja=@idcaja 











GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 21/08/2021 15:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[validar_usuario]

@password varchar(50),
@login varchar(50)
as
select * from USUARIO2
where  Password   = @password and Login=@Login and Estado ='ACTIVO'























GO
USE [master]
GO
ALTER DATABASE [BASEADACURSO] SET  READ_WRITE 
GO
