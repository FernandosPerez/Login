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

    
    public partial class Form1 : Form
    {

        public static int intentos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (intentos == 4)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();

            }

            if (textBox2.Text != "gato")
            {
                intentos = intentos + 1;

                if (intentos == 1)
                {
                    MessageBox.Show("has tenido un error");
                }else if (intentos > 1 && intentos <5)
                {
                    MessageBox.Show("has tenido "+intentos+" errores");
                }    
                

            }

            if (textBox2.Text == "gato")
            {
                this.Hide();

                Form3 form = new Form3();
                form.Enabled = true;
                form.Show();
                
                
            }
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseas salir?", "salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                var confirmacion = MessageBox.Show("Seguro?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (confirmacion == DialogResult.Yes)
                {
                   Application.Exit();
                }
               
            }
        }
    }
}
