namespace Pipes_POS
{
    partial class formSales
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
            panel1 = new Panel();
            label1 = new Label();
            formSales_Cart_Doodle1 = new formSales_Cart_Doodle();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(formSales_Cart_Doodle1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1720, 1030);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 2;
            label1.Text = "Sales";
            // 
            // formSales_Cart_Doodle1
            // 
            formSales_Cart_Doodle1.BackColor = Color.WhiteSmoke;
            formSales_Cart_Doodle1.Location = new Point(1270, 0);
            formSales_Cart_Doodle1.Name = "formSales_Cart_Doodle1";
            formSales_Cart_Doodle1.Size = new Size(450, 1030);
            formSales_Cart_Doodle1.TabIndex = 3;
            // 
            // formSales
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Name = "formSales";
            Size = new Size(1720, 1030);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private formSales_Cart_Doodle formSales_Cart_Doodle1;
    }
}
