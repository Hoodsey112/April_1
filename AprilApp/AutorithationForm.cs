using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    public partial class AutorithationForm : Form
    {
        public AutorithationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person loginPerson = Query.Login(loginTB.Text, pswdTB.Text);
            if ( loginPerson != null)
            {
                
            }
        }
    }
}
