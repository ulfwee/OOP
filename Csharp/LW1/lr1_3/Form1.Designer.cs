namespace lr1_3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBoxGenre = new ComboBox();
            pickdate1 = new DateTimePicker();
            txtAbout = new TextBox();
            txtName = new TextBox();
            panel2 = new Panel();
            button3 = new Button();
            label11 = new Label();
            label10 = new Label();
            button2 = new Button();
            comboBoxChoosegenre = new ComboBox();
            pickdate2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(361, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 56);
            label1.TabIndex = 0;
            label1.Text = "Т Е А Т Р";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(279, 46);
            label2.Name = "label2";
            label2.Size = new Size(369, 20);
            label2.TabIndex = 1;
            label2.Text = "д р а м а т и ч н и х  о б р а з і в";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(39, 85);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 2;
            label3.Text = "Створити";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(415, 84);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 3;
            label4.Text = "Зберегти";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(768, 85);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 4;
            label5.Text = "Показати";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxGenre);
            panel1.Controls.Add(pickdate1);
            panel1.Controls.Add(txtAbout);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(2, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 411);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(383, 353);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 3;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(37, 306);
            label9.Name = "label9";
            label9.Size = new Size(53, 17);
            label9.TabIndex = 12;
            label9.Text = "Дата ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(3, 126);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 11;
            label8.Text = "Опис події";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(46, 80);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 10;
            label7.Text = "Жанр";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(46, 33);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 9;
            label6.Text = "Назва";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.Anchor = AnchorStyles.Left;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Трагікомедія", "Комедія", "Казка", "Хоррор", "Арттерапевтична", "Драма" });
            comboBoxGenre.Location = new Point(115, 74);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(417, 28);
            comboBoxGenre.TabIndex = 6;
            // 
            // pickdate1
            // 
            pickdate1.Anchor = AnchorStyles.Left;
            pickdate1.Location = new Point(115, 306);
            pickdate1.Name = "pickdate1";
            pickdate1.Size = new Size(417, 27);
            pickdate1.TabIndex = 8;
            // 
            // txtAbout
            // 
            txtAbout.Anchor = AnchorStyles.Left;
            txtAbout.Location = new Point(115, 120);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(417, 154);
            txtAbout.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.Location = new Point(115, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(417, 27);
            txtName.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(comboBoxChoosegenre);
            panel2.Controls.Add(pickdate2);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(2, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 411);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.OldLace;
            button3.FlatAppearance.BorderColor = Color.Maroon;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Maroon;
            button3.Location = new Point(92, 245);
            button3.Name = "button3";
            button3.Size = new Size(170, 29);
            button3.TabIndex = 6;
            button3.Text = "Весь список";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(12, 120);
            label11.Name = "label11";
            label11.Size = new Size(116, 17);
            label11.TabIndex = 5;
            label11.Text = "Вибрати жанр";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(12, 52);
            label10.Name = "label10";
            label10.Size = new Size(116, 17);
            label10.TabIndex = 4;
            label10.Text = "Вибрати дату";
            // 
            // button2
            // 
            button2.BackColor = Color.OldLace;
            button2.FlatAppearance.BorderColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(92, 203);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 3;
            button2.Text = "Сортувати";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBoxChoosegenre
            // 
            comboBoxChoosegenre.FormattingEnabled = true;
            comboBoxChoosegenre.Items.AddRange(new object[] { "Трагікомедія", "Комедія", "Казка", "Хоррор", "Арттерапевтична", "Драма" });
            comboBoxChoosegenre.Location = new Point(12, 146);
            comboBoxChoosegenre.Name = "comboBoxChoosegenre";
            comboBoxChoosegenre.Size = new Size(250, 28);
            comboBoxChoosegenre.TabIndex = 2;
            // 
            // pickdate2
            // 
            pickdate2.Location = new Point(12, 80);
            pickdate2.Name = "pickdate2";
            pickdate2.Size = new Size(250, 27);
            pickdate2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 335);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(930, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Театр";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private ComboBox comboBoxGenre;
        private DateTimePicker pickdate1;
        private TextBox txtAbout;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private ComboBox comboBoxChoosegenre;
        private DateTimePicker pickdate2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label11;
        private Label label10;
        private Button button2;
        private Button button3;
    }
}
