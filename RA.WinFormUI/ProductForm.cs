﻿using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Repositories.Concretes;
using RA.Entities.Entity;
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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        MainForm mainForm = new MainForm();

        ProductManager productManager = new ProductManager(new ProductRepository());
        AppUserManager appUserManager = new AppUserManager(new AppUserRepository());
        CategoryManager categoryManager = new CategoryManager(new CategoryRepository());

        private void ProductMain_Load(object sender, EventArgs e)
        {
            ComboProductList();
            ComboCategoryList();
            DgwSettings();
            GetList();
            comboChampaing.SelectedIndex = 0;
        }
        private void ComboProductList()
        {
            comboProduct.DisplayMember = ComboBoxMember.ProductName;
            comboProduct.ValueMember = ComboBoxMember.ID;

            comboProduct.DataSource = productManager.GetAllComboBox();
        }
        private void ComboCategoryList()
        {
            comboCategory.DisplayMember = ComboBoxMember.CategoryName;
            comboCategory.ValueMember = ComboBoxMember.ID;

            comboCategory.DataSource = categoryManager.GetAllComboBox();
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            productManager.GetById((int)comboProduct.SelectedValue);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwClick();
            bttnDelete_Click(sender, e);
        }
        private void DgwClick()
        {
            comboProduct.SelectedValue = dataGridView1.SelectedCells[0].Value;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DgwClick();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) || !string.IsNullOrEmpty(txtUnitPrice.Text) || (int)comboCategory.SelectedValue > 0)
            {
                if (productManager.GetByName(txtProductName.Text) == null)
                {
                    productManager.Add(new Entities.Entity.Product
                    {
                        ProductName = txtProductName.Text,
                        CategoryID = (int)comboCategory.SelectedValue,
                        UnitPrice = Math.Round(decimal.Parse(txtUnitPrice.Text), 2),
                        UnitsInStock = 0,
                        Champaing = 0,
                        IsActive = checkStatu.Checked,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        CreatedUserId = MainForm.userId
                    });
                    ComboProductList();
                    GetList();



                }
                else
                {
                    MessageBox.Show(Messages.ProductNameError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getProduct = productManager.GetById((int)comboProduct.SelectedValue);
            if (getProduct != null)
            {
                if (!string.IsNullOrEmpty(txtProductName.Text) || !string.IsNullOrEmpty(txtUnitPrice.Text) || (int)comboCategory.SelectedValue > 0)
                {
                    if (getProduct.ProductName == txtProductName.Text || productManager.GetByName(txtProductName.Text) == null)
                    {
                        getProduct.ProductName = txtProductName.Text;
                        getProduct.CategoryID = (int)comboCategory.SelectedValue;
                        getProduct.UnitPrice = Math.Round(decimal.Parse(txtUnitPrice.Text), 2);
                        getProduct.Champaing = 0;
                        getProduct.IsActive = checkStatu.Checked;
                        getProduct.UpdatedDate = DateTime.Now;

                        productManager.Update(getProduct);
                        ComboProductList();
                        GetList();

                    }
                    else
                    {
                        MessageBox.Show(Messages.ProductNameError);
                    }
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
            var getProduct = productManager.GetById((int)comboProduct.SelectedValue);
            if (getProduct != null)
            {
                productManager.Delete(getProduct);
                ComboProductList();
                GetList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }
        private void GetList()
        {
            var getProduct = productManager.GetAll();
            if (getProduct != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getProduct)
                {
                    dataGridView1.Rows.Add(item.ID, item.ProductName, categoryManager.GetById(item.CategoryID).CategoryName, item.UnitsInStock, item.Champaing, Math.Round(item.UnitPrice,2), item.IsActive, item.CreatedDate, item.UpdatedDate, appUserManager.GetById(item.CreatedUserId).UserName);
                }
            }
        }
        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 10;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.ProductName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.CategoryName;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.UnitStock;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.Champaing;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.UnitPrice;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[7].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[8].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[9].HeaderText = ColumnHeaders.CreatedUserId;
        }


    }
}
