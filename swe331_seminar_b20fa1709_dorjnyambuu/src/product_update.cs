using swe331_seminar_b20fa1709_dorjnyambuu.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swe331_seminar_b20fa1709_dorjnyambuu.src
{
    public partial class product_update : Form
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value;}
        }
        public product_update(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        public void getData()
        {
            productUc productUc = new productUc();
            Home home = new Home(new models.User());
            home.Controls.Clear();
            home.Controls.Add(productUc);
            this.Close();
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            getData();
        }

        private void product_update_Load(object sender, EventArgs e)
        {
            DataTable dt = GlobalVar.getData("select CategoryId, CategoryName, SupplierID, CompanyName from Categories, Suppliers");
            if(dt.Rows.Count > 0 )
            {
                categoryName.DisplayMember = "Value";
                categoryName.ValueMember = "Text"; 
                supplierName.DisplayMember = "Value";
                supplierName.ValueMember = "Text";
                foreach(DataRow dr in dt.Rows)
                {
                    if(!categoryName.Items.Contains(new { Text = dr[0], Value = dr[1] }))
                    {
                        categoryName.Items.Add(new { Text = dr[0], Value = dr[1] });
                    }
                    if (!supplierName.Items.Contains(new { Text = dr[2], Value = dr[3] }))
                    {
                        supplierName.Items.Add(new { Text = dr[2], Value = dr[3] });
                    }
                }
            }
            if(this._id != 0)
            {
                DataTable product = GlobalVar.getData("select  p.ProductID , p.ProductName,  s.CompanyName, c.CategoryName, p.QuantityPerUnit, p.UnitPrice from products p\r\ninner join Suppliers s on s.SupplierID = p.SupplierID\r\ninner join Categories c on c.CategoryID = p.CategoryID\r\nwhere ProductID = " + this._id);
                if(product.Rows.Count > 0 )
                {
                    productName.Text = product.Rows[0][1].ToString();
                    supplierName.Text = product.Rows[0][2].ToString();
                    categoryName.Text = product.Rows[0][3].ToString();
                    perUnit.Text = product.Rows[0][4].ToString();
                    unitprice.Text = product.Rows[0][5].ToString();
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
           
            List<SqlParameter> param = new List<SqlParameter>();
            param.Add(new SqlParameter("@id", this._id));
            param.Add(new SqlParameter("@cateId", (categoryName.SelectedItem as dynamic).Text));
            param.Add(new SqlParameter("@suppId", (supplierName.SelectedItem as dynamic).Text));
            param.Add(new SqlParameter("@name", productName.Text));
            param.Add(new SqlParameter("@unit", perUnit.Text));
            param.Add(new SqlParameter("@price", unitprice.Text));
            bool res = GlobalVar.exec("updateProduct", param);
            if(res)
            {
               
                getData();
                
            } 
        }
    }
}
