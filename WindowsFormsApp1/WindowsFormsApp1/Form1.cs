using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string filePath = "C:\\Users\\yusuf\\Desktop\\Yeni klasör\\file.txt"; // Dosya yolu

        public Form1()
        {
            InitializeComponent();
           
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "Numara";
            dataGridView1.Columns[1].Name = "Adı";
            dataGridView1.Columns[2].Name = "Soyadı";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Numara";
            dataGridView1.Columns[1].Name = "Adı";
            dataGridView1.Columns[2].Name = "Soyadı";

            // Dosyadan verileri oku ve DataGridView'e yükle
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (data.Length == 3)
                        {
                            dataGridView1.Rows.Add(data[0], data[1], data[2]);
                        }
                    }
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string numara = textBox1.Text.Trim();
            string ad = textBox2.Text.Trim();
            string soyad = textBox3.Text.Trim();

            if (!string.IsNullOrEmpty(numara) && !string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad))
            {
                // Yeni veriyi DataGridView'e ekle
                dataGridView1.Rows.Add(numara, ad, soyad);

                // TextBox'ları temizle
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
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
                            string numara = row.Cells[0].Value?.ToString() ?? "";
                            string ad = row.Cells[1].Value?.ToString() ?? "";
                            string soyad = row.Cells[2].Value?.ToString() ?? "";
                            writer.WriteLine($"{numara} {ad} {soyad}");
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


        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Numara";
            dataGridView1.Columns[1].Name = "Adı";
            dataGridView1.Columns[2].Name = "Soyadı";

            // FormClosing olayını ekliyoruz
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
    }
}

