using System.Threading.Tasks.Sources;
using AngouriMath.Extensions;
using Entities;
namespace BLL
{
    public class BusinessLogicLayer
    {
        DAL.DataAccessLayer DAL;
        public BusinessLogicLayer()
        {
            DAL = new DAL.DataAccessLayer();
        }
        public int YeniKayit(string Plaka, string Renk,  int ModelYili,  string ModelAdi)
        {
            int Sonuc = 0;
            if (!string.IsNullOrEmpty(Plaka) && !string.IsNullOrEmpty(Renk) && !string.IsNullOrEmpty(ModelAdi) && ModelYili != null)
            {
                Arac Kayit = new Arac();
                Kayit.Plaka = Plaka;
                Kayit.Renk = Renk;
                Kayit.ModelYili = ModelYili;
                Kayit.ModelAdi = ModelAdi;

                Sonuc = DAL.YeniKayit(Kayit);
            }
            else
            {
                Sonuc = -100;// Eksik parametre hatası
            }
            return Sonuc;
        }


        public int AracYikama(string Plaka)
        {
            int Sonuc = 0;
            if (!string.IsNullOrEmpty(Plaka))
            {
                Sonuc = DAL.AracYikama(Plaka);
            }
            return Sonuc = 1;
        }

        public int LastikDegis(string Plaka)
        {
            int Sonuc = 0;
            if (!string.IsNullOrEmpty(Plaka))
            {
                var p = Sinif2AracGetir().FirstOrDefault(p => p.Plaka == Plaka);
                if (p.YedekLastik==false)
                {
                    return Sonuc;
                }
                Sonuc = DAL.LastikDegis(Plaka);
                Sonuc = 1;
            }
            return Sonuc;
        }

        public string UcretHesapla(string Plaka)
        {
            string Ucret = "100";
            string Sinif2AracUcretiKatSayisi = "2";
            string Sinif3AracUcretiKatSayisi = "3";
            if (!string.IsNullOrEmpty(Plaka))
            {
                var X = AracKayitGetir().FirstOrDefault(p => p.Plaka == Plaka);
                if (X.Temiz==null && X.BagajHacmi==null)//3. sınıf araç
                {
                    return Ucret;
                }
                else if (X.Temiz == null && X.BagajHacmi != null)// 2. sınıf araç
                {
                    Ucret= (Ucret.EvalNumerical()* Sinif2AracUcretiKatSayisi.EvalNumerical()).ToString();
                    return Ucret;
                }
                else if (X.Temiz != null && X.BagajHacmi == null)//1.sınıf araç
                {
                    Ucret = (Ucret.EvalNumerical() * Sinif3AracUcretiKatSayisi.EvalNumerical()).ToString();
                    return Ucret;
                }
            }

            return Ucret;
        }
        public List<Arac> AracKayitGetir()
        {
            return DAL.AracKayitGetir();
        }

        public List<Sinif1Arac> Sinif1AracGetir()
        {
            return DAL.Sinif1AracGetir();
        }

        public List<Sinif2Arac> Sinif2AracGetir()
        {
            return DAL.Sinif2AracGetir();
        }



    }
}