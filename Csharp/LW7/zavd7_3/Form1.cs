using System.ComponentModel;
using System.Data;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lr1_3
{
    public partial class Form1 : Form
    {
        private Group allShowsGroup = new Group();
        private Group filteredGroup = new Group();
        private readonly TheaterFactory factory = new TheaterFactory();
        BindingList<OperaTheater> operaShows = new BindingList<OperaTheater>();
        BindingList<PuppetTheater> puppetShows = new BindingList<PuppetTheater>();

        private Action<Theater> notify;


        public Form1()
        {
            InitializeComponent();

            allShowsGroup.TheaterAdded += OnTheaterAdded;
            allShowsGroup.GroupCleared += OnGroupCleared;

            allShowsGroup.FilterUsed += (x) =>
            {
                MessageBox.Show("Фільтрацію застосовано");
                return true;
            };

            notify += LogToConsole;

            comboBoxGenre.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            UpdateDynamicFields();
            dataGridView1.DataSource = allShowsGroup;
            SetupDataGridViewColumns();
        }

        private void LogToConsole(Theater t)
        {
            Console.WriteLine("Додано: " + t.Name);
        }


        private void OnTheaterAdded(Theater t)
        {
            try
            {
                MessageBox.Show($"Додано: {t.Name}");
            }
            catch { }
        }

        private void OnGroupCleared(object? sender, TheaterEventArgs e)
        {
            MessageBox.Show(e.Message);
        }


        private Predicate<Theater> FilterByGenre(string genre) =>
            t => t.Genre == genre;

        private Predicate<Theater> FilterByDate(DateTime from, DateTime to) =>
            t => t.Date >= from && t.Date <= to;

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
            string type = comboBox4.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAbout.Text) ||
                string.IsNullOrWhiteSpace(composertxt.Text) ||
                pickdate1.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Введіть дані");
                return;
            }

            int duration = (int)durationNumeric.Value;

            if (type == "Ляльковий")
            {
                var puppet = factory.CreatePuppetTheater(
                    txtName.Text,
                    comboBoxGenre.Text,
                    txtAbout.Text,
                    pickdate1.Value.Date,
                    composertxt.Text,
                    comboBox3.Text
                );

                puppet.SetSchedule(TimeSpan.FromHours(18), duration);

                puppetShows.Add(puppet);
                allShowsGroup.Add(puppet);

                notify?.Invoke(puppet);

            }
            else if (type == "Оперний")
            {
                var opera = factory.CreateOperaTheater(
                    txtName.Text,
                    comboBoxGenre.Text,
                    txtAbout.Text,
                    pickdate1.Value.Date,
                    composertxt.Text,
                    comboBox3.Text,
                    radioButton2.Checked
                );

                opera.SetSchedule(TimeSpan.FromHours(19), duration);

                operaShows.Add(opera);
                allShowsGroup.Add(opera);

                notify?.Invoke(opera);

            }

            txtName.Clear();
            txtAbout.Clear();
            composertxt.Clear();
            comboBoxGenre.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            pickdate1.Value = DateTime.Now;
            radioButton2.Checked = false;
            durationNumeric.Value = 0;            
            UpdateDataGridView(allShowsGroup);


        }


        private void label4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog { Filter = "JSON Files (*.json)|*.json" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string category = comboBox4.SelectedItem?.ToString();
                if (category == "Ляльковий")
                    SaveShowsToFile(dialog.FileName, puppetShows);
                else
                    SaveShowsToFile(dialog.FileName, operaShows);

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
            UpdateDataGridView(allShowsGroup);
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
            UpdateDataGridView(allShowsGroup);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IEnumerable<Theater> filtered = allShowsGroup;

            if (comboBox1.SelectedIndex == 0)
            {
                var pred = FilterByDate(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                filtered = allShowsGroup.Filter(s => pred(s));
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string g = comboBox2.Text;
                var pred = FilterByGenre(g);
                filtered = allShowsGroup.Filter(s => pred(s));
            }
            else
            {
                string g = comboBox2.Text;
                var pred1 = FilterByGenre(g);
                var pred2 = FilterByDate(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);

                filtered = allShowsGroup.Filter(t => pred1(t) && pred2(t));

            }


            UpdateDataGridView(filtered);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            string category = comboBox4.SelectedItem?.ToString();
            OpenFileDialog open = new OpenFileDialog { Filter = "JSON Files (*.json)|*.json" };

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string vmist = File.ReadAllText(open.FileName);

                    if (category == "Ляльковий")
                    {
                        var list = JsonSerializer.Deserialize<List<PuppetTheater>>(vmist);
                        if (list != null)
                            foreach (var p in list)
                                if (!puppetShows.Any(x => x == p))
                                {
                                    puppetShows.Add(p);
                                    allShowsGroup.Add(p);
                                }
                    }
                    else
                    {
                        var list = JsonSerializer.Deserialize<List<OperaTheater>>(vmist);
                        if (list != null)
                            foreach (var o in list)
                                if (!operaShows.Any(x => x == o))
                                {
                                    operaShows.Add(o);
                                    allShowsGroup.Add(o);
                                }
                    }

                    UpdateDataGridView(allShowsGroup);
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            allShowsGroup.Clear();
            puppetShows.Clear();
            operaShows.Clear();
            UpdateDataGridView(allShowsGroup);
        }

        private void composertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDynamicFields();
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
            dataGridView1.Columns.Add("Duration", "Тривалість (хв)");
            dataGridView1.Columns["Duration"].DataPropertyName = "Duration";
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

            UpdateDataGridView(allShowsGroup);
        }

        private void UpdateDataGridView(IEnumerable<Theater> shows)
        {
            var displayList = shows.Select(show => new
            {
                Category = show.Category,
                Name = show.Name,
                Genre = show.Genre,
                Description = show.Description,
                Date = show.Date,
                PuppetType = show is PuppetTheater puppet ? puppet.PuppetType : null,
                AgeCategory = show is PuppetTheater puppet2 ? puppet2.AgeCategory : null,
                Composer = show is OperaTheater opera ? opera.Composer : null,
                Language = show is OperaTheater opera2 ? opera2.Language : null,
                Subtitles = show is OperaTheater opera3 ? (opera3.Subtitles ? "Так" : "Ні") : null,
                Duration = show.Schedule?.DurationMinutes
            }).ToList();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayList;
        }

        
        private void UpdateDynamicFields()
        {
            string n = comboBox4.SelectedItem?.ToString();

            if (n == "Ляльковий")
            {
                label17.Text = "Тип ляльок";
                label18.Text = "Вік. обмеження";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("0+", "3+", "6+", "12+", "16+", "18+");
                radioButton2.Visible = false;
            }
            else
            {
                label17.Text = "Композиор";
                label18.Text = "Мова викон.";
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange("Англійська", "Українська", "Італійська", "Французька");
                radioButton2.Visible = true;
            }
        }

        private void SaveShowsToFile(string path, IEnumerable<Theater> shows)
        {
            string json = JsonSerializer.Serialize(shows, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

    }
}
