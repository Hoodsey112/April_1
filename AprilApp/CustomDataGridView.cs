using System.Data;
using System.Windows.Forms;

namespace AprilApp
{
    public class CustomDataGridView:DataGridView
    {

        public CustomDataGridView()
        {
            VirtualMode = true;
        }

        public static ColumnSettings[] SetColumnsSettings(int userID)
        {
             return Query.GetSettings(userID);
        }
    }
}
