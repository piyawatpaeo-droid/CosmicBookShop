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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CheckAndCreateDatabase();
                LoadBookData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error âËÅ´¿ÍÃìÁ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
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
                        CREATE TABLE BookData (
                            BookId INTEGER PRIMARY KEY AUTOINCREMENT,
                            Bookname TEXT NOT NULL,
                            Category TEXT NOT NULL,
                            Price TEXT,
                            Quantity TEXT
                        )
                        """;

                    const string sampleDataSQL = """
                        INSERT INTO BookData (BookId, Bookname, Category, Price, Quantity) 
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
                MessageBox.Show($"Error ÊÃéÒ§°Ò¹¢éÍÁÙÅ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(usernameTxtb.Text) || string.IsNullOrWhiteSpace(passwordTxtb.Text))
                {
                    MessageBox.Show("¡ÃØ³Ò¡ÃÍ¡ bookname áÅÐ bookId", "¢éÍÁÙÅäÁè¤Ãº",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                const string addSQL = """
                    INSERT INTO BookData (BookId, Bookname, Category, Price, Quantity) 
                    VALUES (@BookId, @Bookname, @Category, @Price, @Quantity)
                    """;

                using var conn = new SQLiteConnection(connString);
                conn.Open();
                using var cmd = new SQLiteCommand(addSQL, conn);

                cmd.Parameters.AddWithValue("@BookId", .Text.Trim());
                cmd.Parameters.AddWithValue("@Bookname", .Text.Trim());
                cmd.Parameters.AddWithValue("@Category", .Text.Trim());
                cmd.Parameters.AddWithValue("@Price", .Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", .Text.Trim());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("à¾ÔèÁ¢éÍÁÙÅ¼ÙéãªéàÃÕÂºÃéÍÂ", "ÊÓàÃç¨",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    LoadBookData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error à¾ÔèÁ¢éÍÁÙÅ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            try
            {
                .Clear();
                .Clear();
                .Clear();
                .Clear();
                .Clear();
                .Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ÅéÒ§¢éÍÁÙÅ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookData()
        {
            try
            {
                const string loadSQL = "SELECT * FROM BookData ORDER BY userId";
                using var conn = new SQLiteConnection(connString);
                using var adapter = new SQLiteDataAdapter(loadSQL, conn);

                var table = new DataTable();
                adapter.Fill(table);
                userdataGridv.DataSource = table;

                HideSensitiveColumns();
                userdataGridv.RowHeadersVisible = false;
                AutoSizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error âËÅ´¢éÍÁÙÅ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideSensitiveColumns()
        {
            if (userdataGridv.Columns["password"] != null)
                userdataGridv.Columns["password"].Visible = false;
            if (userdataGridv.Columns["userId"] != null)
                userdataGridv.Columns["userId"].Visible = false;
        }

        private void AutoSizeColumns()
        {
            foreach (DataGridViewColumn col in userdataGridv.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userdataGridv.CurrentRow == null || string.IsNullOrWhiteSpace(usernameTxtb.Text))
                {
                    MessageBox.Show("¡ÃØ³ÒàÅ×Í¡á¶Çã¹µÒÃÒ§áÅÐ¡ÃÍ¡¢éÍÁÙÅ·ÕèµéÍ§¡ÒÃá¡éä¢", "àÅ×Í¡¢éÍÁÙÅ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = Convert.ToInt32(userdataGridv.CurrentRow.Cells["userId"].Value);
                const string updateSQL = """
                    UPDATE userData SET username=@username, password=@password, 
                    name=@name, lastname=@lastname, email=@email 
                    WHERE userId=@userId
                    """;

                using var conn = new SQLiteConnection(connString);
                conn.Open();
                using var cmd = new SQLiteCommand(updateSQL, conn);

                cmd.Parameters.AddWithValue("@username", usernameTxtb.Text.Trim());
                cmd.Parameters.AddWithValue("@password", passwordTxtb.Text.Trim());
                cmd.Parameters.AddWithValue("@name", nameTxtb.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname", lastnameTxtb.Text.Trim());
                cmd.Parameters.AddWithValue("@email", emailTxtb.Text.Trim());
                cmd.Parameters.AddWithValue("@userId", userId);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ÍÑ»à´µ¢éÍÁÙÅ¼ÙéãªéàÃÕÂºÃéÍÂ", "ÊÓàÃç¨",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("äÁè¾º¢éÍÁÙÅ·Õè¨ÐÍÑ»à´µ", "äÁè¾º¢éÍÁÙÅ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ÍÑ»à´µ¢éÍÁÙÅ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userdataGridv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = userdataGridv.Rows[e.RowIndex];
                .Text = row.Cells[""].Value?.ToString() ?? "";
                .Text = row.Cells[""].Value?.ToString() ?? "";
                .Text = row.Cells[""].Value?.ToString() ?? "";
                .Text = row.Cells[""].Value?.ToString() ?? "";
                .Text = row.Cells[""].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ¤ÅÔ¡µÒÃÒ§: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userdataGridv.CurrentRow == null)
                {
                    MessageBox.Show("¡ÃØ³ÒàÅ×Í¡á¶Ç·ÕèµéÍ§¡ÒÃÅº", "àÅ×Í¡¢éÍÁÙÅ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("¤Ø³á¹èã¨ËÃ×ÍäÁè·Õè¨ÐÅº¢éÍÁÙÅ¼Ùéãªé¹Õé?",
                    "Â×¹ÂÑ¹¡ÒÃÅº", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                int BookId = Convert.ToInt32(userdataGridv.CurrentRow.Cells["BookId"].Value);
                const string deleteSQL = "DELETE FROM BookData WHERE userId = @BookId";

                using var conn = new SQLiteConnection(connString);
                conn.Open();
                using var cmd = new SQLiteCommand(deleteSQL, conn);
                cmd.Parameters.AddWithValue("@BookId", BookId);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Åº¢éÍÁÙÅ¼ÙéãªéàÃÕÂºÃéÍÂ", "ÊÓàÃç¨",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    LoadBookData();
                }
                else
                {
                    MessageBox.Show("äÁè¾º¢éÍÁÙÅ·Õè¨ÐÅº", "äÁè¾º¢éÍÁÙÅ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Åº¢éÍÁÙÅ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = .Text.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    LoadBookData();
                    return;
                }

                const string searchSQL = """
                    SELECT * FROM BookData 
                    WHERE Bookname LIKE @search OR name LIKE @search OR category LIKE @search 
                    ORDER BY BookId
                    """;

                using var conn = new SQLiteConnection(connString);
                using var adapter = new SQLiteDataAdapter(searchSQL, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                var table = new DataTable();
                adapter.Fill(table);
                userdataGridv.DataSource = table;

                HideSensitiveColumns();
                userdataGridv.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ¤é¹ËÒ: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showalluserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClearTextBoxes();
                LoadBookData();
                MessageBox.Show("áÊ´§¢éÍÁÙÅ¼Ùéãªé·Ñé§ËÁ´àÃÕÂºÃéÍÂ", "ÊÓàÃç¨",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error áÊ´§¢éÍÁÙÅ·Ñé§ËÁ´: {ex.Message}", "¢éÍ¼Ô´¾ÅÒ´",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
