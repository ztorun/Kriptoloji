using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptoPreje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isPrime(long x)
        {
            if (x < 3)
                return false;
            for (long i = x - 1; i > 1; i--)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        private long findPrime(long x = 1)
        {
            long myPrime = 2;
            while (!isPrime(myPrime) || myPrime > 100)
            {
                Random rnd = new Random();
                myPrime = rnd.Next(100);
                if (myPrime == x)
                    myPrime = 2;
            }
            return myPrime;
        }

        private long findQ_n(long first, long sec)
        {
            return (first - 1) * (sec - 1);
        }

        private long findN(long first, long sec)
        {
            return (first) * (sec);
        }

        private bool Coprime(long first, long sec)
        {
            long mlen = 0;
            if (first < sec)
                mlen = first;
            else
                mlen = sec;

            for (long i = 2; i < mlen+1; i++)
            {
                if (first % i == 0 && sec % i == 0)
                    return false;
            }
            return true;
        }

        private long findEncKey(long Q_n)
        {
            long mKey = 2;
            while (true)
            {
                Random rnd = new Random();
                mKey = (rnd.Next(Convert.ToInt32(Q_n) - 2)) + 2;
                if (Coprime(mKey, Q_n))
                    break;
            }
            return mKey;
        }

        private long findD(long EncKey, long Q_n)
        {
            for (long d = 1; true; d++)
            {
                if ((d * EncKey) % Q_n == 1)
                    return d;
            }
        }

        private long c_dmodn(long c, long d, long n)      // work out c^d mod n
        {
            long value = 1;
            while (d > 0)
            {
                value *= c;
                value %= n;
                d--;
            }
            return value;
        }

        private long crypteWord(long m, long mKey, long myN)
        {
            return c_dmodn(m, mKey, myN);
        }

        private long EncrypteWord(long c, long myD, long myN)
        {
            return c_dmodn(c, myD, myN);
        }

        private void Crypte_Click(object sender, EventArgs e)
        {
            encryptedtxt.Text = "";
            cryptedtxt.Text = "";
            dtxt.Text = "";
            if (pureText.Text == "")
            {
                MessageBox.Show("Please enter the Text.");
            }
            else if (Asal1txt.Text == "" || Asal2txt.Text == "")
            {
                MessageBox.Show("Please enter the Prime numbers or Random Generate One.");
            }
            else if(etxt.Text == "")
            {
                MessageBox.Show("Please enter the Enc. Key or Generate One.");
            }
            else
            {
                long first = Convert.ToInt64(Asal1txt.Text);
                long sec = Convert.ToInt64(Asal2txt.Text);
                long Q_n = findQ_n(first, sec);
                long myN = findN(first, sec);
                long mKey = Convert.ToInt64(etxt.Text);
                long[] crypted = new long[150];
                long[] encrypted = new long[150];
                long mlen = 0, x, sifre, cozum;
                string mWord = pureText.Text;

                if (!isPrime(first) || !isPrime(sec))
                {
                    MessageBox.Show("The Numbers must be prime numbers.");
                }
                else if (!Coprime(mKey, Q_n))
                {
                    MessageBox.Show("The E Number must be coprime with the T(n) number.");
                }
                else {
                    qntxt.Text = Q_n.ToString();
                    long myD = findD(mKey, Q_n);
                    dtxt.Text = myD.ToString();
                    for (int i = 0; i < mWord.Length; i++)
                    {
                        x = (long)mWord[i];
                        sifre = crypteWord(x, mKey, myN);
                        cozum = EncrypteWord(sifre, myD, myN);
                        crypted[i] = sifre;
                        encrypted[i] = cozum;
                        mlen = i + 1;
                    }
                    for (long i = 0; i < mlen; i++)
                    {
                        cryptedtxt.AppendText(((char)crypted[i]).ToString());
                        encryptedtxt.AppendText(((char)encrypted[i]).ToString());
                    }
                }
            }
        }
        private void KeyCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // only allow one decimal polong
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Asal1txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(sender, e);
        }

        private void Asal2txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(sender, e);
        }

        private void etxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCheck(sender,e);
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            long a, b;
            a = findPrime();
            b = findPrime(a);
            Asal1txt.Text = Convert.ToString(a);
            Asal2txt.Text = Convert.ToString(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qntxt.Text == "")
                MessageBox.Show("Please enter the Prime numbers or Generate One.");
            else
            { 
                long qn = Convert.ToInt64(qntxt.Text);
                long mKey = 1;
                while (true)
                {
                    mKey = findEncKey(Convert.ToInt32(qntxt.Text));
                    if (Coprime(mKey, qn))
                        break;
                }
                etxt.Text = mKey.ToString();
            }
           
        }

        private void Asal1txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long f = Convert.ToInt64(Asal1txt.Text);
                long s = Convert.ToInt64(Asal2txt.Text);
                qntxt.Text = findQ_n(f, s).ToString();
            }
            catch (Exception) { }
            
        }

        private void Asal2txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long f = Convert.ToInt64(Asal1txt.Text);
                long s = Convert.ToInt64(Asal2txt.Text);
                qntxt.Text = findQ_n(f, s).ToString();
            }
            catch (Exception) { }
        }
    }
}
