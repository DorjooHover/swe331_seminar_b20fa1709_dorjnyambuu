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
    public partial class supplierUc : UserControl
    {
        public supplierUc()
        {
            InitializeComponent();
        }

        private void supplierUc_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {

            DataTable dt = GlobalVar.getData("select SupplierID, CompanyName from Suppliers");
            supplier.DataSource = dt;
            supplier.Columns[0].Visible = false;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (supplier.SelectedCells.Count > 0)
            {
                supplier_update supplier_update = new supplier_update(Int32.Parse(supplier.SelectedCells[0].Value.ToString()));
                supplier_update.ShowDialog();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            supplier_update supplier_update = new supplier_update(0);
            supplier_update.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (supplier.SelectedCells.Count > 0)
            {

                bool res = GlobalVar.delete("delete from Suppliers where SupplierId = " + supplier.SelectedCells[0].Value.ToString());

                if (res)
                {
                    getData();
                }
            }
        }
    }
}
