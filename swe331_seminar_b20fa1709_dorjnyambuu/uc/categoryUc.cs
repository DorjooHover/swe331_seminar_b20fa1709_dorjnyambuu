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
    public partial class categoryUc : UserControl
    {
        public categoryUc()
        {
            InitializeComponent();
        }

        private void categoryUc_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {

            DataTable dt = GlobalVar.getData("select * from Categories");
            category.DataSource = dt;
            category.Columns[0].Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (category.SelectedCells.Count > 0)
            {

                bool res = GlobalVar.delete("delete from Categories where CategoryId = " + category.SelectedCells[0].Value.ToString());

                if (res)
                {
                    getData();
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            category_update product_Update = new category_update(0);
            product_Update.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (category.SelectedCells.Count > 0)
            {
                category_update category_update = new category_update(Int32.Parse(category.SelectedCells[0].Value.ToString()));
                category_update.ShowDialog();
            }
        }
    }
}
