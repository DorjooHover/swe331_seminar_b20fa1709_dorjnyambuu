using swe331_seminar_b20fa1709_dorjnyambuu.models;
using swe331_seminar_b20fa1709_dorjnyambuu.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swe331_seminar_b20fa1709_dorjnyambuu.src
{
    public partial class Home : Form
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        public Home(User user)
        {
            InitializeComponent();
            userRegister userRegister = new userRegister(user);
            main.Controls.Add(userRegister);
            if(user.UserName != "")
            {
                this._user = user;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "product")
            {
                productUc productUc = new productUc();
                main.Controls.Clear();
                main.Controls.Add(productUc);
            }
            if (treeView1.SelectedNode.Name == "category")
            {
                categoryUc categoryUc = new categoryUc();
                main.Controls.Clear();
                main.Controls.Add(categoryUc);
            }
            if (treeView1.SelectedNode.Name == "employee")
            {
                employeeUc employeeUc = new employeeUc();
                main.Controls.Clear();
                main.Controls.Add(employeeUc);
            }
            if (treeView1.SelectedNode.Name == "suppliers")
            {
                supplierUc supplierUc = new supplierUc();
                main.Controls.Clear();
                main.Controls.Add(supplierUc);
            }
            if (treeView1.SelectedNode.Name == "order")
            {
                orderUc orderUc = new orderUc();
                main.Controls.Clear();
                main.Controls.Add(orderUc);
            }
            if (treeView1.SelectedNode.Name == "customer")
            {
                customerUc customerUc = new customerUc();
                main.Controls.Clear();
                main.Controls.Add(customerUc);
            }
            if (treeView1.SelectedNode.Name == "user")
            {
                main.Controls.Clear();
                userRegister userRegister = new userRegister(this._user);
                main.Controls.Add(userRegister);
            }
        }
    }
}
