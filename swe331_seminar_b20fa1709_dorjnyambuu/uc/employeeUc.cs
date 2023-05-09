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
    public partial class employeeUc : UserControl
    {
        public employeeUc()
        {
            InitializeComponent();
        }
        public void getData()
        {

            DataTable dt = GlobalVar.getData("select EmployeeID, FirstName, LastName from Employees");
            employee.DataSource= dt;
            employee.Columns[0].Visible = false;
        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (employee.SelectedCells.Count > 0)
            {
                employee_update employee_update = new employee_update(Int32.Parse(employee.SelectedCells[0].Value.ToString()));
                employee_update.ShowDialog();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            employee_update employee_update = new employee_update(0);
            employee_update.ShowDialog();
        }

        private void employeeUc_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
