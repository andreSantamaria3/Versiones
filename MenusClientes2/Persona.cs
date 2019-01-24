using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenusClientes2
{
    public class Persona
    {

        //Atributos
        string idPersona;
        string nombre;
        string apellido;
        string cedula;
        string genero;


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string IdPersona
        {
            get
            {
                return idPersona;
            }

            set
            {
                idPersona = value;
            }
        }



        //Metodos
        //constructor;
        public Persona()
        {

        }

        public Persona(string iniIdPersona, string iniNombre, string iniApellido, string inicedula, string iniGenero)
        {
            this.idPersona = iniIdPersona;
            this.nombre = iniNombre;
            this.apellido = iniApellido;
            this.cedula = iniApellido;
            this.genero = iniGenero;
        }



    }
}
