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
    public partial class employee_update : Form
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public employee_update(int id)
        {
            InitializeComponent();
            this._id = id;
        }
        public void getData()
        {
            employeeUc employeeUc = new employeeUc();
            Home home = new Home(new models.User());
            home.Controls.Clear();
            home.Controls.Add(employeeUc);
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void employee_update_Load(object sender, EventArgs e)
        {
            if (this._id != 0)
            {
                DataTable employee = GlobalVar.getData("select EmployeeId, FirstName, LastName from Employees where EmployeeId = " + this._id);
                {
                    firstname.Text = employee.Rows[0][1].ToString();
                    lastname.Text = employee.Rows[0][2].ToString();
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", this._id));
            param.Add(new SqlParameter("@lastname", firstname.Text));
            param.Add(new SqlParameter("@firstname", lastname.Text));

            bool res = GlobalVar.exec("updateEmployee", param);
            if (res)
            {

                getData();

            }
        }
    }
}
