using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass<decimal> myc = new MyClass<decimal>();
            myc.MyProperty = 45;
            myc.DinamikProperty = 5.41m;

            MyClass<string> myc2 = new MyClass<string>();
            myc2.MyProperty = 87;
            myc2.DinamikProperty = "Negan";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dizi<string> strler = new Dizi<string>(3);
            strler.Ekle("Rick");
            strler.Ekle("Daryl");
            strler.Ekle("Morgan");

            Dizi<int> sayilar = new Dizi<int>(2);
            sayilar.Ekle(98);
            sayilar.Ekle(74);
        }
    }
}