using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenusClientes2
{
    public class Cliente: Persona
    {
        int otro;
        int edad;
        string prueba;
        string direccion;
        Afiliacion afiliacion;
        Ciudad ciudad;
        //Holaaaaaa

        //Constructores
        public Cliente(string iniId, string iniNombre, string iniApellido, string iniCedula, string iniGenero, string iniDireccion, Afiliacion iniAfiliacion, Ciudad iniCiudad) : base(iniId, iniNombre, iniApellido, iniCedula, iniGenero)
        {
            this.direccion = iniDireccion;
            this.Afiliacion = iniAfiliacion;
            this.ciudad = iniCiudad;
        }

        public Cliente()
        {

        }

        //Getter y Setter
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }



        public Ciudad Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public Afiliacion Afiliacion
        {
            get
            {
                return afiliacion;
            }

            set
            {
                afiliacion = value;
            }
        }

        public override string ToString()
        {
            return IdPersona + " " + Nombre + " " + Apellido;
        }






    }
}
