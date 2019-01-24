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
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();
        int StateMotherF = 0;
        Afiliacion afi1 = new Afiliacion();
        Afiliacion afi2 = new Afiliacion();
        List<Ciudad> ciudades = new List<Ciudad>();


        public void Actualizar()
        {
            //Primero se debe actualizar la lista visual actual
            lstPersonas.Items.Clear();
            //Luego Actualizo la lista visual
            foreach (var iter in personas)
            {
                lstPersonas.Items.Add(iter);
            }
            toolStripStatusLabel1.Text = "ACTUALIZADO!";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ciudad c1 = new Ciudad(1, "Quito");
            Ciudad c2 = new Ciudad(1, "Guayaquil");
            Ciudad c3 = new Ciudad(1, "Cuenca");

            ciudades.Add(c1);
            ciudades.Add(c2);
            ciudades.Add(c3);




            afi1.IdAfiliacion = 1;
            afi1.Nombre = "Afiliado";

            afi2.IdAfiliacion = 2;
            afi2.Nombre = "Desafiliado";



        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoEdit FrmIngresar = new FrmIngresoEdit(0,personas,afi1,afi2,ciudades);
            FrmIngresar.ShowDialog();
            this.personas = FrmIngresar.Personas;
            toolStripStatusLabel1.Text = "gUARDADO!";
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente auxCli = new Cliente();
            auxCli = (Cliente)lstPersonas.SelectedItem;

            FrmIngresoEdit FrmEditar = new FrmIngresoEdit(1,personas,afi1,afi2,ciudades,auxCli,lstPersonas.SelectedIndex);
            FrmEditar.ShowDialog();
            this.personas = FrmEditar.Personas;
            Actualizar();
            toolStripStatusLabel1.Text = "EDITADO!";
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            personas.Remove((Persona)lstPersonas.SelectedItem);//OJO CON EL CASTING
            
            Actualizar();
            toolStripStatusLabel1.Text = "ELIMINADO!";
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente auxCli = new Cliente();
            auxCli = (Cliente)lstPersonas.SelectedItem;

            FrmIngresoEdit FrmEditar = new FrmIngresoEdit(1, personas, afi1, afi2, ciudades, auxCli, lstPersonas.SelectedIndex);
            FrmEditar.ShowDialog();
            this.personas = FrmEditar.Personas;
            Actualizar();
            toolStripStatusLabel1.Text = "EDITADO!";
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personas.Remove((Persona)lstPersonas.SelectedItem);//OJO CON EL CASTING

            Actualizar();
            toolStripStatusLabel1.Text = "ELIMINADO!";
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FrmIngresoEdit FrmIngresar = new FrmIngresoEdit(0, personas, afi1, afi2, ciudades);
            FrmIngresar.ShowDialog();
            this.personas = FrmIngresar.Personas;
            toolStripStatusLabel1.Text = "gUARDADO!";
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

            Cliente auxCli = new Cliente();
            auxCli = (Cliente)lstPersonas.SelectedItem;

            FrmIngresoEdit FrmEditar = new FrmIngresoEdit(1, personas, afi1, afi2, ciudades, auxCli, lstPersonas.SelectedIndex);
            FrmEditar.ShowDialog();
            this.personas = FrmEditar.Personas;
            Actualizar();
            toolStripStatusLabel1.Text = "EDITADO!";
        }
    }
}
