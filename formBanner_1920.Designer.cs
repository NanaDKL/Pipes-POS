namespace Pipes_POS
{
    partial class formBanner_1920
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBanner_1920));
            panel1 = new Panel();
            pbSettings = new PictureBox();
            pbNotification = new PictureBox();
            pbMinimize = new PictureBox();
            pbHelp = new PictureBox();
            pbClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbSettings);
            panel1.Controls.Add(pbNotification);
            panel1.Controls.Add(pbMinimize);
            panel1.Controls.Add(pbHelp);
            panel1.Controls.Add(pbClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 50);
            panel1.TabIndex = 0;
            // 
            // pbSettings
            // 
            pbSettings.Cursor = Cursors.Hand;
            pbSettings.Dock = DockStyle.Right;
            pbSettings.Image = (Image)resources.GetObject("pbSettings.Image");
            pbSettings.Location = new Point(1670, 0);
            pbSettings.Name = "pbSettings";
            pbSettings.Size = new Size(50, 50);
            pbSettings.SizeMode = PictureBoxSizeMode.CenterImage;
            pbSettings.TabIndex = 4;
            pbSettings.TabStop = false;
            // 
            // pbNotification
            // 
            pbNotification.Cursor = Cursors.Hand;
            pbNotification.Dock = DockStyle.Right;
            pbNotification.Image = (Image)resources.GetObject("pbNotification.Image");
            pbNotification.Location = new Point(1720, 0);
            pbNotification.Name = "pbNotification";
            pbNotification.Size = new Size(50, 50);
            pbNotification.SizeMode = PictureBoxSizeMode.CenterImage;
            pbNotification.TabIndex = 3;
            pbNotification.TabStop = false;
            // 
            // pbMinimize
            // 
            pbMinimize.Cursor = Cursors.Hand;
            pbMinimize.Dock = DockStyle.Right;
            pbMinimize.Image = (Image)resources.GetObject("pbMinimize.Image");
            pbMinimize.Location = new Point(1770, 0);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(50, 50);
            pbMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMinimize.TabIndex = 2;
            pbMinimize.TabStop = false;
            // 
            // pbHelp
            // 
            pbHelp.Cursor = Cursors.Hand;
            pbHelp.Dock = DockStyle.Right;
            pbHelp.Image = (Image)resources.GetObject("pbHelp.Image");
            pbHelp.Location = new Point(1820, 0);
            pbHelp.Name = "pbHelp";
            pbHelp.Size = new Size(50, 50);
            pbHelp.SizeMode = PictureBoxSizeMode.CenterImage;
            pbHelp.TabIndex = 1;
            pbHelp.TabStop = false;
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Dock = DockStyle.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(1870, 0);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(50, 50);
            pbClose.SizeMode = PictureBoxSizeMode.CenterImage;
            pbClose.TabIndex = 0;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // formBanner_1920
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Name = "formBanner_1920";
            Size = new Size(1920, 50);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbMinimize;
        private PictureBox pbHelp;
        private PictureBox pbClose;
        private PictureBox pbSettings;
        private PictureBox pbNotification;
    }
}
