using swe331_seminar_b20fa1709_dorjnyambuu.models;
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
    public partial class userRegister : UserControl
    {
        public userRegister(User user)
        {
            InitializeComponent();
            username.Text = user.UserName;
            password.Text = user.Password;
            email.Text = user.Email;
            lastname.Text = user.Lastname;
            firstname.Text = user.Firstname;
            address.Text = user.Address;
            register.Text = user.RegisterNumber;
            phone.Text = user.Mobile;
        }
    }
}
