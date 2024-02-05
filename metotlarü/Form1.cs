using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlarü
{
    public partial class Form1 : Form
    {  
        Color renk  = Color.Red;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sekil sekil1 = new Sekil();
            sekil1.uzunkenar = Convert.ToInt32(txtsayi1.Text);
            sekil1.kisakenar = Convert.ToInt32(txtsayi2.Text);
            //sekilkareyaz();
            sekil1.sekilciz(btnsekil, renk);
            sekil1.mesajdegistir(btnsekil, txtmesaj.Text);

            //uygulama
            //sekli mesejdagistir(semanur)

        
        }

        private void btnrek_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
    }
}
