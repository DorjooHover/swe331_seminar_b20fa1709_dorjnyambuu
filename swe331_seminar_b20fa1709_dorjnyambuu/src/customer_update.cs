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
    public partial class customer_update : Form
    {
        private String _id;
        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public customer_update(String id)
        {
            InitializeComponent();
            this._id = id;
        }
        public void getData()
        {
            customerUc customerUc = new customerUc();
            Home home = new Home(new models.User());
            home.Controls.Clear();
            home.Controls.Add(customerUc);
            this.Close();

        }
        private void customer_update_Load(object sender, EventArgs e)
        {
            if (this._id != "0")
            {
                DataTable customer = GlobalVar.getData("select CustomerID, CompanyName from Customers where CustomerID = '" + this._id + "'");
                {
                    name.Text = customer.Rows[0][1].ToString();

                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this._id);
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", this._id));
            param.Add(new SqlParameter("@name", name.Text));

            bool res = GlobalVar.exec("updateCustomer", param);
            if (res)
            {

                getData();

            }
        }
    }
}
