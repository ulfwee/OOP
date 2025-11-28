using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Stitch
{
    public partial class Polotno : UserControl
    {
        public Polotno()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ActiveColor = Color.Red;
            CrossWidth = 12;
            Polotno_SizeChanged(this, EventArgs.Empty);
        }

        public Color ActiveColor = Color.Red;

        private Color[,] Grid;

        [Browsable(true)]
        [DefaultValue(0)]
        public int symm { get; set; }

        [Browsable(true)]
        [DefaultValue(false)]
        public bool IsFillMode { get; set; }

        public int CWid, CHig;
        public int CrossWidth = 12;

        private bool isDrawing = false;
        private Point lastCell = Point.Empty; 

        private void Polotno_MouseDown(object sender, MouseEventArgs e)
        {
            int cellX = e.X / CrossWidth;
            int cellY = e.Y / CrossWidth;

            if (cellX < 0 || cellY < 0 || cellX >= CWid || cellY >= CHig) return;

            if (IsFillMode && e.Button == MouseButtons.Left)
            {
                FloodFillCell(cellX, cellY, ActiveColor);
                Invalidate();
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastCell = new Point(cellX, cellY);
                ApplySymmetryToCell(cellX, cellY, false); 
                Invalidate();
            }
        }

        private void Polotno_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            int cellX = e.X / CrossWidth;
            int cellY = e.Y / CrossWidth;

            if (cellX < 0 || cellY < 0 || cellX >= CWid || cellY >= CHig) return;

            if (cellX == lastCell.X && cellY == lastCell.Y) return;

            AddLineBetweenCells(lastCell, new Point(cellX, cellY));
            lastCell = new Point(cellX, cellY);
            Invalidate();
        }

        private void Polotno_MouseUp_1(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void ApplySymmetryToCell(int cellX, int cellY, bool isDrag)
        {
            HandleCell(cellX, cellY, isDrag);

            int mx = CWid - 1 - cellX;
            int my = CHig - 1 - cellY;

            
            if (symm == 1 || symm == 3) 
                HandleCell(mx, cellY, isDrag);

            if (symm == 2 || symm == 3)   
                HandleCell(cellX, my, isDrag);

            if (symm >= 3 || symm == 4)
                HandleCell(mx, my, isDrag);
        }

        private void HandleCell(int cellX, int cellY, bool isDrag)
        {
            if (cellX < 0 || cellY < 0 || cellX >= CWid || cellY >= CHig) return;

            if (isDrag)
            {
                SetGridCell(cellX, cellY, ActiveColor);
            }
            else
            {
                var cur = GetGridCell(cellX, cellY);
                if (cur.ToArgb() == ActiveColor.ToArgb())
                    SetGridCell(cellX, cellY, Color.Empty);
                else
                    SetGridCell(cellX, cellY, ActiveColor);
            }
        }

        private void AddLineBetweenCells(Point p1, Point p2)
        {
            int x0 = p1.X, y0 = p1.Y;
            int x1 = p2.X, y1 = p2.Y;

            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2;

            while (true)
            {
                ApplySymmetryToCell(x0, y0, true);

                if (x0 == x1 && y0 == y1) break;
                int e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
        }

        public void FloodFillCell(int startCellX, int startCellY, Color fillColor)
        {
            if (startCellX < 0 || startCellY < 0 || startCellX >= CWid || startCellY >= CHig) return;

            Color targetColor = GetGridCell(startCellX, startCellY);

            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            var startPoints = new HashSet<(int x, int y)>();
            startPoints.Add((startCellX, startCellY));
            if (symm == 1 || symm == 3) startPoints.Add((CWid - 1 - startCellX, startCellY));
            if (symm == 2 || symm == 3) startPoints.Add((startCellX, CHig - 1 - startCellY));
            if (symm >= 3 || symm == 4) startPoints.Add((CWid - 1 - startCellX, CHig - 1 - startCellY));

            Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
            HashSet<(int x, int y)> visited = new HashSet<(int x, int y)>();

            foreach (var sp in startPoints)
            {
                if (sp.x >= 0 && sp.y >= 0 && sp.x < CWid && sp.y < CHig)
                {
                    queue.Enqueue(sp);
                    visited.Add(sp);
                }
            }

            while (queue.Count > 0)
            {
                var (cx, cy) = queue.Dequeue();

                if (GetGridCell(cx, cy).ToArgb() != targetColor.ToArgb()) continue;

                SetCellWithSymmetry(cx, cy, fillColor);

                foreach (var (nx, ny) in new[] { (cx - 1, cy), (cx + 1, cy), (cx, cy - 1), (cx, cy + 1) })
                {
                    if (nx >= 0 && ny >= 0 && nx < CWid && ny < CHig && visited.Add((nx, ny)))
                    {
                        queue.Enqueue((nx, ny));
                    }
                }
            }

            Invalidate();
        }

        private Color GetGridCell(int cellX, int cellY)
        {
            if (Grid == null) return Color.Empty;
            if (cellX < 0 || cellY < 0 || cellX >= CWid || cellY >= CHig) return Color.Empty;
            return Grid[cellX, cellY];
        }

        private void SetGridCell(int cellX, int cellY, Color color)
        {
            if (Grid == null) return;
            if (cellX < 0 || cellY < 0 || cellX >= CWid || cellY >= CHig) return;
            Grid[cellX, cellY] = color;
        }

        private void SetCellWithSymmetry(int cellX, int cellY, Color color)
        {
            if (cellX < 0 || cellY < 0 || cellX >= CWid || cellY >= CHig) return;

            SetGridCell(cellX, cellY, color);

            int mx = CWid - 1 - cellX;
            int my = CHig - 1 - cellY;

            if (symm == 1 || symm == 3) SetGridCell(mx, cellY, color);
            if (symm == 2 || symm == 3) SetGridCell(cellX, my, color);
            if (symm >= 3 || symm == 4) SetGridCell(mx, my, color);
        }

        public void SaveToFile(string filename)
        {
            using StreamWriter sw = new StreamWriter(filename, false);
            sw.WriteLine(CrossWidth);
            sw.WriteLine(CWid);
            sw.WriteLine(CHig);

            for (int x = 0; x < CWid; x++)
            {
                for (int y = 0; y < CHig; y++)
                {
                    var c = GetGridCell(x, y);
                    if (c.IsEmpty) continue;
                    sw.WriteLine($"{x},{y},{c.A},{c.R},{c.G},{c.B}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename)) return;

            using StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            int cwFromFile = CrossWidth;
            if (line != null && int.TryParse(line.Trim(), out int cw)) cwFromFile = cw;

            int wid = Math.Max(1, Width / cwFromFile);
            int hig = Math.Max(1, Height / cwFromFile);

            // другий та третій рядки можуть містити CWid/CHig
            string line2 = sr.ReadLine();
            string line3 = sr.ReadLine();
            if (line2 != null && int.TryParse(line2.Trim(), out int wFromFile))
                wid = Math.Max(1, wFromFile);
            if (line3 != null && int.TryParse(line3.Trim(), out int hFromFile))
                hig = Math.Max(1, hFromFile);

            CrossWidth = cwFromFile;
            AllocateGrid(wid, hig);

            // тепер читаємо точки
            string entry;
            while ((entry = sr.ReadLine()) != null)
            {
                var parts = entry.Split(',');
                if (parts.Length >= 6)
                {
                    if (int.TryParse(parts[0], out int x) &&
                        int.TryParse(parts[1], out int y) &&
                        int.TryParse(parts[2], out int a) &&
                        int.TryParse(parts[3], out int r) &&
                        int.TryParse(parts[4], out int g) &&
                        int.TryParse(parts[5], out int b))
                    {
                        if (x >= 0 && y >= 0 && x < CWid && y < CHig)
                            SetGridCell(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
            }

            Polotno_SizeChanged(this, EventArgs.Empty);
            Invalidate();
        }

        public void SaveAsImage(string filename)
        {
            using Bitmap bmp = new Bitmap(Width, Height);
            using Graphics g = Graphics.FromImage(bmp);
            RenderToGraphics(g);
            string ext = Path.GetExtension(filename).ToLowerInvariant();
            ImageFormat fmt = ImageFormat.Png;
            if (ext == ".jpg" || ext == ".jpeg") fmt = ImageFormat.Jpeg;
            else if (ext == ".bmp") fmt = ImageFormat.Bmp;
            bmp.Save(filename, fmt);
        }

        public void PrintPattern()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.Print();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            using Bitmap bmp = new Bitmap(Width, Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                RenderToGraphics(g);
            }

            Rectangle bounds = e.MarginBounds;
            float scale = Math.Min((float)bounds.Width / bmp.Width, (float)bounds.Height / bmp.Height);
            int w = (int)(bmp.Width * scale);
            int h = (int)(bmp.Height * scale);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, w, h);
            e.HasMorePages = false;
        }

        private void RenderToGraphics(Graphics g)
        {
            g.Clear(Color.White);

            using (Pen p = new Pen(Color.FromArgb(40, Color.Gray)))
            {
                for (int x = 0; x <= Width; x += CrossWidth) g.DrawLine(p, x, 0, x, Height);
                for (int y = 0; y <= Height; y += CrossWidth) g.DrawLine(p, 0, y, Width, y);
            }

            if (Grid == null) return;

            for (int ix = 0; ix < CWid; ix++)
            {
                for (int iy = 0; iy < CHig; iy++)
                {
                    var c = Grid[ix, iy];
                    if (c.IsEmpty) continue;
                    using (SolidBrush b = new SolidBrush(c))
                    {
                        int px = ix * CrossWidth;
                        int py = iy * CrossWidth;
                        g.FillRectangle(b, px, py, CrossWidth - 1, CrossWidth - 1);
                    }
                }
            }
        }

        private void Polotno_Paint(object sender, PaintEventArgs e)
        {
            RenderToGraphics(e.Graphics);
        }

        public void Clear()
        {
            if (Grid == null) return;
            for (int x = 0; x < CWid; x++)
                for (int y = 0; y < CHig; y++)
                    Grid[x, y] = Color.Empty;
            Invalidate();
        }

        private void Polotno_SizeChanged(object sender, EventArgs e)
        {
            int newCWid = Math.Max(1, Width / CrossWidth);
            int newCHig = Math.Max(1, Height / CrossWidth);
            AllocateGrid(newCWid, newCHig);
            Invalidate();
        }

        private void AllocateGrid(int newCWid, int newCHig)
        {
            Color[,] old = Grid;
            int oldW = CWid, oldH = CHig;

            CWid = newCWid;
            CHig = newCHig;
            Grid = new Color[CWid, CHig];

            for (int x = 0; x < CWid; x++)
                for (int y = 0; y < CHig; y++)
                    Grid[x, y] = Color.Empty;

            if (old != null)
            {
                int minW = Math.Min(oldW, CWid);
                int minH = Math.Min(oldH, CHig);
                for (int x = 0; x < minW; x++)
                    for (int y = 0; y < minH; y++)
                        Grid[x, y] = old[x, y];
            }
        }
    }
}
