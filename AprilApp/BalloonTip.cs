using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    public class BalloonTip
    {
        //Тестовое задание №4
        public void Show(string title, string text, Control control, ToolTipIcon icon, double showTime)
        {
            ToolTip tTip = new ToolTip();
            tTip.IsBalloon = true;
            tTip.ToolTipTitle = title;
            tTip.ToolTipIcon = icon;

            tTip.Show(string.Empty, control, 0);
            tTip.Show(text, control, (int)showTime);
        }
    }
}
