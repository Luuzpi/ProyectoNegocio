using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlmacenFerreyra.Presentacion
{
    public class Ventas
    {
        private int id_Venta;
        private int id_Cliente;
        private int id_Empleado;
        private int id_Pedido;
        private int id_Producto;
        private int Fecha;
        private string Detalle;

        public Ventas(int id_Venta, int id_Cliente, int id_Empleado, int id_Pedido, int id_Producto, int Fecha, string Detalle)
        {
            this.id_Venta = id_Venta;
            this.id_Cliente = id_Cliente;
            this.id_Empleado = id_Empleado;
            this.id_Pedido = id_Pedido;
            this.id_Producto = id_Producto;
            this.Fecha = Fecha;
            this.Detalle = Detalle;
        }
        public Ventas()
        {
            this.id_Venta = 0;
            this.id_Cliente = 0;
            this.id_Empleado = 0;
            this.id_Pedido = 0;
            this.id_Producto = 0;
            this.Fecha = 0;
            this.Detalle = "";
        }
        public int Id_Venta
        {
            get
            {
                return id_Venta;
            }
            set
            {
                id_Venta = value;
            }
        }
        public int Id_Cliente
        {
            get
            {
                return id_Cliente;
            }
            set
            {
                id_Cliente = value;
            }
        }
        public int Id_Empleado
        {
            get
            {
                return id_Empleado;
            }
            set
            {
                id_Empleado = value;
            }
        }
        public int Id_Pedido
        {    get
            {
                return id_Pedido;
            }
            set
            {
                id_Pedido = value;
            }
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
        














    }
}
