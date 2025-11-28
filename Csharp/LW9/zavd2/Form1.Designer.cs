using System.Windows.Forms;

namespace Stitch
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.polotno1 = new Stitch.Polotno();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPencil = new System.Windows.Forms.CheckBox();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.RBNoSym = new System.Windows.Forms.RadioButton();
            this.RBCentr = new System.Windows.Forms.RadioButton();
            this.RBDwi = new System.Windows.Forms.RadioButton();
            this.RBWert = new System.Windows.Forms.RadioButton();
            this.RBGoriz = new System.Windows.Forms.RadioButton();
            this.labelSym = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // polotno1
            // 
            this.polotno1.Location = new System.Drawing.Point(12, 12);
            this.polotno1.Name = "polotno1";
            this.polotno1.Size = new System.Drawing.Size(620, 426);
            this.polotno1.TabIndex = 0;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(652, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(120, 26);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Колір";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(652, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 26);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPencil);
            this.panel1.Controls.Add(this.chkFill);
            this.panel1.Controls.Add(this.RBNoSym);
            this.panel1.Controls.Add(this.RBCentr);
            this.panel1.Controls.Add(this.RBDwi);
            this.panel1.Controls.Add(this.RBWert);
            this.panel1.Controls.Add(this.RBGoriz);
            this.panel1.Location = new System.Drawing.Point(652, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 200);
            this.panel1.TabIndex = 3;
            // 
            // rbPencil
            // 
            this.rbPencil.AutoSize = true;
            this.rbPencil.Location = new System.Drawing.Point(6, 172);
            this.rbPencil.Name = "rbPencil";
            this.rbPencil.Size = new System.Drawing.Size(73, 24);
            this.rbPencil.TabIndex = 6;
            this.rbPencil.Text = "Олівець";
            this.rbPencil.UseVisualStyleBackColor = true;
            this.rbPencil.CheckedChanged += new System.EventHandler(this.rbPencil_CheckedChanged);
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(6, 145);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(81, 24);
            this.chkFill.TabIndex = 5;
            this.chkFill.Text = "Заливка";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.chkFill_CheckedChanged);
            // 
            // RBNoSym
            // 
            this.RBNoSym.AutoSize = true;
            this.RBNoSym.Location = new System.Drawing.Point(3, 116);
            this.RBNoSym.Name = "RBNoSym";
            this.RBNoSym.Size = new System.Drawing.Size(113, 24);
            this.RBNoSym.TabIndex = 4;
            this.RBNoSym.TabStop = true;
            this.RBNoSym.Text = "Без симетрії";
            this.RBNoSym.UseVisualStyleBackColor = true;
            this.RBNoSym.CheckedChanged += new System.EventHandler(this.RBNoSym_CheckedChanged);
            // 
            // RBCentr
            // 
            this.RBCentr.AutoSize = true;
            this.RBCentr.Location = new System.Drawing.Point(3, 87);
            this.RBCentr.Name = "RBCentr";
            this.RBCentr.Size = new System.Drawing.Size(116, 24);
            this.RBCentr.TabIndex = 3;
            this.RBCentr.TabStop = true;
            this.RBCentr.Text = "Центральна";
            this.RBCentr.UseVisualStyleBackColor = true;
            this.RBCentr.CheckedChanged += new System.EventHandler(this.RBCentr_CheckedChanged);
            // 
            // RBDwi
            // 
            this.RBDwi.AutoSize = true;
            this.RBDwi.Location = new System.Drawing.Point(3, 58);
            this.RBDwi.Name = "RBDwi";
            this.RBDwi.Size = new System.Drawing.Size(102, 24);
            this.RBDwi.TabIndex = 2;
            this.RBDwi.TabStop = true;
            this.RBDwi.Text = "Дві осі";
            this.RBDwi.UseVisualStyleBackColor = true;
            this.RBDwi.CheckedChanged += new System.EventHandler(this.RBDwi_CheckedChanged);
            // 
            // RBWert
            // 
            this.RBWert.AutoSize = true;
            this.RBWert.Location = new System.Drawing.Point(3, 29);
            this.RBWert.Name = "RBWert";
            this.RBWert.Size = new System.Drawing.Size(115, 24);
            this.RBWert.TabIndex = 1;
            this.RBWert.TabStop = true;
            this.RBWert.Text = "Вертикальна";
            this.RBWert.UseVisualStyleBackColor = true;
            this.RBWert.CheckedChanged += new System.EventHandler(this.RBWert_CheckedChanged);
            // 
            // RBGoriz
            // 
            this.RBGoriz.AutoSize = true;
            this.RBGoriz.Location = new System.Drawing.Point(3, 0);
            this.RBGoriz.Name = "RBGoriz";
            this.RBGoriz.Size = new System.Drawing.Size(123, 24);
            this.RBGoriz.TabIndex = 0;
            this.RBGoriz.TabStop = true;
            this.RBGoriz.Text = "Горизонтальна";
            this.RBGoriz.UseVisualStyleBackColor = true;
            this.RBGoriz.CheckedChanged += new System.EventHandler(this.RBGoriz_CheckedChanged);
            // 
            // labelSym
            // 
            this.labelSym.Location = new System.Drawing.Point(652, 44);
            this.labelSym.Name = "labelSym";
            this.labelSym.Size = new System.Drawing.Size(120, 21);
            this.labelSym.TabIndex = 4;
            this.labelSym.Text = "Симетрія";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(652, 412);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 26);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Завантажити";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(652, 444);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(120, 26);
            this.btnImage.TabIndex = 7;
            this.btnImage.Text = "Експорт PNG/JPG";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(652, 476);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 26);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Друк";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.polotno1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSym);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnPrint);
            this.Name = "MainForm";
            this.Text = "Редактор візерунків — Stitch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Polotno polotno1;
        private Button buttonColor;
        private Button buttonClear;
        private Panel panel1;
        private RadioButton RBGoriz;
        private RadioButton RBWert;
        private RadioButton RBDwi;
        private RadioButton RBCentr;
        private RadioButton RBNoSym;
        private Label labelSym;
        private ColorDialog colorDialog1;
        private Button btnSave;
        private Button btnLoad;
        private Button btnImage;
        private Button btnPrint;
        private CheckBox chkFill;
        private CheckBox rbPencil;
    }
}
