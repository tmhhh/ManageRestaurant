using ResManage.DAO;
using ResManage.Forms.Foods;
using ResManage.Model;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Forms
{
    public partial class frmMain : Form
    {
        public int TableWidth = 80;
        public int TableHeight = 80;

        public frmMain()
        {
            InitializeComponent();
            LoadTable();
            loadCategory();
            loadCBTable(cbSTB);
        }
        void LoadTable()
        {
            flpnMain.Controls.Clear();
            List<Table> tableList = tableDB.getListTable();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableWidth, Height = TableHeight };
                btn.Text = "Table " + item.TableID.ToString() + "\n";
                btn.Image = ResManage.Properties.Resources.tablechuan;

                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.TableStatus)
                {
                    case 0:
                        btn.BackColor = Color.Aqua;
                        btn.Text += "Empty";
                        break;
                    default:
                        btn.BackColor = Color.DarkRed;
                        btn.Text += "Exist";
                        break;
                }

                flpnMain.Controls.Add(btn);
            }
        }
        void showBill(int tbID)
        {
            lsvBill.Items.Clear();
            List<displayBill> listBillInfo = displayBillDB.getListMenuByTable(tbID);
            double total = 0;
            foreach (displayBill item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.UnitPrice.ToString("c"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
                total += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            textBoxTotal.Text = total.ToString("c");

        }
        void loadCategory()
        {
            List<Category> listCat = catDB.getListCategory();
            comboBoxCat.DataSource = listCat;
            comboBoxCat.DisplayMember = "catName";
        }
        void loadFoodByCatID(int id)
        {
            List<Food> listFood = foodDB.getFoodByCatID(id);
            comboBoxFoodByCatID.DataSource = listFood;
            comboBoxFoodByCatID.DisplayMember = "foodName";
        }
        void loadCBTable(ComboBox cbTB)
        {
            cbTB.DataSource = tableDB.getListTable();
            cbTB.DisplayMember = "tableID";
        }
        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).TableID;
            lsvBill.Tag = (sender as Button).Tag;
            showBill(tableID);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboardFrm = new dashboard();
            dashboardFrm.Show();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.DataSource == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.CatID;
            loadFoodByCatID(id);
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int billID = billDB.getUncheckBillByTbID(table.TableID);
            int foodID = (comboBoxFoodByCatID.SelectedItem as Food).FoodID;
            int quantity = (int)quantitySelect.Value;

            int quantityRemain = foodDB.getFoodQuantityByID(foodID);
            if(quantity<=quantityRemain)
            {
                if (billID == -1)
                {
                    billDB.insertBill(table.TableID);
                    billInfoDB.insertBillInfo(billDB.getMaxBillID(), foodID, quantity);
                }
                else
                {
                    billInfoDB.insertBillInfo(billID, foodID, quantity);
                }
                showBill(table.TableID);
                LoadTable();
            }
            else
            {
                MessageBox.Show("Not enough food !!!");
            }
         
        }


        private void payBtn_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int billID = billDB.getUncheckBillByTbID(table.TableID);

            int discount = (int)discountNumer.Value;
            double total = Convert.ToDouble(textBoxTotal.Text.Split('$')[1]);
            //MessageBox.Show(textBoxTotal.Text.ToString());
            double finalprice = total - (total / 100) * discount;
            if (billID != -1)
            {
                if (MessageBox.Show(string.Format("Are you sure you want to Pay the table {0} ?\n Discount= {1}\n Total:{2}", table.TableID, discount, finalprice), "Restaurant", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    billDB.checkOut(billID, discount, finalprice);
                    showBill(table.TableID);
                    LoadTable();
                }
            }

        }
        private void buttonSTB_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).TableID;
            int id2 = (cbSTB.SelectedItem as Table).TableID;
            if (MessageBox.Show(string.Format("Are you sure you want to switch table {0} to {1}", id1, id2), "Restaurant", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                tableDB.switchTable(id1, id2);
                LoadTable();
            }


        }
        #endregion


    }
}
