using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

public partial class Form1 : Form
{
    private int CrossWins = 0, ZeroWins = 0, Draws = 0;
    private string PlayerName = "Гравець";

    public Form1()
    {
        InitializeComponent();
        this.Text = "Хрестики-нулики";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size(520, 600);

        pole1.OnFinish += Pole_OnFinish;
        pole1.OnDraw += Pole_OnDraw;
        btnStart.Click += BtnStart_Click;

        UpdateScore();
        btnStart.Enabled = false; 
    }

    private void Pole_OnDraw()
    {
        Draws++;
        lblDraws.Text = Draws.ToString();
        btnStart.Text = "Нічия!";
        btnStart.ForeColor = Color.Blue;
        btnStart.Enabled = true;
    }

    private void Pole_OnFinish(char winner)
    {
        if (winner == 'X') CrossWins++;
        else ZeroWins++;

        lblPlayerScore.Text = CrossWins.ToString();
        lblComputerScore.Text = ZeroWins.ToString();

        if (winner == 'X')
        {
            btnStart.Text = "Вітаю!";
            btnStart.ForeColor = Color.Red;
        }
        else
        {
            btnStart.Text = "Комп'ютер переміг";
            btnStart.ForeColor = Color.Navy;
        }

        btnStart.Enabled = true;
        UpdateScore();
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
        pole1.Clear();
        btnStart.Text = "Почати";
        btnStart.ForeColor = Color.Black;
        btnStart.Enabled = false;
    }

    private void UpdateScore()
    {
        lblPlayerName.Text = PlayerName;
        lblPlayerScore.Text = CrossWins.ToString();
        lblComputerScore.Text = ZeroWins.ToString();
        lblDraws.Text = Draws.ToString();

        lblPlayerName.Font = lblPlayerScore.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        lblComputerScore.Font = new Font("Segoe UI", 12, FontStyle.Regular);
        lblPlayerName.ForeColor = lblPlayerScore.ForeColor = Color.Black;
        lblComputerScore.ForeColor = Color.Black;

        if (CrossWins > ZeroWins)
        {
            lblPlayerName.ForeColor = lblPlayerScore.ForeColor = Color.Red;
            lblPlayerName.Font = lblPlayerScore.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }
        else if (ZeroWins > CrossWins)
        {
            lblComputerScore.ForeColor = Color.Red;
            lblComputerScore.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }
    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {
        PlayerName = txtName.Text.Trim();
        if (string.IsNullOrEmpty(PlayerName)) PlayerName = "Гравець";
        lblPlayerName.Text = PlayerName;
    }

    private void radioBeginner_CheckedChanged(object sender, EventArgs e) { if (radioBeginner.Checked) pole1.ComputerLevel = Level.Beginner; }
    private void radioCandidate_CheckedChanged(object sender, EventArgs e) { if (radioCandidate.Checked) pole1.ComputerLevel = Level.Candidate; }
    private void radioExpert_CheckedChanged(object sender, EventArgs e) { if (radioExpert.Checked) pole1.ComputerLevel = Level.Expert; }
}