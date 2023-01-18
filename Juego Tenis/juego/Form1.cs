using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            juego_parte_2 ventanajuego = new juego_parte_2();
            ventanajuego.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BIENBENIDO A TENIS, EL JUEGO TRATA DE CONTROLAR LA BARRA DE ABAJO CON EL MOUSE Y EVITAR QUE LAS PELOTAS CAIGAN. AL IR AVANZANDO EN EL JUEGO SUBIRAS DE NIVEL Y APARECERAN MAS PELOTAS. SUERTE! LA PELOTA *POKEBALL* TE SUMA 2 DE PUNTAJE AL IGUAL QUE LA PELOTA DE FUTBOL *BLANCO Y NEGRO*, LA PELOTA AMARILLO CON ROJO TE RESTA 1 DE PUNTAJE Y LA PELOTA DEL BARCELONA TE SUMA 4 DE PUNTAJE.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
