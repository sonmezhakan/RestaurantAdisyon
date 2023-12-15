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
            txtAdress = new TextBox();
            txtSupplier = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelMid = new Panel();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            yenileToolStripMenuItem = new ToolStripMenuItem();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            txtContactName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboSupplier = new ComboBox();
            panelLeft.SuspendLayout();
            panelLeftBottom.SuspendLayout();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(comboSupplier);
            panelLeft.Controls.Add(label5);
            panelLeft.Controls.Add(txtContactName);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(txtPhoneNumber);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(lblID);
            panelLeft.Controls.Add(checkStatu);
            panelLeft.Controls.Add(panelLeftBottom);
            panelLeft.Controls.Add(txtAdress);
            panelLeft.Controls.Add(txtSupplier);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(label2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(367, 681);
            panelLeft.TabIndex = 4;
            // 
            // lblID
            // 
            lblID.Location = new Point(163, 19);
            lblID.Name = "lblID";
            lblID.Size = new Size(167, 15);
            lblID.TabIndex = 15;
            lblID.Text = "0";
            // 
            // checkStatu
            // 
            checkStatu.AutoSize = true;
            checkStatu.Checked = true;
            checkStatu.CheckState = CheckState.Checked;
            checkStatu.Location = new Point(163, 237);
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
            // txtAdress
            // 
            txtAdress.Location = new Point(163, 153);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(167, 78);
            txtAdress.TabIndex = 7;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(163, 67);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(167, 23);
            txtSupplier.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 156);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Adres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 70);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Firma Adı :";
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
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(163, 124);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(167, 23);
            txtPhoneNumber.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 127);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 16;
            label1.Text = "Telefon No :";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(163, 95);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(167, 23);
            txtContactName.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 98);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 18;
            label4.Text = "İletşim Kurulacak Kişi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 41);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 20;
            label5.Text = "İşlem Yapılacak Firma Adı :";
            // 
            // comboSupplier
            // 
            comboSupplier.FormattingEnabled = true;
            comboSupplier.Location = new Point(163, 38);
            comboSupplier.Name = "comboSupplier";
            comboSupplier.Size = new Size(167, 23);
            comboSupplier.TabIndex = 21;
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
        private TextBox txtContactName;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label1;
        private Label lblID;
        private CheckBox checkStatu;
        private Panel panelLeftBottom;
        private Button bttnDelete;
        private Button bttnUpdate;
        private Button bttnAdd;
        private TextBox txtAdress;
        private TextBox txtSupplier;
        private Label label3;
        private Label label2;
        private Panel panelMid;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem yenileToolStripMenuItem;
        private ComboBox comboSupplier;
        private Label label5;
    }
}