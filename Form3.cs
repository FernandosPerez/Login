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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 form = new Form5();
            form.ShowDialog();
        }
    }
}
