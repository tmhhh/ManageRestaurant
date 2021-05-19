using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManage.Model
{
    public class Table
    {
        private int tableID;
        private int tableStatus;

        public int TableID { get => tableID; set => tableID = value; }
        public int TableStatus { get => tableStatus; set => tableStatus = value; }
        public Table() { }
        public Table(int tableID,  int tableStatus) 
        {
            this.tableID = tableID;
            this.tableStatus = tableStatus;
        
        }

    }
}
