using System;
using System.Linq;

namespace SporSalonuTakip.Moduller
{
    internal class Antrenor : UyeVeAntronorOrtakOzellikleri
    {
        private string _antid;
        public string Id
        {
            get => _antid;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Id boş olamaz.");

                if (value.Length < 7)
                    throw new ArgumentException("Id 7 karakterden az olamaz.");

                // Sadece rakamlardan oluşmamalı
                if (value.All(char.IsDigit))
                    throw new ArgumentException("Id sadece rakamlardan oluşmamalıdır. İlk harfi A veya U olmalıdır.");

                char ilk = char.ToUpper(value[0]); // küçük harf gelse bile büyüt
                if (ilk != 'A' && ilk != 'U')
                    throw new ArgumentException("ID'nin ilk harfi yalnızca 'A' veya 'U' olabilir.");

                string kalan = value.Substring(1);
                if (!kalan.All(char.IsDigit))
                    throw new ArgumentException("ID'nin ilk harfi dışındaki tüm karakterler rakam olmalıdır.");

                _antid = value.ToUpper();
            }
        }

        private string _antad;
        public string Ad
        {
            get => _antad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ad boş olamaz.");

                if (value.Length < 2)
                    throw new ArgumentException("Ad 2 karakterden az olamaz.");

                if (value.Any(char.IsDigit))
                    throw new ArgumentException("Ad rakam içeremez.");

                _antad = value.Trim();
            }
        }

        private string _antsoyad;
        public string Soyad
        {
            get => _antsoyad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Soyad boş olamaz.");

                if (value.Length < 2)
                    throw new ArgumentException("Soyad 2 karakterden az olamaz.");

                if (value.Any(char.IsDigit))
                    throw new ArgumentException("Soyad rakam içeremez.");

                _antsoyad = value.Trim();
            }
        }

        private int _antyas;
        public int Yas
        {
            get => _antyas;
            set
            {
                if (value < 18 || value > 65)
                    throw new ArgumentException("Antrenör yaşı 18 ile 65 arasında olmalıdır.");

                _antyas = value;
            }
        }

        private string _antcinsiyet;
        public string cinsiyet
        {
            get => _antcinsiyet;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value=="Seçiniz")
                    throw new ArgumentException("Cinsiyet boş olamaz.");

                _antcinsiyet = value;
            }
        }

        // Antrenöre özel özellikler
        private string _uzmanlik;
        public string UzmanlikAlani
        {
            get => _uzmanlik;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Uzmanlık alanı boş olamaz.");
                _uzmanlik = value.Trim();
            }
        }

        private int _tecrubeYili;
        public int TecrubeYili
        {
            get => _tecrubeYili;
            set
            {
                if (value < 0 || value > 50)
                    throw new ArgumentException("Tecrübe yılı 0–50 arasında olmalıdır.");
                _tecrubeYili = value;
            }
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad} - {UzmanlikAlani} ({TecrubeYili} yıl)";
        }
    }
}

