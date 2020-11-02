using System.IO;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;

namespace AprilApp
{
    class ConverterClass
    {
        //Тестовое задание №8
        public static void CreateJSONFile(DataTable dTable)
        {
            try
            {
                string output = JsonConvert.SerializeObject(dTable);
                string path = $@"{Application.StartupPath}\output.json";
                File.WriteAllText(path, output);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable ConverterJSONtoDataTable(string fileContent)
        {
            DataTable jsonTable = JsonConvert.DeserializeObject<DataTable>(fileContent);

            return jsonTable;
        }
    }
}
