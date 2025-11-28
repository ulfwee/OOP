using System.Drawing;
using System.Windows.Forms;

public class GameButton : Button
{
    public bool IsClear { get; private set; } = true;
    public bool IsCross { get; private set; } = false;
    public bool IsZero { get; private set; } = false;
    public bool IsWinning { get; private set; } = false;

    public GameButton()
    {
        Text = "";
        Font = new Font("Arial", 36, FontStyle.Bold);
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 3;
        FlatAppearance.BorderColor = Color.Black;
        ForeColor = Color.Black;
        BackColor = Color.WhiteSmoke;
    }

    public void SetCross()
    {
        Text = "X";
        ForeColor = Color.Green;
        IsCross = true;
        IsZero = false;
        IsClear = false;
    }

    public void SetZero()
    {
        Text = "O";
        ForeColor = Color.Red;
        IsCross = false;
        IsZero = true;
        IsClear = false;
    }

    public void SetClear()
    {
        Text = "";
        ForeColor = Color.Black;
        BackColor = Color.WhiteSmoke;
        IsWinning = false;
        IsClear = true;
        IsCross = false;
        IsZero = false;
    }

    public void HighlightWin()
    {
        IsWinning = true;
        BackColor = Color.Gold;
    }

    // Додаємо методи для тимчасової перевірки (потрібні для AI)
    public void TempSetCross() => IsCross = true;
    public void TempSetZero() => IsZero = true;
    public void TempClearCross() => IsCross = false;
    public void TempClearZero() => IsZero = false;
}