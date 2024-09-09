using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Models.Dto
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int? idCategory { get; set; }

        public Product() { }

        public Product(int idProducto, string nombre, string descripcion, decimal precio, int cantidadStock, int? idCategoria)
        {
            id = idProducto;
            name = nombre;
            description = descripcion;
            price = precio;
            stock = cantidadStock;
            idCategory = idCategoria;
        }

        public Product(string nombre, string descripcion, decimal precio, int cantidadStock, int idCategoria)
        {
            name = nombre;
            description = descripcion;
            price = precio;
            stock = cantidadStock;
            idCategory = idCategoria;
        }
    }
}
