using System;
using System.Windows.Forms;

namespace Stitch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                polotno1.ActiveColor = colorDialog1.Color;
            }
        }

        private void RBGoriz_CheckedChanged(object sender, EventArgs e) => polotno1.symm = 2;
        private void RBWert_CheckedChanged(object sender, EventArgs e) => polotno1.symm = 1;
        private void RBDwi_CheckedChanged(object sender, EventArgs e) => polotno1.symm = 3;
        private void RBCentr_CheckedChanged(object sender, EventArgs e) => polotno1.symm = 4;
        private void RBNoSym_CheckedChanged(object sender, EventArgs e) => polotno1.symm = 0;

        private void buttonClear_Click(object sender, EventArgs e) => polotno1.Clear();

        private void btnSave_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog { Filter = "Stitch Project|*.stitch", DefaultExt = "stitch" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                polotno1.SaveToFile(sfd.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Stitch Project|*.stitch", DefaultExt = "stitch" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                polotno1.LoadFromFile(ofd.FileName);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog { Filter = "PNG Image|*.png|JPEG Image|*.jpg", DefaultExt = "png" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                polotno1.SaveAsImage(sfd.FileName);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            polotno1.PrintPattern();
        }

        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            polotno1.IsFillMode = chkFill.Checked;
        }

        private void rbPencil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPencil.Checked) polotno1.IsFillMode = false;
        }
    }
}
