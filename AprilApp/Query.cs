using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Npgsql;

namespace AprilApp
{
    class Query
    {
        private string connectionString = $"host={Properties.Settings.Default.hostDef}; username={Properties.Settings.Default.userNameDef}; password={Properties.Settings.Default.pswdDef}; database={Properties.Settings.Default.dataBaseDef}";
        private static NpgsqlConnection sqlConnection;
        private static NpgsqlTransaction sqlTransaction;

        /// <summary>
        /// Получение параметров из запроса
        /// </summary>
        /// <returns>true - ..., false - ...</returns>
        public static bool DeriveParameters(string command)
        {
            return true;
        }

        /// <summary>
        /// Открытие соединения с БД
        /// </summary>
        /// <returns>true - Соединение установлено, false - Проблемы при открытии соединения</returns>
        public bool OpenConnection()
        {
            try
            { 
                sqlConnection = new NpgsqlConnection(connectionString);

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    return true;
                }
                else return false;
            }
            catch(NpgsqlException nex)
            {
                MessageBox.Show($"{nex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Закрытие соединения с БД
        /// </summary>
        /// <returns>true - Соединение закрыто успешно, false - проблемы при закрытии соединения</returns>
        public bool CloseConnection()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                    return true;
                }
                else return false;
            }
            catch(NpgsqlException nex)
            {
                MessageBox.Show($"{nex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Открытие соединения с БД
        /// </summary>
        /// <returns>true - Соединение установлено, false - Проблемы при открытии соединения</returns>
        public bool Add(string parameterName, object parameterValue, NpgsqlTypes.NpgsqlDbType type)
        {
            return true;
        }

        /// <summary>
        /// Начало транзакции
        /// </summary>
        /// <returns>true - ..., false - ...</returns>
        private static bool BeginTransaction()
        {
            try
            {
                sqlTransaction = sqlConnection.BeginTransaction();
                return true;
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Успешное завершение транзакции
        /// </summary>
        /// <returns>true - ..., false - ...</returns>
        private static bool CommitTransaction()
        {
            try
            { 
                sqlTransaction.Commit();
                return true;
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Отмена изменений в указанной транзакции
        /// </summary>
        /// <returns>true - ..., false - ...</returns>
        private static bool RollbackTransaction()
        {
            try
            {
                sqlTransaction.Rollback();
                return true;
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Выполнение запроса без получения результата запроса в ответе
        /// </summary>
        /// <returns>true - ..., false - ...</returns>
        public static bool ExecuteNonQuery(string query)
        {
            try
            {
                if (sqlConn.State == ConnectionState.Closed) sqlConn.Open();

                NpgsqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Connection = sqlConnection;
                if (Query.BeginTransaction()) sqlCommand.Transaction = sqlTrans;

                try
                {
                    sqlCommand.CommandText = query;
                    sqlCommand.ExecuteNonQuery();

                    Query.CommitTransaction();
                }
                catch(NpgsqlException ex)
                {
                    MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        Query.RollbackTransaction();
                        return false;
                    }
                    catch(NpgsqlException ex_)
                    {
                        MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex_.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Заполнение DataTable табличными данными из запроса
        /// </summary>
        /// <returns>Возвращает DataTable</returns>
        public static DataTable FillData(string query)
        {
            try
            {
                DataTable fillData = new DataTable();

                using (NpgsqlCommand sqlCommand = new NpgsqlCommand(query, sqlConn))
                {
                    if (sqlConn.State == ConnectionState.Closed) sqlConn.Open();

                    fillData.Load(sqlCommand.ExecuteReader());
                }

                return fillData;
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show($"Произошла ошибка при выполнении запроса:\n {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static NpgsqlConnection sqlConn
        {
            get { return sqlConnection; }
        }

        public static NpgsqlTransaction sqlTrans
        {
            get { return sqlTransaction; }
        }
    }
}
