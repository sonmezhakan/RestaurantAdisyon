namespace RA.WinFormUI
{
    partial class AppUserForm
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
            checkStatu = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            comboEmployeeFirstName = new ComboBox();
            label1 = new Label();
            panelMid = new Panel();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            yenileToolStripMenuItem = new ToolStripMenuItem();
            bttnDelete = new Button();
            bttnUpdate = new Button();
            bttnAdd = new Button();
            comboEmployeeLastName = new ComboBox();
            label7 = new Label();
            lblID = new Label();
            label6 = new Label();
            panelLeftBottom = new Panel();
            label2 = new Label();
            panelLeft = new Panel();
            label3 = new Label();
            comboUserName = new ComboBox();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panelLeftBottom.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // checkStatu
            // 
            checkStatu.AutoSize = true;
            checkStatu.Checked = true;
            checkStatu.CheckState = CheckState.Checked;
            checkStatu.Location = new Point(183, 189);
            checkStatu.Name = "checkStatu";
            checkStatu.Size = new Size(63, 19);
            checkStatu.TabIndex = 11;
            checkStatu.Text = "Durum";
            checkStatu.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 101);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 23);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(183, 72);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(190, 23);
            txtUserName.TabIndex = 6;
            // 
            // comboEmployeeFirstName
            // 
            comboEmployeeFirstName.FormattingEnabled = true;
            comboEmployeeFirstName.Location = new Point(183, 130);
            comboEmployeeFirstName.Name = "comboEmployeeFirstName";
            comboEmployeeFirstName.Size = new Size(190, 23);
            comboEmployeeFirstName.TabIndex = 5;
            comboEmployeeFirstName.SelectedIndexChanged += comboEmployeeFirstName_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 75);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // panelMid
            // 
            panelMid.Controls.Add(dataGridView1);
            panelMid.Dock = DockStyle.Fill;
            panelMid.Location = new Point(387, 0);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(877, 681);
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
            dataGridView1.Size = new Size(877, 681);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
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
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // yenileToolStripMenuItem
            // 
            yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            yenileToolStripMenuItem.Size = new Size(105, 22);
            yenileToolStripMenuItem.Text = "Yenile";
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
            bttnDelete.Click += bttnDelete_Click;
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
            bttnUpdate.Click += bttnUpdate_Click;
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
            bttnAdd.Click += bttnAdd_Click;
            // 
            // comboEmployeeLastName
            // 
            comboEmployeeLastName.FormattingEnabled = true;
            comboEmployeeLastName.Location = new Point(183, 160);
            comboEmployeeLastName.Name = "comboEmployeeLastName";
            comboEmployeeLastName.Size = new Size(190, 23);
            comboEmployeeLastName.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 164);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 17;
            label7.Text = "Çalışan Soyad :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(264, 21);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 16;
            lblID.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 134);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 15;
            label6.Text = "Çalışan Ad :";
            // 
            // panelLeftBottom
            // 
            panelLeftBottom.Controls.Add(bttnDelete);
            panelLeftBottom.Controls.Add(bttnUpdate);
            panelLeftBottom.Controls.Add(bttnAdd);
            panelLeftBottom.Dock = DockStyle.Bottom;
            panelLeftBottom.Location = new Point(0, 628);
            panelLeftBottom.Name = "panelLeftBottom";
            panelLeftBottom.Size = new Size(387, 53);
            panelLeftBottom.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 105);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(comboUserName);
            panelLeft.Controls.Add(comboEmployeeLastName);
            panelLeft.Controls.Add(label7);
            panelLeft.Controls.Add(lblID);
            panelLeft.Controls.Add(label6);
            panelLeft.Controls.Add(panelLeftBottom);
            panelLeft.Controls.Add(checkStatu);
            panelLeft.Controls.Add(txtPassword);
            panelLeft.Controls.Add(txtUserName);
            panelLeft.Controls.Add(comboEmployeeFirstName);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(387, 681);
            panelLeft.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 20;
            label3.Text = "İşlem Yapılacak Kullanıcı Adı :";
            // 
            // comboUserName
            // 
            comboUserName.FormattingEnabled = true;
            comboUserName.Location = new Point(183, 43);
            comboUserName.Name = "comboUserName";
            comboUserName.Size = new Size(190, 23);
            comboUserName.TabIndex = 19;
            comboUserName.SelectedIndexChanged += comboUserName_SelectedIndexChanged;
            // 
            // AppUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelMid);
            Controls.Add(panelLeft);
            Name = "AppUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppUserForm";
            Load += AppUserForm_Load;
            panelMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panelLeftBottom.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkStatu;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private ComboBox comboEmployeeFirstName;
        private Label label1;
        private Panel panelMid;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem yenileToolStripMenuItem;
        private Button bttnDelete;
        private Button bttnUpdate;
        private Button bttnAdd;
        private ComboBox comboEmployeeLastName;
        private Label label7;
        private Label lblID;
        private Label label6;
        private Panel panelLeftBottom;
        private Label label2;
        private Panel panelLeft;
        private Label label3;
        private ComboBox comboUserName;
    }
}