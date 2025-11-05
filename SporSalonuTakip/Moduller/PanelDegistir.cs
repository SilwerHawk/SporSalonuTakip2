using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SporSalonuTakip.Usercontrols; 

namespace SporSalonuTakip.Moduller
{
    public class PanelDegistir
    {
        private readonly Panel _hedefPanel;
        private readonly Dictionary<string, UserControl> _views = new();

        public PanelDegistir(Panel hedefPanel)
        {
            _hedefPanel = hedefPanel;
        }

        public void Goster(string key)
        {
            _hedefPanel.SuspendLayout();
            _hedefPanel.Controls.Clear();

            var control = GetOrCreateControl(key);
            control.Dock = DockStyle.Fill;
            _hedefPanel.Controls.Add(control);

            _hedefPanel.ResumeLayout();
        }

        private UserControl GetOrCreateControl(string key)
        {
            if (_views.TryGetValue(key, out var mevcut))
                return mevcut;

            UserControl yeni = key switch
            {
                "Anasayfa" => new Giris(),
                "UyeEkle" => new Uyeekle(),
                "AntrenorEkle" => new Antrenorekle(),
                "ProgramEkle" => new Programekle(),
                "Sorgulama" => new Sorgulama(),
                _ => new Giris(),
            };

            _views[key] = yeni;
            return yeni;
        }
    }
}
