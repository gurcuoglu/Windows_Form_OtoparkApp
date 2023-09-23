using Entities;


namespace OtoparkFromApp
{
    public partial class Form1 : Form
    {
        BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            List<Arac> AracKayitlari = BLL.AracKayitGetir();
            bool Sinif1 = false;
            bool Sinif2 = false;
            bool Sinif3 = false;
            if (checkedListBox1.CheckedItems.Count != 0)
            {

                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    if (checkedListBox1.CheckedItems[x].ToString() == "1.Sınıf Araçlar")
                    {
                        Sinif1 = true;
                    }
                    if (checkedListBox1.CheckedItems[x].ToString() == "2.Sınıf Araçlar")
                    {
                        Sinif2 = true;
                    }
                    if (checkedListBox1.CheckedItems[x].ToString() == "3.Sınıf Araçlar")
                    {
                        Sinif3 = true;
                    }
                }
            }// seçili kutuları bulduk

            if (AracKayitlari != null && AracKayitlari.Count > 0)
            {
                if (Sinif1 == false)
                {
                    foreach (var X in AracKayitlari)
                    {
                        if (X.Temiz != null && X.Fiyat != null)
                        {
                            AracKayitlari.Remove(X);
                        }

                    }
                }
                if (Sinif2 == false)
                {
                    foreach (var X in AracKayitlari)
                    {
                        if (X.BagajHacmi != null)
                        {
                            AracKayitlari.Remove(X);
                        }

                    }
                }
                if (Sinif3 == false)
                {
                    foreach (var X in AracKayitlari)
                    {
                        if (X.Temiz == null && X.BagajHacmi == null)
                        {
                            AracKayitlari.Remove(X);
                        }

                    }
                }
            }
            if (AracKayitlari != null && AracKayitlari.Count > 0)
            {
                lst_liste.DataSource = AracKayitlari;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Arac A = (Arac)lst_liste.SelectedItem;
            if (A.Temiz == null)
            {
                MessageBox.Show("1. Sınıf bir araç seçiniz.");
            }
            else
            {
                BLL.AracYikama(A.Plaka);
                MessageBox.Show("Aracınız Temizlendi");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arac A = (Arac)lst_liste.SelectedItem;
            if (A.BagajHacmi == null)
            {
                MessageBox.Show("2. Sınıf bir araç seçiniz.");
            }
            else
            {
                BLL.LastikDegis(A.Plaka);
                if (BLL.LastikDegis(A.Plaka) == 0)
                {
                    MessageBox.Show("Yedek Lastiğiniz Bulunmuyor");
                }
                else
                {
                    MessageBox.Show("Aracınızın lastiği değiştirildi yedek lastiğiniz kalmadı");
                }

            }

        }

        private void lst_liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Arac A = (Arac)lst_liste.SelectedItem;
            MessageBox.Show("Ücretiniz " + BLL.UcretHesapla(A.Plaka) + "₺'dir.");
        }
    }
}