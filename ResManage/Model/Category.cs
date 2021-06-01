using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.Model
{
   public class Category
    {
        private int catID;
        private string catName;
        public int CatID { get => catID; set => catID = value; }
        public string CatName { get => catName; set => catName = value; }
        public Category(int catID,string catName)
        {
            this.CatID = catID;
            this.CatName = catName;
        }
        public Category(DataRow row)
        {
            this.CatID = (int)row["catID"];
            this.CatName = row["catName"].ToString();
        }
    }
}
