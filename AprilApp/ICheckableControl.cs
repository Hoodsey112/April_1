using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    interface ICheckableControl
    {
        bool EmptyDataCheck { get; set; }
        bool Check();
    }
}
