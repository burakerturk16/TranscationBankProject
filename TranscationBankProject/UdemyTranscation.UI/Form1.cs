using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UdemyTranscation.UI.Operation;

namespace UdemyTranscation.UI
{
    public partial class Form1 : Form
    {
        Operation.BLL bll = new Operation.BLL();
        public Form1()
        {
          

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }
       public void Yenile()
        {
            List<Entities.Hesap> hesaplar = bll.HesapList();
            dataGridView1.DataSource = hesaplar;
            
        }

        private void button2_Click(object sender, EventArgs e) //kontrol et aktar bu
        {
            bll.KontrolEtAktar(txt_gondericiHesap.Text, txt_aliciHesap.Text, decimal.Parse(txt_tutar.Text)); // gonderen hesap no alıcı hesap no tutar parametreleri olacak
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btn_kontrolEtAktar_Click(object sender, EventArgs e)
        {
            bll.KontrolEtAktarTrans(txt_gondericiHesap.Text, txt_aliciHesap.Text, decimal.Parse(txt_tutar.Text));
                        
        }
    }
}
