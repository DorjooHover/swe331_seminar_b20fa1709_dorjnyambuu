using swe331_seminar_b20fa1709_dorjnyambuu.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swe331_seminar_b20fa1709_dorjnyambuu.src
{
    public partial class order_update : Form
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public order_update(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        public void getData()
        {
            orderUc orderUc = new orderUc();
            Home home = new Home(new models.User());
            home.Controls.Clear();
            home.Controls.Add(orderUc);
            this.Close();

        }
        private void cancel_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", this._id));
            param.Add(new SqlParameter("@cus", (customer.SelectedItem as dynamic).Text));
            param.Add(new SqlParameter("@emp", (employee.SelectedItem as dynamic).Text));
            bool res = GlobalVar.exec("updateOrder", param);
            if (res)
            {

                getData();

            }
        }

        private void order_update_Load(object sender, EventArgs e)
        {
            DataTable dt = GlobalVar.getData("select EmployeeID, LastName, CustomerID, CompanyName from Employees, Customers");
            if (dt.Rows.Count > 0)
            {
                customer.DisplayMember = "Value";
                customer.ValueMember = "Text";
                employee.DisplayMember = "Value";
                employee.ValueMember = "Text";
                foreach (DataRow dr in dt.Rows)
                {
                    if (!customer.Items.Contains(new { Text = dr[0], Value = dr[1] }))
                    {
                        customer.Items.Add(new { Text = dr[0], Value = dr[1] });
                    }
                    if (!employee.Items.Contains(new { Text = dr[2], Value = dr[3] }))
                    {
                        employee.Items.Add(new { Text = dr[2], Value = dr[3] });
                    }
                }
            }
            if (this._id != 0)
            {
                DataTable order = GlobalVar.getData("select OrderID ,  LastName,  CompanyName from Orders o\r\ninner join Employees e on e.EmployeeID = o.EmployeeID\r\ninner join Customers c  on c.CustomerID = o.CustomerID\r\nwhere OrderID = " + this._id);
                if (order.Rows.Count > 0)
                {
                    
                    employee.Text = order.Rows[0][1].ToString();
                    customer.Text = order.Rows[0][2].ToString();
                    
                }
            }
        }
    }
}
