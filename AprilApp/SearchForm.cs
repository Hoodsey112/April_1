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
    public partial class SearchForm : Form
    {
        Form1 _form;
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Form1 form)
        {
            InitializeComponent();
            _form = form;
            searchBox.Text = _form.searchText;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            _form.loadData.DefaultView.RowFilter = $"{_form.customDataGridView1.Columns[_form.colIndex].HeaderText} like '%'";
            _form.searchText = "";
            Close();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            _form.loadData.DefaultView.RowFilter = $"{_form.customDataGridView1.Columns[_form.colIndex].HeaderText} like '%{searchBox.Text}%'";
            _form.searchText = searchBox.Text;
            Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _form.loadData.DefaultView.RowFilter = $"{_form.customDataGridView1.Columns[_form.colIndex].HeaderText} like '%{searchBox.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
