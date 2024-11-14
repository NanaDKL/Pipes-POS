namespace Pipes_POS
{
    partial class formLogin_1920
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            formBanner_19201 = new formBanner_1920();
            formMain_19201 = new formMain_1920();
            formLoginForm_19201 = new formLoginForm_1920();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(formBanner_19201);
            panel1.Controls.Add(formLoginForm_19201);
            panel1.Controls.Add(formMain_19201);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 0;
            // 
            // formBanner_19201
            // 
            formBanner_19201.Location = new Point(0, 0);
            formBanner_19201.Name = "formBanner_19201";
            formBanner_19201.Size = new Size(1920, 50);
            formBanner_19201.TabIndex = 0;
            // 
            // formMain_19201
            // 
            formMain_19201.Location = new Point(0, 50);
            formMain_19201.Name = "formMain_19201";
            formMain_19201.Size = new Size(1920, 1030);
            formMain_19201.TabIndex = 2;
            // 
            // formLoginForm_19201
            // 
            formLoginForm_19201.Location = new Point(0, 50);
            formLoginForm_19201.Name = "formLoginForm_19201";
            formLoginForm_19201.Size = new Size(1920, 1030);
            formLoginForm_19201.TabIndex = 1;
            // 
            // formLogin_1920
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin_1920";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formLogin_1920";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private formBanner_1920 formBanner_19201;
        private formLoginForm_1920 formLoginForm_19201;
        private formMain_1920 formMain_19201;
    }
}