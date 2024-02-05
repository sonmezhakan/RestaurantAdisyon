using Microsoft.Extensions.DependencyInjection;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Concrete;
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
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeForm(IServiceProvider serviceProvider)
        {
            _employeeService = serviceProvider.GetRequiredService<IEmployeeService>();
            InitializeComponent();

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ComboEmployeeFirstNameList();
            DgwSettings();
            GetList();
        }
        private void ComboEmployeeFirstNameList()
        {
            comboEmployeeFirstName.DisplayMember = ComboBoxMember.FirstName;
            comboEmployeeFirstName.ValueMember = ComboBoxMember.ID;

            comboEmployeeFirstName.DataSource = _employeeService.GetByAllComboBox();
        }

        private void comboEmployeeFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEmployeeLastName.DisplayMember = ComboBoxMember.LastName;
            comboEmployeeLastName.ValueMember = ComboBoxMember.ID;

            comboEmployeeLastName.DataSource = _employeeService.GetByFirstName(comboEmployeeFirstName.Text);
        }

        private void comboEmployeeLastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEmployeeFirstName.SelectedValue.ToString() == comboEmployeeLastName.SelectedValue.ToString())
            {
                var getEmployee = _employeeService.GetById((int)comboEmployeeLastName.SelectedValue);
                if (getEmployee != null)
                {
                    lblID.Text = getEmployee.ID.ToString();
                    txtFirstName.Text = getEmployee.FirstName;
                    txtLastName.Text = getEmployee.LastName;
                    txtEmail.Text = getEmployee.Email;
                    txtAdres.Text = getEmployee.Adress;
                    txtPhoneNumber.Text = getEmployee.PhoneNumber;
                    checkStatu.Checked = (bool)getEmployee.IsActive;
                }
            }
        }
        private void GetList()
        {
            var employeeList = _employeeService.GetAll();
            if (employeeList != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in employeeList)
                {
                    dataGridView1.Rows.Add(item.ID, item.FirstName, item.LastName, item.Email, item.PhoneNumber, item.Adress, item.IsActive,
                        item.CreatedDate, item.UpdatedDate);
                }
            }
        }

        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 9;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.FistName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.LastName;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.Email;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.PhoneNumber;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.Adress;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[7].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[8].HeaderText = ColumnHeaders.UpdatedDate;
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) || !string.IsNullOrEmpty(txtLastName.Text) || !string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                if (_employeeService.GetByEmail(txtEmail.Text) == false)
                {
                    _employeeService.Add(new Entities.Entity.Employee
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Adress = txtAdres.Text,
                        IsActive = checkStatu.Checked,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                    });
                    ComboEmployeeFirstNameList();
                    GetList();
                }
                else
                {
                    MessageBox.Show(Messages.EmailError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            var getEmployee = _employeeService.GetById((int)comboEmployeeLastName.SelectedValue);
            if (getEmployee != null && !string.IsNullOrEmpty(txtFirstName.Text) || !string.IsNullOrEmpty(txtLastName.Text) || !string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                if (getEmployee.Email == txtEmail.Text || _employeeService.GetByEmail(txtEmail.Text) != true)
                {
                    getEmployee.FirstName = txtFirstName.Text;
                    getEmployee.LastName = txtLastName.Text;
                    getEmployee.Email = txtEmail.Text;
                    getEmployee.PhoneNumber = txtPhoneNumber.Text;
                    getEmployee.Adress = txtAdres.Text;
                    getEmployee.IsActive = checkStatu.Checked;
                    getEmployee.UpdatedDate = DateTime.Now;

                    _employeeService.Update(getEmployee);
                    ComboEmployeeFirstNameList();
                    GetList();
                }
                else
                {
                    MessageBox.Show(Messages.EmailError);
                }
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            var getEmployee = _employeeService.GetById((int)comboEmployeeLastName.SelectedValue);
            if (getEmployee != null)
            {
                _employeeService.Delete(getEmployee.ID);
                ComboEmployeeFirstNameList();
                GetList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }

        

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgwClick();
            bttnDelete_Click(sender, e);
        }
        private void DgwClick()
        {
            if (comboEmployeeFirstName.SelectedValue.ToString() == comboEmployeeLastName.SelectedValue.ToString())
            {
                comboEmployeeFirstName.SelectedValue = dataGridView1.SelectedCells[0].Value;
                comboEmployeeLastName.SelectedValue = dataGridView1.SelectedCells[0].Value;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DgwClick();
        }
    }
}
