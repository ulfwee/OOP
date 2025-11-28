using System.ComponentModel;

namespace Stitch
{
    partial class Polotno
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();
            this.SuspendLayout();
            // 
            // Polotno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Polotno";
            this.Size = new System.Drawing.Size(620, 426);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Polotno_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Polotno_MouseUp_1);
            this.SizeChanged += new System.EventHandler(this.Polotno_SizeChanged);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
