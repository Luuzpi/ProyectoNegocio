using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenFerreyra.Presentacion
{
    public class Clientes
    {
        private int id_Cliente;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Telefono;

        public Clientes (int id_Cliente, string Nombre, string Apellido, string Direccion,string Telefono) 
        {
            this.id_Cliente = id_Cliente;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
        }
        public Clientes()
        {
            this.id_Cliente = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion= "";
            this.Telefono = "";
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
        public string nombre
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }
        public string apellido
        {
            get
            {
                return Apellido;
            }

            set
            {
                Apellido = value;
            }
        }
        public string direccion
        {
            get
            {
                return Direccion;
            }

            set
            {
                Direccion = value;
            }
        }
        public string telefono
        {
            get
            {
                return Telefono;
            }

            set
            {
                Telefono = value;
            }
        }

    }
}
