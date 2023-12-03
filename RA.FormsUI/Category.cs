﻿using RA.BusinessLogic.Concrete;
using RA.BusinessLogic.Contats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RA.WebFormsUI
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        CategoryRepository categoryRepository = new CategoryRepository();
        AppUserRepository appUserRepository = new AppUserRepository();

        private void Category_Load(object sender, EventArgs e)
        {
            ComboCategoryList();
            DgwSettings();
            GetList();
        }

        private void ComboCategoryList()
        {
            comboCategory.DisplayMember = ComboBoxMember.CategoryName;
            comboCategory.ValueMember = ComboBoxMember.ID;

            comboCategory.DataSource = categoryRepository.GetAll();
        }

        private void GetList()
        {
            var getCategoryList = categoryRepository.GetAll();
            if (getCategoryList.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in categoryRepository.GetAll())
                {
                    dataGridView1.Rows.Add(item.ID, item.CategoryName, item.Desription, item.Champaing, item.IsActive, item.CreatedDate, item.UpdatedDate, appUserRepository.GetById(item.CreatedUserId).UserName);
                }
            }
        }

        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.CategoryName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.Description;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.Champaing;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[7].HeaderText = ColumnHeaders.CreatedUserId;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryName.Text))
            {
                if (categoryRepository.GetByCategoryName(txtCategoryName.Text) == null)
                {
                    categoryRepository.Add(new Entities.Entity.Category
                    {
                        CategoryName = txtCategoryName.Text,
                        Desription = txtDescription.Text,
                        IsActive = checkStatu.Checked,
                        Champaing = 0,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        CreatedUserId = 3
                    });
                    ComboCategoryList();
                    GetList();
                }
                else
                {
                    MessageBox.Show(Messages.CategoryNameError);
                }

            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getCategory = categoryRepository.GetById((int)comboCategory.SelectedValue);
            if (getCategory != null && ! string.IsNullOrEmpty(txtCategoryName.Text))
            {
                if (comboCategory.Text == txtCategoryName.Text || categoryRepository.GetByCategoryName(txtCategoryName.Text) == null)
                {
                    getCategory.CategoryName = txtCategoryName.Text;
                    getCategory.Desription = txtDescription.Text;
                    getCategory.IsActive = checkStatu.Checked;
                    getCategory.UpdatedDate = DateTime.Now;

                    categoryRepository.Update(getCategory);
                    ComboCategoryList();
                    GetList();
                }
                else
                {
                    MessageBox.Show(Messages.CategoryNameError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            var getCategory = categoryRepository.GetById((int)comboCategory.SelectedValue);
            if (getCategory != null)
            {
                categoryRepository.Delete(getCategory.ID);
                ComboCategoryList();
                GetList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getCategory = categoryRepository.GetById((int)comboCategory.SelectedValue);
            if (getCategory != null)
            {
                lblID.Text = getCategory.ID.ToString();
                txtCategoryName.Text = getCategory.CategoryName;
                txtDescription.Text = getCategory.Desription;
                comboChampaing.SelectedIndex = getCategory.Champaing;
                checkStatu.Checked = (bool)getCategory.IsActive;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwClick();
            bttnDelete_Click(sender, e);
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DgwClick();
        }
        private void DgwClick()
        {
            comboCategory.SelectedValue = dataGridView1.SelectedCells[0].Value;
        }
    }
}
