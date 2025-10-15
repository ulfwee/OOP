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
        BindingList<OperaTheater> operaShows = new BindingList<OperaTheater>();
        BindingList<PuppetTheater> puppetShows = new BindingList<PuppetTheater>();


        public string n;

        public Form1(string n)
        {
            this.n = n;
            InitializeComponent();
            comboBoxGenre.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            if (n == "Ляльковий")
            {
                label17.Text = "Тип ляльок";
                label18.Text = "Вік. обмеження";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("0+", "3+", "6+", "12+", "16+", "18+"); 
                radioButton2.Visible = false;
                dataGridView1.DataSource = puppetShows;

            }
            else if (n == "Оперний")
            {
                label17.Text = "Композиор";
                label18.Text = "Мова викон.";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("Англійська", "Українська", "Італійська", "Французька");
                radioButton2.Visible = true;
                dataGridView1.DataSource = operaShows;

            }
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
            if (n == "Ляльковий")
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAbout.Text) && !string.IsNullOrWhiteSpace(composertxt.Text) && pickdate1.Value.Date >= DateTime.Now)
                {
                    PuppetTheater puppetth = new PuppetTheater()
                    {
                        Name = txtName.Text,
                        Genre = comboBoxGenre.Text,
                        Description = txtAbout.Text,
                        Date = pickdate1.Value.Date,
                        PuppetType = composertxt.Text,
                        AgeCategory = comboBox3.Text
                    };

                    puppetShows.Add(puppetth);
                    txtName.Clear();
                    txtAbout.Clear();
                    comboBoxGenre.SelectedIndex = 0;
                    pickdate1.Value = DateTime.Now;
                    comboBox3.SelectedIndex = 0;
                    composertxt.Clear();
                }
                else
                {
                    MessageBox.Show("Введіть дані");
                }
            }
            else if (n == "Оперний")
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAbout.Text) && !string.IsNullOrWhiteSpace(composertxt.Text) && pickdate1.Value.Date >= DateTime.Now)
                {
                    OperaTheater operath = new OperaTheater()
                    {
                        Name = txtName.Text,
                        Genre = comboBoxGenre.Text,
                        Description = txtAbout.Text,
                        Date = pickdate1.Value.Date,
                        Composer = composertxt.Text,
                        Language = comboBox3.Text,
                        Subtitles = radioButton2.Checked
                    };

                    operaShows.Add(operath);
                    txtName.Clear();
                    txtAbout.Clear();
                    comboBoxGenre.SelectedIndex = 0;
                    pickdate1.Value = DateTime.Now;
                    comboBox3.SelectedIndex = 0;
                    composertxt.Clear();
                    radioButton2.Checked = false;
                }
                else
                {
                    MessageBox.Show("Введіть дані");
                }
            }
            

        }


        private void label4_Click(object sender, EventArgs e)
        {
            if (n == "Ляльковий")
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                Filter = "JSON Files (*.json)|*.json"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                var showslist = puppetShows;


                string json = JsonSerializer.Serialize(showslist, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dialog.FileName, json);
                MessageBox.Show("Збережено");
                }
            }
            else if (n == "Оперний")
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "JSON Files (*.json)|*.json"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var showslist = operaShows;


                    string json = JsonSerializer.Serialize(showslist, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(dialog.FileName, json);
                    MessageBox.Show("Збережено");
                }
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
            if (n == "Ляльковий")
            { 
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = puppetShows;
            }
            else if (n == "Оперний")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = operaShows;
            }
                
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (n == "Ляльковий")
            {
                if (dateTimePicker1.Enabled == false)
                {
                    string chosengenre = comboBox2.SelectedItem.ToString();
                    var filtered = puppetShows.Where(s => s.Genre == chosengenre).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filtered;
                }
                else if (comboBox2.Enabled == false)
                {
                    DateTime datefrom = dateTimePicker1.Value.Date;
                    DateTime dateto = dateTimePicker2.Value.Date;
                    var filtered = puppetShows.Where(s => (s.Date >= datefrom) && (s.Date <= dateto)).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filtered;
                }
                else
                {
                    string chosengenre = comboBox2.SelectedItem.ToString();
                    DateTime datefrom = dateTimePicker1.Value.Date;
                    DateTime dateto = dateTimePicker2.Value.Date;
                    var filtered = puppetShows.Where(s => (s.Date >= datefrom) && (s.Date <= dateto) && (s.Genre == chosengenre)).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filtered;
                }
            }
            else if (n == "Оперний")
            {
                if (dateTimePicker1.Enabled == false)
                {
                    string chosengenre = comboBox2.SelectedItem.ToString();
                    var filtered = operaShows.Where(s => s.Genre == chosengenre).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filtered;
                }
                else if (comboBox2.Enabled == false)
                {
                    DateTime datefrom = dateTimePicker1.Value.Date;
                    DateTime dateto = dateTimePicker2.Value.Date;
                    var filtered = operaShows.Where(s => (s.Date >= datefrom) && (s.Date <= dateto)).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filtered;
                }
                else
                {
                    string chosengenre = comboBox2.SelectedItem.ToString();
                    DateTime datefrom = dateTimePicker1.Value.Date;
                    DateTime dateto = dateTimePicker2.Value.Date;
                    var filtered = operaShows.Where(s => (s.Date >= datefrom) && (s.Date <= dateto) && (s.Genre == chosengenre)).ToList();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = filtered;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (n == "Ляльковий")
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
                        var showlist = JsonSerializer.Deserialize<List<PuppetTheater>>(vmist);

                        if (showlist != null)
                        {
                            dataGridView1.DataSource = null;


                            foreach (var ps in showlist)
                            {
                                if (!puppetShows.Any(x => x == ps))
                                    puppetShows.Add(ps);
                            }
                            dataGridView1.DataSource = puppetShows;
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
            else if (n == "Оперний")
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
                        var showlist = JsonSerializer.Deserialize<List<OperaTheater>>(vmist);

                        if (showlist != null)
                        {
                            dataGridView1.DataSource = null;


                            foreach (var os in showlist)
                            {
                                if (!operaShows.Any(x => x == os))
                                    operaShows.Add(os);
                            }
                            dataGridView1.DataSource = operaShows;
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
        }
    

        private void label16_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void composertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void langtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
