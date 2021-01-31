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
    public class DAL
    {
        SqlConnection bgl;
        SqlCommand gm;
        SqlDataReader read;
        int returnValueINT;
        bool returnValueBOOL;
        Entities.Hesap hesap;

        public DAL()
        {
            bgl = new SqlConnection();
            bgl.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

        }
        public void BaglantiAyarla()
        {
            if (bgl.State == ConnectionState.Closed)
                bgl.Open();
            else
            {
                bgl.Close();
            }
            
        }
        public int HesapKontrol(string HesapNo)
        {
            gm = new SqlCommand("select count(*) from Hesaplar where HesapNo = @HesapNo", bgl);
            gm.Parameters.Add("HesapNo", SqlDbType.NVarChar).Value = HesapNo;
            BaglantiAyarla();
            returnValueINT = (int)gm.ExecuteScalar();
            BaglantiAyarla();
            return returnValueINT;
        }
        public bool HesapTutarKontrol(string HesapNo, decimal Tutar)
        {
            gm = new SqlCommand("select count(*) from Hesaplar where HesapNo = @HesapNo and Tutar <= @Tutar", bgl);
            gm.Parameters.Add("HesapNo", SqlDbType.NVarChar).Value = HesapNo;
            gm.Parameters.Add("Tutar", SqlDbType.Decimal).Value = Tutar;
            BaglantiAyarla();
            returnValueINT = (int)gm.ExecuteScalar();
            returnValueBOOL = (bool)gm.ExecuteScalar();
            Console.WriteLine("GELEN DEGER SAYISI VE DOGRU OLUP OLMADIGI", returnValueINT, returnValueBOOL);
            BaglantiAyarla();
            return returnValueBOOL;
        }
        public SqlDataReader HesapListe()
        {
            gm = new SqlCommand("select * from Hesaplar", bgl);
            BaglantiAyarla();
            return gm.ExecuteReader();
           
        }
        public int KontrolEtAktar(string gonderenHesapNo, string aliciHesapNo, decimal tutar)
        {
            int kontrol = 0;
            gm = new SqlCommand("select count(*) from Hesaplar where HesapNo = @gonderenHesap", bgl);
            gm.Parameters.Add("gonderenHesap", SqlDbType.NVarChar).Value = gonderenHesapNo;
            BaglantiAyarla();
            kontrol = (int)gm.ExecuteScalar();
            BaglantiAyarla();

            if (kontrol > 0)
            {
                gm = new SqlCommand("select count(*) from Hesaplar where HesapNo = @aliciHesap", bgl);
                gm.Parameters.Add("alicihesap", SqlDbType.NVarChar).Value = aliciHesapNo;
                BaglantiAyarla();
                kontrol = (int)gm.ExecuteScalar();
                BaglantiAyarla();

            }
            if (kontrol > 0)
            {
                gm = new SqlCommand("update Hesaplar set Tutar = Tutar - @Miktar where HesapNo = @gonderenHesap", bgl);
                gm.Parameters.Add("Miktar", SqlDbType.Decimal).Value = tutar;
                gm.Parameters.Add("gonderenHesap", SqlDbType.NVarChar).Value = gonderenHesapNo;
                BaglantiAyarla();
                gm.ExecuteNonQuery();
                BaglantiAyarla();

                gm = new SqlCommand("update Hesaplar set Tutar = Tutar + @Miktar where HesapNo = @aliciHesap", bgl);
                gm.Parameters.Add("Miktar", SqlDbType.Decimal).Value = tutar;
                gm.Parameters.Add("aliciHesap", SqlDbType.NVarChar).Value = aliciHesapNo;
                BaglantiAyarla();
                kontrol = gm.ExecuteNonQuery();
                BaglantiAyarla();


                gm = new SqlCommand("insert into HesapLogs values(@gonderenHesap,@aliciHesap,@miktar,@ıslemTarih)", bgl);
                gm.Parameters.Add("gonderenHesap", SqlDbType.NVarChar).Value = gonderenHesapNo;
                gm.Parameters.Add("aliciHesap", SqlDbType.NVarChar).Value = aliciHesapNo;
                gm.Parameters.Add("Miktar", SqlDbType.Decimal).Value = tutar;
                gm.Parameters.Add("ıslemTarih", SqlDbType.DateTime).Value = DateTime.Now;
                BaglantiAyarla();
                kontrol = gm.ExecuteNonQuery();
                BaglantiAyarla();

            }
            return kontrol;


        }
        public int KontrolEtAktarTrans(string gonderenHesapNo, string aliciHesapNo, decimal tutar)
        {
            int kontrol = 0;
            gm = new SqlCommand("select count(*) from Hesaplar where HesapNo = @gonderenHesap", bgl);
            gm.Parameters.Add("gonderenHesap", SqlDbType.NVarChar).Value = gonderenHesapNo;
            BaglantiAyarla();
            kontrol = (int)gm.ExecuteScalar();
            BaglantiAyarla();

            if (kontrol > 0)
            {
                gm = new SqlCommand("select count(*) from Hesaplar where HesapNo = @aliciHesap", bgl);
                gm.Parameters.Add("alicihesap", SqlDbType.NVarChar).Value = aliciHesapNo;
                BaglantiAyarla();
                kontrol = (int)gm.ExecuteScalar();
                BaglantiAyarla();
                if(kontrol >0)
                {
                    BaglantiAyarla();
                    SqlTransaction trans = bgl.BeginTransaction();
                    try
                    {
                        if (kontrol > 0)
                        {
                            gm = new SqlCommand("update Hesaplar set Tutar = Tutar - @Miktar where HesapNo = @gonderenHesap", bgl,
                                trans);
                            gm.Parameters.Add("Miktar", SqlDbType.Decimal).Value = tutar;
                            gm.Parameters.Add("gonderenHesap", SqlDbType.NVarChar).Value = gonderenHesapNo;
                            gm.ExecuteNonQuery();

                            gm = new SqlCommand("update Hesaplar set Tutar = Tutar + @Miktar where HesapNo = @aliciHesap", bgl
                                , trans);
                            gm.Parameters.Add("Miktar", SqlDbType.Decimal).Value = tutar;
                            gm.Parameters.Add("aliciHesap", SqlDbType.NVarChar).Value = aliciHesapNo;
                            gm.ExecuteNonQuery();

                            gm = new SqlCommand("insert into HesapLogs values(@gonderenHesap,@aliciHesap,@miktar,@ıslemTarih)", bgl
                                , trans);
                            gm.Parameters.Add("gonderenHesap", SqlDbType.NVarChar).Value = gonderenHesapNo;
                            gm.Parameters.Add("aliciHesap", SqlDbType.NVarChar).Value = aliciHesapNo;
                            gm.Parameters.Add("Miktar", SqlDbType.Decimal).Value = tutar;
                            gm.Parameters.Add("ıslemTarih", SqlDbType.DateTime).Value = DateTime.Now;
                            gm.ExecuteNonQuery();
                            trans.Commit();
                            BaglantiAyarla();
                            kontrol = 1;
                        }
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        kontrol = -1;
                    }
                }
              
            }
            return kontrol;
        }

    }
}



