using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr1_3
{
    public partial class Greeting_form : Form
    {
        public Greeting_form()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Greeting_form_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void Greeting_form_Shown(object sender, EventArgs e)
        {

            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form1 form = new Form1();
                form.Show();
            }
            else if (radioButton2.Checked)
            {
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Виберіть тип театру!");
            }
        }
    }
}
