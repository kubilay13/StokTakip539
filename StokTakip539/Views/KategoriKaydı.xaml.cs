using StokTakip.Models;
using StokTakip539.Models;
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
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {   
            AppDbContext _db = new AppDbContext();
            var a = TbKategoriAdı.Text;
            Kategori kategori = new Kategori()
            {
                KategoriAdi = a,
            };
            _db.Kategoriler.Add(kategori);
            _db.SaveChanges();
        }

        private void DbKategori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TbKategoriAdı_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
