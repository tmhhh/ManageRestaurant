using ResManage.Forms;
using ResManage.Forms.UserInfo;
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
                //MessageBox.Show("Login Successfully !!!");
                globalUser.currentUser = UsersDB.findUserByUsernameID(txtUsername.Text);
                dashboard dashboard = new dashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error !!!");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regist rfrm = new Regist();
            rfrm.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}








