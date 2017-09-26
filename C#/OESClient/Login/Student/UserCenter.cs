using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic.LoginServiceReference;

namespace Client.Student
{
    public partial class UserCenter : Form
    {
        private User user = Login.userOverall;

        public UserCenter()
        {
            InitializeComponent();
            this.userNameBtn.Text = user.Username;
            this.userNameHerf.Text = user.Username;
            this.userNameNow.Text = user.Username;
        }
    }
}