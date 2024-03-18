using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenFerreyra.Presentacion
{
    public class Empleados
    {
        private int id_Empleado;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Comentario;
        private int Fecha_Ingreso;
        private string password;
        private string mail;

        public Empleados(int id_Empleado, string Nombre, string Apellido, string Direccion, string Comentario, int Fecha_Ingreso, string password, string mail)
        {
            this.id_Empleado = id_Empleado;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.Comentario = Comentario;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.password = password;
            this.mail = mail;

        }
        public Empleados()
        {
            this.id_Empleado = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Direccion = "";
            this.Comentario = "";
            this.Fecha_Ingreso = 0;
            this.mail = "";
            this.password = "";

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
        public string comentario
        {
            get
            {
                return Comentario;
            }
            set
            {
                Comentario = value;
            }
        }
        public int fecha_ingreso
        {
            get
            {
                return Fecha_Ingreso;
            }
            set
            {
                Fecha_Ingreso = value;
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }


    }
}
