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
            dataGridView1 = new DataGridView();
            label6 = new Label();
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
            label3.Location = new Point(28, 85);
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
            label4.Location = new Point(279, 85);
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
            label5.Location = new Point(542, 85);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 4;
            label5.Text = "Сортувати";
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(875, 367);
            dataGridView1.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(761, 85);
            label6.Name = "label6";
            label6.Size = new Size(142, 23);
            label6.TabIndex = 6;
            label6.Text = "Весь список";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(930, 529);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
        private Label label6;
    }
}
