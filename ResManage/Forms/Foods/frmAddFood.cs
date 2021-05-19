using ResManage.DAO;
using ResManage.Model;
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

namespace ResManage.Forms.Foods
{
    public partial class frmAddFood : Form
    {
        public frmAddFood()
        {
            InitializeComponent();
            loadCate();
        }

        void loadCate()
        {
            cbCate.DataSource = cateDB.getListCate();
            cbCate.DisplayMember = "catName";
            cbCate.ValueMember = "catID";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            pbPic.Image.Save(pic, pbPic.Image.RawFormat);
            Food f = new Food(txbFName.Text, Convert.ToInt32(txbFQuantity.Text), float.Parse(txbFPrice.Text), Convert.ToInt32(cbCate.SelectedValue), pic);
            if (foodDB.insertFood(f))
            {
                MessageBox.Show("Add successfully !!!");
            }
            else
            {
                MessageBox.Show("Error !!!");

            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = dialog.FileName;
            }
            pbPic.ImageLocation = imageLocation;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txbInput.Text != null)
            {
                gvListFood.DataSource = foodDB.search(txbInput.Text);
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvListFood.Columns["foodPic"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                gvListFood.AllowUserToAddRows = false;
            }
        }
    }
}
