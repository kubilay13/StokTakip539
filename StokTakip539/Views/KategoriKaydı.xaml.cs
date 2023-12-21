﻿using Microsoft.EntityFrameworkCore;
using StokTakip.Models;
using StokTakip539.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StokTakip539.Views
{

    /// <summary>
    /// KategoriKaydı.xaml etkileşim mantığı
    /// </summary>
    public partial class KategoriKaydı : Window
    {
        public KategoriKaydı()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            var kategoriler = Db.Context.Kategoriler.ToList();
            DbKategori.ItemsSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbKategoriAdı.Text)) //Eğer kullanıcı kategori adını boş bırkaırsa
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Kategori kategori = new Kategori()
            {
                KategoriAdi = TbKategoriAdı.Text
            };
            try
            {
                Db.Context.Kategoriler.Add(kategori);
                Db.Context.SaveChanges();
            }
            catch(Exception ex) 
            {
                Db.Context.Kategoriler.Add(kategori);
                MessageBox.Show("Kayıt Yapılırken Hata Oluştu.","Hata",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            Listele();

            
            
        }

        private void DbKategori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TbKategoriAdı_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnGüncelle_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
