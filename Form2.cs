using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoProject
{
    public partial class Form2 : Form
    {
        Caesar caesar = new Caesar();
        public Form2()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public class Clent
        {
            string le;

            public Clent(string m)
            {
                le = m;
            }

            public string Replace(string m, int key) //замена символа m на символ со смещением key
            {
                int pos = le.IndexOf(m);
                if (pos == -1)
                    return "";
                pos = (pos + key) % le.Length;
                if (pos < 0)
                    pos += le.Length;
                return le.Substring(pos, 1);
            }
        }

        class Caesar : List<Clent> //список исходных наборов букв
        {
            public Caesar()
            {
                this.Add(new Clent("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"));
                this.Add(new Clent("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"));
            }
            public string Codec(string m, int key) //кодировать-декодировать
            {
                string res = "", tmp = "";
                for (int i = 0; i < m.Length; i++)
                {
                    foreach (Clent v in this)
                    {
                        tmp = v.Replace(m.Substring(i, 1), key);
                        if (tmp != "")
                        {
                            res += tmp;
                            break;
                        }
                    }
                    if (tmp == "")
                        res += m.Substring(i, 1);
                }
                return res;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = fileText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = caesar.Codec(richTextBox1.Text, (int)numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = caesar.Codec(richTextBox2.Text, -(int)numericUpDown1.Value);
        }
    }
}
