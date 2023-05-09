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
    public partial class supplier_update : Form
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public supplier_update(int id)
        {
            InitializeComponent();
            this._id = id;
        }
        public void getData()
        {
            supplierUc customerUc = new supplierUc();
            Home home = new Home(new models.User());
            home.Controls.Clear();
            home.Controls.Add(customerUc);
            this.Close();

        }

        private void save_Click(object sender, EventArgs e)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", this._id));
            param.Add(new SqlParameter("@name", name.Text));

            bool res = GlobalVar.exec("updateSupplier", param);
            if (res)
            {
                getData();

            }
        }

        private void supplier_update_Load(object sender, EventArgs e)
        {
            if (this._id != 0)
            {
                DataTable supplier = GlobalVar.getData("select SupplierID, CompanyName from Suppliers where SupplierID = " + this._id);
                {
                    name.Text = supplier.Rows[0][1].ToString();

                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}
