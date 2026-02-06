namespace Cosmic_Book_Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            ShowalldataButton = new Button();
            SearchButton = new Button();
            ClearButton = new Button();
            DeleteProductButton = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            SellproductQuantity = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ExportproductButton = new Button();
            SellproductButton = new Button();
            ImportproductButton = new Button();
            AddproductButton = new Button();
            CategoryComboBox = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            PriceTextbox = new TextBox();
            BookNameTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            ReceiptButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 37);
            label1.TabIndex = 0;
            label1.Text = "Cosmic Book Shop";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ReceiptButton);
            groupBox1.Controls.Add(ShowalldataButton);
            groupBox1.Controls.Add(SearchButton);
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(DeleteProductButton);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(SellproductQuantity);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(ExportproductButton);
            groupBox1.Controls.Add(SellproductButton);
            groupBox1.Controls.Add(ImportproductButton);
            groupBox1.Controls.Add(AddproductButton);
            groupBox1.Controls.Add(CategoryComboBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(PriceTextbox);
            groupBox1.Controls.Add(BookNameTextbox);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(141, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ShowalldataButton
            // 
            ShowalldataButton.Location = new Point(18, 227);
            ShowalldataButton.Name = "ShowalldataButton";
            ShowalldataButton.Size = new Size(170, 26);
            ShowalldataButton.TabIndex = 26;
            ShowalldataButton.Text = "แสดงสินค้าทั้งหมด";
            ShowalldataButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(18, 195);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(170, 26);
            SearchButton.TabIndex = 25;
            SearchButton.Text = "ค้นหา";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += button7_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(452, 162);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(87, 26);
            ClearButton.TabIndex = 24;
            ClearButton.Text = "ล้าง";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(276, 163);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(87, 26);
            DeleteProductButton.TabIndex = 23;
            DeleteProductButton.Text = "ลบสินค้า";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(418, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(121, 25);
            textBox7.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(418, 100);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(121, 25);
            textBox6.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(418, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 25);
            textBox5.TabIndex = 20;
            // 
            // SellproductQuantity
            // 
            SellproductQuantity.Location = new Point(418, 35);
            SellproductQuantity.Name = "SellproductQuantity";
            SellproductQuantity.Size = new Size(121, 25);
            SellproductQuantity.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(369, 136);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 18;
            label9.Text = "จำนวน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 104);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 17;
            label8.Text = "จำนวน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 70);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 16;
            label7.Text = "จำนวน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 38);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 15;
            label6.Text = "จำนวน";
            label6.Click += label6_Click;
            // 
            // ExportproductButton
            // 
            ExportproductButton.Location = new Point(276, 99);
            ExportproductButton.Name = "ExportproductButton";
            ExportproductButton.Size = new Size(87, 26);
            ExportproductButton.TabIndex = 12;
            ExportproductButton.Text = "ส่งออก";
            ExportproductButton.UseVisualStyleBackColor = true;
            ExportproductButton.Click += button3_Click;
            // 
            // SellproductButton
            // 
            SellproductButton.Location = new Point(276, 34);
            SellproductButton.Name = "SellproductButton";
            SellproductButton.Size = new Size(87, 26);
            SellproductButton.TabIndex = 13;
            SellproductButton.Text = "ขาย";
            SellproductButton.UseVisualStyleBackColor = true;
            SellproductButton.Click += button1_Click;
            // 
            // ImportproductButton
            // 
            ImportproductButton.Location = new Point(276, 67);
            ImportproductButton.Name = "ImportproductButton";
            ImportproductButton.Size = new Size(87, 26);
            ImportproductButton.TabIndex = 11;
            ImportproductButton.Text = "นำเข้า";
            ImportproductButton.UseVisualStyleBackColor = true;
            ImportproductButton.Click += button2_Click;
            // 
            // AddproductButton
            // 
            AddproductButton.Location = new Point(276, 131);
            AddproductButton.Name = "AddproductButton";
            AddproductButton.Size = new Size(87, 26);
            AddproductButton.TabIndex = 14;
            AddproductButton.Text = "เพิ่มสินค้า";
            AddproductButton.UseVisualStyleBackColor = true;
            AddproductButton.Click += button4_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(91, 69);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(121, 25);
            CategoryComboBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 104);
            label5.Name = "label5";
            label5.Size = new Size(33, 17);
            label5.TabIndex = 7;
            label5.Text = "ราคา";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 72);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 6;
            label4.Text = "ประเภท";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 39);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 5;
            label3.Text = "ชื่อหนังสือ";
            // 
            // PriceTextbox
            // 
            PriceTextbox.Location = new Point(91, 101);
            PriceTextbox.Name = "PriceTextbox";
            PriceTextbox.Size = new Size(121, 25);
            PriceTextbox.TabIndex = 2;
            // 
            // BookNameTextbox
            // 
            BookNameTextbox.Location = new Point(91, 36);
            BookNameTextbox.Name = "BookNameTextbox";
            BookNameTextbox.Size = new Size(121, 25);
            BookNameTextbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(739, 257);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ReceiptButton
            // 
            ReceiptButton.Location = new Point(380, 215);
            ReceiptButton.Name = "ReceiptButton";
            ReceiptButton.Size = new Size(159, 26);
            ReceiptButton.TabIndex = 27;
            ReceiptButton.Text = "ออกใบเสร็จ";
            ReceiptButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cosmic Book Shop";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox PriceTextbox;
        private TextBox BookNameTextbox;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox CategoryComboBox;
        private Button SearchButton;
        private Button ShowalldataButton;
        private Button ClearButton;
        private Button DeleteProductButton;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox SellproductQuantity;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button ExportproductButton;
        private Button SellproductButton;
        private Button ImportproductButton;
        private Button AddproductButton;
        private Button ReceiptButton;
    }
}
