using System;
using System.IO;
using System.Windows.Forms;

namespace _21martteori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklenirken sütunlar tanımlanır
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3; // 3 sütun tanımlanıyor
            dataGridView1.Columns[0].Name = "Numara";
            dataGridView1.Columns[1].Name = "Adı";
            dataGridView1.Columns[2].Name = "Soyadı";

            // Var olan dosyadan verileri yükle
            LoadDataFromFile();
        }

        // Yeni veri ekleme ve dosyaya yazma
        private void button1_Click(object sender, EventArgs e)
        {
            string numara = textBox1.Text;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;

            // DataGridView sütunlarının tanımlı olduğundan emin olun
            if (dataGridView1.ColumnCount == 0)
            {
                MessageBox.Show("DataGridView sütunları tanımlanmamış. Önce sütunları tanımlayın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Satır ekleme
            dataGridView1.Rows.Add(numara, ad, soyad);

            // Veriyi dosyaya kaydet
            using (StreamWriter yaz = new StreamWriter("C:\\Users\\yusuf\\Desktop\\Yeni klasör\\file.txt", true))
            {
                yaz.WriteLine($"{numara} {ad} {soyad}");
            }

            // TextBox temizleme
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        // Dosyadan verileri DataGridView'e yükleme
        private void LoadDataFromFile()
        {
            string filePath = "C:\\Users\\yusuf\\Desktop\\Yeni klasör\\file.txt";

            if (!File.Exists(filePath))
                return;

            using (StreamReader oku = new StreamReader(filePath))
            {
                string line;
                while ((line = oku.ReadLine()) != null)
                {
                    string[] bilgi = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (bilgi.Length == 3)
                    {
                        dataGridView1.Rows.Add(bilgi[0], bilgi[1], bilgi[2]);
                    }
                }
            }
        }
    }
}
