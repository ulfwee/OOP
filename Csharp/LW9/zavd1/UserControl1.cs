using System.Reflection;

namespace Katok;

public partial class Katok : UserControl
{
    public Point[] P;
    List<Point[]> history = new List<Point[]>();
    int[] dx;
    int[] dy;
    Random R = new Random();
    int n;

    public Katok(int N)
    {
        InitializeComponent();
        DoubleBuffered = true;

        n = N;
        P = new Point[n];
        dx = new int[n];
        dy = new int[n];

        for (int i = 0; i < n; i++)
        {
            P[i].X = R.Next(Width);
            P[i].Y = R.Next(Height);

            do dx[i] = R.Next(-3, 4); while (dx[i] == 0);
            do dy[i] = R.Next(-3, 4); while (dy[i] == 0);
        }

        timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < n; i++)
        {
            P[i].X += dx[i];
            P[i].Y += dy[i];

            if (P[i].X < 3 || P[i].X > Width - 3) dx[i] = -dx[i];
            if (P[i].Y < 3 || P[i].Y > Height - 3) dy[i] = -dy[i];

            P[i].X = Math.Clamp(P[i].X, 3, Width - 3);
            P[i].Y = Math.Clamp(P[i].Y, 3, Height - 3);
        }

        history.Add((Point[])P.Clone());
        if (history.Count > 7)
            history.RemoveAt(0);

        Invalidate();
    }

    private void Katok_Paint(object sender, PaintEventArgs e)
    {
        Pen randomPen = new Pen(GetSoftColor(), 2);

        foreach (var polygonState in history)
            e.Graphics.DrawPolygon(randomPen, polygonState);
    }

    private Color GetSoftColor()
    {
        return Color.FromArgb(
            150 + R.Next(100),
            150 + R.Next(100),
            150 + R.Next(100)
        );
    }

    private void Katok_Load(object sender, EventArgs e)
    {

    }
}
