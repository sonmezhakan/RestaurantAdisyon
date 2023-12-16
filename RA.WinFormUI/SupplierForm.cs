using Microsoft.EntityFrameworkCore;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
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
    public partial class SupplierForm : Form
    {

        public SupplierForm()
        {
            InitializeComponent();
        }
        SupplierManager supplierManager = new SupplierManager(new SupplierRepository());
        AppUserManager appUserManager = new AppUserManager(new AppUserRepository());
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            ComboSupplierList();
            DgwSettings();
            SupplierList();
        }

        private void ComboSupplierList()
        {
            comboSupplier.DisplayMember = ComboBoxMember.SupplierName;
            comboSupplier.ValueMember = ComboBoxMember.ID;

            comboSupplier.DataSource = supplierManager.GetAllComboBox();
        }
        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 9;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.CompanyName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.ContactName;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.PhoneNumber;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.Adress;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[7].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[8].HeaderText = ColumnHeaders.CreatedUserId;
        }

        private void SupplierList()
        {
            var getSupplier = supplierManager.GetAll();
            if (getSupplier != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getSupplier)
                {
                    dataGridView1.Rows.Add(item.ID, item.CompanyName, item.ContactName, item.PhoneNumber, item.Adress, item.IsActive, item.CreatedDate, item.UpdatedDate, appUserManager.GetById(item.CreatedUserId).UserName);
                }
            }
        }

        private void comboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getSupplier = supplierManager.GetById((int)comboSupplier.SelectedValue);
            if (getSupplier != null)
            {
                lblID.Text = getSupplier.ID.ToString();
                txtCompanyName.Text = getSupplier.CompanyName;
                txtContactName.Text = getSupplier.ContactName;
                txtPhoneNumber.Text = getSupplier.PhoneNumber.ToString();
                txtAdress.Text = getSupplier.Adress;
                checkStatu.Checked = (bool)getSupplier.IsActive;
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DgwClick();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwClick();
            bttnDelete_Click(sender, e);
        }

        private void DgwClick()
        {
            comboSupplier.SelectedValue = dataGridView1.SelectedCells[0].Value;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCompanyName.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtAdress.Text))
            {
                if (!supplierManager.GetByNameBool(txtCompanyName.Text))
                {
                    supplierManager.Add(new Entities.Entity.Supplier
                    {
                        CompanyName = txtCompanyName.Text,
                        ContactName = txtContactName.Text,
                        PhoneNumber = char.Parse(txtPhoneNumber.Text),
                        Adress = txtAdress.Text,
                        CreatedUserId = MainForm.userId
                    });
                }
                else
                {
                    MessageBox.Show(Messages.SupplierNameError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
