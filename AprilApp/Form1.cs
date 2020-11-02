using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;
using System.IO;

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
        public Person person;
        private bool firstRun = true;

        public Form1()
        {
            InitializeComponent();
            FuncConnection();
            AutorForm();
            //person = Query.Login("admin", "admin");
            
            KeyPreview = true;
            firstRun = false;
        }

        private void AutorForm()
        {
            using (AutorithationForm aForm = new AutorithationForm(this))
            {
                aForm.ShowDialog();
            }
            if (person == null || person.ID == 0) Environment.Exit(0);
            else InitializeColumn();
        }

        /// <summary>
        /// Функция автоматического подключения к БД при запуске приложения
        /// </summary>
        private void FuncConnection()
        {
            try
            { 
                query = new Query();
                if (query.OpenConnection() == true)
                {
                    sqlConnection = Query.sqlConn;
                    MessageBox.Show("Соединение установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Что то пошло не так, проверьте правильность указанных настроек", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// функция инициализации столбцов при запуске, согласно сохраненных настроек пользователя
        /// </summary>
        private void InitializeColumn()
        {
            try
            { 
                customDataGridView1.AutoGenerateColumns = false;
                if (person.ColumnSettings != null)
                {     
                    for (int i = 0; i < customDataGridView1.Columns.Count; i++)
                    {
                        customDataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        foreach (ColumnSettings column in person.ColumnSettings)
                        {
                            if (customDataGridView1.Columns[i].Name == column.columnName)
                            {
                                customDataGridView1.Columns[i].DisplayIndex = column.columnIndex;
                                customDataGridView1.Columns[i].Visible = column.columnVisible;
                                customDataGridView1.Columns[i].Width = column.columnWidth;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработка события по нажатию на заголовок столбца, снимает выделение с ячейки
        /// </summary>
        private void CustomDataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ((CustomDataGridView)sender).CurrentCell = null;
            customDataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            colIndex = e.ColumnIndex;
        }

        /// <summary>
        /// Кнопка для поключения к БД
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            query = new Query();
            if (query.OpenConnection() == true)
            {
                sqlConnection = Query.sqlConn;
                MessageBox.Show("Соединение установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Что то пошло не так, проверьте правильность указанных настроек", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        /// <summary>
        /// Кнопка для разрыва соединения с БД
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (query.CloseConnection() == true) MessageBox.Show("Соединение разорвано", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Что то пошло не так, проверьте правильность указанных настроек", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// Добавление пользователя в БД
        /// </summary>
        private void addPersonBTN_Click(object sender, EventArgs e)
        {
            try
            { 
                if (CustomControlCollection.DataCheck(this.Controls))
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        string defaultColumnsSettings = "[{\"columnName\":\"lastName\",\"columnWidth\":129,\"columnIndex\":0,\"columnVisible\":true}," +
                                                         "{\"columnName\":\"firstName\",\"columnWidth\":129,\"columnIndex\":1,\"columnVisible\":true}," +
                                                         "{\"columnName\":\"patrName\",\"columnWidth\":128,\"columnIndex\":2,\"columnVisible\":true}," +
                                                         "{\"columnName\":\"bDate\",\"columnWidth\":129,\"columnIndex\":3,\"columnVisible\":true}," +
                                                         "{\"columnName\":\"login\",\"columnWidth\":129,\"columnIndex\":4,\"columnVisible\":true}," +
                                                         "{\"columnName\":\"password\",\"columnWidth\":129,\"columnIndex\":5,\"columnVisible\":true}]";

                        if (Query.ExecuteNonQuery($"insert into Persons (id, lastName, firstName, patrName, birthDate, login, password, columnsSettings) values (default, '{lastNameTB.Text}', '{firstNameTB.Text}', '{patrNameTB.Text}', '{birthDate.Value:yyyy-MM-dd}', '{loginTB.Text}', '{Query.EncryptPSWD(pswdTB.Text)}', '{defaultColumnsSettings}')"))
                            MessageBox.Show($"Запрос успешно выполнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show($"Запрос не может быть выполнен, соединение не установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Получение списка пользователей из БД
        /// </summary>
        private void getPersonsBTN_Click(object sender, EventArgs e)
        {
            try
            { 
                if (sqlConnection.State == ConnectionState.Open)
                {
                    loadData = new DataTable();
                    loadData = Query.FillData("select lastName," +
                                                    " firstName," +
                                                    " patrName," +
                                                    " to_char(birthDate, 'dd.MM.YYYY') bDate," +
                                                    " login," +
                                                    " password" +
                                             " from Persons");

                    customDataGridView1.DataSource = loadData;
                    MessageBox.Show($"Запрос успешно выполнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show($"Запрос не может быть выполнен, соединение не установлено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Вызов формы для настройки видимости столбцов
        /// </summary>
        private void columnsSettings_Click(object sender, EventArgs e)
        {
            ColumnsSettingsForm settingsForm = new ColumnsSettingsForm(this);
            settingsForm.ShowDialog();
            UpdateSettings();
        }

        /// <summary>
        /// Значение true, если мышка в зоне customDataGridView
        /// </summary>
        private void customDataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dgvEnter = true;
        }

        /// <summary>
        /// Значение false, если мышка вне зоне customDataGridView
        /// </summary>
        private void customDataGridView1_MouseLeave(object sender, EventArgs e)
        {
            dgvEnter = false;
        }

        /// <summary>
        /// Если мышка в зоне customDataGridView и был выбран определенный столбец, то откроется форма для поиска по выбранному столбцу
        /// </summary>
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


        /// <summary>
        /// Изменение ширины столбца с записью данных в БД
        /// </summary>
        private void customDataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                if (!firstRun)
                {
                    if (person.ColumnSettings != null)
                    {
                        foreach (ColumnSettings column in person.ColumnSettings)
                        {
                            if (e.Column.Name == column.columnName)
                            {
                                column.columnWidth = e.Column.Width;
                                break;
                            }
                        }

                        UpdateSettings();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение проядкового номера столбца
        /// </summary>
        private void customDataGridView1_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (!firstRun)
            {
                if (person.ColumnSettings != null)
                {
                    foreach (ColumnSettings column in person.ColumnSettings)
                    {
                        if (e.Column.Name == column.columnName)
                        {
                            column.columnIndex = e.Column.DisplayIndex;
                            break;
                        }
                    }

                    UpdateSettings();
                }
            }
        }

        /// <summary>
        /// Функция update'а настроек в формате json залогиненного пользователя
        /// </summary>
        private void UpdateSettings()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(person.ColumnSettings);

            if (sqlConnection.State == ConnectionState.Open)
            {
                Query.ExecuteNonQuery($"update Persons set columnsSettings = '{json}' where id = {person.ID}");
            }
        }

        private void createJsonBTN_Click(object sender, EventArgs e)
        {
            if (loadData.Rows.Count > 0)
            {
                ConverterClass.CreateJSONFile(loadData);
            }
        }

        private void loadJsonBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fDialog = new OpenFileDialog())
            {
                fDialog.DefaultExt = ".json";
                fDialog.Filter = "JSON document (.json)|*.json";
                fDialog.InitialDirectory = $"{Application.StartupPath}\\";
                if (fDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = null;
                    string filePath = fDialog.FileName;
                    Stream fileStream = fDialog.OpenFile();

                    using (StreamReader sReader = new StreamReader(fileStream))
                    {
                        fileContent = sReader.ReadToEnd();
                    }

                    customDataGridView1.DataSource = null;
                    customDataGridView1.DataSource = ConverterClass.ConverterJSONtoDataTable(fileContent);
                }
            }
        }
    }
}
