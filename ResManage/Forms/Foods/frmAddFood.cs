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
            Load();
        }

        void loadCate()
        {
            cbCate.DataSource = cateDB.getListCate();
           
            cbCate.DisplayMember = "catName";
            cbCate.ValueMember = "catID";

        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbInput.Text != null)
            {
                gvListFood.DataSource = foodDB.search(txbInput.Text);
                DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvListFood.Columns["foodPic"];
                picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
                gvListFood.AllowUserToAddRows = false;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txbFName.Text = "";
            txbFQuantity.Text = "";
            txbFPrice.Text = "";
            pbPic.Image = null;
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
        #region EditFood
        public void Load()
        {
            cbCateE.DataSource = cateDB.getListCate();
            cbCateE.DisplayMember = "catName";
            cbCateE.ValueMember = "catID";
        }
        public void LoadData(Food f)
        {
            txbFNameE.Text = f.FoodName;
            txbFPriceE.Text = f.FoodPrice.ToString();
            txbFQuantityE.Text = f.FootQuan.ToString();
            txbFoodIDE.Text = f.FoodID.ToString();
            cbCateE.SelectedValue = f.CatID.ToString();
            pbPicE.Image =Image.FromStream(f.FoodPic);
        }
      
        private void gvListFoodE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(gvListFoodE.CurrentRow.Cells[0].Value);
            Food f = foodDB.getFoodByID(id);
            LoadData(f);
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            if (foodDB.Delete(Convert.ToInt32(txbFoodIDE.Text)))
            {
                MessageBox.Show("Delete successfully !!!");
                gvListFood.DataSource = foodDB.getList();
            }
            else
                MessageBox.Show("Error !!!");
        }

        private void btnUpdateE_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            pbPicE.Image.Save(pic, pbPicE.Image.RawFormat);
            Food f = new Food(Convert.ToInt32(gvListFoodE.CurrentRow.Cells[0].Value),txbFNameE.Text, Convert.ToInt32(txbFQuantityE.Text), float.Parse(txbFPriceE.Text), Convert.ToInt32(cbCateE.SelectedValue), pic);

            if (foodDB.Update(f))
            {
                MessageBox.Show("Update successfully !!!");
            }
            else
                MessageBox.Show("Error !!!");
        }

        private void btnUE_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageLocation = dialog.FileName;
            }
            pbPicE.ImageLocation = imageLocation;
        }

        private void buttonViewFE_Click(object sender, EventArgs e)
        {
            gvListFoodE.DataSource = foodDB.getList();
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)gvListFoodE.Columns["foodPic"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            gvListFoodE.AllowUserToAddRows = false;
        }

        private void backEBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashFrm = new dashboard();
            dashFrm.Show();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard frm = new dashboard();
            frm.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard frm = new dashboard();
            frm.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    #endregion
}

