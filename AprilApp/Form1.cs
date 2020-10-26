using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprilApp
{
    public partial class Form1 : Form
    {
        Query query;
        NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = new Query();
            if (query.OpenConnection() == true)
            {
                sqlConnection = Query.sqlConn;
                MessageBox.Show("Соединение установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //NpgsqlCommand command = new NpgsqlCommand("select * from Persons", sqlConnection);
                //command.CommandType = CommandType.Text;
                //NpgsqlCommandBuilder.DeriveParameters(command);

                //if(Query.ExecuteNonQuery("")) MessageBox.Show($"Запрос успешно выполнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Что то пошло не так, проверьте правильность указанных настроек", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (query.CloseConnection() == true) MessageBox.Show("Соединение разорвано", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Что то пошло не так, проверьте правильность указанных настроек", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addPersonBTN_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                if (Query.ExecuteNonQuery($"insert into Persons (id, lastName, firstName, patrName, birthDate) values (default, '{lastName.Text}', '{firstName.Text}', '{patrName.Text}', '{birthDate.Value:yyyy-MM-dd}')"))
                    MessageBox.Show($"Запрос успешно выполнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Запрос не может быть выполнен, соединение не установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void getPersonsBTN_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                dataGridView1.DataSource = Query.FillData("select lastName," +
                                                                " firstName," +
                                                                " patrName," +
                                                                " to_char(birthDate, 'dd.MM.YYYY') bDate" +
                                                         " from Persons");
                    MessageBox.Show($"Запрос успешно выполнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Запрос не может быть выполнен, соединение не установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
