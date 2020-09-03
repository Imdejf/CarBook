using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBook
{
    public partial class ReportsForm : Form
    {
        REPORTS reports = new REPORTS();

        public ReportsForm()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reports.getCars();
            dataGridView1.Columns[0].HeaderCell.Value = "Marka";
            dataGridView1.Columns[1].HeaderCell.Value = "Numer rejestracyjny";

        }
    }
}
