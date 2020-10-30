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
        // Для авторизации используется логин и пароль admin
        Form1 form;
        public AutorithationForm(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.person = Query.Login(loginTB.Text, pswdTB.Text);
            if ( form.person != null)
            {
                MessageBox.Show("Вы успешно авторизованы", "Добро пожаловать", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("Неверно ввели логин или пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
