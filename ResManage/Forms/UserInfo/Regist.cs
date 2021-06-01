using ResManage.forms;
using RestaurantManagement.DAO;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Forms.UserInfo
{
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (txbRepass.Text != textBoxPW.Text)
            {
                MessageBox.Show("Please check your repassword !!!");
            }
            else
            {
                MemoryStream pic = new MemoryStream();
                pbImage.Image.Save(pic, pbImage.Image.RawFormat);
                string name = textBoxName.Text;
                string uname = textBoxUnameID.Text;
                string uPw = textBoxPW.Text;
                int type = 0;
                DateTime birthDate = dtBirth.Value;

                if (radioButtonMan.Checked)
                {
                    type = 1;
                }
                else if (radioButtonWai.Checked)
                {
                    type = 0;
                }
                Users u = new Users(name, uname, uPw,type, birthDate, pic);
                if (UsersDB.Register(u))
                {
                    this.Close();
                    frmLogIn loginFrm = new frmLogIn();
                    loginFrm.Show();
                }
                else
                {
                    MessageBox.Show("Regist Failed");
                }
            }

        }

        private void bnUpload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = dialog.FileName;
            }
            pbImage.ImageLocation = imageLocation;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn frm = new frmLogIn();
            frm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
