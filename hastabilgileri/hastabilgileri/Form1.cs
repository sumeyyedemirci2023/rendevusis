using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastabilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Randevu randevu;
        List<Randevu> randevuListesi=new List<Randevu>();
        private void Form1_Load(object sender, EventArgs e)
        {
            randevuListesi.Add(new Randevu(1,"Sümeyye Demirci","0553265355","Kardiyoloji",newDateTime(),true);
        }
    }
}
