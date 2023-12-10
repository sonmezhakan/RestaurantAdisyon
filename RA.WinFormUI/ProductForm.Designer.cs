namespace RA.WinFormUI
{
    partial class ProductForm
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
            yenileToolStripMenuItem = new ToolStripMenuItem();
            comboChampaing = new ComboBox();
            label6 = new Label();
            panelLeftBottom = new Panel();
            bttnDelete = new Button();
            bttnUpdate = new Button();
            bttnAdd = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            panelMid = new Panel();
            checkStatu = new CheckBox();
            txtUnitStock = new TextBox();
            txtUnitPrice = new TextBox();
            comboCategory = new ComboBox();
            txtProductName = new TextBox();
            comboProduct = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblID = new Label();
            panelLeft = new Panel();
            panelLeftBottom.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelMid.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // yenileToolStripMenuItem
            // 
            yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            yenileToolStripMenuItem.Size = new Size(105, 22);
            yenileToolStripMenuItem.Text = "Yenile";
            // 
            // comboChampaing
            // 
            comboChampaing.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChampaing.FormattingEnabled = true;
            comboChampaing.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" });
            comboChampaing.Location = new Point(140, 187);
            comboChampaing.Name = "comboChampaing";
            comboChampaing.Size = new Size(197, 23);
            comboChampaing.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 191);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 15;
            label6.Text = "İndirim :";
            // 
            // panelLeftBottom
            // 
            panelLeftBottom.Controls.Add(bttnDelete);
            panelLeftBottom.Controls.Add(bttnUpdate);
            panelLeftBottom.Controls.Add(bttnAdd);
            panelLeftBottom.Dock = DockStyle.Bottom;
            panelLeftBottom.Location = new Point(0, 628);
            panelLeftBottom.Name = "panelLeftBottom";
            panelLeftBottom.Size = new Size(370, 53);
            panelLeftBottom.TabIndex = 14;
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
            dataGridView1.Size = new Size(894, 681);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panelMid
            // 
            panelMid.Controls.Add(dataGridView1);
            panelMid.Dock = DockStyle.Fill;
            panelMid.Location = new Point(370, 0);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(894, 681);
            panelMid.TabIndex = 3;
            // 
            // checkStatu
            // 
            checkStatu.AutoSize = true;
            checkStatu.Checked = true;
            checkStatu.CheckState = CheckState.Checked;
            checkStatu.Location = new Point(140, 218);
            checkStatu.Name = "checkStatu";
            checkStatu.Size = new Size(63, 19);
            checkStatu.TabIndex = 11;
            checkStatu.Text = "Durum";
            checkStatu.UseVisualStyleBackColor = true;
            // 
            // txtUnitStock
            // 
            txtUnitStock.Enabled = false;
            txtUnitStock.Location = new Point(140, 158);
            txtUnitStock.Name = "txtUnitStock";
            txtUnitStock.Size = new Size(197, 23);
            txtUnitStock.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(140, 129);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(197, 23);
            txtUnitPrice.TabIndex = 9;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(140, 100);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(197, 23);
            comboCategory.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(140, 71);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(197, 23);
            txtProductName.TabIndex = 7;
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(140, 42);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(197, 23);
            comboProduct.TabIndex = 6;
            comboProduct.SelectedIndexChanged += comboProduct_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 161);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 5;
            label5.Text = "Stok Miktarı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 132);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Fiyat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 103);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Kategori Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 74);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Ürün Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "İşlem Yapılacak Ürün :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(233, 24);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 0;
            lblID.Text = "0";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(comboChampaing);
            panelLeft.Controls.Add(label6);
            panelLeft.Controls.Add(panelLeftBottom);
            panelLeft.Controls.Add(checkStatu);
            panelLeft.Controls.Add(txtUnitStock);
            panelLeft.Controls.Add(txtUnitPrice);
            panelLeft.Controls.Add(comboCategory);
            panelLeft.Controls.Add(txtProductName);
            panelLeft.Controls.Add(comboProduct);
            panelLeft.Controls.Add(label5);
            panelLeft.Controls.Add(label4);
            panelLeft.Controls.Add(label3);
            panelLeft.Controls.Add(label2);
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(lblID);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(370, 681);
            panelLeft.TabIndex = 2;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelMid);
            Controls.Add(panelLeft);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductMain";
            Load += ProductMain_Load;
            panelLeftBottom.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelMid.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripMenuItem yenileToolStripMenuItem;
        private ComboBox comboChampaing;
        private Label label6;
        private Panel panelLeftBottom;
        private Button bttnDelete;
        private Button bttnUpdate;
        private Button bttnAdd;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private DataGridView dataGridView1;
        private Panel panelMid;
        private CheckBox checkStatu;
        private TextBox txtUnitStock;
        private TextBox txtUnitPrice;
        private ComboBox comboCategory;
        private TextBox txtProductName;
        private ComboBox comboProduct;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblID;
        private Panel panelLeft;
    }
}