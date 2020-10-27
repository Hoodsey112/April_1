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
    }
}
