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
    public partial class ColumnsSettingsForm : Form
    {
        Form1 _main;
        public ColumnsSettingsForm()
        {
            InitializeComponent();
        }

        public ColumnsSettingsForm(Form1 main)
        {
            InitializeComponent();
            _main = main;

            for (int i = 0; i < main.customDataGridView1.Columns.Count; i++)
            {
                dataGridView1.Rows.Add(main.customDataGridView1.Columns[i].Visible, main.customDataGridView1.Columns[i].HeaderText, main.customDataGridView1.Columns[i].Name);
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_main != null)
            {
                if (dataGridView1.CurrentCell != null)
                {
                    _main.customDataGridView1.Columns[dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Index].Visible = bool.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    foreach (ColumnSettings column in _main.person.ColumnSettings)
                    {
                        if (column.columnName == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString())
                        {
                            column.columnVisible = bool.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                            break;
                        }
                    }
                }
            }
        }
    }
}
