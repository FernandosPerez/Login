using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        int falla = 4;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled ==true )
            {
                button3.Enabled = true;

                if (textBox1.Text=="5576945365")
                {
                    this.Hide();
                    Form1.intentos = 0;
                    MessageBox.Show("Vuelvo y reitero ;)");
                    Form1 form = new Form1();
                    form.Show();

                }
                else if (textBox1.Text!= "5576945365")
                {
                    falla = falla -1;
                    MessageBox.Show("El numero no corresponde tienes "+falla+ " intentos");
                    if (falla == 0)
                    {
                        button3.Enabled = false;
                        textBox1.Enabled = false;
                        MessageBox.Show("Se te dijo y se te advirtio !!!");
                        Application.Exit();
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                button3.Enabled = true;
                button3.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
