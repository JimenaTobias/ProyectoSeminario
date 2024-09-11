using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Models.Dto
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descrip { get; set; }

        public Categoria() { }

        public Categoria(int idCategoria, string nombre_cat, string descrip_cat)
        {
            id = idCategoria;
            nombre = nombre_cat;
            descrip = descrip_cat;
        }

        public Categoria(string nombre_cat, string descrip_cat)
        {
            nombre = nombre_cat;
            descrip = descrip_cat;
        }
    }
}
