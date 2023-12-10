namespace RA.WinFormUI
{
    partial class OrderForm
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
            panelLeft = new Panel();
            panelRight = new Panel();
            panelMid = new Panel();
            dataGridView1 = new DataGridView();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 681);
            panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1244, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(20, 681);
            panelRight.TabIndex = 1;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(dataGridView1);
            panelMid.Dock = DockStyle.Fill;
            panelMid.Location = new Point(10, 0);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1234, 681);
            panelMid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1234, 681);
            dataGridView1.TabIndex = 2;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelMid);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderForm";
            Load += OrderForm_Load;
            panelMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelMid;
        private DataGridView dataGridView1;
    }
}