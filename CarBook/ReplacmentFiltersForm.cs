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
    public partial class ReplacmentFiltersForm : Form
    {
        CONNECT conn = new CONNECT();
        FILTER filters = new FILTER();
        public ReplacmentFiltersForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                string filterFuel = textBoxFuel.Text;
                string filterOil = textBoxOil.Text;
                string filterLPG = textBoxLPG.Text;
                string filterAir = textBoxAir.Text;
                string filterCabin = textBoxCabin.Text;
                string filterRandom = textBoxRandom.Text;
                string filterRandomName = textBoxRandomName.Text;
                DateTime dateFuel = dateTimePickerFuel.Value;
                DateTime dateOil = dateTimePickerOil.Value;
                DateTime dateLPG = dateTimePickerLPG.Value;
                DateTime dateAir = dateTimePickerAir.Value;
                DateTime dateCabin = dateTimePickerCabin.Value;
                DateTime dateRandom = dateTimePickerRandom.Value;
            try
            {
                int filterIdentityID = Convert.ToInt32(textBoxID.Text);
                bool insterFilter = filters.insertFilter(filterFuel, filterOil, filterLPG, filterAir, filterCabin, filterRandom, filterIdentityID, filterRandomName, dateFuel, dateOil, dateLPG, dateAir, dateCabin, dateRandom);
                if (insterFilter)
                {
                    int id = Convert.ToInt32(textBoxID.Text);
                    MessageBox.Show("Dodano informacje!", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonClear.PerformClick();
                    dataGridViewHistory.DataSource = filters.displayFilters(id);
                }
                else
                {
                    MessageBox.Show("Nie zapisano danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ReplacmentFiltersForm_Load(object sender, EventArgs e)
        {
            dataGridViewCar.DataSource = filters.getCar();
            dataGridViewCar.Columns[3].Visible = false;
        }

        private void dataGridViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonClear.PerformClick();
            try
            {
                textBoxID.Text = dataGridViewCar.CurrentRow.Cells[3].Value.ToString();
                int id = Convert.ToInt32(textBoxID.Text);
                dataGridViewHistory.DataSource = filters.displayFilters(id);
                dataGridViewHistory.Columns[0].HeaderCell.Value = "Filtr paliwa";
                dataGridViewHistory.Columns[1].HeaderCell.Value = "Filtr oleju";
                dataGridViewHistory.Columns[2].HeaderCell.Value = "Filtr LPG";
                dataGridViewHistory.Columns[3].HeaderCell.Value = "Filtr powietrza";
                dataGridViewHistory.Columns[4].HeaderCell.Value = "Filtr kabiny";
                dataGridViewHistory.Columns[5].Visible = false;
                dataGridViewHistory.Columns[6].HeaderCell.Value = dataGridViewHistory.CurrentRow.Cells[5].Value;
                dataGridViewHistory.Columns[7].Visible = false;
                dataGridViewHistory.Columns[8].Visible = false;
                dataGridViewHistory.Columns[9].Visible = false;
                dataGridViewHistory.Columns[10].Visible = false;
                dataGridViewHistory.Columns[11].Visible = false;
                dataGridViewHistory.Columns[12].Visible = false;
                dataGridViewHistory.Columns[13].Visible = false;
                dataGridViewInformation();
            }
            catch(Exception)
            { 

            }
        }

        private void dataGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewInformation();
            }
            catch (Exception)
            {

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFuel.Text = "";
            textBoxOil.Text = "";
            textBoxLPG.Text = "";
            textBoxAir.Text = "";
            textBoxRandom.Text = "";
            textBoxCabin.Text = "";
            textBoxRandomName.Text = "";
            dateTimePickerFuel.Value = DateTime.Now;
            dateTimePickerOil.Value = DateTime.Now;
            dateTimePickerLPG.Value = DateTime.Now;
            dateTimePickerAir.Value = DateTime.Now;
            dateTimePickerCabin.Value = DateTime.Now;
            dateTimePickerRandom.Value = DateTime.Now;

        }

        public void dataGridViewInformation()
        {
            textBoxFuel.Text = dataGridViewHistory.CurrentRow.Cells[0].Value.ToString();
            textBoxOil.Text = dataGridViewHistory.CurrentRow.Cells[1].Value.ToString();
            textBoxLPG.Text = dataGridViewHistory.CurrentRow.Cells[2].Value.ToString();
            textBoxAir.Text = dataGridViewHistory.CurrentRow.Cells[3].Value.ToString();
            textBoxRandomName.Text = dataGridViewHistory.CurrentRow.Cells[5].Value.ToString();
            textBoxCabin.Text = dataGridViewHistory.CurrentRow.Cells[4].Value.ToString();
            textBoxRandom.Text = dataGridViewHistory.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerFuel.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[7].Value);
            dateTimePickerOil.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[8].Value);
            dateTimePickerLPG.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[9].Value);
            dateTimePickerAir.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[10].Value);
            dateTimePickerCabin.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[11].Value);
            dateTimePickerRandom.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[12].Value);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int updateid = Convert.ToInt32(textBoxID.Text);
                int ID = Convert.ToInt32(dataGridViewHistory.CurrentRow.Cells[13].Value);
                if (filters.removeFilter(ID))
                {
                    MessageBox.Show("Usunięto!", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonClear.PerformClick();
                    dataGridViewHistory.DataSource = filters.displayFilters(updateid);
                }
                else
                {
                    MessageBox.Show("Nie udało się usunąć!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
