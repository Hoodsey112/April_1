using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    //Тестовое задание №3
    interface ICheckableControl
    {
        bool EmptyDataCheck { get; set; }
        bool Check();
    }
}
