using Assignemtn2_SaleManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemtn2_SaleManagement.View
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            FStoreContext context = new FStoreContext();
            LoadDataForDGV();

            cboOrderID.DisplayMember = "OrderId";
            cboOrderID.ValueMember = "OrderId";
            cboOrderID.DataSource = context.OrderDetails.ToList();

            cboProduct.DisplayMember = "ProductName";
            cboProduct.ValueMember = "ProductId";
            cboProduct.DataSource = context.Products.ToList();




        }

        private void LoadDataForDGV()
        {
            using(FStoreContext context = new FStoreContext())
            {
                var orders = context.Orders;
                var products = context.Products;
                var details = context.OrderDetails;

                var Records = (from o in orders
                               join d in details on o.OrderId equals d.OrderId
                               join p in products on d.ProductId equals p.ProductId
                               select new
                               {
                                   OrderID = d.OrderId,
                                   ProductID = p.ProductId,
                                   ProductName = p.ProductName,
                                   UnitPrice = d.UnitPrice,
                                   Quantity = d.Quantity,
                                   Discount = d.Discount
                               }).ToList();
                detailsGridView.DataSource = Records;
            }
        }

        private void detailsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = detailsGridView.SelectedRows[0];
            cboOrderID.SelectedValue = Convert.ToInt32(row.Cells[0].Value.ToString());
            cboProduct.SelectedValue = Convert.ToInt32(row.Cells[1].Value.ToString());
            maskUnitPrice.Text = row.Cells[3].Value.ToString();
            maskQuantity.Text = row.Cells[4].Value.ToString();
            maskDiscount.Text = row.Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this order detail?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int OrderID = Convert.ToInt32(detailsGridView.SelectedRows[0].Cells[0].Value);
                using (FStoreContext context = new FStoreContext())
                {
                    OrderDetail detail = context.OrderDetails.First(x => x.OrderId == OrderID);
                    
                    context.OrderDetails.Remove(detail);
                    context.SaveChanges();
                    LoadDataForDGV();
                }
            }
        }

        private void bntInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure insert a new order detail?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OrderDetail detail = new OrderDetail();
                detail.OrderId = Convert.ToInt32(cboOrderID.SelectedValue);
                detail.ProductId = Convert.ToInt32(cboProduct.SelectedValue);
                detail.Quantity = Convert.ToInt32(maskQuantity.Text);
                detail.UnitPrice = Convert.ToDecimal(maskUnitPrice.Text);
                detail.Discount = Convert.ToDouble(maskDiscount.Text);
                
                using (FStoreContext context = new FStoreContext())
                {
                    context.OrderDetails.Add(detail);
                    context.SaveChanges();

                }
                LoadDataForDGV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to update this Order detail?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (detailsGridView.CurrentRow.Index != -1)
                {
                    int orderID = Convert.ToInt32(detailsGridView.CurrentRow.Cells[0].Value);
                    int productId = Convert.ToInt32(detailsGridView.CurrentRow.Cells[1].Value);
                    using (FStoreContext context = new FStoreContext())
                    {
                        OrderDetail detail = context.OrderDetails.First(x => x.OrderId == orderID && x.ProductId == productId);
                        
                        detail.Quantity = Convert.ToInt32(maskQuantity.Text);
                        detail.UnitPrice = Convert.ToDecimal(maskUnitPrice.Text);
                        detail.Discount = Convert.ToDouble(maskDiscount.Text);
                        context.SaveChanges();
                    }
                    LoadDataForDGV();
                }



            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboOrderID.Text = string.Empty;
            cboProduct.Text = string.Empty;
            maskDiscount.Text = string.Empty;
            maskQuantity.Text = string.Empty;
            maskUnitPrice.Text = string.Empty;

        }
    }
}
