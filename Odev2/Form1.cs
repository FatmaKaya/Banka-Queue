using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Banka TB = new Banka();

        private void btnDKListesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TB.Musteriler.Listele()+"\n\nOrtalama İşlem Tamamlanma Süresi= "+TB.Musteriler.OrtIslemTamamlanmaSuresi().ToString());
            TB.Musteriler.toplamSure = 0;
        }

        private void btnKBOKListesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TB.KBMusteriler.Listele() + "\n\nOrtalama İşlem Tamamlanma Süresi= " + TB.KBMusteriler.OrtIslemTamamlanmaSuresi().ToString());
            TB.KBMusteriler.toplamSure = 0;
        }
        
        private void btnBKOKListesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TB.BKMusteriler.Listele() + "\n\nOrtalama İşlem Tamamlanma Süresi= " + TB.BKMusteriler.OrtIslemTamamlanmaSuresi().ToString());
            TB.BKMusteriler.toplamSure = 0;
        }

        private void btnKBAzBekleyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TB.SıralamaKB());
        }

        private void btnBKAzBekleyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TB.SıralamaBK());
        }
    }
}
