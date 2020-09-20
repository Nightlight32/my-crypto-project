using System;
using System.Windows.Forms;


namespace CryptoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 newForm2 = new Form2();
        Form3 newForm3 = new Form3();
        
        private void button1_Click(object sender, EventArgs e) //открыть шифр Цезаря
        {
           this.Hide();
           newForm2.ShowDialog();
           this.Show();
           
        }

        private void button2_Click(object sender, EventArgs e) //открыть Диффи-Хеллман
        {
            this.Hide();
            newForm3.ShowDialog();
            this.Show();
        }  
    }
}
