using SporSalonuTakip.Moduller;
using SporSalonuTakip.Usercontrols;

namespace SporSalonuTakip;
public partial class Form1 : Form
{
    private PanelDegistir _panelDegistir; //panel yöneticisi alaný
    public Form1()
    {
        InitializeComponent();

        // Nesneyi formun paneline baðlýyoruz
        _panelDegistir = new PanelDegistir(pnl_Anapanael);

        // Varsayýlan sayfayý açýyoruz
        _panelDegistir.Goster("Anasayfa");
    }

    private void btn_Anasayfa_Click(object sender, EventArgs e)
    {
        //// Renkleri sýfýrla
        //btn_Anasayfa.BackColor = Color.FromArgb(140, 145, 204);
        //btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

        //panelb1.BackColor = Color.FromArgb(0, 140, 178);
        //panelB2.BackColor = Color.FromArgb(74, 76, 107);
        //panelb3.BackColor = Color.FromArgb(74, 76, 107);
        //panelb4.BackColor = Color.FromArgb(74, 76, 107);
        //panelb5.BackColor = Color.FromArgb(74, 76, 107);

        _panelDegistir.Goster("Anasayfa");

        RenkDegistir renk = new RenkDegistir();
        renk.BtnRenk1(this);
    }

    private void btn_UyeEkle_Click(object sender, EventArgs e)
    {
        //btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
        //btn_UyeEkle.BackColor = Color.FromArgb(140, 145, 204);
        //btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

        //panelb1.BackColor = Color.FromArgb(74, 76, 107);
        //panelB2.BackColor = Color.FromArgb(230, 215, 159);
        //panelb3.BackColor = Color.FromArgb(74, 76, 107);
        //panelb4.BackColor = Color.FromArgb(74, 76, 107);
        //panelb5.BackColor = Color.FromArgb(74, 76, 107);

        _panelDegistir.Goster("UyeEkle");

        RenkDegistir renk = new RenkDegistir();
        renk.BtnRenk2(this);
    }

    private void btn_AntrenorEkle_Click(object sender, EventArgs e)
    {
        //btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
        //btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_AntrenorEkle.BackColor = Color.FromArgb(140, 145, 204);
        //btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

        //panelb1.BackColor = Color.FromArgb(74, 76, 107);
        //panelB2.BackColor = Color.FromArgb(74, 76, 107);
        //panelb3.BackColor = Color.FromArgb(239, 155, 110);
        //panelb4.BackColor = Color.FromArgb(74, 76, 107);
        //panelb5.BackColor = Color.FromArgb(74, 76, 107);

        _panelDegistir.Goster("AntrenorEkle");

        RenkDegistir renk = new RenkDegistir();
        renk.BtnRenk3(this);
    }

    private void btn_ProgramEkle_Click(object sender, EventArgs e)
    {
        //btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
        //btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_ProgramEkle.BackColor = Color.FromArgb(140, 145, 204);
        //btn_Sorgulama.BackColor = Color.FromArgb(74, 76, 107);

        //panelb1.BackColor = Color.FromArgb(74, 76, 107);
        //panelB2.BackColor = Color.FromArgb(74, 76, 107);
        //panelb3.BackColor = Color.FromArgb(74, 76, 107);
        //panelb4.BackColor = Color.FromArgb(75, 198, 183);
        //panelb5.BackColor = Color.FromArgb(74, 76, 107);

        _panelDegistir.Goster("ProgramEkle");

        RenkDegistir renk = new RenkDegistir();
        renk.BtnRenk4(this);
    }

    private void btn_Sorgulama_Click(object sender, EventArgs e)
    {
        //btn_Anasayfa.BackColor = Color.FromArgb(74, 76, 107);
        //btn_UyeEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_AntrenorEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_ProgramEkle.BackColor = Color.FromArgb(74, 76, 107);
        //btn_Sorgulama.BackColor = Color.FromArgb(140, 145, 204);

        //panelb1.BackColor = Color.FromArgb(74, 76, 107);
        //panelB2.BackColor = Color.FromArgb(74, 76, 107);
        //panelb3.BackColor = Color.FromArgb(74, 76, 107);
        //panelb4.BackColor = Color.FromArgb(74, 76, 107);
        //panelb5.BackColor = Color.FromArgb(247, 27, 88);

        _panelDegistir.Goster("Sorgulama");

        RenkDegistir renk = new RenkDegistir();
        renk.BtnRenk5(this);
    }

}
