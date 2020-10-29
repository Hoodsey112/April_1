using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    public static class CustomControlCollection
    {
        public static bool DataCheck(this Control.ControlCollection control)
        {
            bool result = true;

            foreach(var elem in control)
            {
                if (elem.GetType() == typeof(CustomTextBox))
                {
                    if (!((ICheckableControl)elem).Check())
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
