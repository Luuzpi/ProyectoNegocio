using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlmacenFerreyra.Presentacion
{
    public class Productos
    {
        private int id_Producto;
        private string Nombre;
        private int Stock;
        private string Detalle;
        private decimal Precio;
        private int Fecha;
        private decimal Peso;

        public Productos(int id_Producto, string Nombre, int Stock, string Detalle, decimal Precio, int Fecha, decimal Peso)
        {
            this.id_Producto = id_Producto;
            this.Nombre = Nombre;
            this.Stock = Stock;
            this.Detalle = Detalle;
            this.Precio = Precio;
            this.Fecha = Fecha;
            this.Peso = Peso;
        }
        public int Id_Producto
        {
            get
            {
                return id_Producto;
            }

            set
            {
                id_Producto = value;
            }
        }
        public string nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                nombre = value;
            }

        }
        public int stock
        {
            get
            {
                return Stock;
            }
            set
            {
                Stock = value;

            }
        }
        public string detalle
        {
            get
            {
                return Detalle;
            }
            set
            {
                Detalle = value;
            }
        }
        public decimal precio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }
        public int fecha
        {
            get
            {
                return Fecha;
            }

            set
            {
                Fecha = value;
            }
        }
        public decimal peso
        {
            get
            {
                return Peso;
            }
            set
            {
                Peso = value;
            }
        }






























    }
}
