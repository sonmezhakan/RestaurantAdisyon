using Microsoft.Extensions.DependencyInjection;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
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
        private readonly IProductService _productService;
        private readonly IAppUserService _appUserService;
        private readonly ISupplierService _supplierService;
        private readonly IStockService _stockService;
        public StockForm(IServiceProvider serviceProvider)
        {
            _productService = serviceProvider.GetRequiredService<IProductService>();
            _appUserService = serviceProvider.GetRequiredService<IAppUserService>();
            _supplierService = serviceProvider.GetRequiredService<ISupplierService>();
            _stockService = serviceProvider.GetRequiredService<IStockService>();

            InitializeComponent();
        }

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

            comboSupplier.DataSource = _supplierService.GetAllComboBox();
        }
        private void ComboProductList()
        {
            comboProduct.DisplayMember = ComboBoxMember.ProductName;
            comboProduct.ValueMember = ComboBoxMember.ID;

            comboProduct.DataSource = _productService.GetAllComboBox();
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
            var getStock = _stockService.GetAll();
            if (getStock != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getStock)
                {
                    dataGridView1.Rows.Add(item.ID, _productService.GetById(item.ProductID).ProductName, _supplierService.GetById(item.SupplierID).CompanyName, item.UnitPrice, item.UnitsInStock, item.IsActive, item.CreatedDate, item.UpdatedDate,
                        _appUserService.GetById(item.CreatedUserId).UserName);
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
            var getStock = _stockService.GetById((int)dataGridView1.SelectedCells[0].Value);
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
            var getProduct = _productService.GetById((int)comboProduct.SelectedValue);
            var getSupplier = _supplierService.GetById((int)comboSupplier.SelectedValue);
            if (getProduct != null || getSupplier != null)
            {
                if (!string.IsNullOrEmpty(txtUnitPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    getProduct.UnitsInStock += int.Parse(txtQuantity.Text);
                    _productService.Update(getProduct);

                    _stockService.Add(new Entities.Entity.Stock
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
            var getStock = _stockService.GetById(int.Parse(lblID.Text));
            var getProduct = _productService.GetById(getStock.ProductID);
            if (getStock != null && getProduct != null)
            {
                getProduct.UnitsInStock -= getStock.UnitsInStock;
                _productService.Update(getProduct);

                _stockService.Delete(getStock.ID);
                StockList();

            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getStock = _stockService.GetById(int.Parse(lblID.Text));
            var getProduct = _productService.GetById(getStock.ProductID);
            if (getStock != null && getProduct != null)
            {
                if(!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    getProduct.UnitsInStock -= getStock.UnitsInStock;
                    getProduct.UnitsInStock += int.Parse(txtQuantity.Text);
                    _productService.Update(getProduct);

                    getStock.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    getStock.UnitsInStock = int.Parse(txtQuantity.Text);
                    _stockService.Update(getStock);
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
