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
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
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
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(90, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            groupBox1.Enter += groupBox1_Enter;
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
            // textBox2
            // 
            textBox2.Location = new Point(91, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 25);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 25);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 25);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 41);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 5;
            label3.Text = "ชื่อหนังสือ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 70);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 6;
            label4.Text = "ประเภท";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 99);
            label5.Name = "label5";
            label5.Size = new Size(33, 17);
            label5.TabIndex = 7;
            label5.Text = "ราคา";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 128);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 9;
            label2.Text = "จำนวนสินค้า";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(292, 69);
            button2.Name = "button2";
            button2.Size = new Size(87, 26);
            button2.TabIndex = 11;
            button2.Text = "นำเข้า";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(292, 101);
            button3.Name = "button3";
            button3.Size = new Size(87, 26);
            button3.TabIndex = 12;
            button3.Text = "ส่งออก";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(291, 38);
            button1.Name = "button1";
            button1.Size = new Size(87, 26);
            button1.TabIndex = 13;
            button1.Text = "ขาย";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(292, 131);
            button4.Name = "button4";
            button4.Size = new Size(87, 26);
            button4.TabIndex = 14;
            button4.Text = "เพิ่มสินค้า";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 41);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 15;
            label6.Text = "จำนวน";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 76);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 16;
            label7.Text = "จำนวน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 104);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 17;
            label8.Text = "จำนวน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 135);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 18;
            label9.Text = "จำนวน";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 25);
            textBox1.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(434, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(121, 25);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(434, 101);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(121, 25);
            textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(434, 132);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(121, 25);
            textBox7.TabIndex = 22;
            // 
            // button5
            // 
            button5.Location = new Point(291, 163);
            button5.Name = "button5";
            button5.Size = new Size(87, 26);
            button5.TabIndex = 23;
            button5.Text = "ลบสินค้า";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(468, 163);
            button6.Name = "button6";
            button6.Size = new Size(87, 26);
            button6.TabIndex = 24;
            button6.Text = "ล้าง";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(14, 195);
            button7.Name = "button7";
            button7.Size = new Size(170, 26);
            button7.TabIndex = 25;
            button7.Text = "ค้นหา";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(14, 227);
            button8.Name = "button8";
            button8.Size = new Size(170, 26);
            button8.TabIndex = 26;
            button8.Text = "แสดงสินค้าทั้งหมด";
            button8.UseVisualStyleBackColor = true;
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
    }
}
