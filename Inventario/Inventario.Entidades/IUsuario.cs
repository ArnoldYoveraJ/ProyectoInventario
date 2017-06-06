using System;
namespace Inventario.Entidades
{
    interface IUsuario
    {
        int Cod_usu { get; set; }
        string Contra { get; set; }
        int Estado { get; set; }
        string Nom_usu { get; set; }
        int Tipo { get; set; }
    }
}
