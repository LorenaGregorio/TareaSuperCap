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
          
            int contador =0;
          




            var jugador1 = new DetallesJugador
            {

                                                             
                //datos personales de jugador
                Estatura = Convert.ToDouble(textBox8.Text),
                Peso = Convert.ToDouble(textBox9.Text),
                GrupoSanguineo = comboBox4.Text,
                Alergico = comboBox5.Text,
                EnfermedadCondicion = textBox10.Text,
                Lesiones = textBox11.Text,
                Lateralidad = comboBox6.Text,
                PosicionCampo = textBox12.Text,

                //detalles jugador
                JugadorNuevo = Convert.ToBoolean(comboBox1.Text),
                Nombres = textBox1.Text,
                Apellidos = textBox2.Text,
                Direccion = textBox3.Text,
                Telefono = textBox4.Text,
                Email = textBox5.Text,
                LugardeNacimiento = textBox6.Text,
                FechadeNacimiento = Convert.ToDateTime(dateTimePicker1.Text),
                Identificacion = comboBox2.Text,
                NumerodeIdentificacionCUI = Convert.ToInt32(textBox7.Text),
                JugadorRetira = Convert.ToBoolean(comboBox3.Text)

               
            };
           
       
            form1.AgregarJugadores(jugador1);

            contador = Convert.ToInt32(label24.Text) + 1;
            label24.Text = contador.ToString();
            borrar();
         




        }
        private void borrar ()
        {
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void JugadorForms_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
