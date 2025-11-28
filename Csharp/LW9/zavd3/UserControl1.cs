using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

public delegate void FinishEventHandler(char winner);

public enum Level { Beginner, Candidate, Expert }

public partial class Pole : UserControl
{
    private GameButton[,] P = new GameButton[3, 3];
    public event FinishEventHandler OnFinish;
    public event Action OnDraw;

    private bool active = true;
    private int Moves = 0;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Level ComputerLevel { get; set; } = Level.Expert;

    public Pole()
    {
        this.DoubleBuffered = true;
        this.Resize += Pole_Resize;

        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
            {
                P[r, c] = new GameButton();
                P[r, c].Click += GameButton_Click;
                this.Controls.Add(P[r, c]);
            }

        ArrangeButtons();
    }

    private void Pole_Resize(object sender, EventArgs e) => ArrangeButtons();

    private void ArrangeButtons()
    {
        int w = this.ClientSize.Width / 3;
        int h = this.ClientSize.Height / 3;
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
            {
                P[r, c].Left = c * w;
                P[r, c].Top = r * h;
                P[r, c].Width = w;
                P[r, c].Height = h;
            }
    }

    public void Clear()
    {
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                P[r, c].SetClear();
        active = true;
        Moves = 0;
    }

    private void GameButton_Click(object sender, EventArgs e)
    {
        var btn = (GameButton)sender;
        if (!btn.IsClear || !active) return;

        btn.SetCross();
        Moves++;
        CheckWin();
        if (!active) return;

        if (Moves >= 9)
        {
            active = false;
            OnDraw?.Invoke();
            return;
        }

        ComputerMove();
    }

    private void ComputerMove()
    {
        if (ComputerLevel == Level.Beginner)
        {
            RandomMove();
            return;
        }

        // Спроба виграти (O)
        var win = FindBestMove('O');
        if (win != null)
        {
            P[win.Value.r, win.Value.c].SetZero();
            Moves++;
            CheckWin();
            return;
        }

        // Експерт: блокуємо виграш гравця
        if (ComputerLevel == Level.Expert)
        {
            var block = FindBestMove('X');
            if (block != null)
            {
                P[block.Value.r, block.Value.c].SetZero();
                Moves++;
                CheckWin();
                return;
            }
        }

        // Інакше випадково
        RandomMove();
    }

    private void RandomMove()
    {
        Random rnd = new Random();
        int r, c;
        do
        {
            r = rnd.Next(3);
            c = rnd.Next(3);
        } while (!P[r, c].IsClear);

        P[r, c].SetZero();
        Moves++;
        CheckWin();
    }

    private (int r, int c)? FindBestMove(char symbol)
    {
        bool isCross = symbol == 'X';
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                if (P[r, c].IsClear)
                {
                    if (isCross) P[r, c].TempSetCross();
                    else P[r, c].TempSetZero();

                    if (CheckWinSymbol(symbol))
                    {
                        if (isCross) P[r, c].TempClearCross();
                        else P[r, c].TempClearZero();
                        return (r, c);
                    }

                    if (isCross) P[r, c].TempClearCross();
                    else P[r, c].TempClearZero();
                }
        return null;
    }

    private void CheckWin()
    {
        var lines = new int[][]
        {
            new int[] {0,0,0,1,0,2}, new int[] {1,0,1,1,1,2}, new int[] {2,0,2,1,2,2},
            new int[] {0,0,1,0,2,0}, new int[] {0,1,1,1,2,1}, new int[] {0,2,1,2,2,2},
            new int[] {0,0,1,1,2,2}, new int[] {0,2,1,1,2,0}
        };

        foreach (var l in lines)
        {
            int r0 = l[0], c0 = l[1], r1 = l[2], c1 = l[3], r2 = l[4], c2 = l[5];

            if (P[r0, c0].IsCross && P[r1, c1].IsCross && P[r2, c2].IsCross)
            {
                HighlightLine(r0, c0, r1, c1, r2, c2);
                active = false;
                OnFinish?.Invoke('X');
                return;
            }
            if (P[r0, c0].IsZero && P[r1, c1].IsZero && P[r2, c2].IsZero)
            {
                HighlightLine(r0, c0, r1, c1, r2, c2);
                active = false;
                OnFinish?.Invoke('O');
                return;
            }
        }
    }

    private bool CheckWinSymbol(char symbol)
    {
        bool cross = symbol == 'X';
        Func<int, int, bool> cell = (r, c) => cross ? P[r, c].IsCross : P[r, c].IsZero;

        for (int i = 0; i < 3; i++)
            if ((cell(i, 0) && cell(i, 1) && cell(i, 2)) ||
                (cell(0, i) && cell(1, i) && cell(2, i))) return true;
        return (cell(0, 0) && cell(1, 1) && cell(2, 2)) ||
               (cell(0, 2) && cell(1, 1) && cell(2, 0));
    }

    private void HighlightLine(int r0, int c0, int r1, int c1, int r2, int c2)
    {
        P[r0, c0].HighlightWin();
        P[r1, c1].HighlightWin();
        P[r2, c2].HighlightWin();
    }
}