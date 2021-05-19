using ResManage.Forms;
using ResManage.Model;
using RestaurantManagement.DAO;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.forms
{
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (UsersDB.logIn(txtUsername.Text, txtPass.Text))
            {
                MessageBox.Show("Login Successfully !!!");
                globalUser.currentUser = UsersDB.findUserByUsernameID(txtUsername.Text);
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error !!!");
            }
        }
    }




}








