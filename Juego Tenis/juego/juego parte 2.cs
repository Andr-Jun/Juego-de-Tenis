using System;
using System.Drawing;
using System.Windows.Forms;

namespace juego
{
    public partial class juego_parte_2 : Form
    {
        public juego_parte_2()
        {
            InitializeComponent();
        }
        int velocidad = 3;
        int velocidad2 = 4;
        int velocidad3 = 4;
        int velocidad4 = 5;
        int cont = 0;
        int cont2 = 0;
        int cont3 = 0;
        int cont4 = 0;
        int puntaje = 0;
        int puntaje2 = 0;
        int puntaje3 = 0;
        int puntaje4 = 0;
        int resul = 0;
        int vida = 4;

        bool Arriba;
        bool Izquierda;
        bool Arriba2;
        bool Izquierda2;
        bool Arriba3;
        bool Izquierda3;
        bool Arriba4;
        bool Izquierda4;

        private void juego_parte_2_Load(object sender, EventArgs e)
        {
            this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
            Random aleatorio = new Random();
            Random aleatorio2 = new Random();
            pictureBox2.Location = new Point(aleatorio.Next(this.Height),0);
            pictureBox3.Location = new Point(aleatorio2.Next(this.Height), 0);
            Arriba = true;
            Izquierda = true;
            Arriba2 = true;
            Izquierda2 = true;
            MessageBox.Show("Nivel 1");
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void juego_parte_2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Top > this.Height)
            {
                timer1.Enabled = false;
                if (timer1.Enabled == false || timer2.Enabled == false || timer3.Enabled == false || timer4.Enabled == false)
                {
                    vida = vida - 1;
                    this.Text = "vidas:" + vida;
                }
                if (vida < 1)
                    {
                        resul = puntaje + puntaje2 - puntaje3 + puntaje4;
                        MessageBox.Show("puntaje:" + resul.ToString() + "veces!");
                        MessageBox.Show("fin del juego");
                        this.Close();
                    }
                velocidad = 3;
                cont = 0;
            }
            if (pictureBox2.Left + pictureBox2.Width >= pictureBox1.Left &&
                pictureBox2.Left + pictureBox2.Width <= pictureBox1.Left + pictureBox1.Width &&
                pictureBox2.Top + pictureBox2.Height >= pictureBox1.Top &&
                pictureBox2.Top + pictureBox2.Height <= pictureBox1.Top + pictureBox1.Height)
            {
                Arriba = false;
                puntaje += 2;
                cont += 1;
                if (cont > 2)
                {
                    velocidad += 2;
                    cont = 0;
                }
                resul = puntaje + puntaje2;
                this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                if (resul == 10)
                {
                    Random aleatorio3 = new Random();
                    pictureBox4.Location = new Point(aleatorio3.Next(this.Height), 0);
                    timer3.Enabled = true;
                    if (timer3.Enabled == true)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        MessageBox.Show("Ha pasado al nivel 2");
                        this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                    }
                }
                resul = puntaje + puntaje2 - puntaje3;
                this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                if (resul == 20)
                {
                    Random aleatorio4 = new Random();
                    pictureBox5.Location = new Point(aleatorio4.Next(this.Height), 0);
                    timer4.Enabled = true;
                    if (timer4.Enabled == true)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                        MessageBox.Show("Ha pasado al nivel 3");
                        this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                        timer4.Enabled = true;
                    }
                }

            }
            #region movimiento de la pelota
            if (Izquierda)
            {
                pictureBox2.Left += velocidad; // a la derecha
            }
            else
            {
                pictureBox2.Left -= velocidad; // a la izquierda
            }

            if (Arriba)
            {
                pictureBox2.Top += velocidad; // va para abajo 
            }
            else
            {
                pictureBox2.Top -= velocidad; // va para arriba
            }
            if (pictureBox2.Top <= 0) // si pega en la pared de arriba
            {
                Arriba = true;
            }
            if (pictureBox2.Left <=0) // si pega en la izquierda
            {
                Izquierda = true;
            }
            if (pictureBox2.Left >= this.Width - 50) // si pega en la derecha
            {
                Izquierda = false;
            }


            #endregion
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Top > this.Height)
            {
                timer2.Enabled = false;
                if (timer1.Enabled == false || timer2.Enabled == false || timer3.Enabled == false || timer4.Enabled == false)
                {
                    vida = vida - 1;
                    this.Text = "vidas:" + vida;
                }
                if (vida < 1)
                    {
                        resul = puntaje + puntaje2 - puntaje3 + puntaje4;
                        MessageBox.Show("puntaje:" + resul.ToString() + "veces!");
                        MessageBox.Show("fin del juego");
                        this.Close();
                    }
                velocidad2 = 4;
                cont2 = 0;
            }
            if (pictureBox3.Left + pictureBox3.Width >= pictureBox1.Left &&
                pictureBox3.Left + pictureBox3.Width <= pictureBox1.Left + pictureBox1.Width &&
                pictureBox3.Top + pictureBox3.Height >= pictureBox1.Top &&
                pictureBox3.Top + pictureBox3.Height <= pictureBox1.Top + pictureBox1.Height)
            {
                Arriba2 = false;
                puntaje2 += 2;
                cont2 += 1;
                if (cont2 > 2)
                {
                    velocidad2 += 2;
                    cont2 = 0;
                }
                resul = puntaje + puntaje2;
                this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                if (resul == 10)
                {
                    Random aleatorio3 = new Random();
                    pictureBox4.Location = new Point(aleatorio3.Next(this.Height), 0);
                    timer3.Enabled = true;
                    if (timer3.Enabled == true)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        MessageBox.Show("Ha pasado al nivel 2");
                        this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                    }
                }
                resul = puntaje + puntaje2 - puntaje3;
                this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                if (resul == 20)
                {
                    Random aleatorio4 = new Random();
                    pictureBox5.Location = new Point(aleatorio4.Next(this.Height), 0);
                    timer4.Enabled = true;
                    if (timer4.Enabled == true)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                        MessageBox.Show("Ha pasado al nivel 3");
                        this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                        timer4.Enabled = true;
                    }
                }
            }
            #region movimiento de la pelota 2
            if (Izquierda2)
            {
                pictureBox3.Left += velocidad2;
            }
            else
            {
                pictureBox3.Left -= velocidad2;
            }

            if (Arriba2)
            {
                pictureBox3.Top += velocidad2;
            }
            else
            {
                pictureBox3.Top -= velocidad2;
            }
            if (pictureBox3.Top <= 0)
            {
                Arriba2 = true;
            }
            if (pictureBox3.Left <= 0)
            {
                Izquierda2 = true;
            }
            if (pictureBox3.Left >= this.Width - 50)
            {
                Izquierda2 = false;
            }
            #endregion
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Top > this.Height)
            {
                timer3.Enabled = false;
                if (timer1.Enabled == false || timer2.Enabled == false || timer3.Enabled == false || timer4.Enabled == false)
                {
                    vida = vida - 1;
                    this.Text = "vidas:" + vida;
                }
                if (vida < 1)
                {
                    resul = puntaje + puntaje2 - puntaje3 + puntaje4;
                    MessageBox.Show("puntaje:" + resul.ToString() + "veces!");
                    MessageBox.Show("fin del juego");
                    this.Close();
                }
                velocidad3 = 4;
                cont3 = 0;
            }
            if (pictureBox4.Left + pictureBox4.Width >= pictureBox1.Left &&
                pictureBox4.Left + pictureBox4.Width <= pictureBox1.Left + pictureBox1.Width &&
                pictureBox4.Top + pictureBox4.Height >= pictureBox1.Top &&
                pictureBox4.Top + pictureBox4.Height <= pictureBox1.Top + pictureBox1.Height)
            {
                Arriba3 = false;
                puntaje3 += 1;
                cont3 += 1;
                if (cont3 > 2)
                {
                    velocidad3 += 2;
                    cont3 = 0;
                }
                resul = puntaje + puntaje2 - puntaje3;
                this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                if (resul == 20)
                {
                    Random aleatorio4 = new Random();
                    pictureBox5.Location = new Point(aleatorio4.Next(this.Height), 0);
                    timer4.Enabled = true;
                    if (timer4.Enabled == true)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                        MessageBox.Show("Ha pasado al nivel 3");
                        this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                        timer4.Enabled = true;
                    }
                }
            }
            #region movimiento de la pelota 3
            if (Izquierda3)
            {
                pictureBox4.Left += velocidad3;
            }
            else
            {
                pictureBox4.Left -= velocidad3;
            }

            if (Arriba3)
            {
                pictureBox4.Top += velocidad3;
            }
            else
            {
                pictureBox4.Top -= velocidad3;
            }
            if (pictureBox4.Top <= 0)
            {
                Arriba3 = true;
            }
            if (pictureBox4.Left <= 0)
            {
                Izquierda3 = true;
            }
            if (pictureBox4.Left >= this.Width - 50)
            {
                Izquierda3 = false;
            }
            #endregion
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Top > this.Height)
            {
                timer4.Enabled = false;
                if (timer1.Enabled == false || timer2.Enabled == false || timer3.Enabled == false || timer4.Enabled == false)
                {
                    vida = vida - 1;
                    this.Text = "vidas:" + vida;
                }
                if (vida < 1)
                {
                    resul = puntaje + puntaje2 - puntaje3 + puntaje4;
                    MessageBox.Show("puntaje:" + resul.ToString() + "veces!");
                    MessageBox.Show("fin del juego");
                    this.Close();
                }
                velocidad4 = 5;
                cont4 = 0;
            }
            if (pictureBox5.Left + pictureBox5.Width >= pictureBox1.Left &&
                pictureBox5.Left + pictureBox5.Width <= pictureBox1.Left + pictureBox1.Width &&
                pictureBox5.Top + pictureBox5.Height >= pictureBox1.Top &&
                pictureBox5.Top + pictureBox5.Height <= pictureBox1.Top + pictureBox1.Height)
            {
                Arriba4 = false;
                puntaje4 += 4;
                cont4 += 1;
                if (cont4 > 2)
                {
                    velocidad4 += 2;
                    cont4 = 0;
                }
                resul = puntaje + puntaje2 - puntaje3 + puntaje4;
                this.Text = "vidas:" + vida + " " + "Puntaje:" + resul;
            }
            #region movimiento de la pelota 4
            if (Izquierda4)
            {
                pictureBox5.Left += velocidad4;
            }
            else
            {
                pictureBox5.Left -= velocidad4;
            }

            if (Arriba4)
            {
                pictureBox5.Top += velocidad4;
            }
            else
            {
                pictureBox5.Top -= velocidad4;
            }
            if (pictureBox5.Top <= 0)
            {
                Arriba4 = true;
            }
            if (pictureBox5.Left <= 0)
            {
                Izquierda4 = true;
            }
            if (pictureBox5.Left >= this.Width - 50)
            {
                Izquierda4 = false;
            }
            #endregion
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
