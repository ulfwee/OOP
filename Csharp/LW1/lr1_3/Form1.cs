using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lr1_3
{

    public partial class Form1 : Form
    {
        List<Theater> shows = new List<Theater>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            label3.Visible = false;
            comboBoxGenre.SelectedIndex = 0;
            comboBoxChoosegenre.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            label5.Visible = false;
            label3.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addnew addnew = new Addnew();

            var r = addnew.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selected = pickdate2.Value.Date;
            string chosengenre = comboBoxChoosegenre.SelectedItem.ToString();

            var filtered = shows
    .Where(s => s.Genre == chosengenre && s.Date.Date == selected)
    .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtName.Text != null && txtAbout != null)
            {
                Theater theater = new Theater();
                theater.Name = txtName.Text;
                theater.Genre = comboBoxGenre.Text;
                theater.Description = txtAbout.Text;
                theater.Date = pickdate1.Value.Date;

                shows.Add(theater);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = shows;

                txtName.Text = null;
                txtAbout.Text = null;
                comboBoxGenre.SelectedIndex = 0;
                pickdate1.Text = null;

            }
            else MessageBox.Show("¬вед≥ть дан≥");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = shows;
        }
        

        private void label4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var showslist = shows;


                string json = JsonSerializer.Serialize(showslist, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dialog.FileName, json);
                MessageBox.Show("«бережено");
            }
        }
    }
    public class Theater
        {
            public string Name { get; set; }
            public string Genre { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }

        }
}
