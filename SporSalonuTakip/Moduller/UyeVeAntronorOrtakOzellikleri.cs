using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporSalonuTakip.Moduller
{
    internal interface UyeVeAntronorOrtakOzellikleri
    {
        string Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        int Yas { get; set; }
        string cinsiyet { get; set; }

    }
}
