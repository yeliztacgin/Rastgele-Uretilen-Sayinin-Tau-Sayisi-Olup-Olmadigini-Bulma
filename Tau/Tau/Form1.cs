using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            int toplam = 0;
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 101);
            textBox1.Text = sayi.ToString();

            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi%i==0)
                {
                    listBox1.Items.Add("Sayınızın Tam Bölenleri"+" " + i);

                    toplam++;
                
                }
            }

            MessageBox.Show("Bölenlerin Toplamı" + toplam);

            if (sayi%toplam==0)
            {
                MessageBox.Show("Tau Sayısıdır");
            }
            else
            {
                MessageBox.Show("Tau Sayısı Değildir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
    }

