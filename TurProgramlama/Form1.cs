using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurProgramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float kisi;                               //Degişken tanımlama
        float kar;
        float tur;
        float koltuk;
        float bos;
        float otobus;

        private void Form1_Load(object sender, EventArgs e)             //Programın Constructer fonksiyonu görevini alır.
        {
            kisi = 0;
            kar = 0;
            tur = 0;
            bos = 0;
            koltuk = 46;
            otobus = 0;
            pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\think.jpg");        // Gorsel resim kutucuğuna yerleştiriliyor.
        }

        private void btnHesapla_Click(object sender, EventArgs e)           // Hesaplama butonuna tıklandığında çalışacak fonksiyondur.
        {

            kisi = Convert.ToInt16(txtKisi.Text);                           // Kişi sayısı kullanıcıdan alınıyor.


            if (cmbTur.Text == "Lütfen Seçiniz..")
            {
                MessageBox.Show("Lütfen hangi turu seçtiğinizi belirtiniz.", "Uyarı",  MessageBoxButtons.OK);
                cmbTur.Focus();
            }
            else {
                if (kisi <= 0 )
                {
                    MessageBox.Show("Kişi sayısı negatif veya 0 a eşit olamaz.", "Uyarı", MessageBoxButtons.OK);
                    txtKisi.Focus();
                }
                else {

                    if (kisi <= 46)
                    {
                        tur = cmbTur.SelectedIndex;                                     // Tur türü kullanıcıdan alınıyor (1_ Şehiriçi 2_Şehirdışı)
                        kisi = Convert.ToInt16(txtKisi.Text);                           // Kişi sayısı kullanıcıdan alınıyor.

                        bos =  koltuk% kisi;                                 //Boş koltuk hesaplanıyor.
                        otobus = 1;                                        //Gereken otobüs miktarı
                        kar = kisi / (otobus * koltuk);                                 //Kar oranı hesaplaması

                        lblSonucKisiSayisi.Text = kisi.ToString();                      //Etiketlere sonuçlar yazılıyor.
                        lblSonucOtobus.Text = otobus.ToString();
                        lblSonucBosKoltuk.Text = bos.ToString();

                        if (tur == 0)                       // Şehir içi
                        {

                            if (kar <= 0.6)
                            {                   // Zarar
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Zarar";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\red.jpg");  // Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.6 && kar <= 0.9)    //karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\yellow.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.9)               //çok karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + "Çok Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\green.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }

                        }

                        if (tur == 1)                       // Şehir dışı
                        {

                            if (kar <= 0.7)                     // Zarar
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Zarar";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\red.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.7 && kar <= 0.9)  //karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\yellow.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.9)                //çok karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + "Çok Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\green.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                        }



                    }
                    else {
                        tur = cmbTur.SelectedIndex;                                     // Tur türü kullanıcıdan alınıyor (1_ Şehiriçi 2_Şehirdışı)
                        kisi = Convert.ToInt16(txtKisi.Text);                           // Kişi sayısı kullanıcıdan alınıyor.

                        bos = koltuk - (koltuk % kisi);                                 //Boş koltuk hesaplanıyor.
                        otobus = kisi / koltuk;                                         //Gereken otobüs miktarı
                        kar = kisi / (otobus * koltuk);                                 //Kar oranı hesaplaması

                        lblSonucKisiSayisi.Text = kisi.ToString();                      //Etiketlere sonuçlar yazılıyor.
                        lblSonucOtobus.Text = otobus.ToString();
                        lblSonucBosKoltuk.Text = bos.ToString();

                        if (tur == 0)                       // Şehir içi
                        {

                            if (kar <= 0.6)
                            {                   // Zarar
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Zarar";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\red.jpg");  // Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.6 && kar <= 0.9)    //karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\yellow.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.9)               //çok karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + "Çok Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\green.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }

                        }

                        if (tur == 1)                       // Şehir dışı
                        {

                            if (kar <= 0.7)                     // Zarar
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Zarar";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\red.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.7 && kar <= 0.9)  //karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + " Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\yellow.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                            else if (kar >= 0.9)                //çok karlı
                            {
                                lblSonucKar.Text = "%" + kar.ToString() + "-" + "Çok Kârlı";
                                pctKar.Image = Image.FromFile(Environment.CurrentDirectory + "\\gorsel\\green.jpg");// Gorsel resim kutucuğuna yerleştiriliyor.
                            }
                        }
                    }


                }
            }

         

            
               

       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form ekran = new Form2();
            ekran.Show();
        }

        
    }

        
}

