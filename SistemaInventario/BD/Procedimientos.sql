--Procedimiento para mostrar categoría
create proc spmostrar_categoria
as
select top 200 * from CATEGORIA order by COD_CAT desc
go

--Procedimiento buscar Nombre
create proc spbuscar_categoria
@textobuscar varchar(50)
as
select * from CATEGORIA where NOM_CAT like @textobuscar + '%'
go

--Procedimiento Editar
create proc speditar_categoria
@cod_cat int,
@nom_cat varchar(30)
as
update categoria set NOM_CAT=@nom_cat where COD_CAT=@cod_cat;
go

--procedimiento Eliminar
create proc speliminar_categoria
@cod_cat int
as
delete from categoria where cod_cat=@cod_cat