namespace Pipes_POS
{
    partial class formSales_Cart_Items
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
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 1030);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 119);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 1);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 119);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 68);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 4;
            label3.Text = "Cart Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 30);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 3;
            label2.Text = "Date and time";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(422, 399);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(13, 547);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 232);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // formSales_Cart_Items
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel2);
            Name = "formSales_Cart_Items";
            Size = new Size(450, 1030);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}
