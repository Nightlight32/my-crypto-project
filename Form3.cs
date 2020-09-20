using System;
using System.Windows.Forms;
using System.Numerics;

namespace CryptoProject
{
    public partial class Form3 : Form
    {
        int primeNumber, gBase, aliceSecretKey, bobSecretKey;
        public Form3()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            primeNumber = (int)(numericUpDown1.Value);
            gBase = (int)(numericUpDown2.Value);
            aliceSecretKey = (int)(numericUpDown3.Value);
            bobSecretKey = (int)(numericUpDown4.Value);
            //вычисляем публичный ключ Алисы
            var A = BigInteger.ModPow(gBase, aliceSecretKey, primeNumber);
            textBox1.Text = A.ToString();
            //и Боба
            var B = BigInteger.ModPow(gBase, bobSecretKey, primeNumber);
            textBox2.Text = B.ToString();

            //находим секретный ключ Алисы
            var aliceSecretKeyExchanged = BigInteger.ModPow(B, aliceSecretKey, primeNumber);
            textBox3.Text = aliceSecretKeyExchanged.ToString();
            //и Боба
            var bobSecretKeyExchanged = BigInteger.ModPow(A, bobSecretKey, primeNumber);
            textBox4.Text = bobSecretKeyExchanged.ToString();
        }
    }
}
