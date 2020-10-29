using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilApp
{
    public class Person
    {
        private int id;
        private string lastName;
        private string firstName;
        private string patrName;
        private ColumnSettings[] columnSettings;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string PatrName
        {
            get { return patrName; }
            set { patrName = value; }
        }

        public ColumnSettings[] ColumnSettings
        {
            get { return columnSettings; }
            set { columnSettings = value; }
        }
    }
}
