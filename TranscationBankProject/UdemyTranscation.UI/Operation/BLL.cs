using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace UdemyTranscation.UI.Operation
{
  public class BLL
    {
        DAL dal;
        SqlCommand gm;
        public BLL()
        {
            dal = new DAL();
        }
        public int HesapKontrol(string HesapNo)
        {
            if (!string.IsNullOrEmpty(HesapNo))
            {
                return dal.HesapKontrol(HesapNo);
            }
            else
                return -1;
        }
        public bool HesapTutarKontrol(string HesapNo,decimal Tutar)
        {
            if (!string.IsNullOrEmpty(HesapNo) && Tutar > 0)
            {
                return dal.HesapTutarKontrol(HesapNo,Tutar);
            }
            else
                return false;
        }
        public List<Entities.Hesap> HesapList()
        {
             List<Entities.Hesap> hesaplar = new List<Entities.Hesap>();
             SqlDataReader reader = dal.HesapListe();
            while (reader.Read())
            {
                hesaplar.Add(new Entities.Hesap()
                {

                    ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    HesapNo = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Adi = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Tutar = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)

                }) ;
            }
            reader.Close();
            dal.BaglantiAyarla();
            return hesaplar;
        }
        public int KontrolEtAktar(string gonderenHesapNo, string aliciHesapNo, decimal tutar)
        {
            return dal.KontrolEtAktar(gonderenHesapNo, aliciHesapNo, tutar); //kontrol edilecek var mı yok mu diye 
        }
        public int KontrolEtAktarTrans(string gonderenHesapNo, string aliciHesapNo, decimal tutar)
        {
            return dal.KontrolEtAktarTrans(gonderenHesapNo, aliciHesapNo, tutar); //kontrol edilecek var mı yok mu diye 
            
        }
    }
 
}
