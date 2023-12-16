namespace RA.WinFormUI
{
    partial class StockForm
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
            components = new System.ComponentModel.Container();
            panelLeft = new Panel();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            lblID = new Label();
            panelLeftBottom = new Panel();
            bttnDelete = new Button();
            bttnUpdate = new Button();
            bttnAdd = new Button();
            txtCategoryName = new TextBox();
            comboCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            yenileToolStripMenuItem = new ToolStripMenuItem();
            panelMid = new Panel();
            dataGridView1 = new DataGridView();
            panelLeft.SuspendLayout();
            panelLeftBottom.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(textBox1);
            panelLeft.Controls.Add(comboBox1);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(lblID);
            panelLeft.Controls.Add(panelLeftBottom);
            panelLeft.Controls.Add(txtCategoryName);
            panelLeft.Controls.Add(comboCategory);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 681);
            panelLeft.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 118);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 17;
            label4.Text = "Miktar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 88);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 16;
            label3.Text = "Fiyat :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(150, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 15;
            lblID.Text = "0";
            // 
            // panelLeftBottom
            // 
            panelLeftBottom.Controls.Add(bttnDelete);
            panelLeftBottom.Controls.Add(bttnUpdate);
            panelLeftBottom.Controls.Add(bttnAdd);
            panelLeftBottom.Dock = DockStyle.Bottom;
            panelLeftBottom.Location = new Point(0, 628);
            panelLeftBottom.Name = "panelLeftBottom";
            panelLeftBottom.Size = new Size(300, 53);
            panelLeftBottom.TabIndex = 13;
            // 
            // bttnDelete
            // 
            bttnDelete.Dock = DockStyle.Left;
            bttnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttnDelete.Location = new Point(246, 0);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(121, 53);
            bttnDelete.TabIndex = 13;
            bttnDelete.Text = "Sil";
            bttnDelete.UseVisualStyleBackColor = true;
            // 
            // bttnUpdate
            // 
            bttnUpdate.Dock = DockStyle.Left;
            bttnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttnUpdate.Location = new Point(121, 0);
            bttnUpdate.Name = "bttnUpdate";
            bttnUpdate.Size = new Size(125, 53);
            bttnUpdate.TabIndex = 12;
            bttnUpdate.Text = "Güncelle";
            bttnUpdate.UseVisualStyleBackColor = true;
            // 
            // bttnAdd
            // 
            bttnAdd.Dock = DockStyle.Left;
            bttnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttnAdd.Location = new Point(0, 0);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(121, 53);
            bttnAdd.TabIndex = 10;
            bttnAdd.Text = "Ekle";
            bttnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(79, 85);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(167, 23);
            txtCategoryName.TabIndex = 6;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(79, 27);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(167, 23);
            comboCategory.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 59);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Firma Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, yenileToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(106, 48);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(105, 22);
            silToolStripMenuItem.Text = "Sil";
            // 
            // yenileToolStripMenuItem
            // 
            yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            yenileToolStripMenuItem.Size = new Size(105, 22);
            yenileToolStripMenuItem.Text = "Yenile";
            // 
            // panelMid
            // 
            panelMid.Controls.Add(dataGridView1);
            panelMid.Dock = DockStyle.Fill;
            panelMid.Location = new Point(300, 0);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(964, 681);
            panelMid.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(964, 681);
            dataGridView1.TabIndex = 1;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelMid);
            Controls.Add(panelLeft);
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockForm";
            Load += StockForm_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelLeftBottom.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            panelMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Label lblID;
        private Panel panelLeftBottom;
        private Button bttnDelete;
        private Button bttnUpdate;
        private Button bttnAdd;
        private TextBox txtCategoryName;
        private ComboBox comboCategory;
        private Label label2;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem yenileToolStripMenuItem;
        private Panel panelMid;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
    }
}