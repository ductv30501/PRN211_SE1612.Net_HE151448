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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            using (FStoreContext context = new FStoreContext())
            {
                productGridView.DataSource = context.Products.ToList();
            }
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = productGridView.SelectedRows[0];
            txtProductId.Text = row.Cells[0].Value.ToString();
            txtProductName.Text = row.Cells[2].Value.ToString();
            txtCategoryId.Text = row.Cells[1].Value.ToString();
            txtUnit.Text = row.Cells[5].Value.ToString();
            txtWeight.Text = row.Cells[3].Value.ToString();
            txtUnitPrice.Text = row.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(productGridView.SelectedRows[0].Cells[0].Value);
                using (FStoreContext context = new FStoreContext())
                {
                    Product p = context.Products.First(x => x.ProductId == productId);
                    List<OrderDetail> details = context.OrderDetails.Where(x => x.ProductId == productId).ToList();
                    context.OrderDetails.RemoveRange(details);
                    context.Remove(p);
                    context.SaveChanges();
                    LoadDataForDGV();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure insert a new product?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product o = new Product();
                o.ProductId = Convert.ToInt32(txtProductId.Text);
                o.ProductName = txtProductName.Text;
                //MessageBox.Show(cbMember.ValueMember);
                o.CategoryId = Convert.ToInt32(txtCategoryId.Text);
                o.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                o.Weight = txtWeight.Text;
                o.UnitsInStock = Convert.ToInt32(txtUnit.Text);

                using (FStoreContext context = new FStoreContext())
                {
                    context.Products.Add(o);
                    context.SaveChanges();

                }
                LoadDataForDGV();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to update this Product?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (productGridView.CurrentRow.Index != -1)
                {
                    int productId = Convert.ToInt32(productGridView.CurrentRow.Cells[0].Value);
                    using (FStoreContext context = new FStoreContext())
                    {
                        Product p = context.Products.First(x => x.ProductId == productId);
                        //p.ProductId = Convert.ToInt32(txtProductId.Text);
                        p.CategoryId = Convert.ToInt32(txtCategoryId.Text);
                        //MessageBox.Show(cbMember.ValueMember);
                        p.ProductName = txtProductName.Text;
                        p.UnitPrice = Convert.ToInt32(txtUnitPrice.Text.Replace(".",""));
                        p.UnitsInStock = Convert.ToInt32(txtUnit.Text);
                        p.Weight = txtWeight.Text;
                        context.SaveChanges();
                    }
                    LoadDataForDGV();
                }



            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtProductId.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }
    }
}
