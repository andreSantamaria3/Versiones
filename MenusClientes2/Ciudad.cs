using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenusClientes2
{
    public class Ciudad
    {

        //Atributos
        int idCiudad;
        string nombreCiudad;

        //Constructores
        public Ciudad()
        {

        }
        public Ciudad(int iniId, string iniNombre)
        {
            this.idCiudad = iniId;
            this.nombreCiudad = iniNombre;
        }



        //Getter y Setter
        public int IdCiudad
        {
            get
            {
                return idCiudad;
            }

            set
            {
                idCiudad = value;
            }
        }
        public string NombreCiudad
        {
            get
            {
                return nombreCiudad;
            }

            set
            {
                nombreCiudad = value;
            }
        }

        public override string ToString()
        {
            return nombreCiudad;
        }


    }
}
