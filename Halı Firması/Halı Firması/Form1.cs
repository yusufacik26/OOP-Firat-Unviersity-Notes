using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Halı_Firması
{
    public partial class Form1 : Form
    {
        private string path = "C:\\Users\\yusuf\\Desktop\\Yeni klasör\\halilar.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;

            string FabrikaAdi = textBox2.Text;
            int haliAdedi = Convert.ToInt32(textBox3.Text);
            int m2 = Convert.ToInt32(textBox4.Text);

            hali h = new hali(ad, FabrikaAdi, haliAdedi, m2);


            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(h.Ad + " " + h.fabrikaadi + " " + h.HaliAdedi + " " + h.M2);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string FabrikaAdi = textBox2.Text;
            string haliAdedi = Convert.ToString(textBox3.Text);
            string m2 = Convert.ToString(textBox4.Text);

            List<string> satirlar = new List<string>();
            bool silindi = false;

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        // javadaki gibi split işlemi!!!!!
                        string[] parcalar = satir.Split(' ');

                        if (parcalar.Length == 4 &&
                            parcalar[0] == ad &&
                            parcalar[1] == FabrikaAdi &&
                            parcalar[2] == haliAdedi &&
                            parcalar[3] == m2)
                        {

                            silindi = true;
                            continue;
                        }

                        // Eşleşmeyen satırları listeye ekledim burda
                        satirlar.Add(satir);
                    }
                }

                // Eğer bir satır silindiyse dosyayı güncelle!!!
                if (silindi)
                {
                    using (StreamWriter sw = new StreamWriter(path, false)) // Dosyanın içeriğini güncelle
                    {
                        foreach (string s in satirlar)
                        {
                            sw.WriteLine(s);
                        }
                    }
                    MessageBox.Show("Veri başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("Belirtilen veri bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Kişi Adı";
            dataGridView1.Columns[1].Name = "Fabrika Adı";
            dataGridView1.Columns[2].Name = "Halı Sayısı";
            dataGridView1.Columns[3].Name = "M2";

            // Dosyadan verileri oku ve DataGridView'e yükle
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (data.Length == 4)
                        {
                            dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);
                        }
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "Kişi Adı";
            dataGridView1.Columns[1].Name = "Fabrika Adı";
            dataGridView1.Columns[2].Name = "Halı Sayısı";
            dataGridView1.Columns[3].Name = "M2";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string ad = textBox1.Text.Trim();
            string FabrikaAdi = textBox2.Text.Trim();
            string haliAdedi = Convert.ToString(textBox3.Text);
            string m2 = Convert.ToString(textBox4.Text);

            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(FabrikaAdi) && !string.IsNullOrEmpty(haliAdedi) && !string.IsNullOrEmpty(m2))
            {
                // Yeni veriyi DataGridView'e ekle
                dataGridView1.Rows.Add(ad, FabrikaAdi, haliAdedi, m2);

                // TextBox'ları temizle
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "C:\\Users\\yusuf\\Desktop\\Yeni klasör\\file.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow) // Yeni satırları kaydetmez
                        {
                            string ad = row.Cells[0].Value?.ToString() ?? "";
                            string FabrikaAdi = row.Cells[1].Value?.ToString() ?? "";
                            string haliAdedi = row.Cells[2].Value?.ToString() ?? "";
                            string m2 = row.Cells[2].Value?.ToString() ?? "";
                            writer.WriteLine($"{ad} {FabrikaAdi} {haliAdedi} {m2}");
                        }
                    }
                }
                MessageBox.Show("Veriler başarıyla dosyaya yazıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> satirlar = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    // javadaki gibi split işlemi!!!!!
                    string[] parcalar = satir.Split(' ');
                    dataGridView1.Rows.Add(parcalar[0], parcalar[1], parcalar[2], parcalar[3]);


                }
            }
        }
    }

    class hali
    {
        private string ad;
        private string FabrikaAdi;
        private int haliAdedi;
        private int m2;


        public hali(string ad, string FabrikaAdi, int haliAdedi, int m2)
        {

            this.ad = ad;
            this.FabrikaAdi = FabrikaAdi;
            this.haliAdedi = haliAdedi;
            this.m2 = m2;


        }
        public string Ad
        {

            get { return ad; }
        }

        public string fabrikaadi
        {
            get { return FabrikaAdi; }
        }

        public int HaliAdedi
        {
            get { return haliAdedi; }
        }

        public int M2
        {
            get { return m2; }
        }
    }
}
    





    


