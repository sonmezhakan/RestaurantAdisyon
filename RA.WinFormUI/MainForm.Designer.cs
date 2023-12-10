namespace RA.WinFormUI
{
    partial class MainForm
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
            panelMid = new Panel();
            lblTableName = new Label();
            silToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            panelLeft = new Panel();
            lblTotalPrice = new Label();
            label1 = new Label();
            panelBottom = new Panel();
            label2 = new Label();
            bttnPayment = new Button();
            toolStripButtonTable = new ToolStripButton();
            siparişListesiToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButtonOrder = new ToolStripDropDownButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonEmployee = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButtonUser = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonProduct = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonCategory = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            panelTopLeft = new Panel();
            panelRight = new Panel();
            panelTop = new Panel();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelLeft.SuspendLayout();
            panelBottom.SuspendLayout();
            toolStrip1.SuspendLayout();
            panelTopLeft.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMid
            // 
            panelMid.AutoScroll = true;
            panelMid.Dock = DockStyle.Fill;
            panelMid.Location = new Point(498, 100);
            panelMid.MinimumSize = new Size(125, 0);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(751, 772);
            panelMid.TabIndex = 9;
            // 
            // lblTableName
            // 
            lblTableName.Dock = DockStyle.Top;
            lblTableName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTableName.Location = new Point(0, 0);
            lblTableName.Name = "lblTableName";
            lblTableName.Size = new Size(498, 36);
            lblTableName.TabIndex = 0;
            lblTableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(86, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(87, 26);
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
            dataGridView1.Location = new Point(0, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(498, 736);
            dataGridView1.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dataGridView1);
            panelLeft.Controls.Add(lblTableName);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 100);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(498, 772);
            panelLeft.TabIndex = 7;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Dock = DockStyle.Left;
            lblTotalPrice.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.Location = new Point(191, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(307, 169);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "0";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 169);
            label1.TabIndex = 0;
            label1.Text = "ToplamTutar :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(label2);
            panelBottom.Controls.Add(bttnPayment);
            panelBottom.Controls.Add(lblTotalPrice);
            panelBottom.Controls.Add(label1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 872);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1249, 169);
            panelBottom.TabIndex = 6;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(498, 0);
            label2.Name = "label2";
            label2.Size = new Size(292, 169);
            label2.TabIndex = 3;
            label2.Text = "₺";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bttnPayment
            // 
            bttnPayment.Dock = DockStyle.Right;
            bttnPayment.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttnPayment.Location = new Point(1011, 0);
            bttnPayment.Name = "bttnPayment";
            bttnPayment.Size = new Size(238, 169);
            bttnPayment.TabIndex = 2;
            bttnPayment.Text = "Hesap Öde";
            bttnPayment.UseVisualStyleBackColor = true;
            bttnPayment.Click += bttnPayment_Click;
            // 
            // toolStripButtonTable
            // 
            toolStripButtonTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonTable.Image = Properties.Resources.tables;
            toolStripButtonTable.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonTable.ImageTransparentColor = Color.Magenta;
            toolStripButtonTable.Name = "toolStripButtonTable";
            toolStripButtonTable.Size = new Size(69, 89);
            toolStripButtonTable.Text = "Masalar";
            toolStripButtonTable.TextAlign = ContentAlignment.BottomCenter;
            toolStripButtonTable.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonTable.Click += toolStripButtonTable_Click;
            // 
            // siparişListesiToolStripMenuItem
            // 
            siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            siparişListesiToolStripMenuItem.Size = new Size(174, 26);
            siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            siparişListesiToolStripMenuItem.Click += siparişListesiToolStripMenuItem_Click;
            // 
            // toolStripDropDownButtonOrder
            // 
            toolStripDropDownButtonOrder.DropDownItems.AddRange(new ToolStripItem[] { siparişListesiToolStripMenuItem });
            toolStripDropDownButtonOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripDropDownButtonOrder.Image = Properties.Resources.orders;
            toolStripDropDownButtonOrder.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButtonOrder.Name = "toolStripDropDownButtonOrder";
            toolStripDropDownButtonOrder.Size = new Size(88, 89);
            toolStripDropDownButtonOrder.Text = "Siparişler";
            toolStripDropDownButtonOrder.TextAlign = ContentAlignment.BottomCenter;
            toolStripDropDownButtonOrder.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 92);
            // 
            // toolStripButtonEmployee
            // 
            toolStripButtonEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonEmployee.Image = Properties.Resources.employees;
            toolStripButtonEmployee.ImageTransparentColor = Color.Magenta;
            toolStripButtonEmployee.Name = "toolStripButtonEmployee";
            toolStripButtonEmployee.Size = new Size(82, 89);
            toolStripButtonEmployee.Text = "Çalışanlar";
            toolStripButtonEmployee.TextAlign = ContentAlignment.BottomCenter;
            toolStripButtonEmployee.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonEmployee.Click += toolStripButtonEmployee_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 92);
            // 
            // toolStripButtonUser
            // 
            toolStripButtonUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonUser.Image = Properties.Resources.users;
            toolStripButtonUser.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonUser.ImageTransparentColor = Color.Magenta;
            toolStripButtonUser.Name = "toolStripButtonUser";
            toolStripButtonUser.Size = new Size(90, 89);
            toolStripButtonUser.Text = "Kullanıcılar";
            toolStripButtonUser.TextAlign = ContentAlignment.BottomCenter;
            toolStripButtonUser.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonUser.Click += toolStripButtonUser_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 92);
            // 
            // toolStripButtonProduct
            // 
            toolStripButtonProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonProduct.Image = Properties.Resources.products;
            toolStripButtonProduct.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonProduct.ImageTransparentColor = Color.Magenta;
            toolStripButtonProduct.Name = "toolStripButtonProduct";
            toolStripButtonProduct.Size = new Size(68, 89);
            toolStripButtonProduct.Text = "Ürünler";
            toolStripButtonProduct.TextAlign = ContentAlignment.BottomCenter;
            toolStripButtonProduct.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonProduct.Click += toolStripButtonProduct_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 92);
            // 
            // toolStripButtonCategory
            // 
            toolStripButtonCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripButtonCategory.Image = Properties.Resources.categories;
            toolStripButtonCategory.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButtonCategory.ImageTransparentColor = Color.Magenta;
            toolStripButtonCategory.Name = "toolStripButtonCategory";
            toolStripButtonCategory.Size = new Size(90, 89);
            toolStripButtonCategory.Text = "Kategoriler";
            toolStripButtonCategory.TextAlign = ContentAlignment.BottomCenter;
            toolStripButtonCategory.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonCategory.Click += toolStripButtonCategory_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonCategory, toolStripSeparator1, toolStripButtonProduct, toolStripSeparator2, toolStripButtonUser, toolStripSeparator3, toolStripButtonEmployee, toolStripSeparator4, toolStripDropDownButtonOrder, toolStripButtonTable });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(727, 92);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // panelTopLeft
            // 
            panelTopLeft.Controls.Add(toolStrip1);
            panelTopLeft.Dock = DockStyle.Left;
            panelTopLeft.Location = new Point(0, 0);
            panelTopLeft.Name = "panelTopLeft";
            panelTopLeft.Size = new Size(727, 100);
            panelTopLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.AutoScroll = true;
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(1249, 100);
            panelRight.MaximumSize = new Size(870, 772);
            panelRight.MinimumSize = new Size(125, 100);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(655, 772);
            panelRight.TabIndex = 8;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelTopLeft);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1904, 100);
            panelTop.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelMid);
            Controls.Add(panelLeft);
            Controls.Add(panelBottom);
            Controls.Add(panelRight);
            Controls.Add(panelTop);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelLeft.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelTopLeft.ResumeLayout(false);
            panelTopLeft.PerformLayout();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMid;
        private Label lblTableName;
        private ToolStripMenuItem silToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private Panel panelLeft;
        private Label label1;
        private Panel panelBottom;
        private ToolStripButton toolStripButtonTable;
        private ToolStripMenuItem siparişListesiToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButtonOrder;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButtonEmployee;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonUser;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonProduct;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonCategory;
        private ToolStrip toolStrip1;
        private Panel panelTopLeft;
        private Panel panelRight;
        private Panel panelTop;
        private Button bttnPayment;
        public Label label2;
        public Label lblTotalPrice;
    }
}