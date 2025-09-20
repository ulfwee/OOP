using System.ComponentModel;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lr1_3
{

    public partial class Form1 : Form
    {
        List<Theater> shows = new List<Theater>();


        public Form1()
        {
            InitializeComponent();
            comboBoxGenre.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();

            label10.Visible = true;
            label5.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAbout.Text))
            {
                Theater theater = new Theater()
                {
                    Name = txtName.Text,
                    Genre = comboBoxGenre.Text,
                    Description = txtAbout.Text,
                    Date = pickdate1.Value.Date
                };

                shows.Add(theater);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = shows;
                txtName.Clear();
                txtAbout.Clear();
                comboBoxGenre.SelectedIndex = 0;
                pickdate1.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Введіть дані");
            }

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
                MessageBox.Show("Збережено");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            label10.Visible = false;
            label5.Visible = true;
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                comboBox2.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = shows;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (dateTimePicker1.Enabled == false)
            {
                string chosengenre = comboBox2.SelectedItem.ToString();
                var filtered = shows.Where(s => s.Genre == chosengenre).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtered;
            }
            else if (comboBox2.Enabled == false)
            {
                DateTime datefrom = dateTimePicker1.Value.Date;
                DateTime dateto = dateTimePicker2.Value.Date;
                var filtered = shows.Where(s => (s.Date >= datefrom) && (s.Date <= dateto)).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtered;
            }
            else
            {
                string chosengenre = comboBox2.SelectedItem.ToString();
                DateTime datefrom = dateTimePicker1.Value.Date;
                DateTime dateto = dateTimePicker2.Value.Date;
                var filtered = shows.Where(s => (s.Date >= datefrom) && (s.Date <= dateto) && (s.Genre == chosengenre)).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filtered;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string vmist = File.ReadAllText(openFileDialog.FileName);
                    var showlist = JsonSerializer.Deserialize<List<Theater>>(vmist);

                    if (showlist != null)
                    {
                        dataGridView1.DataSource = null;

                        
                        foreach (var s in showlist)
                        {
                            bool alreadyexists = shows.Any(x =>
                            x.Name == s.Name &&
                            x.Genre == s.Genre &&
                            x.Date == s.Date &&
                            x.Description == s.Description);

                            if (!alreadyexists)
                                shows.Add(s);
                        }
                        dataGridView1.DataSource = shows;
                    }
                    else
                    {
                        MessageBox.Show("Файл пустий");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при читанні файлу: " + ex.Message);
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {       
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
    }
}
