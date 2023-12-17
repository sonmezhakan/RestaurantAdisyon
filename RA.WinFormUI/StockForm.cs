using RA.Business.Constants;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RA.WinFormUI
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        ProductManager productManager = new ProductManager(new ProductRepository());
        SupplierManager supplierManager = new SupplierManager(new SupplierRepository());
        StockManager stockManager = new StockManager(new StockRepository());
        AppUserManager appUserManager = new AppUserManager(new AppUserRepository());
        private void StockForm_Load(object sender, EventArgs e)
        {
            ComboSupplierList();
            ComboProductList();
            DgwSettings();
            StockList();
        }

        private void ComboSupplierList()
        {
            comboSupplier.DisplayMember = ComboBoxMember.SupplierName;
            comboSupplier.ValueMember = ComboBoxMember.ID;

            comboSupplier.DataSource = supplierManager.GetAllComboBox();
        }
        private void ComboProductList()
        {
            comboProduct.DisplayMember = ComboBoxMember.ProductName;
            comboProduct.ValueMember = ComboBoxMember.ID;

            comboProduct.DataSource = productManager.GetAllComboBox();
        }
        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 9;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.ProductName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.CompanyName;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.UnitPrice;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.Quantity;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[7].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[8].HeaderText = ColumnHeaders.CreatedUserId;
        }
        private void StockList()
        {
            var getStock = stockManager.GetAll();
            if (getStock != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getStock)
                {
                    dataGridView1.Rows.Add(item.ID, productManager.GetById(item.ProductID).ProductName, supplierManager.GetById(item.SupplierID).CompanyName, item.UnitPrice, item.UnitsInStock, item.IsActive, item.CreatedDate, item.UpdatedDate,
                        appUserManager.GetById(item.CreatedUserId).UserName);
                }
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwClick();
            bttnDelete_Click(sender, e);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DgwClick();
        }
        private void DgwClick()
        {
            var getStock = stockManager.GetById((int)dataGridView1.SelectedCells[0].Value);
            if (getStock != null)
            {
                lblID.Text = getStock.ID.ToString();
                comboProduct.SelectedValue = getStock.ProductID;
                comboSupplier.SelectedValue = getStock.SupplierID;
                txtUnitPrice.Text = getStock.UnitPrice.ToString();
                txtQuantity.Text = getStock.UnitsInStock.ToString();
            }
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            var getProduct = productManager.GetById((int)comboProduct.SelectedValue);
            var getSupplier = supplierManager.GetById((int)comboSupplier.SelectedValue);
            if (getProduct != null || getSupplier != null)
            {
                if (!string.IsNullOrEmpty(txtUnitPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    getProduct.UnitsInStock += int.Parse(txtQuantity.Text);
                    productManager.Update(getProduct);

                    stockManager.Add(new Entities.Entity.Stock
                    {
                        ProductID = (int)comboProduct.SelectedValue,
                        SupplierID = (int)comboSupplier.SelectedValue,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtQuantity.Text),
                        IsActive = true,
                        CreatedUserId = MainForm.userId
                    });
                    StockList();
                }
                else
                {
                    MessageBox.Show(Messages.NotNull);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            var getStock = stockManager.GetById(int.Parse(lblID.Text));
            var getProduct = productManager.GetById(getStock.ProductID);
            if (getStock != null && getProduct != null)
            {
                getProduct.UnitsInStock -= getStock.UnitsInStock;
                productManager.Update(getProduct);

                stockManager.Delete(getStock);
                StockList();

            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getStock = stockManager.GetById(int.Parse(lblID.Text));
            var getProduct = productManager.GetById(getStock.ProductID);
            if (getStock != null && getProduct != null)
            {
                if(!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    getProduct.UnitsInStock -= getStock.UnitsInStock;
                    getProduct.UnitsInStock += int.Parse(txtQuantity.Text);
                    productManager.Update(getProduct);

                    getStock.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    getStock.UnitsInStock = int.Parse(txtQuantity.Text);
                    stockManager.Update(getStock);
                    StockList();
                    
                }
                else
                {
                    MessageBox.Show(Messages.NotNull);
                }

            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }
    }
}
