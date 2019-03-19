using TareaEquipodeFutbol.Jugador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEquipodeFutbol
{
    public partial class JugadorForms : Form
    {
        private Form1 form1;

        public JugadorForms(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }
       

        List<DetallesJugador> listajugador1 = new List<DetallesJugador>();

        private void button1_Click(object sender, EventArgs e)
        {

            //if (listajugador1.Count)
            //{

            //}

            var jugador1 = new DetallesJugador
            {
                //datos personales de jugador
                Estatura = Convert.ToDouble(textBox8.Text),
                Peso = Convert.ToDouble(textBox9.Text)

                //detalles jugador
            };

            form1.AgregarJugadores(jugador1);


        }

        private void JugadorForms_Load(object sender, EventArgs e)
        {

        }
    }
}
