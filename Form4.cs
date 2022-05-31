using System;
using System.Windows.Forms;

namespace Login
{


    public partial class Form4 : Form
    {

        public Form4()
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


                    double dato1 = (var1 * (-0.2727272727)) + (var2 * (0.5454545455)) + (var3 * (0.1818181818));
                    double dato2 = (var1 * (0.09090909091)) + (var2 * (-0.1818181818)) + (var3 * (0.2727272727));
                    double dato3 = (var1 * (0.6363636364)) + (var2 * (-0.2727272727)) + (var3 * (-0.09090909091));

                    dataGridView1.Rows.Add();
                    int cant = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cant].Value = Math.Round(dato1);
                    dataGridView1[1, cant].Value = Math.Round(dato2);
                    dataGridView1[2, cant].Value = Math.Round(dato3);

                    contador = 0;
                    
                }


                contador++;


            }

        }

        

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form = new Form3();
            form.Enabled = true;
            form.Show();
        }
    }
}
