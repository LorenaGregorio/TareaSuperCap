using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaEquipodeFutbol.Jugador;

namespace TareaEquipodeFutbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<DetallesJugador> listajugador1 = new List<DetallesJugador>();
        public void AgregarJugadores(DetallesJugador jugador1)
        {

            listajugador1.Add(jugador1);
            BindingSource bs = new BindingSource();
            bs.DataSource = listajugador1;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //este es el enlace para el formulario
            using (JugadorForms frmj = new JugadorForms(this))
            {
                frmj.ShowDialog();
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
