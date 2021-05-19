using ResManage.DAO;
using ResManage.Model;
using RestaurantManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManage.Forms.Manager
{
    public partial class frmSheduleDrawing : Form
    {
        public int btnWidth = 85;
        public int btnHeight = 60;
        public int boardWidth = 9;
        public int boardHeight = 4;
        DateTime firstDayOfWeek = new DateTime();
        public frmSheduleDrawing()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {

            firstDayOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1);
            cbUserID.DataSource = UsersDB.getListUser();
            cbUserID.DisplayMember = "userID";
            cbUserID.ValueMember = "userID";
            txbName.Text = UsersDB.getUserByID(Convert.ToInt32(cbUserID.SelectedValue)).UserName;
            lbSpan.Text = "(From " + firstDayOfWeek.ToShortDateString() + " --> " + firstDayOfWeek.AddDays(6).ToShortDateString() + ")";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DrawBoard();
        }
        public void DrawBoard()
        {
            pnBoard.Controls.Clear();
            Button[,] matrixButton = new Button[4, 9];
            int temp = 0;
            int shift = 1;
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < boardHeight; i++)
            {

                for (int j = 0; j < boardWidth; j++)
                {

                    Button btn = new Button()
                    {
                        Width = btnWidth,
                        Height = btnHeight,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                    };
                    btn.Font = new Font(btn.Font, FontStyle.Bold);

                    pnBoard.Controls.Add(btn);
                    if (i == 0 && j > 0)
                    {
                        btn.BackColor = Color.LightPink;
                        DateTime date = firstDayOfWeek.AddDays(temp);
                        btn.Text = date.DayOfWeek + "\n" + date.ToShortDateString();
                        temp++;
                    }
                    else if (j == 0 && i >= 0)
                    {
                        btn.BackColor = Color.LightBlue;
                        if (i > 0)
                        {
                            btn.Text = shift.ToString();
                            shift++;
                        }
                        else btn.Text = "Shift";
                      
                    }
                    else
                        btn.BackColor = Color.AliceBlue;



                    matrixButton[i, j] = btn;

                    oldButton = btn;
                }

                oldButton.Location = new Point(0, oldButton.Location.Y + btnHeight);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
            ShowEmpSchedule(matrixButton);
        }
        public void ShowEmpSchedule(Button[,] matrixButton)
        {
            List<Working> listWorking = workingDB.getListWorkingByUserID(Convert.ToInt32(cbUserID.SelectedValue));
            for (int i = 0; i < matrixButton.GetLength(0); i++)
            {
                for (int j = 0; j < matrixButton.GetLength(1); j++)
                {
                    foreach (Working w in listWorking)
                    {
                        if (matrixButton[0, j].Text == w.WorkingDate.DayOfWeek + "\n" + w.WorkingDate.ToShortDateString() && matrixButton[i, 0].Text == w.Shift.ToString())
                        {
                            matrixButton[i, j].Text = "X";
                        }
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            firstDayOfWeek = firstDayOfWeek.AddDays(7);
            lbSpan.Text = "(From " + firstDayOfWeek.ToShortDateString() + " to " + firstDayOfWeek.AddDays(6).ToShortDateString() + ")";
            DrawBoard();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            firstDayOfWeek = firstDayOfWeek.AddDays(-7);
            lbSpan.Text = "(From " + firstDayOfWeek.ToShortDateString() + " to " + firstDayOfWeek.AddDays(6).ToShortDateString() + ")";
            DrawBoard();
        }

        private void cbUserID_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbUserID.Text != "System.Data.DataRowView")
                txbName.Text = UsersDB.getUserByID(Convert.ToInt32(cbUserID.SelectedValue)).UserName;

        }
    }
}
