using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AprilApp
{
    public partial class Form1 : Form
    {
        Query query;
        NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public DataTable loadData;
        public int colIndex = 0;
        public string searchText = "";
        private bool dgvEnter = false;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void CustomDataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ((CustomDataGridView)sender).CurrentCell = null;
            customDataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            colIndex = e.ColumnIndex;
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
                loadData = new DataTable();
                loadData = Query.FillData("select lastName," +
                                                                " firstName," +
                                                                " patrName," +
                                                                " to_char(birthDate, 'dd.MM.YYYY') bDate" +
                                                         " from Persons");

                customDataGridView1.DataSource = loadData;
                for (int i = 0; i < customDataGridView1.Columns.Count; i++)
                {
                    customDataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                    MessageBox.Show($"Запрос успешно выполнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"Запрос не может быть выполнен, соединение не установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void columnsSettings_Click(object sender, EventArgs e)
        {
            ColumnsSettingsForm settingsForm = new ColumnsSettingsForm(this);
            settingsForm.ShowDialog();
            
        }

        private void customDataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void customDataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dgvEnter = true;
        }

        private void customDataGridView1_MouseLeave(object sender, EventArgs e)
        {
            dgvEnter = false;
        }

        private void customDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvEnter)
            {
                using (SearchForm sForm = new SearchForm(this))
                {
                    sForm.ShowDialog();
                }
                customDataGridView1.Columns[colIndex].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);   
            }
        }
    }
}
