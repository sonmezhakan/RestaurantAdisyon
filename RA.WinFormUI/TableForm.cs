using RA.Business.Concrete;
using RA.Business.Constants;
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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }
        TableManager tableRepository = new TableManager();
        AppUserManager appUserRepository = new AppUserManager();
        private void TableForm_Load(object sender, EventArgs e)
        {
            ComboTableList();
            DgwSettings();
            GetList();
        }
        private void ComboTableList()
        {
            comboTable.DisplayMember = ComboBoxMember.TableName;
            comboTable.ValueMember = ComboBoxMember.ID;

            comboTable.DataSource = tableRepository.GetAllComboBox();
        }

        private void comboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getTable = tableRepository.GetById((int)comboTable.SelectedValue);
            if (getTable != null)
            {
                lblID.Text = getTable.ID.ToString();
                txtTableName.Text = getTable.TableName;
                txtDescription.Text = getTable.Description;
                checkStatu.Checked = (bool)getTable.IsActive;
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void GetList()
        {
            var tableList = tableRepository.GetAll();
            if (tableList != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in tableList)
                {
                    dataGridView1.Rows.Add(item.ID, item.TableName, item.Description, item.IsActive, item.CreatedDate, item.UpdatedDate,
                        appUserRepository.GetById(item.CreatedUserId).UserName);
                }
            }
        }

        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.TableName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.Description;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.CreatedUserId;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTableName.Text))
            {
                if (tableRepository.GetByTableName(txtTableName.Text) != true)
                {
                    tableRepository.Add(new Entities.Entity.Table
                    {
                        TableName = txtTableName.Text,
                        Description = txtDescription.Text,
                        IsActive = checkStatu.Checked,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        CreatedUserId = MainForm.userId
                    });
                    ComboTableList();
                    GetList();
                }
                else
                {
                    MessageBox.Show(Messages.TableNameError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getTable = tableRepository.GetById((int)comboTable.SelectedValue);
            if (getTable != null && !string.IsNullOrEmpty(txtTableName.Text))
            {
                if (getTable.TableName == txtTableName.Text || tableRepository.GetByTableName(txtTableName.Text) != true)
                {
                    getTable.TableName = txtTableName.Text;
                    getTable.Description = txtDescription.Text;
                    getTable.IsActive = checkStatu.Checked;
                    getTable.UpdatedDate = DateTime.Now;

                    tableRepository.Update(getTable);
                    ComboTableList();
                    GetList();
                }
                else
                {
                    MessageBox.Show(Messages.TableNameError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            var getTable = tableRepository.GetById((int)comboTable.SelectedValue).ID;
            if (getTable != null)
            {
                tableRepository.Delete(getTable);
                ComboTableList();
                GetList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }
        private void DgwClick()
        {
            comboTable.SelectedValue = dataGridView1.SelectedCells[0].Value;
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

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetList();
        }

    }
}
