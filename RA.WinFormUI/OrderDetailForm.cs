using RA.Business.Constants;
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
    public partial class OrderDetailForm : Form
    {
        public OrderDetailForm()
        {
            InitializeComponent();
        }

        public static int orderID = 0;

        OrderDetailManager orderDetailManager = new OrderDetailManager(new OrderDetailRepository());
        ProductManager productManager = new ProductManager(new ProductRepository());
        AppUserManager appUserManager = new AppUserManager(new AppUserRepository());

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            DgwSettings();
            OrderList();
        }
        private void OrderList()
        {
            if(orderID != null || orderID > 0)
            {
                OrderDetailList(orderDetailManager.GetByOrderIdList(orderID));
                orderID = 0;
            }
            else
            {
                OrderDetailList(orderDetailManager.GetAll());
                orderID = 0;
            }
        }
        private void OrderDetailList(List<OrderDetail> orderDetail)
        {
            var getOrderDetail = orderDetail;
            if (getOrderDetail != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in getOrderDetail)
                {
                    dataGridView1.Rows.Add(item.ID, item.OrderID, productManager.GetById(item.ProductID).ProductName, item.UnitPrice, item.Quantity, item.Discount, item.IsActive, item.CreatedDate, item.UpdatedDate, appUserManager.GetById(item.CreatedUserId).UserName);
                }
            }
        }
        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 10;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.ID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.OrderID;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.ProductName;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.UnitPrice;
            dataGridView1.Columns[4].HeaderText = ColumnHeaders.Quantity;
            dataGridView1.Columns[5].HeaderText = ColumnHeaders.Discount;
            dataGridView1.Columns[6].HeaderText = ColumnHeaders.IsActive;
            dataGridView1.Columns[7].HeaderText = ColumnHeaders.CreatedDate;
            dataGridView1.Columns[8].HeaderText = ColumnHeaders.UpdatedDate;
            dataGridView1.Columns[9].HeaderText = ColumnHeaders.UserName;
        }
    }
}
