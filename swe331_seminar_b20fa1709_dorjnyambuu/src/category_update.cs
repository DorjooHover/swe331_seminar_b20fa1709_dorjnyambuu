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
    public partial class category_update : Form
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public category_update(int id)
        {
            InitializeComponent();
            this._id = id;
        }
        public void getData()
        {
            categoryUc categoryUc = new categoryUc();
            Home home = new Home(new models.User());
            home.Controls.Clear();
            home.Controls.Add(categoryUc);
            this.Close();
        }

        private void category_update_Load(object sender, EventArgs e)
        {
            
            if (this._id != 0)
            {
                DataTable category = GlobalVar.getData("select * from Categories where CategoryId = " + this._id);
                if (category.Rows.Count > 0)
                {
                    categoryName.Text = category.Rows[0][1].ToString();
                    desc.Text = category.Rows[0][2].ToString();
                   
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", this._id));
            param.Add(new SqlParameter("@cateId", categoryName.Text));
            param.Add(new SqlParameter("@desc", desc.Text));

            bool res = GlobalVar.exec("updateCategory", param);
            if (res)
            {

                getData();

            }
        }
    }
}
