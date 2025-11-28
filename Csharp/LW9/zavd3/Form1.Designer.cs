partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Pole pole1;
    private Button btnStart;
    private Label lblPlayerName;
    private Label lblPlayerScore;
    private Label lblComputerScore;
    private Label lblDraws;
    private TextBox txtName;
    private RadioButton radioBeginner;
    private RadioButton radioCandidate;
    private RadioButton radioExpert;
    private GroupBox groupBox1;

    private void InitializeComponent()
    {
        this.pole1 = new Pole();
        this.btnStart = new Button();
        this.lblPlayerName = new Label();
        this.lblPlayerScore = new Label();
        this.lblComputerScore = new Label();
        this.lblDraws = new Label();
        this.txtName = new TextBox();
        this.radioBeginner = new RadioButton();
        this.radioCandidate = new RadioButton();
        this.radioExpert = new RadioButton();
        this.groupBox1 = new GroupBox();

        this.groupBox1.SuspendLayout();
        this.SuspendLayout();

        // pole1
        this.pole1.Location = new Point(30, 30);
        this.pole1.Size = new Size(340, 340);

        // btnStart
        this.btnStart.Location = new Point(400, 120);
        this.btnStart.Size = new Size(90, 50);
        this.btnStart.Text = "Почати";
        this.btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        this.btnStart.UseVisualStyleBackColor = true;

        // Елементи статистики
        this.lblPlayerName.AutoSize = true;
        this.lblPlayerName.Location = new Point(50, 400);
        this.lblPlayerName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        this.lblPlayerName.Text = "Гравець";

        this.lblPlayerScore.AutoSize = true;
        this.lblPlayerScore.Location = new Point(180, 400);
        this.lblPlayerScore.Font = new Font("Segoe UI", 14F);
        this.lblPlayerScore.Text = "0";

        this.lblComputerScore.AutoSize = true;
        this.lblComputerScore.Location = new Point(300, 400);
        this.lblComputerScore.Font = new Font("Segoe UI", 14F);
        this.lblComputerScore.Text = "0";

        this.lblDraws.AutoSize = true;
        this.lblDraws.Location = new Point(420, 400);
        this.lblDraws.Font = new Font("Segoe UI", 12F);
        this.lblDraws.Text = "0";

        this.txtName.Location = new Point(50, 440);
        this.txtName.Size = new Size(200, 25);
        this.txtName.Text = "Гравець";
        this.txtName.TextChanged += txtName_TextChanged;

        // Група рівнів
        this.groupBox1.Location = new Point(30, 480);
        this.groupBox1.Size = new Size(460, 70);
        this.groupBox1.Text = "Рівень комп'ютера";
        this.groupBox1.Controls.Add(this.radioBeginner);
        this.groupBox1.Controls.Add(this.radioCandidate);
        this.groupBox1.Controls.Add(this.radioExpert);

        this.radioBeginner.Location = new Point(20, 30);
        this.radioBeginner.Text = "Початківець";
        this.radioCandidate.Location = new Point(160, 30);
        this.radioCandidate.Text = "Кандидат";
        this.radioCandidate.Checked = true;
        this.radioExpert.Location = new Point(300, 30);
        this.radioExpert.Text = "Експерт";

        this.radioBeginner.CheckedChanged += radioBeginner_CheckedChanged;
        this.radioCandidate.CheckedChanged += radioCandidate_CheckedChanged;
        this.radioExpert.CheckedChanged += radioExpert_CheckedChanged;

        // Додати все на форму
        this.Controls.Add(this.pole1);
        this.Controls.Add(this.btnStart);
        this.Controls.Add(this.lblPlayerName);
        this.Controls.Add(this.lblPlayerScore);
        this.Controls.Add(this.lblComputerScore);
        this.Controls.Add(this.lblDraws);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.groupBox1);

        // Підписи
        var lblVs = new Label() { Text = ":", Location = new Point(240, 400), AutoSize = true, Font = new Font("Segoe UI", 14F) };
        var lblComp = new Label() { Text = "Комп'ютер", Location = new Point(270, 400), AutoSize = true, Font = new Font("Segoe UI", 12F) };
        var lblDrawCaption = new Label() { Text = "Нічії:", Location = new Point(370, 400), AutoSize = true, Font = new Font("Segoe UI", 12F) };
        this.Controls.AddRange(new Control[] { lblVs, lblComp, lblDrawCaption });

        this.groupBox1.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}