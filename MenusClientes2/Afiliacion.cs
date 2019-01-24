using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenusClientes2
{
    public class Afiliacion
    {


        int idAfiliacion;
        string nombre;
        public Afiliacion()
        {

        }

        public int IdAfiliacion
        {
            get
            {
                return idAfiliacion;
            }

            set
            {
                idAfiliacion = value;
            }
        }

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

        public override string ToString()
        {
            return nombre;
        }


    }
}
