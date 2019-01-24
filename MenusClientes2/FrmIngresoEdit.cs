using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusClientes2
{
    public partial class FrmIngresoEdit : Form
    {
        int estado;

        List<Persona> personas = new List<Persona>();
        Afiliacion afi1 = new Afiliacion();
        Afiliacion afi2 = new Afiliacion();
        List<Ciudad> ciudades = new List<Ciudad>();
        Cliente clienteAux = new Cliente();
        int index;

        public List<Persona> Personas
        {
            get
            {
                return personas;
            }

            set
            {
                personas = value;
            }
        }

        public Afiliacion Afi1
        {
            get
            {
                return afi1;
            }

            set
            {
                afi1 = value;
            }
        }

        public Afiliacion Afi2
        {
            get
            {
                return afi2;
            }

            set
            {
                afi2 = value;
            }
        }

        public List<Ciudad> Ciudades
        {
            get
            {
                return ciudades;
            }

            set
            {
                ciudades = value;
            }
        }

        public Cliente ClienteAux
        {
            get
            {
                return clienteAux;
            }

            set
            {
                clienteAux = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public FrmIngresoEdit()
        {
            InitializeComponent();
        }

        public FrmIngresoEdit(int iniEstado, List<Persona> iniPersonas,Afiliacion iniAf1, Afiliacion iniAf2, List<Ciudad> iniCiudades, Cliente iniAuxCli,int iniIndex)
        {
            InitializeComponent();
            this.Personas = iniPersonas;
            this.estado = iniEstado;
            this.Afi1 = iniAf1;
            this.Afi2 = iniAf2;
            this.Ciudades = iniCiudades;
            this.ClienteAux = iniAuxCli;
            this.Index = iniIndex;
        }

        public FrmIngresoEdit(int iniEstado, List<Persona> iniPersonas, Afiliacion iniAf1, Afiliacion iniAf2, List<Ciudad> iniCiudades)
        {
            InitializeComponent();
            this.Personas = iniPersonas;
            this.estado = iniEstado;
            this.Afi1 = iniAf1;
            this.Afi2 = iniAf2;
            this.Ciudades = iniCiudades;
            

        }

        public void llenarCombos() {
            cbxCiudad.Items.Clear();
            foreach (var iter in  Ciudades) {
                cbxCiudad.Items.Add(iter);
            }
            cbxAfiliacion.Items.Clear();
            cbxAfiliacion.Items.Add(Afi1);
            cbxAfiliacion.Items.Add(Afi2);

        }
        public void Limpiar()
        {
            txtId.Text = " ";
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtCedula.Text = " ";
            txtGenero.Text = " ";
            txtDireccion.Text = " ";
            cbxAfiliacion.Text = " ";
            cbxCiudad.Text = " ";
            //txtSueldo.Text = " ";
            //txtTurno.Text = " ";
            //txtCaja.Text = " ";
           
        }
        private void FrmIngresoEdit_Load(object sender, EventArgs e)
        {
            llenarCombos();

            if (estado == 1)
            {

                Cliente auxCli = new Cliente();
                auxCli = ClienteAux;

                txtId.Text = auxCli.IdPersona;
                txtNombre.Text = auxCli.Nombre;
                txtApellido.Text = auxCli.Apellido;
                txtCedula.Text = auxCli.Cedula;
                txtGenero.Text = auxCli.Genero;

                txtDireccion.Text = auxCli.Direccion;
                cbxAfiliacion.Text = auxCli.Afiliacion.Nombre;
                cbxCiudad.Text = auxCli.Ciudad.NombreCiudad;
            }
            else {
                Limpiar();
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                Cliente cli = new Cliente();

                cli.IdPersona = txtId.Text;
                cli.Nombre = txtNombre.Text;
                cli.Apellido = txtApellido.Text;
                cli.Cedula = txtCedula.Text;
                cli.Genero = txtGenero.Text;
                cli.Direccion = txtDireccion.Text;
                cli.Afiliacion = (Afiliacion)cbxAfiliacion.SelectedItem;
                cli.Ciudad = (Ciudad)cbxCiudad.SelectedItem;

                Personas.Add(cli);
                Limpiar();
                
                Console.WriteLine("Ingreso Exitoso");

                this.Close();
            }
            else
            {
                int i;
                i =Index;
                Cliente cli1 = new Cliente();

                cli1.IdPersona = txtId.Text;
                cli1.Nombre = txtNombre.Text;
                cli1.Apellido = txtApellido.Text;
                cli1.Cedula = txtCedula.Text;
                cli1.Genero = txtGenero.Text;
                cli1.Direccion = txtDireccion.Text;
                cli1.Afiliacion = (Afiliacion)cbxAfiliacion.SelectedItem;
                cli1.Ciudad = (Ciudad)cbxCiudad.SelectedItem;

                Personas[i] = cli1;
                Console.WriteLine("Actualizacion Exitosa");
                this.Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
