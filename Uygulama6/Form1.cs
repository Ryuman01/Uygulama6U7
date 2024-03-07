using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama6
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[3];
        int[,] yazili = new int[3,4];
        int index = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            yazili[index, 0] = int.Parse(txtYazili1.Text);
            yazili[index, 1] = int.Parse(txtYazili2.Text);
            yazili[index, 2] = int.Parse(txtYazili3.Text);
            yazili[index, 3] = int.Parse(txtYazili4.Text);
            index++;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            double toplam;
            for (int x = 0; x < 3; x++)
            {
                toplam = 0;
                for (int y = 0; y < 4; y++)
                {
                    toplam += yazili[x, y];
                }
                lbYazili.Items.Add(isimler[x] + " => " + toplam / 4 );
            }
        }
    }
}
