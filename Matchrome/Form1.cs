using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matchrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {

          
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (textBox1.Text == "matinho")
            {
                Form2 j2 = new Form2();
                j2.Show();

            }
            else
            {
                MessageBox.Show("Senha incorreta!! Tente novamente");
            }
        }
    }
}
