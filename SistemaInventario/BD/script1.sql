USE [BDINVENTARIO]
GO
/****** Object:  Table [dbo].[AREA]    Script Date: 18/05/2017 19:05:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AREA](
	[COD_AREA] [int] IDENTITY(1,1) NOT NULL,
	[NOM_AREA] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_AREA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[COD_CAT] [int] IDENTITY(1,1) NOT NULL,
	[NOM_CAT] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_CAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_ORDEN]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_ORDEN](
	[COD_DETORD] [int] IDENTITY(1,1) NOT NULL,
	[STOCK_INICIAL] [int] NOT NULL,
	[STOCK_ACTUAL] [int] NOT NULL,
	[COD_ORDEN] [int] NOT NULL, --EDITAR ÑA BASE DE DATOS, CAMBIAR LAS LLAVES FORANEAS A "NOT NULL"
	[COD_PRODUCTO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_DETORD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPRESA]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPRESA](
	[COD_EMPRESA] [int] IDENTITY(1,1) NOT NULL,
	[NOM_EMPRESA] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_EMPRESA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDEN]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDEN](
	[COD_ORDEN] [int] IDENTITY(1,1) NOT NULL,
	[FECHA] [date] NOT NULL,
	[TIPO_COMPROBANTE] [varchar](20) NOT NULL,
	estado int not null, -- agregar este campo
	[COD_USU] [int] NOT NULL,
	[COD_PROV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_ORDEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[COD_PRODUCTO] [int] IDENTITY(1,1) NOT NULL,
	[NOM_PRODUCTO] [varchar](30) NOT NULL,
	[MARCA] [varchar](30) NOT NULL,
	[MODELO_PLACA] [varchar](30) NULL,
	[SERIE] [varchar](50) NOT NULL,
	[PROCESADOR] [varchar](20) NULL,
	[DD] [varchar](20) NULL,
	[RAM] [varchar](20) NULL,
	[SO] [varchar](20) NULL,
	[IMAGEN] [image] NULL,
	[ESTADO] [int] NOT NULL,
	[DESCRIPCION] [varchar](50) NULL,
	[COD_CAT] [int] NOT NULL,
	[COD_TRABAJADOR] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_PRODUCTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[COD_PROV] [int] IDENTITY(1,1) NOT NULL,
	[RAZON_SOCIAL] [varchar](100) NOT NULL,
	[SECTOR_COMERCIAL] [varchar](50)  NULL,--ACTUALIZAR
	[TIPO_DOC] [varchar](20) NOT NULL,
	[NUM_DOC] [varchar](11) NOT NULL,
	[DIRECCION] [varchar](60) NULL,
	[TELEFONO] [varchar](20) NULL,
	[EMAIL] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_PROV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRABAJADOR]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRABAJADOR](
	[COD_TRABAJADOR] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRES] [varchar](50) NOT NULL,
	[APELLIDOS] [varchar](50) NULL,
	[DNI] [char](8) NOT NULL,
	[EMAIL] [varchar](60) NULL,
	[ANEXO] [char](4) NULL,
	[COD_AREA] [int] NOT NULL,
	[COD_EMPRESA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_TRABAJADOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[COD_USU] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_COMPLETO] [varchar](100) NOT NULL,
	[USUARIO] [varchar](30) NOT NULL,
	[CONTRA] [varchar](20) NOT NULL,
	[TIPO] [varchar](20) NOT NULL,
	[ESTADO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_USU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DETALLE_ORDEN]  WITH CHECK ADD  CONSTRAINT [FK_DET_ORDEN] FOREIGN KEY([COD_ORDEN])
REFERENCES [dbo].[ORDEN] ([COD_ORDEN])
GO
ALTER TABLE [dbo].[DETALLE_ORDEN] CHECK CONSTRAINT [FK_DET_ORDEN]
GO
ALTER TABLE [dbo].[DETALLE_ORDEN]  WITH CHECK ADD  CONSTRAINT [FK_DET_ORDEN1] FOREIGN KEY([COD_PRODUCTO])
REFERENCES [dbo].[PRODUCTOS] ([COD_PRODUCTO])
GO
ALTER TABLE [dbo].[DETALLE_ORDEN] CHECK CONSTRAINT [FK_DET_ORDEN1]
GO
ALTER TABLE [dbo].[ORDEN]  WITH CHECK ADD  CONSTRAINT [FK_ORDEN] FOREIGN KEY([COD_USU])
REFERENCES [dbo].[USUARIO] ([COD_USU])
GO
ALTER TABLE [dbo].[ORDEN] CHECK CONSTRAINT [FK_ORDEN]
GO
ALTER TABLE [dbo].[ORDEN]  WITH CHECK ADD  CONSTRAINT [FK_ORDEN1] FOREIGN KEY([COD_PROV])
REFERENCES [dbo].[PROVEEDOR] ([COD_PROV])
GO
ALTER TABLE [dbo].[ORDEN] CHECK CONSTRAINT [FK_ORDEN1]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_CATEGORIA] FOREIGN KEY([COD_CAT])
REFERENCES [dbo].[CATEGORIA] ([COD_CAT])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_CATEGORIA]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTE] FOREIGN KEY([COD_TRABAJADOR])
REFERENCES [dbo].[TRABAJADOR] ([COD_TRABAJADOR])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_CLIENTE]
GO
ALTER TABLE [dbo].[TRABAJADOR]  WITH CHECK ADD  CONSTRAINT [FK_AREA] FOREIGN KEY([COD_AREA])
REFERENCES [dbo].[AREA] ([COD_AREA])
GO
ALTER TABLE [dbo].[TRABAJADOR] CHECK CONSTRAINT [FK_AREA]
GO
ALTER TABLE [dbo].[TRABAJADOR]  WITH CHECK ADD  CONSTRAINT [FK_EMPRESA] FOREIGN KEY([COD_EMPRESA])
REFERENCES [dbo].[EMPRESA] ([COD_EMPRESA])
GO
ALTER TABLE [dbo].[TRABAJADOR] CHECK CONSTRAINT [FK_EMPRESA]
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_categoria]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento buscar Nombre
create proc [dbo].[spbuscar_categoria]
@textobuscar varchar(50)
as
select * from CATEGORIA where NOM_CAT like @textobuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[speditar_categoria]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento Editar
create proc [dbo].[speditar_categoria]
@cod_cat int,
@nom_cat varchar(30)
as
update categoria set NOM_CAT=@nom_cat where COD_CAT=@cod_cat;

GO
/****** Object:  StoredProcedure [dbo].[speliminar_categoria]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--procedimiento Eliminar
create proc [dbo].[speliminar_categoria]
@cod_cat int
as
delete from categoria where cod_cat=@cod_cat
GO
/****** Object:  StoredProcedure [dbo].[spinsertar_categoria]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_categoria]
@COD_CAT INT OUTPUT,
@NOM_CAT VARCHAR
AS
INSERT INTO CATEGORIA (NOM_CAT) VALUES(@NOM_CAT)
GO
/****** Object:  StoredProcedure [dbo].[spmostrar_categoria]    Script Date: 18/05/2017 19:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento para mostrar categoría
create proc [dbo].[spmostrar_categoria]
as
select top 200 * from CATEGORIA order by COD_CAT desc

GO



--Procedimientos

--Areas
create proc spmostrar_area
as
select top 100 * from AREA order by cod_area desc;
go

create proc spinsertar_area
@cod_area int output,
@nom varchar(30)
as
insert into area(nom_area) values(@nom);

create proc speditar_area
@cod_area int output,
@nom varchar(30)
as
update area set nom=@nom where cod_area=@cod_area;

create proc speliminar_area
@cod_area int output,
as
delete from area where cod_area=@cod_area;

create proc spbuscar_area
@textobuscar varchar(30)
as
select * from area where nom_area like @textobuscar +  '%';

--Productos

CREATE proc [dbo].[speditar_producto]
@COD_PRODUCTO INT,
@NOM_PRODUCTO varchar(30),
@MARCA varchar(30),
@MODELO_PLACA varchar(30),
@SERIE varchar(50),
@PROCESADOR varchar(20),
@DD varchar(20),
@RAM varchar(20),
@SO varchar(20),
@IMAGEN image,
@ESTADO int,
@DESCRIPCION varchar(50),
@COD_CAT int,
@COD_TRABAJADOR int
as
UPDATE PRODUCTOS SET 
nom_producto=@NOM_PRODUCTO,
marca=@MARCA,
modelo_placa=@MODELO_PLACA,
serie=@SERIE,
procesador=@PROCESADOR,
dd=@DD,
ram=@RAM,
so=@SO,
imagen=@IMAGEN,
estado=@ESTADO,
descripcion=@DESCRIPCION,
cod_cat=@COD_CAT,
cod_cliente=@COD_TRABAJADOR
WHERE COD_PRODUCTO=@COD_PRODUCTO;
GO

CREATE PROCEDURE [dbo].[speliminar_producto]
@COD_PROD INT
AS
DELETE FROM PRODUCTOS WHERE COD_PRODUCTO=@COD_PROD;
GO

CREATE proc [dbo].[INSERTAR_PRODUCTO]
--@COD_PRODUCTO int output,
@NOM_PRODUCTO varchar(30),
@MARCA varchar(30),
@MODELO_PLACA varchar(30),
@SERIE varchar(50),
@PROCESADOR varchar(20),
@DD varchar(20),
@RAM varchar(20),
@SO varchar(20),
@IMAGEN image,
@ESTADO int,
@DESCRIPCION varchar(50),
@COD_CAT int,
@COD_TRABAJADOR int
as
insert into PRODUCTOS(NOM_PRODUCTO,MARCA,MODELO_PLACA,SERIE,
	PROCESADOR,DD,RAM,SO,IMAGEN,ESTADO,DESCRIPCION,COD_CAT,COD_TRABAJADOR)
values(@NOM_PRODUCTO,@MARCA,@MODELO_PLACA,@SERIE,@PROCESADOR,@DD,@RAM,@SO,
@IMAGEN,@ESTADO,@DESCRIPCION,@COD_CAT,@COD_TRABAJADOR);
GO

create proc spmostrar_producto
as 
--select  top 100 * from productos order by NOM_PRODUCTO desc
select top 100 p.nom_producto,p.marca,p.modelo_placa,p.serie,p.procesador,p.dd,p.ram,p.so,p.imagen,p.estado,
p.descripcion,c.cod_cat,c.nom_cat,t.cod_trabajador,t.nombres + t.apellidos as Trabajador from productos p inner join categoria c
on p.cod_cat=c.cod_cat inner join trabajador t
on p.cod_trabajador=t.cod_trabajador
order by p.COD_PRODUCTO
go

--Buscar por Nombre
CREATE PROCEDURE [dbo].[spbuscar_producto]
@buscartexto varchar(50)
AS
--select * from productos where NOM_PRODUCTO like @buscartexto + '%' 
select p.nom_producto,p.marca,p.modelo_placa,p.serie,p.procesador,p.dd,p.ram,p.so,p.imagen,p.estado,
p.descripcion,c.cod_cat,t.cod_trabajador from productos p inner join categoria c
on p.cod_cat=c.cod_cat inner join trabajador t
on p.cod_trabajador=t.cod_trabajador
where p.nom_producto like @buscartexto + '%'
order by p.COD_PRODUCTO desc
GO

--Buscar por Marca--Ejecutar procedimiento
CREATE PROCEDURE [dbo].[spbuscar_producto_marca]
@buscartexto varchar(50)
AS
select p.nom_producto,p.marca,p.modelo_placa,p.serie,p.procesador,p.dd,p.ram,p.so,p.imagen,p.estado,
p.descripcion,c.cod_cat,t.cod_trabajador from productos p inner join categoria c
on p.cod_cat=c.cod_cat inner join trabajador t
on p.cod_trabajador=t.cod_trabajador
where p.marca like @buscartexto + '%'
order by p.COD_PRODUCTO desc
GO

--Buscar por número de serie--Ejecutar procedimiento
CREATE PROCEDURE [dbo].[spbuscar_producto_serie]
@buscartexto varchar(50)
AS
select p.nom_producto,p.marca,p.modelo_placa,p.serie,p.procesador,p.dd,p.ram,p.so,p.imagen,p.estado,
p.descripcion,c.cod_cat,t.cod_trabajador from productos p inner join categoria c
on p.cod_cat=c.cod_cat inner join trabajador t
on p.cod_trabajador=t.cod_trabajador
where p.serie like @buscartexto + '%'
order by p.COD_PRODUCTO desc
GO


--fin productos

--Trabajadores
create proc speditar_trabajador
@cod_tra int,
@nom varchar(50),
@ape varchar(50),
@dni char(8),
@email varchar(60),
@anexo char(4),
@cod_area int,
@cod_emp int
as
update trabajador set NOMBRES=@nom,APELLIDOS=@ape,DNI=@dni,EMAIL=@email,
ANEXO=@anexo,COD_AREA=@cod_area,COD_EMPRESA=@cod_emp where
COD_TRABAJADOR=@cod_tra; 
go

create proc spinsertar_trabajador
--@cod_tra int output,
@nom varchar(50),
@ape varchar(50),
@dni char(8),
@email varchar(60),
@anexo char(4),
@cod_area int,
@cod_emp int
as
insert into TRABAJADOR(nombres,apellidos,dni,email,anexo,cod_area,cod_empresa) 
values (@nom,@ape,@dni,@email,@anexo,@cod_area,@cod_emp)
go

create proc spmostrar_trabajador
as
select * from trabajador order by cod_trabajador;
go

create proc speliminar_trabajador
@cod int
as
delete from trabajador where cod_trabajador=@cod;
go

create proc spbuscar_trabajador
@textobuscar varchar(30)
as
select * from trabajador where APELLIDOS like @textobuscar + '%'
go
--fin trabajadores

--Procedimientos Proveedores
--Insertar
--Agregar el parámetro upper para convertir en mayuscula. y no agregarlo desde el visual
create proc spinsertar_proveedor
@cod_prov int output,
@razon_s varchar(100),
@sector varchar(50),
@tip_doc varchar(20),
@num_doc varchar(11),
@dir varchar(60),
@tel varchar(20),
@email varchar(60)
as 
insert into proveedor(RAZON_SOCIAL,SECTOR_COMERCIAL,TIPO_DOC,NUM_DOC,DIRECCION,TELEFONO,EMAIL)
values(@razon_s,@sector,@tip_doc,@num_doc,@dir,@tel,@email)
go

--Editar
create proc speditar_proveedor
@cod_prov int,
@razon_s varchar(100),
@sector varchar(50),
@tip_doc varchar(20),
@num_doc varchar(11),
@dir varchar(60),
@tel varchar(20),
@email varchar(60)
as 
update proveedor set RAZON_SOCIAL=@razon_s,SECTOR_COMERCIAL=@sector,
TIPO_DOC=@tip_doc,NUM_DOC=@num_doc,DIRECCION=@dir,TELEFONO=@tel,EMAIL=@email
where COD_PROV=@cod_prov;
go

--Mostrar
create proc spmostrar_proveedor
as
select * from proveedor order by cod_prov
go

--Buscar por razon social
create proc spbuscar_proveedor
@texto_buscar varchar(30)
as 
select * from proveedor where razon_social like @texto_buscar + '%'
go

--Buscar por número documento
create proc spbuscar_proveedor_numdoc
@texto_buscar varchar(30)
as 
select * from proveedor where NUM_DOC like @texto_buscar + '%'
go

--Eliminar
create proc speliminar_proveedor
@cod_prov int
as
delete from proveedor where COD_PROV=@cod_prov;
go

--Procedimientos de Usuarios

--Insertar
create proc spinsertar_usuario
@cod_usu int output,
@nom_com varchar(100),
@usu varchar(30),
@contra varchar(20),
@tipo varchar(20),
@est int
as 
insert into usuarios(nombre_completo,usuario,contra,tipo,estado)
values(@cod_usu,@nom_com,@usu,@contra,@tipo,@est)
go

--Editar
create proc speditar_usuario
@cod_usu int,
@nom_com varchar(100),
@usu varchar(30),
@contra varchar(20),
@tipo varchar(20),
@est int
as 
update usuario set nombre_completo=@nom_com,usuario=@usu,
contra=@contra, tipo=@tipo,estado=@est where cod_usu=@cod_usu;
go

--Eliminar
create proc speliminar_usuario
@cod_usu int
as
delete from usuario where cod_usu=@cod_usu;
go

--Mostrar
create proc spmostrar_usuario
as
select top(50) * from usuario order by tipo desc;
go

--Buscar por Nombre
create proc spbuscar_nombre
@textobuscar varchar(20)
as
select * from usuario where nombre_completo=@textobuscar; 
go

--Buscar por usuario
create proc spbuscar_usuario
@textobuscar varchar(20)
as
select * from usuario where usuario=@textobuscar; 
go

--logear usuario --correr
create proc splogear_usuario
@usu varchar(30),
@contra varchar(20)
as
select cod_usu,nombre_completo,tipo from usuarios where usuario=@usu and contra=@contra
go

--procedimientos para orden y detalle de orden

--agregar columna estado
alter table order add estado varchar(7) not null
go
-- mostrar orden de ingreso de productos
create proc spmostrar_orden_ingreso
as
select top(100) do.stock_inicial,o.cod_orden,o.fecha,o.tipo_comprobante,o.estado,u.nombre_completo,p.razon_social,
p.tipo_doc,p.num_doc from detalle_orden do inner join orden o
on do.cod_orden= o.cod_orden
inner join usuario u on
o.cod_usu=u.cod_su inner join proveedor p on
o.cod_prov=p.cod_prov 
order by o.cod_orden desc
go

--mostrar ingresos entre fecha
create proc spbuscar_orden_ingreso_porfecha
--@fechainicio date,
--@fechafin date
@fechainicio varchar(20),
@fechafin varchar(20)
as
select do.stock_inicial,o.cod_orden,o.fecha,o.tipo_comprobante,o.estado,u.nombre_completo,p.razon_social,
p.tipo_doc,p.num_doc from detalle_orden do inner join orden o
on do.cod_orden= o.cod_orden
inner join usuario u on
o.cod_usu=u.cod_su inner join proveedor p on
o.cod_prov=p.cod_prov 
where o.fecha between @fechainicio and @fechafin
order by o.cod_orden desc
go

--ingresar orden
create proc spingresar_orden
@cod_orden int=null output,
@fecha date,
@tipo_comprobante varchar(20),
@cod_usu int,
@cod_prov int
as
insert into orden(cod_orden,fecha,tipo_comprobante,cod_usu,cod_prov)
values (@cod_orden,@fecha,@tipo_comprobante,@cod_usu,@cod_prov)
--obtener el código autogenreado
set @cod_orden=@@identity
go

--anular una orden
create proc spanular_ingreso_orden
@cod_orden int
as
update orden set estado="ANULADO" where 
cod_orden=@cod_orden
go

--Insertar detalle de orden
create proc spingresar_detalle_orden
@cod_detord int,
@stock_ini int,
@stock_act int,
@cod_orden int,
@cod_pro int
as
insert into detalle_orden (cod_detord,stock_ini ,stock_act,cod_orden,cod_pro)
values(@cod_detord,@stock_ini ,@stock_act,@cod_orden,@cod_pro)
go

--Mostrar detalle de ingreso
create proc spmostrar_detalle_ingreso
@textobuscar int
as
select do.cod_detord,do.stock_inicial,do.stock_actual,(p.nombre_producto + ' ' +
p.marca) as Producto from detalle_orden do inner join productos p 
on do.cod_producto=p.cod_producto
where cod_detord=@textobuscar
go
