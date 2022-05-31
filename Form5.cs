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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String codigo = richTextBox1.Text;
            char[] eliminar = { ' ' };
            String[] trozos = codigo.Split(eliminar);

            int contador = 1;
            int var1 = 0;
            int var2 = 0;
            int var3 = 0;
            for (int i = 0; i < trozos.Length; i++)
            {

                if (contador == 1)
                {
                    var1 = Int32.Parse(trozos[i]);
                }
                else if (contador == 2)
                {
                    var2 = Int32.Parse(trozos[i]);
                }
                else if (contador == 3)
                {
                    var3 = Int32.Parse(trozos[i]);

                    int dato1 = (var1 * 1) + (var2 * 0) + (var3 * 2);
                    int dato2 = (var1 * 2) + (var2 * -1) + (var3 * 1);
                    int dato3 = (var1 * 1) + (var2 * 3) + (var3 * 0);

                    dataGridView1.Rows.Add();
                    int cant = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cant].Value = dato1;
                    dataGridView1[1, cant].Value = dato2;
                    dataGridView1[2, cant].Value = dato3;

                    contador = 0;
                }


                contador++;


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
                    this.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form = new Form3();
            form.Enabled = true;
            form.Show();

        }
        
    }
}
