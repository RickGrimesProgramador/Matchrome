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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void navegar()
        {
            webBrowser1.Navigate(textBox1.Text);
        }
        private void nothing()
        {
                                                                                                        webBrowser1.Navigate("https://www.google.com/search?q=miah+khalifa+nude&tbm=isch&ved=2ahUKEwiigt-Kzu35AhWwN7kGHT7XC1AQ2-cCegQIABAA&oq=miah+khalifa+nude&gs_lcp=CgNpbWcQA1CNCFjdC2DQDGgAcAB4AIABcogBmgSSAQMwLjWYAQCgAQGqAQtnd3Mtd2l6LWltZ8ABAQ&sclient=img&ei=SoINY6K1KLDv5OUPvq6vgAU&bih=597&biw=1242#imgrc=u86ON3x1MKJ4LM");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                navegar();

            }
            else
            {
                MessageBox.Show("Escreva");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "chimaco esteve aqui")
            {
                nothing();

            }
            if (textBox1.Text != "chimaco esteve aqui")
            {
               webBrowser1.GoHome();

            }
            
        }
    }
}
