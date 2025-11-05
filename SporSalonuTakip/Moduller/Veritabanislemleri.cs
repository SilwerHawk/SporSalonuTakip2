using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace SporSalonuTakip.Moduller
{
    internal class Veritabanislemleri
    {
        private readonly string _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SporSalonu.db");
        private readonly string _connStr;

        public Veritabanislemleri()
        {
            _connStr = $"Data Source={_dbPath};Version=3;";
        }

        // Veritabanı var mı kontrol et, yoksa oluştur
        public void VeritabaniKontrolEt()
        {
            if (!File.Exists(_dbPath))
                SQLiteConnection.CreateFile(_dbPath);

            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            // Üye tablosu
            string tabloUye = @"
            CREATE TABLE IF NOT EXISTS Uye (
                Id TEXT PRIMARY KEY,
                Ad TEXT,
                Soyad TEXT,
                Yas INTEGER,
                Cinsiyet TEXT,
                Boy REAL,
                Kilo REAL,
                Antrenor TEXT
            );";

            // Antrenör tablosu
            string tabloAntrenor = @"
            CREATE TABLE IF NOT EXISTS Antrenor (
                Id TEXT PRIMARY KEY,
                Ad TEXT,
                Soyad TEXT,
                Yas INTEGER,
                Cinsiyet TEXT,
                UzmanlikAlani TEXT,
                TecrubeYili INTEGER
            );";

            // Program tablosu — 7 günlük egzersiz planı
            string tabloProgram = @"
            CREATE TABLE IF NOT EXISTS Program (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                UyeId TEXT,
                AdSoyad TEXT,
                Gun1 TEXT,
                Gun2 TEXT,
                Gun3 TEXT,
                Gun4 TEXT,
                Gun5 TEXT,
                Gun6 TEXT,
                Gun7 TEXT,
                FOREIGN KEY (UyeId) REFERENCES Uye(Id)
            );";

            using (var cmd1 = new SQLiteCommand(tabloUye, conn)) cmd1.ExecuteNonQuery();
            using (var cmd2 = new SQLiteCommand(tabloAntrenor, conn)) cmd2.ExecuteNonQuery();
            using (var cmd3 = new SQLiteCommand(tabloProgram, conn)) cmd3.ExecuteNonQuery();
        }

        // Üye ekle
        public void UyeEkle(string id, string ad, string soyad, int yas, string cinsiyet, double boy, double kilo, string antrenor)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = @"
            INSERT INTO Uye (Id, Ad, Soyad, Yas, Cinsiyet, Boy, Kilo, Antrenor)
            VALUES (@Id, @Ad, @Soyad, @Yas, @Cinsiyet, @Boy, @Kilo, @Antrenor);";

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            cmd.Parameters.AddWithValue("@Yas", yas);
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@Boy", boy);
            cmd.Parameters.AddWithValue("@Kilo", kilo);
            cmd.Parameters.AddWithValue("@Antrenor", antrenor);
            cmd.ExecuteNonQuery();
        }

        // Üye listele
        public DataTable UyeListele()
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT * FROM Uye";
            using var cmd = new SQLiteCommand(sql, conn);
            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }

        // Üye Ad + Soyad listesi
        public DataTable UyeAdSoyadListesiGetir()
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT Id, Ad || ' ' || Soyad AS AdSoyad FROM Uye ORDER BY Ad, Soyad;";
            using var cmd = new SQLiteCommand(sql, conn);
            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }

        // Üye bilgilerini ID’ye göre getir  🔥 (Eksik olan kısım eklendi)
        public DataRow? UyeBilgiGetirById(string uyeId)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT * FROM Uye WHERE Id = @Id LIMIT 1;";
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", uyeId);

            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);

            return tablo.Rows.Count > 0 ? tablo.Rows[0] : null;
        }

        // Antrenör ekle
        public void AntrenorEkle(string id, string ad, string soyad, int yas, string cinsiyet, string uzmanlik, int tecrubeYili)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = @"
            INSERT INTO Antrenor (Id, Ad, Soyad, Yas, Cinsiyet, UzmanlikAlani, TecrubeYili)
            VALUES (@Id, @Ad, @Soyad, @Yas, @Cinsiyet, @UzmanlikAlani, @TecrubeYili);";

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Ad", ad);
            cmd.Parameters.AddWithValue("@Soyad", soyad);
            cmd.Parameters.AddWithValue("@Yas", yas);
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@UzmanlikAlani", uzmanlik);
            cmd.Parameters.AddWithValue("@TecrubeYili", tecrubeYili);
            cmd.ExecuteNonQuery();
        }

        // Antrenör listele
        public DataTable AntrenorListele()
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT * FROM Antrenor";
            using var cmd = new SQLiteCommand(sql, conn);
            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }

        // Antrenör Ad-Soyad listesi
        public DataTable AntrenorAdSoyadListesiGetir()
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT DISTINCT Id, Ad || ' ' || Soyad AS AdSoyad FROM Antrenor ORDER BY Ad, Soyad;";
            using var cmd = new SQLiteCommand(sql, conn);
            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }

        // Program ekle veya güncelle (7 sütun)
        public void ProgramEkle(string uyeId, string adSoyad,
            string gun1, string gun2, string gun3, string gun4,
            string gun5, string gun6, string gun7)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = @"
                DELETE FROM Program WHERE UyeId = @UyeId;
                INSERT INTO Program (UyeId, AdSoyad, Gun1, Gun2, Gun3, Gun4, Gun5, Gun6, Gun7)
                VALUES (@UyeId, @AdSoyad, @Gun1, @Gun2, @Gun3, @Gun4, @Gun5, @Gun6, @Gun7);";

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UyeId", uyeId);
            cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
            cmd.Parameters.AddWithValue("@Gun1", gun1);
            cmd.Parameters.AddWithValue("@Gun2", gun2);
            cmd.Parameters.AddWithValue("@Gun3", gun3);
            cmd.Parameters.AddWithValue("@Gun4", gun4);
            cmd.Parameters.AddWithValue("@Gun5", gun5);
            cmd.Parameters.AddWithValue("@Gun6", gun6);
            cmd.Parameters.AddWithValue("@Gun7", gun7);
            cmd.ExecuteNonQuery();
        }

        // Program listele (tüm kayıtlar)
        public DataTable ProgramListele()
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT UyeId, AdSoyad, Gun1, Gun2, Gun3, Gun4, Gun5, Gun6, Gun7 FROM Program ORDER BY Id;";
            using var cmd = new SQLiteCommand(sql, conn);
            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }

        // Antrenör bilgilerini getir (Ad Soyad’a göre)
        public DataRow? AntrenorBilgiGetir(string adSoyad)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT * FROM Antrenor WHERE Ad || ' ' || Soyad = @AdSoyad LIMIT 1;";
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);

            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new();
            adapter.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // Antrenörün üyelerini getir
        public DataTable AntrenorUyeListesi(string antrenorAdSoyad)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = @"SELECT Id AS UyeNo, Ad, Soyad, Yas, Cinsiyet, Boy, Kilo
                           FROM Uye
                           WHERE Antrenor = @Ant
                           ORDER BY Ad;";
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ant", antrenorAdSoyad);

            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }

        // Üye bilgilerini (Ad Soyad’a göre) getir
        public DataRow? UyeBilgiGetir(string adSoyad)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT * FROM Uye WHERE Ad || ' ' || Soyad = @AdSoyad LIMIT 1;";
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);

            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable dt = new();
            adapter.Fill(dt);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // Üye programını getir
        public DataTable UyeProgramGetir(string uyeId)
        {
            VeritabaniKontrolEt();
            using var conn = new SQLiteConnection(_connStr);
            conn.Open();

            string sql = "SELECT Gun1, Gun2, Gun3, Gun4, Gun5, Gun6, Gun7 FROM Program WHERE UyeId = @UyeId;";
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UyeId", uyeId);

            using var adapter = new SQLiteDataAdapter(cmd);
            DataTable tablo = new();
            adapter.Fill(tablo);
            return tablo;
        }
    }
}
