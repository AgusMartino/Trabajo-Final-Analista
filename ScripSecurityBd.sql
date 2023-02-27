CREATE DATABASE [Usuario_Perfil_Permiso]
GO
use Usuario_Perfil_Permiso
Go
CREATE TABLE [dbo].[Perfil](
	[IdPerfil] [int] IDENTITY(1,1) NOT NULL,
	[Perfil] [varchar](50) NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[IdPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Perfil_Perfil](
	[IdPerfil_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[IdPerfil] [int] NULL,
	[IdPerfil_hijo] [int] NULL,
 CONSTRAINT [PK_Perfil_Perfil] PRIMARY KEY CLUSTERED 
(
	[IdPerfil_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Permiso](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[Permiso] [varchar](50) NULL,
	[Vista] [varchar](50) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Permiso_Perfil](
	[IdPermiso_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[IdPerfil] [int] NULL,
	[IdPermiso] [int] NULL,
 CONSTRAINT [PK_Permiso_Perfil] PRIMARY KEY CLUSTERED 
(
	[IdPermiso_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[Habilitado] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Usuario_Perfil](
	[IdUsuario_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdPerfil] [int] NULL,
 CONSTRAINT [PK_Usuario_Perfil] PRIMARY KEY CLUSTERED 
(
	[IdUsuario_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Usuario_Permiso](
	[IdUsuario_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdPermiso] [int] NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[IdUsuario_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
insert into [dbo].[Permiso] (Permiso, Vista)
values
('Realizar Venta','FmrRealizarVenta'),
('Cancelar Venta','FmrCancelarVenta'),
('Realizar Pago Proveedor','FmrPagoProveedor'),
('Cancelar Pago Proveedor','FmrCancelarPagoProveedor'),
('Realizar pago empleado','FmrPagoEmpleado'),
('Cancelar pago empleado','FmrCancelarPagoEmpleado'),
('Realizar pago servicio','FmrPagoServicio'),
('Cancelar pago servicio','FmrCancelarPagoServicio'),
('Alta Usuario','FmrAltaUsuario'),
('Modificar Usuario','FmrModificarUsuario'),
('Crear Perfil','FmrCrearPerfil'),
('Modificar Perfil','FmrModificarPerfil'),
('Alta Cliente','FmrAltaCliente'),
('Modificar Cliente','FmrModificarCliente'),
('Alta Empleado','FmrAltaEmpleado'),
('Modificar Empleado','FmrModificarEmpleado'),
('Alta Rubro','FmrAltaRubro'),
('Modificar Rubro','FmrModificarRubro'),
('Alta Materia Prima','FmrAltaMateriaPrima'),
('Modificar Materia Prima','FmrModificarMateriaPrima'),
('Alta Producto','FmrAltaProducto'),
('Modificar Producto','FmrModificarProducto'),
('Alta Proveedor','FmrAltaProveedor'),
('Modificar Proveedor','FmrModificarProveedor'),
('Alta Servicio','FmrAltaServicio'),
('Modificar Servicio','FmrModificarServicio'),
('Gestion Caja','FmrGestionCaja'),
('Gestion Turno','FmrGestionTurnos'),
('Gestion Inventario','FmrGestionInventario'),
('Ventas Por Producto','FmrVentasPorProducto'),
('Inventario','FmrInventario')
GO
insert into [dbo].[Perfil](Perfil)
values
('Gestion Ventas'),
('Pago Proveedor'),
('Pago Empleado'),
('Pago Servicio'),
('Usuarios'),
('Perfiles'),
('Gestion Usuarios'),
('Gestion Clientes'),
('Gestion Empleados'),
('Gestion Rubros'),
('Materia Prima'),
('Producto'),
('Gestion Productos'),
('Gestion Proveedores'),
('Gestion Servicios'),
('Gestion Caja'),
('Gestion Turno'),
('Gestion Inventario'),
('Gestion Informes'),
('Gestion Pagos'),
('Administrador')
GO
insert into [dbo].[Permiso_Perfil](IdPerfil, IdPermiso)
values
(1,1),
(1,2),
(2,3),
(2,4),
(3,5),
(3,6),
(4,7),
(4,8),
(5,9),
(5,10),
(6,11),
(6,12),
(8,13),
(8,14),
(9,15),
(9,16),
(10,17),
(10,18),
(11,19),
(11,20),
(12,21),
(12,22),
(14,23),
(14,24),
(15,25),
(15,26),
(16,27),
(17,28),
(18,29),
(19,30),
(19,31)
GO
insert into [dbo].[Perfil_Perfil] (IdPerfil, IdPerfil_hijo)
values
(20,2),
(20,3),
(20,4),
(7,5),
(7,6),
(13,11),
(13,12),
(21,1),
(21,20),
(21,7),
(21,8),
(21,9),
(21,10),
(21,13),
(21,14),
(21,15),
(21,16),
(21,17),
(21,18),
(21,19)
GO
insert into [dbo].[Usuario] (Usuario, Contraseña, Habilitado)
values 
('Admin','4QrcOUm6Wau+VuBX8g+IPg==', 'True' )
GO
insert into [dbo].[Usuario_Perfil](IdUsuario, IdPerfil)
values (1,21)
GO