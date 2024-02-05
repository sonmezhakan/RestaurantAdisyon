using Microsoft.Extensions.DependencyInjection;
using RA.Business.Constants;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Repositories.Concretes;


namespace RA.WinFormUI
{
    public partial class SupplierForm : Form
    {
        private readonly IAppUserService _appUserService;
        private readonly ISupplierService _supplierService;
        public SupplierForm(IServiceProvider serviceProvider)
        {
            _appUserService = serviceProvider.GetRequiredService<IAppUserService>();
            _supplierService = serviceProvider.GetRequiredService<ISupplierService>();
            InitializeComponent();
        }

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

            comboSupplier.DataSource = _supplierService.GetAllComboBox();
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
            var getSupplier = _supplierService.GetAll();
            if (getSupplier != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getSupplier)
                {
                    dataGridView1.Rows.Add(item.ID, item.CompanyName, item.ContactName, item.PhoneNumber, item.Adress, item.IsActive, item.CreatedDate, item.UpdatedDate, _appUserService.GetById(item.CreatedUserId).UserName);
                }
            }
        }

        private void comboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            var getSupplier = _supplierService.GetById((int)comboSupplier.SelectedValue);
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
                if (!_supplierService.GetByNameBool(txtCompanyName.Text))
                {
                    _supplierService.Add(new Entities.Entity.Supplier
                    {
                        CompanyName = txtCompanyName.Text,
                        ContactName = txtContactName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Adress = txtAdress.Text,
                        UpdatedDate = DateTime.Now,
                        CreatedUserId = MainForm.userId,
                        IsActive = checkStatu.Checked
                    });
                    ComboSupplierList();
                    SupplierList();
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
            var getSupplier = _supplierService.GetById((int)comboSupplier.SelectedValue);
            if(getSupplier != null)
            {
                if (!string.IsNullOrEmpty(txtCompanyName.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text) && !string.IsNullOrEmpty(txtAdress.Text))
                {
                    if (getSupplier.CompanyName == txtCompanyName.Text || _supplierService.GetByName(txtCompanyName.Text) == null)
                    {
                        getSupplier.CompanyName = txtCompanyName.Text;
                        getSupplier.ContactName = txtContactName.Text;
                        getSupplier.PhoneNumber = txtPhoneNumber.Text;
                        getSupplier.Adress = txtAdress.Text;
                        getSupplier.IsActive = checkStatu.Checked;
                        _supplierService.Update(getSupplier);
                        ComboSupplierList();
                        SupplierList();
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
            else
            { MessageBox.Show(Messages.NotNull); }

            
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            var getSupplier = _supplierService.GetById((int)comboSupplier.SelectedValue);
            if(getSupplier != null)
            {
                _supplierService.Delete(getSupplier.ID);
                ComboSupplierList();
                SupplierList();
            }
            else
            {
                MessageBox.Show(Messages.NotNull);
            }
        }
    }
}
