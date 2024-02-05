using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlarü
{
    internal class Sekil
    {
        public int uzunkenar {  get; set; } 

        public int kisakenar { get; set; }


        //parametre almayan ve deger döndürmeyen

        public void kareyaz()
        {
            int sonuc= this.kisakenar * this.uzunkenar;
            MessageBox.Show($"sekil karesi:{sonuc}");
        }
        //parametre alan ve değer döndürmeyen(vodi)
        public void sekilciz(Button btn,Color renk)
        {
            btn.Width = this. uzunkenar;
            btn.Height = this.kisakenar;
            btn.BackColor = renk;
        }
        public void mesajdegistir(Button btn,string mesaj)
        {
             
         btn. Text = mesaj;
        }



    }
}
