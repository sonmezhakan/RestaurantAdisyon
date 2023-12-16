namespace RA.WinFormUI
{
    partial class SupplierForm
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
            lblID = new Label();
            checkStatu = new CheckBox();
            panelLeftBottom = new Panel();
            bttnDelete = new Button();
            bttnUpdate = new Button();
            bttnAdd = new Button();
            txtCategoryName = new TextBox();
            comboCategory = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelMid = new Panel();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            yenileToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            panelLeft.SuspendLayout();
            panelLeftBottom.SuspendLayout();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(textBox3);
            panelLeft.Controls.Add(label5);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(textBox2);
            panelLeft.Controls.Add(textBox1);
            panelLeft.Controls.Add(lblID);
            panelLeft.Controls.Add(checkStatu);
            panelLeft.Controls.Add(panelLeftBottom);
            panelLeft.Controls.Add(txtCategoryName);
            panelLeft.Controls.Add(comboCategory);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(367, 681);
            panelLeft.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(232, 22);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 15;
            lblID.Text = "0";
            // 
            // checkStatu
            // 
            checkStatu.AutoSize = true;
            checkStatu.Checked = true;
            checkStatu.CheckState = CheckState.Checked;
            checkStatu.Location = new Point(161, 240);
            checkStatu.Name = "checkStatu";
            checkStatu.Size = new Size(63, 19);
            checkStatu.TabIndex = 14;
            checkStatu.Text = "Durum";
            checkStatu.UseVisualStyleBackColor = true;
            // 
            // panelLeftBottom
            // 
            panelLeftBottom.Controls.Add(bttnDelete);
            panelLeftBottom.Controls.Add(bttnUpdate);
            panelLeftBottom.Controls.Add(bttnAdd);
            panelLeftBottom.Dock = DockStyle.Bottom;
            panelLeftBottom.Location = new Point(0, 628);
            panelLeftBottom.Name = "panelLeftBottom";
            panelLeftBottom.Size = new Size(367, 53);
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
            txtCategoryName.Location = new Point(161, 69);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(167, 23);
            txtCategoryName.TabIndex = 6;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(161, 40);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(167, 23);
            comboCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 101);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 2;
            label3.Text = "İletişim Kurulacak Kişi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 72);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Firma Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 43);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "İşlem Yapılacak Tedarikçi :";
            // 
            // panelMid
            // 
            panelMid.Controls.Add(dataGridView1);
            panelMid.Dock = DockStyle.Fill;
            panelMid.Location = new Point(0, 0);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1264, 681);
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
            dataGridView1.Size = new Size(1264, 681);
            dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(161, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 156);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 78);
            textBox2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 160);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 18;
            label4.Text = "Adres :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 130);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 19;
            label5.Text = "Telefon No :";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelLeft);
            Controls.Add(panelMid);
            Name = "SupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelLeftBottom.ResumeLayout(false);
            panelMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblID;
        private CheckBox checkStatu;
        private Panel panelLeftBottom;
        private Button bttnDelete;
        private Button bttnUpdate;
        private Button bttnAdd;
        private TextBox txtCategoryName;
        private ComboBox comboCategory;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelMid;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem yenileToolStripMenuItem;
    }
}