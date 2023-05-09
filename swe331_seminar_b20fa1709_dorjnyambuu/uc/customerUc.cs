using swe331_seminar_b20fa1709_dorjnyambuu.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swe331_seminar_b20fa1709_dorjnyambuu.uc
{
    public partial class customerUc : UserControl
    {
        public customerUc()
        {
            InitializeComponent();
        }
        public void getData()
        {

            DataTable dt = GlobalVar.getData("select CustomerID, CompanyName from Customers");
            customer.DataSource = dt;
            customer.Columns[0].Visible = false;
        }

        private void customerUc_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (customer.SelectedCells.Count > 0)
            {
                customer_update customer_update = new customer_update(customer.SelectedCells[0].Value.ToString());
                customer_update.ShowDialog();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            customer_update customer_update = new customer_update("0");
            customer_update.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (customer.SelectedCells.Count > 0)
            {

                bool res = GlobalVar.delete("delete from Customers where CustomerId = " + customer.SelectedCells[0].Value.ToString());

                if (res)
                {
                    getData();
                }
            }
        }
    }
}
