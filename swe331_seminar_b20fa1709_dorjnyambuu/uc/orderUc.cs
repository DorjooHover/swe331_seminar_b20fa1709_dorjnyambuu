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
    public partial class orderUc : UserControl
    {
        public orderUc()
        {
            InitializeComponent();
        }

        private void orderUc_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {

            DataTable dt = GlobalVar.getData("select o.OrderID, e.LastName, c.CompanyName from orders o\r\ninner join Customers c on c.CustomerID = o.CustomerID\r\ninner join Employees e on e.EmployeeID = o.EmployeeID\r\n");
            order.DataSource = dt;
            order.Columns[0].Visible = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (order.SelectedCells.Count > 0)
            {
                order_update order_update = new order_update(Int32.Parse(order.SelectedCells[0].Value.ToString()));
                order_update.ShowDialog();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            order_update order_update = new order_update(0);
            order_update.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (order.SelectedCells.Count > 0)
            {

                bool res = GlobalVar.delete("delete from [Order Details] where OrderID = " + order.SelectedCells[0].Value.ToString() + " delete from Orders where OrderID = " + order.SelectedCells[0].Value.ToString());

                if (res)
                {
                    getData();
                }
            }
        }
    }
}
