using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cosmic_Book_Shop
{
    public partial class Form1 : Form
    {
        private readonly string connString = "Data Source=db/database.db;Version=3;";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CheckAndCreateDatabase();
                LoadProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error โหลดฟอร์ม: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckAndCreateDatabase()
        {
            try
            {
                const string dbPath = "db/database.db";
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath) ?? string.Empty);

                if (!File.Exists(dbPath))
                {
                    SQLiteConnection.CreateFile(dbPath);
                    using var conn = new SQLiteConnection(connString);
                    conn.Open();

                    const string createTableSQL = """
                        CREATE TABLE userData (
                            userId INTEGER PRIMARY KEY AUTOINCREMENT,
                            username TEXT NOT NULL,
                            password TEXT NOT NULL,
                            name TEXT,
                            lastname TEXT,
                            email TEXT UNIQUE
                        )
                        """;

                    const string sampleDataSQL = """
                        INSERT INTO productData (ProductName, Category, Price, Quantity,) 
                        VALUES ('', '', '', '', '')
                        """;

                    using var cmd = new SQLiteCommand(createTableSQL, conn);
                    cmd.ExecuteNonQuery();

                    using var cmd2 = new SQLiteCommand(sampleDataSQL, conn);
                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error สร้างฐานข้อมูล: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductData()
        {
            try
            {
                const string loadSQL = "SELECT * FROM ProductData ORDER BY ProductId";
                using var conn = new SQLiteConnection(connString);
                using var adapter = new SQLiteDataAdapter(loadSQL, conn);

                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                //HideSensitiveColumns();
                dataGridView1.RowHeadersVisible = false;
                //AutoSizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error โหลดข้อมูล: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
