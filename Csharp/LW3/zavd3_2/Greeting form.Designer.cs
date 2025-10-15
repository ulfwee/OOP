namespace lr1_3
{
    partial class Greeting_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 44);
            label1.TabIndex = 0;
            label1.Text = "Оберіть театр";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Courier New", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(36, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(215, 31);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Оперний театр";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Courier New", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(36, 131);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(243, 31);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ляльковий театр";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.OldLace;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(18, 176);
            button2.Name = "button2";
            button2.Size = new Size(369, 29);
            button2.TabIndex = 15;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Greeting_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(407, 216);
            Controls.Add(button2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Greeting_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Greeting_form";
            Load += Greeting_form_Load;
            Shown += Greeting_form_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button2;
    }
}