using ResManage.DAO;
using ResManage.Forms.UserInfo;
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
//using Word = Microsoft.Office.Interop.Word;

namespace ResManage.Forms.ReportStat
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<double> sWorkingTime = new List<double>();
            List<double> rWorkingTime = new List<double>();
            List<double> totalSalary = new List<double>();

            DataTable dt = workingDB.standardWorkingTime(dtFrom.Value, dtTo.Value);
            foreach (DataRow dr in dt.Rows)
            {
                sWorkingTime.Add(Convert.ToDouble(dr["sWorkingTime"]));
            }
            dt = workingDB.workingTime(dtFrom.Value, dtTo.Value);
            foreach (DataRow dr in dt.Rows)
            {
                rWorkingTime.Add(Convert.ToDouble(dr["TotalTime"]));
            }
            for (int i = 0; i < rWorkingTime.Count; i++)
            {
                double tmp = rWorkingTime.ElementAt(i) - sWorkingTime.ElementAt(i);
                if (tmp < 0)
                {
                    totalSalary.Add(rWorkingTime.ElementAt(i) * 50 - 100 * Math.Abs(tmp));
                }
                else
                {
                    totalSalary.Add(sWorkingTime.ElementAt(i) * 50 + 100 * Math.Abs(tmp));
                }
            }
            DataTable ttSalary = new DataTable();
            ttSalary.Columns.Add("User ID");
            ttSalary.Columns.Add("Total Salary");
            for (int i = 0; i < totalSalary.Count; i++)
            {
                ttSalary.Rows.Add(new object[] { i + 1, totalSalary.ElementAt(i) });
            }

            gvSalary.DataSource = ttSalary;
        }

        private void btnDailySalary_Click(object sender, EventArgs e)
        {
            DateTime t = DateTime.Parse("0:30:00");
            DateTime currentTime = DateTime.Parse(DateTime.Now.ToLongTimeString());
            if (DateTime.Compare(currentTime, t) >= 0)
            {
                gvDailyWave.DataSource = dailyWageDB.wageCalculate();
            }
            else
            {
                MessageBox.Show("This action is not available now !!!");
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserOption frm = new frmUserOption();
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //SaveFileDialog sfd = new SaveFileDialog();

            //sfd.Filter = "Word Documents (*.docx)|*.docx";

            //sfd.FileName = "export.docx";

            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    Export_Data_To_Word(gvSalary, sfd.FileName);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SaveFileDialog sfd = new SaveFileDialog();

            //sfd.Filter = "Word Documents (*.docx)|*.docx";

            //sfd.FileName = "export.docx";

            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    Export_Data_To_Word(gvDailyWave, sfd.FileName);
            //}
        }
        //public void Export_Data_To_Word(DataGridView DGV, string filename)
        //{

        //    int temp = 1;
        //    if (DGV.Rows.Count != 0)
        //    {
        //        int RowCount = DGV.Rows.Count;
        //        int ColumnCount = DGV.ColumnCount + 1;
        //        Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

        //        //add rows
        //        int r = 0;
        //        for (r = 0; r <= RowCount - 1; r++)
        //        {
        //            for (int c = 0; c <= ColumnCount - 1; c++)
        //            {
        //                if (c == 0)
        //                {
        //                    DataArray[r, c] = temp.ToString();
        //                    temp++;

        //                }
        //                else
        //                    DataArray[r, c] = DGV.Rows[r].Cells[c - 1].Value;
        //            } //end row loop
        //        } //end column loop



        //        Word.Document oDoc = new Word.Document();
        //        oDoc.Application.Visible = true;

        //        //page orintation
        //        oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


        //        dynamic oRange = oDoc.Content.Application.Selection.Range;
        //        string oTemp = "";
        //        Object oMissing = System.Reflection.Missing.Value;
        //        for (r = 0; r <= RowCount - 1; r++)
        //        {
        //            for (int c = 0; c <= ColumnCount - 1; c++)
        //            {

        //                oTemp = oTemp + DataArray[r, c] + "\t";

        //            }
        //        }

        //        //table format
        //        oRange.Text = oTemp;

        //        object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
        //        object ApplyBorders = true;
        //        object AutoFit = true;
        //        object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

        //        oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
        //                              Type.Missing, Type.Missing, ref ApplyBorders,
        //                              Type.Missing, Type.Missing, Type.Missing,
        //                              Type.Missing, Type.Missing, Type.Missing,
        //                              Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

        //        oRange.Select();

        //        oDoc.Application.Selection.Tables[1].Select();
        //        oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
        //        oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
        //        oDoc.Application.Selection.Tables[1].Rows[1].Select();
        //        oDoc.Application.Selection.InsertRowsAbove(1);
        //        oDoc.Application.Selection.Tables[1].Rows[1].Select();


        //        //header row style
        //        oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
        //        //oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
        //        oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

        //        //add header row manually
        //        for (int c = 0; c <= ColumnCount - 1; c++)
        //        {
        //            if (c == 0)
        //            {
        //                oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = "No";

        //            }
        //            else
        //                oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c - 1].HeaderText;
        //        }

        //        //table style 
        //        oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
        //        oDoc.Application.Selection.Tables[1].Rows[1].Select();
        //        oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

        //        //header text
        //        foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
        //        {
        //            Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
        //            headerRange.Text = "Danh Sach Diem Qua Trinh";
        //            headerRange.Font.Size = 16;
        //            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //        }

        //        //save images
        //        //for (r = 0; r <= RowCount - 1; r++)
        //        //{
        //        //    byte[] imgbyte = (byte[])gvStudent.Rows[r].Cells[7].Value;
        //        //    MemoryStream ms = new MemoryStream(imgbyte);
        //        //    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
        //        //    Clipboard.SetDataObject(finalPic);
        //        //    oDoc.Application.Selection.Tables[1].Cell(r + 2, 9).Range.Paste();
        //        //    oDoc.Application.Selection.Tables[1].Cell(r + 2, 9).Range.InsertParagraph();
        //        //}
        //        //save the file
        //        oDoc.SaveAs(filename);
        //    }


        //}

    }
}
