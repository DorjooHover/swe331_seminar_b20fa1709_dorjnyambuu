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
    public partial class productUc : UserControl
    {
        public productUc()
        {
            InitializeComponent();

        }

        private void productUc_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
           
            DataTable dt = GlobalVar.getData("select  p.ProductID , p.ProductName,  s.CompanyName, c.CategoryName, p.QuantityPerUnit, p.UnitPrice from products p\r\n\r\ninner join Suppliers s on s.SupplierID = p.SupplierID\r\ninner join Categories c on c.CategoryID = p.CategoryID");
            product.DataSource = dt;
            product.Columns[0].Visible= false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            product_update product_Update = new product_update(0);
            product_Update.ShowDialog();
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
           if(product.SelectedCells.Count > 0)
            {
                product_update product_Update = new product_update(Int32.Parse(product.SelectedCells[0].Value.ToString()));
                product_Update.ShowDialog();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(product.SelectedCells.Count > 0)
            {
                
                bool res = GlobalVar.delete("delete [Order Details] where ProductID = " + product.SelectedCells[0].Value.ToString() + " delete Products where ProductID = " + product.SelectedCells[0].Value.ToString());
                
                if(res)
                {
                    getData();
                }
            }
        }
    }
}
