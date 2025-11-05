using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuTakip.Moduller
{
    internal class Uye : UyeVeAntronorOrtakOzellikleri
    {
        private string _id;
        public string Id
        {
            get { return _id; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Id boş olamaz.");
                }
                if (value.Length < 7)
                {
                    throw new ArgumentException("Id 7 karakterden az olamaz.");
                }
                if (value.All(char.IsDigit))
                {
                    throw new ArgumentException("Id sadece rakamlardan oluşmamamalıdır. İlk harfi a veya u olmalıdır.");
                }
                char ilk = char.ToUpper(value[0]); // küçük gelse de büyüğe çevir
                if (ilk != 'A' && ilk != 'U')
                {
                    throw new ArgumentException("ID'nin ilk harfi yalnızca 'A' veya 'U' olabilir.");
                }
                string kalan = value.Substring(1);
                if (!kalan.All(char.IsDigit))
                {
                    throw new ArgumentException("ID'nin ilk harfi dışındaki tüm karakterler rakam olmalıdır.");
                }
                else
                {
                    _id = value;
                }

            }


        }
        private string _ad;
        public string Ad
        {
            get { return _ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Ad boş olamaz.");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Ad 2 karakterden az olamaz.");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Ad rakam içeremez.");
                }
                else
                {
                    _ad = value;
                }
            }
        }
        private string _soyad;
        public string Soyad
        {
            get { return _soyad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Soyad boş olamaz.");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Soyad 2 karakterden az olamaz.");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Soyad rakam içeremez.");
                }
                else
                {
                    _soyad = value;
                }
            }
        }
        private int _yas;
        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value < 13 || value > 50)
                {
                    throw new ArgumentException("Yaş 13 ile 50 arasında olmalıdır.");
                }
                if (value.ToString().Any(char.IsLetter))
                {
                    throw new ArgumentException("Yaş sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    _yas = value;
                }
            }
        }
        private string _cinsiyet;
        public string cinsiyet
        {
            get { return _cinsiyet; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value=="Seçiniz")
                {
                    throw new ArgumentException("Lütfen cinsiyet seçiniz.");
                }
                else
                {
                    _cinsiyet = value;
                }
            }
        }
        private double _Kilo;
        public double Kilo
        {
            get { return _Kilo; }
            set
            {
                if (value < 30 || value > 200)
                {
                    throw new ArgumentException("Kilo 30 ile 200 arasında olmalıdır.");
                }
                if (value.ToString().Any(char.IsLetter))
                {
                    throw new ArgumentException("Kilo sadece rakamlardan oluşmalıdır.");
                }
                if (string.IsNullOrWhiteSpace(value.ToString()))
                {
                    throw new ArgumentException("Kilo boş olamaz.");
                }
                if (value.ToString().Any(char.IsLetter))
                {
                    throw new ArgumentException("Kilo sadece rakamlardan oluşmalıdır.");
                }
                else
                {
                    _Kilo = value;
                }
            }
        }
        public double Boy { get; set; }

        private string _antrenorAdi;
        public string AntrenorAdi
        {
            get { return _antrenorAdi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value=="Seçiniz")
                {
                    throw new ArgumentException("Antrenör adı seçiniz.");
                }
                else
                {
                    _antrenorAdi = value;
                }
            }
        }

    }   
}
