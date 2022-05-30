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
                    var1 = i;
                }
                else if (contador == 2)
                {
                    var2 = i;
                }
                else if (contador == 3)
                {
                    var3 = i;


                    int dato1 =  (var1 * (-3%11)) + (var2 * (6%11)) + (var3 * (2%11));
                    int dato2 =  (var1 * (1%11)) + (var2 * (-2%11)) + (var3 * (3%11));
                    int dato3 =  (var1 * (7%11)) + (var2 * (-3%11)) + (var3 * (-1%11));
                    
                    dataGridView1.Rows.Add();
                    int cant = dataGridView1.Rows.Count - 1;
                    dataGridView1[0, cant].Value =dato1;
                    dataGridView1[1, cant].Value = dato2;
                    dataGridView1[2, cant].Value = dato3;
                    
                    contador = 0;
                    var1 = 0;
                    var2 = 0;
                    var3 = 0;
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
    }
}
