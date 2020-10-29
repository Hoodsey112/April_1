using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilApp
{
    public class ColumnSettings
    {
        private string ColumnName;
        private int ColumnWidth;
        private int ColumnIndex;
        private bool ColumnVisible;
        public string columnName
        {
            get { return ColumnName; }
            set { ColumnName = value; }
        }
        public int columnWidth
        {
            get { return ColumnWidth; }
            set { ColumnWidth = value; }
        }

        public int columnIndex
        {
            get { return ColumnIndex; }
            set { ColumnIndex = value; }
        }

        public bool columnVisible
        {
            get { return ColumnVisible; }
            set { ColumnVisible = value; }
        }
    }
}
