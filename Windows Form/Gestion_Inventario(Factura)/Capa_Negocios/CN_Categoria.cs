using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class CN_Categorias
    {
        private readonly CD_Categorias data = new CD_Categorias();
        private readonly CD_Categorias datosCategoria = new CD_Categorias();
        public DataTable ObtenerCategorias()
        {
            return data.ObtenerCategorias();
        }


        public DataTable BuscarCategoria(string filtro)
        {
            return datosCategoria.BuscarCategoria(filtro);
        }

        public void InsertarCategoria(string nombre, string descripcion)
        {
            datosCategoria.InsertarCategoria(nombre, descripcion); 
        }

        public void ActualizarCategoria(int idCategoria, string nombre, string descripcion)
        {
            datosCategoria.ActualizarCategoria(idCategoria, nombre, descripcion);
        }

        public void EliminarCategoria(int idCategoria)
        {
            datosCategoria.EliminarCategoria(idCategoria);
        }


    }
}

