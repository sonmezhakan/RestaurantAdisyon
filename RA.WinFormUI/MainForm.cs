using Microsoft.Extensions.DependencyInjection;
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
    public partial class MainForm : Form
    {
        private readonly IProductService _productService;
        private readonly ITableService _tableService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _productService = serviceProvider.GetRequiredService<IProductService>();
            _tableService = serviceProvider.GetRequiredService<ITableService>();
            _orderService = serviceProvider.GetRequiredService<IOrderService>();
            _orderDetailService = serviceProvider.GetRequiredService<IOrderDetailService>();
            InitializeComponent();
        }
        public static int userId;

        int tableId = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProductList();
            TableList();
            DgwSettings();
        }

        private void ProductList()
        {
            int widht = 100;
            int height = 75;
            int locX = 15;
            int locY = 19;
            int k = 0;
            var getProduct = _productService.GetAll();
            Button[] buttonArray = new Button[getProduct.Count()];

            for (int i = 1; i <= getProduct.Count(); i++)
            {
                k = i - 1;
                buttonArray[k] = new Button();
                buttonArray[k].Name = getProduct[k].ID.ToString();
                buttonArray[k].Text = getProduct[k].ProductName + "\n" + Math.Round(getProduct[k].UnitPrice, 2) + " ₺";
                buttonArray[k].Size = new Size(widht, height);
                buttonArray[k].Location = new Point(locX, locY);
                buttonArray[k].Click += new EventHandler(this.ButtonArray_click);

                if (getProduct[k].IsActive == true && getProduct[k].UnitsInStock > 0)
                {
                    buttonArray[k].BackColor = Color.Green;
                    buttonArray[k].Enabled = true;
                }
                else
                {
                    buttonArray[k].BackColor = Color.Red;
                    buttonArray[k].Enabled = false;
                }


                locX += widht + 5;

                if (i % 6 == 0)
                {
                    locX = 15;
                    locY += height + 5;
                }
                this.panelRight.Controls.Add(buttonArray[k]);
            }
        }

        private void ButtonArray_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (_tableService.GetById(tableId) != null)
            {
                Order getTable = _orderService.GetByTableId(tableId, true);
                if (getTable != null)
                {
                    List<OrderDetail> orderDetail = _orderDetailService.GetByOrderIdList(getTable.ID);
                    var getOrderDetail = orderDetail.FirstOrDefault(x => x.ProductID == int.Parse(button.Name));
                    if (getOrderDetail != null)
                    {
                        OrderDetailUpdate(getOrderDetail);
                    }
                    else
                    {
                        OrderDetailAdd(getTable, _productService.GetById(int.Parse(button.Name)));
                    }
                    ProductStockRemoveUpdate(_productService.GetById(int.Parse(button.Name)), 1);
                    OrderList(tableId);
                    ProductList();
                    bttnRefresh_Click(sender, e);
                }
                else
                {
                    OrderAdd();

                    ButtonArray_click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(Messages.TableNotNull);
            }

        }
        private void OrderAdd()
        {
            _orderService.Add(new Order
            {
                TableId = tableId,
                OrderDate = DateTime.Now,
                IsActive = true,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedUserId = userId,
            });
        }

        private void OrderDetailAdd(Order order, Product product)
        {
            _orderDetailService.Add(new OrderDetail
            {
                OrderID = order.ID,
                ProductID = product.ID,
                UnitPrice = Math.Round(product.UnitPrice, 2),
                Quantity = 1,
                Discount = 0,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                CreatedUserId = userId
            });
        }
        private void OrderDetailUpdate(OrderDetail orderDetail)
        {
            orderDetail.Quantity += 1;
            orderDetail.UpdatedDate = DateTime.Now;
            _orderDetailService.Update(orderDetail);
        }

        private void TableList()
        {
            int widht = 100;
            int height = 75;
            int locX = 11;
            int locY = 19;

            var getTable = _tableService.GetAll();
            Button[] buttonTableArray = new Button[getTable.Count()];

            for (int i = 1; i <= getTable.Count(); i++)
            {
                int k = i - 1;

                buttonTableArray[k] = new Button();
                buttonTableArray[k].Name = getTable[k].ID.ToString();
                buttonTableArray[k].Text = getTable[k].TableName;
                buttonTableArray[k].Size = new Size(widht, height);
                buttonTableArray[k].Location = new Point(locX, locY);
                buttonTableArray[k].Click += new EventHandler(this.ButtonTableArray_click);

                if (getTable[k].IsActive == true)
                {
                    buttonTableArray[k].BackColor = Color.Green;
                }
                else
                {
                    buttonTableArray[k].BackColor = Color.Red;
                    buttonTableArray[k].Enabled = false;
                }

                locX += widht + 5;

                if (i % 6 == 0)
                {
                    locX = 11;
                    locY += height + 5;
                }

                this.panelMid.Controls.Add(buttonTableArray[k]);
            }
        }
        private void ButtonTableArray_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            tableId = int.Parse(button.Name);

            lblTableName.Text = button.Text;
            OrderList(tableId);
        }

        private void OrderList(int tableId)
        {
            var resultOrder = _orderService.GetByTableId(tableId, true);
            decimal totalPrice = 0;
            if (resultOrder != null && _orderDetailService.GetByOrderIdList(resultOrder.ID) != null)
            {
                totalPrice = 0;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                foreach (var item in _orderDetailService.GetByOrderIdList(resultOrder.ID))
                {
                    dataGridView1.Rows.Add(item.OrderID, _productService.GetById(item.ProductID).ProductName, item.Quantity, Math.Round(item.UnitPrice, 2));
                    totalPrice += Math.Round(item.Quantity * item.UnitPrice, 2);
                }
                lblTotalPrice.Text = Math.Round(totalPrice, 2).ToString();
            }
            else
            {
                totalPrice = 0;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                lblTotalPrice.Text = Math.Round(totalPrice, 2).ToString();
            }
        }
        private void DgwSettings()
        {
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = ColumnHeaders.OrderID;
            dataGridView1.Columns[1].HeaderText = ColumnHeaders.ProductName;
            dataGridView1.Columns[2].HeaderText = ColumnHeaders.Quantity;
            dataGridView1.Columns[3].HeaderText = ColumnHeaders.UnitPrice;
        }

        private void ProductStockRemoveUpdate(Product product, int quantity)
        {
            product.UnitsInStock -= quantity;
            _productService.Update(product);
        }
        private void ProductStockAddUpdate(Product product, int quantity)
        {
            product.UnitsInStock += quantity;
            _productService.Update(product);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getOrderDetail = _orderDetailService.GetByOrderIdList((int)dataGridView1.SelectedCells[0].Value);
            var getProduct = _productService.GetByName(dataGridView1.SelectedCells[1].Value.ToString());

            _orderDetailService.Delete(_orderDetailService.GetByOrderAndProductId((int)dataGridView1.SelectedCells[0].Value, getProduct.ID).ID);

            ProductStockAddUpdate(getProduct, int.Parse(dataGridView1.SelectedCells[2].Value.ToString()));
            OrderList(tableId);
            ProductList();
        }

        private void toolStripButtonCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm(_serviceProvider);
            category.Show();
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm(_serviceProvider);
            product.Show();
        }

        private void toolStripButtonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm(_serviceProvider);
            employee.Show();
        }

        private void toolStripButtonTable_Click(object sender, EventArgs e)
        {
            TableForm table = new TableForm(_serviceProvider);
            table.Show();
        }

        private void bttnPayment_Click(object sender, EventArgs e)
        {

            PaymentForm paymentForm = new PaymentForm(_serviceProvider);
            PaymentForm.totalPrice = Math.Round(decimal.Parse(lblTotalPrice.Text), 2);
            PaymentForm.getOrder = _orderService.GetByTableId(tableId, true);
            paymentForm.ShowDialog();
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            AppUserForm appUserForm = new AppUserForm(_serviceProvider);
            appUserForm.Show();
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(_serviceProvider);
            orderForm.Show();
        }

        private void toolStripButtonStock_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm(_serviceProvider);
            stockForm.Show();
        }

        private void toolStripButtonSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(_serviceProvider);
            supplierForm.Show();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            panelMid.Controls.Clear();
            ProductList();
            TableList();
        }
    }
}
