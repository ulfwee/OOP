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
        private BindingList<IShow> allShows = new BindingList<IShow>();



        public Form1()
        {
            InitializeComponent();

            comboBoxGenre.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;   

            UpdateTheaterTypeUI();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = allShows;
            SetupDataGridViewColumns();
        }
        private void UpdateTheaterTypeUI()
        {
            string n = comboBox4.SelectedItem?.ToString();

            if (n == "Ляльковий")
            {
                label17.Text = "Тип ляльок";
                label18.Text = "Вік. обмеження";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("0+", "3+", "6+", "12+", "16+", "18+");
                radioButton2.Visible = false;

                composertxt.Visible = false;
                txtPuppetType.Visible = true;
            }
            else if (n == "Оперний")
            {
                label17.Text = "Композитор";
                label18.Text = "Мова викон.";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("Англійська", "Українська", "Італійська", "Французька");
                radioButton2.Visible = true;

                composertxt.Visible = true;
                txtPuppetType.Visible = false;
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
            string n = comboBox4.SelectedItem?.ToString();
            if (n == "Ляльковий")
            {
                if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtAbout.Text) && !string.IsNullOrWhiteSpace(txtPuppetType.Text) && pickdate1.Value.Date >= DateTime.Now)
                {
                    PuppetTheater puppetth = new PuppetTheater()
                    {
                        Name = txtName.Text,
                        Genre = comboBoxGenre.Text,
                        Description = txtAbout.Text,
                        Date = pickdate1.Value.Date,
                        PuppetType = txtPuppetType.Text,
                        AgeCategory = comboBox3.Text,
                        Category = n
                    };

                    puppetShows.Add(puppetth);
                    allShows.Add(puppetth);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = allShows.ToList();
                    dataGridView1.Refresh();
                    SetupDataGridViewColumns();
                    CleanEmptyColumns();

                    MessageBox.Show(puppetth.PuppetType);

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
                        Subtitles = radioButton2.Checked,
                        Category = n
                    };

                    operaShows.Add(operath);
                    allShows.Add(operath);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = allShows.ToList();
                    dataGridView1.Refresh();
                    SetupDataGridViewColumns();
                    CleanEmptyColumns();

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
            string n = comboBox4.SelectedItem?.ToString();
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json;

                if (n == "Ляльковий")
                    json = JsonSerializer.Serialize(puppetShows.OfType<PuppetTheater>(), new JsonSerializerOptions { WriteIndented = true });
                else
                    json = JsonSerializer.Serialize(operaShows.OfType<OperaTheater>(), new JsonSerializerOptions { WriteIndented = true });

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
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
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
            dataGridView1.DataSource = allShows.ToList();
            SetupDataGridViewColumns();  
            CleanEmptyColumns();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IEnumerable<IShow> filtered = allShows;

            if (comboBox1.SelectedIndex == 1)
            {
                string chosenGenre = comboBox2.SelectedItem?.ToString();
                filtered = filtered.Where(s => s.Genre == chosenGenre);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string chosenGenre = comboBox2.SelectedItem?.ToString();
                DateTime dateFrom = dateTimePicker1.Value.Date;
                DateTime dateTo = dateTimePicker2.Value.Date;
                filtered = filtered.Where(s => s.Genre == chosenGenre && s.Date >= dateFrom && s.Date <= dateTo);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allShows.ToList();
            SetupDataGridViewColumns();  
            CleanEmptyColumns();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            string n = comboBox4.SelectedItem?.ToString();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string vmist = File.ReadAllText(openFileDialog.FileName);

                    if (n == "Ляльковий")
                    {
                        var showlist = JsonSerializer.Deserialize<List<PuppetTheater>>(vmist);
                        if (showlist != null)
                        {
                            foreach (var ps in showlist)
                            {
                                if (!puppetShows.Any(x => x == ps))
                                {
                                    puppetShows.Add(ps);
                                    allShows.Add(ps);
                                }
                            }
                        }
                    }
                    else
                    {
                        var showlist = JsonSerializer.Deserialize<List<OperaTheater>>(vmist);
                        if (showlist != null)
                        {
                            foreach (var os in showlist)
                            {
                                if (!operaShows.Any(x => x == os))
                                {
                                    operaShows.Add(os);
                                    allShows.Add(os);
                                }
                            }
                        }
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = allShows.ToList();
                    SetupDataGridViewColumns();  
                    CleanEmptyColumns();
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
            allShows.Clear();
            SetupDataGridViewColumns();
            dataGridView1.Refresh();
        }

        private void composertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SetupDataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Category", "Тип театру");
            dataGridView1.Columns["Category"].DataPropertyName = "Category";

            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns["Name"].DataPropertyName = "Name";
                
            dataGridView1.Columns.Add("Genre", "Жанр");
            dataGridView1.Columns["Genre"].DataPropertyName = "Genre";

            dataGridView1.Columns.Add("Description", "Опис");
            dataGridView1.Columns["Description"].DataPropertyName = "Description";

            dataGridView1.Columns.Add("Date", "Дата");
            dataGridView1.Columns["Date"].DataPropertyName = "Date";

            dataGridView1.Columns.Add("PuppetType", "Тип ляльок");
            dataGridView1.Columns["PuppetType"].DataPropertyName = "PuppetType";

            dataGridView1.Columns.Add("AgeCategory", "Вік. обмеження");
            dataGridView1.Columns["AgeCategory"].DataPropertyName = "AgeCategory";

            dataGridView1.Columns.Add("Composer", "Композитор");
            dataGridView1.Columns["Composer"].DataPropertyName = "Composer";

            dataGridView1.Columns.Add("Language", "Мова");
            dataGridView1.Columns["Language"].DataPropertyName = "Language";

            dataGridView1.Columns.Add("Subtitles", "Субтитри");
            dataGridView1.Columns["Subtitles"].DataPropertyName = "Subtitles";

            dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridView1.Columns["Subtitles"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["PuppetType"].Width = 100;
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBox4.SelectedItem?.ToString();

            if (n == "Ляльковий")
            {
                label17.Text = "Тип ляльок";
                label18.Text = "Вік. обмеження";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("0+", "3+", "6+", "12+", "16+", "18+");
                radioButton2.Visible = false;

                composertxt.Visible = false;
                txtPuppetType.Visible = true;  
            }
            else if (n == "Оперний")
            {
                label17.Text = "Композитор";
                label18.Text = "Мова викон.";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("Англійська", "Українська", "Італійська", "Французька");
                radioButton2.Visible = true;

                composertxt.Visible = true;
                txtPuppetType.Visible = false; 
            }
        }
        
        private void CleanEmptyColumns()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem is Theater show)
                {
                    if (show.Category == "Оперний")
                    {
                        row.Cells["PuppetType"].Value = "";
                        row.Cells["AgeCategory"].Value = "";
                    }
                    else if (show.Category == "Ляльковий")
                    {
                        row.Cells["Composer"].Value = "";
                        row.Cells["Language"].Value = "";
                        row.Cells["Subtitles"].Value = "";
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
