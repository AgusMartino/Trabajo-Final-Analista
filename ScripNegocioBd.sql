CREATE DATABASE [Gestion Stock]
go
use [Gestion Stock]
go
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Fecha_de_nacimiento] [datetime] NULL,
	[Dni] [int] NOT NULL,
	[Direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Fecha_de_nacimiento] [datetime] NULL,
	[Direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Empleado_1] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Inventario](
	[IdInventario] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaPrima] [int] NOT NULL,
	[Cantidad] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Materia_Prima](
	[IdMateriaPrima] [int] IDENTITY(1,1) NOT NULL,
	[IdUnidad_de_medida] [int] NULL,
	[Codigo_MateriaPrima] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Costo] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Materia_Prima] PRIMARY KEY CLUSTERED 
(
	[IdMateriaPrima] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[MateriaPrima_Producto](
	[IdMateriaPrima_Producto] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaPrima] [int] NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [decimal](18, 0) NULL,
 CONSTRAINT [PK_MateriaPrima_Producto] PRIMARY KEY CLUSTERED 
(
	[IdMateriaPrima_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Movimientos_caja](
	[IdMovimiento] [int] NOT NULL,
	[Cantidad] [decimal](18, 0) NULL,
	[IdTipo_de_movimiento] [int] NULL,
	[idTipo_de_pago] [int] NULL,
	[Fecha_de_movimiento] [datetime] NULL,
 CONSTRAINT [PK_Movimientos_caja] PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Orden_de_Compra](
	[Id_Orden_compra] [int] IDENTITY(1,1) NOT NULL,
	[Id_Pago_Proveedor] [int] NULL,
	[IdMateriaPrima] [int] NULL,
	[Cantidad] [int] NULL,
	[Subtotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Orde_de_Compra] PRIMARY KEY CLUSTERED 
(
	[Id_Orden_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Orden_de_Venta](
	[IdOrden_de_Venta] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [decimal](18, 0) NULL,
	[SubTotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Orden_de_Venta] PRIMARY KEY CLUSTERED 
(
	[IdOrden_de_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Pago_empleado](
	[id_Pago_empleado] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NULL,
	[Monto_pagado] [decimal](18, 0) NULL,
	[Fecha_de_pago] [datetime] NULL,
 CONSTRAINT [PK_Pago_empleado] PRIMARY KEY CLUSTERED 
(
	[id_Pago_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Pago_Proveedor](
	[Id_Pago] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NULL,
	[Fecha_de_pago] [datetime] NULL,
	[Total] [decimal](18, 0) NULL,
	[Monto_pagado] [decimal](18, 0) NULL,
	[Monto_adeudado] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Pago_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Id_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Pago_servicio](
	[Id_Pago_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[idServicio] [int] NULL,
	[Monto_pagado] [decimal](18, 0) NULL,
	[Fecha_de_pago] [datetime] NULL,
 CONSTRAINT [PK_Pago_servicio] PRIMARY KEY CLUSTERED 
(
	[Id_Pago_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[IdRubro] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Codigo_producto] [varchar](50) NULL,
	[Precio] [decimal](18, 0) NULL,
	[Costo] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Cuit] [numeric](18, 0) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Rubro](
	[IdRubro] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_rubro] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[IdRubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Servicio](
	[IdServicio] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_servicio] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Servicio_1] PRIMARY KEY CLUSTERED 
(
	[IdServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Tipo_de_movimiento](
	[IdTipo_de_movimiento] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Afecta_movimeinto] [int] NULL,
 CONSTRAINT [PK_Tipo_de_movimiento] PRIMARY KEY CLUSTERED 
(
	[IdTipo_de_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Tipo_de_pago](
	[IdTipo_de_pago] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_de_pago] [varchar](50) NULL,
 CONSTRAINT [PK_Tipo_de_pago] PRIMARY KEY CLUSTERED 
(
	[IdTipo_de_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Turno](
	[IdTurno] [int] IDENTITY(1,1) NOT NULL,
	[Caja_inicial] [decimal](18, 0) NULL,
	[Fecha_de_inicio] [datetime] NULL,
	[Fecha_de_cierre] [datetime] NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[IdTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Unidad_de_medida](
	[Id_unidad_de_medida] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Unidad_de_medida] PRIMARY KEY CLUSTERED 
(
	[Id_unidad_de_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[IdTipo_de_pago] [int] NULL,
	[Fecha_de_venta] [datetime] NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
insert into [dbo].[Unidad_de_medida](Nombre)
values
('Kilogramo'),
('Gramo'),
('Unidad'),
('Litro')
GO
insert into [dbo].[Tipo_de_pago] (Tipo_de_pago)
values
('Efectivo'),
('Credito'),
('Debito'),
('Mercado Pago')
GO
insert into [dbo].[Tipo_de_movimiento](IdTipo_de_movimiento,Nombre, Afecta_movimeinto)
values
(1, 'Ingreso', 1),
(2, 'Egreso', -1)
GO
