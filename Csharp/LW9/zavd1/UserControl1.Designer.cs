namespace Katok
{
    partial class Katok
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
           
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
         
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "Katok";
            Load += Katok_Load;
            Paint += Katok_Paint;
            ResumeLayout(false);
        }

        #endregion
    }
}
