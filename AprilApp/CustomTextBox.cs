using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    class CustomTextBox: TextBox, ICheckableControl
    {
        public bool EmptyDataCheck { get; set; }

        public bool Check()
        {

            if (!EmptyDataCheck) return true;
            if (this.Text != null && this.Text != string.Empty) return true;
            else
            {
                BalloonTip tip = new BalloonTip();
                tip.Show("Ошибка", "Поле не может быть пустым", this, ToolTipIcon.Error, 3000.0);
            }
            
            return false;
        }
    }
}
