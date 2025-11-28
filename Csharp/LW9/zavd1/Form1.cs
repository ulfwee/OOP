namespace Katok;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        TableLayoutPanel layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 2
        };

        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

        Controls.Add(layout);

        Random rand = new Random();

        for (int i = 0; i < 4; i++)
        {
            Katok k = new Katok(rand.Next(5, 15));
            k.Parent = this;
            k.Dock = DockStyle.Fill;
            k.BackColor = GetSoftColor(rand);
            layout.Controls.Add(k);
        }

        this.BackColor = GetSoftColor(rand);
    }

    private Color GetSoftColor(Random rand)
    {
        int r = rand.Next(100, 200);
        int g = rand.Next(100, 200);
        int b = rand.Next(100, 200);
        return Color.FromArgb(r, g, b);
    }
}