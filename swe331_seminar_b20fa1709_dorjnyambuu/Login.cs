using swe331_seminar_b20fa1709_dorjnyambuu.models;
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

namespace swe331_seminar_b20fa1709_dorjnyambuu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            User loginUser = new User();
            loginUser.Password = password.Text;
            loginUser.UserName = username.Text;
            User res = GlobalVar.login(loginUser);
            if(res == null)
            {
                alert.Text = "Нэвтрэх нэр, нууц буруу байна.";
            } else
            {
                Home home = new Home(res);
                home.Show();
                this.Hide();
            }
        }
    }
}
