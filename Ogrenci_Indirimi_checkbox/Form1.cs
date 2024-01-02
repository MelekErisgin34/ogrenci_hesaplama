using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Indirimi_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double adet, fiyat, odenecek;

            adet = Convert.ToDouble(txtAdet.Text);
            fiyat = Convert.ToDouble(txtFiyat.Text);

            //if(chkOgrenci.Checked )
            //{
            //    odenecek = (adet * fiyat) * 0.80;
            //}
            //else
            //{
            //    odenecek = adet * fiyat;
            //}

            odenecek = adet * fiyat;

            if (chkOgrenci.Checked) //Öğrenci işaretliyse
            {
                odenecek = odenecek * 0.8; //%20 indirim uygula
            }


            lblOdenecek.Text = "Ödenecek Tutar: " + odenecek.ToString();
        }
    }
}
