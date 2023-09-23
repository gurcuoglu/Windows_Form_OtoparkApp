using Entities;
using System.Collections.Generic;

namespace DAL
{
    public class DataAccessLayer
    {
        List<Arac> Kayitlarim;
        List<Sinif1Arac> Kayitlarim1;
        List<Sinif2Arac> Kayitlarim2;
        public DataAccessLayer()
        {
            Kayitlarim = new List<Arac> ();
            Kayitlarim1 = new List<Sinif1Arac>();
            Kayitlarim2 = new List<Sinif2Arac>();
            VeriTabaniKontrol();
        }

        private void VeriTabaniKontrol()
        {
            bool KlasorKontrol = Directory.Exists(@"c:\OtoparkDB");

            if (!KlasorKontrol)
            {
                Directory.CreateDirectory(@"c:\OtoparkDB");

                if (File.Exists(@"c:\OtoparkDB\arac.json")) { }
                else File.Create(@"c:\OtoparkDB\arac.json");
                
               
            }
        }

        public int YeniKayit(Arac A)
        {
            int Sonuc = 0;
            try
            {
                AracKayitGetir();
                Kayitlarim.Add(A);
                JsonDBGuncelle();
            }
            catch (Exception)
            {

                Sonuc = 0;
            }
            return Sonuc;
        }

        public List<Arac> AracKayitGetir() 
        {
            if (File.Exists(@"c:\OtoparkDB\arac.json"))
            {
               string JsonDBText = File.ReadAllText(@"c:\OtoparkDB\arac.json");
               Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Arac>>(JsonDBText);

            }
            return Kayitlarim;
        } //Tüm kayıtları görme


        public List<Sinif1Arac> Sinif1AracGetir()
        {
            if (File.Exists(@"c:\OtoparkDB\arac.json"))
            {
                string JsonDBText = File.ReadAllText(@"c:\OtoparkDB\arac.json");
                Kayitlarim1 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Sinif1Arac>>(JsonDBText);

            }

            foreach (var X in Kayitlarim1)
            {
                
                if (X.Temiz== null && X.Fiyat == null)
                {
                    Kayitlarim1.Remove(X);
                }
            }
            return Kayitlarim1;
        }
        public List<Sinif2Arac> Sinif2AracGetir()
        {
            if (File.Exists(@"c:\OtoparkDB\arac.json"))
            {
                string JsonDBText = File.ReadAllText(@"c:\OtoparkDB\arac.json");
                Kayitlarim2 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Sinif2Arac>>(JsonDBText);

            }

            foreach (var X in Kayitlarim2)
            {

                if (X.BagajHacmi == null && X.YedekLastik == null)
                {
                    Kayitlarim2.Remove(X);
                }
            }
            return Kayitlarim2;
        }

        public int AracYikama(string Plaka)
        {
            int Sonuc = 0;
            Sinif1AracGetir();
            int Index = Kayitlarim1.FindIndex(p=>p.Plaka == Plaka);
            if (Index>-1)
            {
                Kayitlarim1[Index].Temiz = true; 
            }
            JsonDBGuncelle();
            Sonuc = 1;
            return Sonuc;
        }

        public int LastikDegis(string Plaka)
        {
            int Sonuc = 0;
            Sinif2AracGetir();
            int Index = Kayitlarim2.FindIndex(p => p.Plaka == Plaka);
            if (Index > -1)
            {
                Kayitlarim2[Index].YedekLastik= false;
            }
            JsonDBGuncelle();
            Sonuc = 1;
            return Sonuc;
        }

        private void JsonDBGuncelle()
        {
            if (Kayitlarim != null && Kayitlarim.Count>0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"c:\OtoparkDB\arac.json", JsonDB);
            }
            

        }



        
    }
}