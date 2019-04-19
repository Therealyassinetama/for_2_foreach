using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string s = "";
        List<double> prijzen = new List<double>();
        double Totaalprijs = 0;
        double Prijs1 = 270.69;
        double Prijs2 = 20.88;
        double Prijs3 = 1.35;

        private void button1_Click(object sender, EventArgs e)
        {
            Totaalprijs = 0;
            prijzen.Add(Prijs1);
            prijzen.Add(Prijs2);
            prijzen.Add(Prijs3);
            foreach (double gay in prijzen)
            {
                Totaalprijs += gay;
            }
            s = "U totaalprijs is " + Totaalprijs.ToString() + ". Wilt u pinnen of contant betalen?";
            MessageBox.Show(s);
        }
    }
}
