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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Visible = true;

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmDetails details = new frmDetails();
            details.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Visible = true;
        }
    }
}
