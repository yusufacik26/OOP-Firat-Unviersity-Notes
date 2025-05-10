using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2mayıs_teori2_Doğru_Dosya_
{
    public abstract class Hayvan
    {

        public string isim;
        public string cins;

        public Hayvan() { }

        public abstract string sesCikar();

        
    }

    public class Kopek : Hayvan
    {
        public override string sesCikar()
        {
            return "HAV HAV!!";
        }


    }

    public class Kedi : Hayvan
    {
        public override string sesCikar()
        {
            return "Miyavvv";
        }


    }
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void HayvanGoster(Hayvan h)
        {

            MessageBox.Show("Hayvan adı:" + h.isim + Environment.NewLine + "Cikarilan ses" + h.sesCikar());


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kopek k = new Kopek();
            k.isim = "Bolt";
            HayvanGoster(k);

            Kedi kd = new Kedi();

            kd.isim = "Limon";
            kd.cins = "Sarman";
            HayvanGoster(kd);

        }
    }
}
