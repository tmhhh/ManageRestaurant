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
    public partial class frmEditDelete : Form
    {
        public frmEditDelete()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            cbCate.DataSource = cateDB.getListCate();
            cbCate.DisplayMember = "catName";
            cbCate.ValueMember = "catID";
        }
        public void LoadData(Food f)
        {
            txbFName.Text = f.FoodName;
            txbFPrice.Text = f.FoodPrice.ToString();
            txbFQuantity.Text = f.FootQuan.ToString();
            txbFoodID.Text = f.FoodID.ToString();
            cbCate.SelectedValue = f.CatID.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gvListFood.DataSource = foodDB.getList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = dialog.FileName;
            }
            pbPic.ImageLocation = imageLocation;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            pbPic.Image.Save(pic, pbPic.Image.RawFormat);
            Food f = new Food(txbFName.Text, Convert.ToInt32(txbFQuantity.Text), float.Parse(txbFPrice.Text), Convert.ToInt32(cbCate.SelectedValue), pic);
            if (foodDB.Update(f))
            {
                MessageBox.Show("Update successfully !!!");
            }
            else
                MessageBox.Show("Error !!!");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (foodDB.Delete(Convert.ToInt32(txbFoodID.Text)))
            {
                MessageBox.Show("Delete successfully !!!");
                gvListFood.DataSource = foodDB.getList();
            }
            else
                MessageBox.Show("Error !!!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void gvListFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gvListFood.CurrentRow.Cells[0].Value);
            Food f = foodDB.getFoodByID(id);
            LoadData(f);
        }
    }
}
