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
    public partial class ExchangeLiquidForm : Form
    {
        public ExchangeLiquidForm()
        {
            InitializeComponent();
        }
        EXCHANGELIQUID liquid = new EXCHANGELIQUID();
        //create a function to get cars list 
        private void ExchangeLiquidForm_Load(object sender, EventArgs e)
        {

           
            dataGridViewCar.DataSource = liquid.getCar();
            dataGridViewCar.Columns[3].Visible = false;
        }

        //add new record for table or if liquidcount = false update last record 
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string liquidOne = textBoxLiquidOne.Text;
            string liquidTwo = textBoxLiquidTwo.Text;
            string liquidThree = textBoxLiquidThree.Text;
            string liquidFour = textBoxLiquidFour.Text;
            string liquidFive = textBoxLiquidFive.Text;
            DateTime dateOne= dateTimePickerOne.Value;
            DateTime dateTwo = dateTimePickerTwo.Value ;
            DateTime dateThree = dateTimePickerThree.Value;
            DateTime dateFour = dateTimePickerFour.Value;
            DateTime dateFive = dateTimePickerFive.Value;

            try
            {
                int liquidIdentityID = Convert.ToInt32(textBoxID.Text);
                int id = Convert.ToInt32(textBoxID.Text);
                bool liquidcount = liquid.countRecord(id);
                if (liquidcount)
                {
                    bool insertLiquid = liquid.insertLiquid(liquidOne, liquidTwo, liquidThree, liquidFour, liquidFive, dateOne, dateTwo, dateThree, dateFour, dateFive,liquidIdentityID);
                    if (insertLiquid)
                    {
                        MessageBox.Show("Zapisano", "Zapisywanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Błąd!", "Zapisywanie", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    bool editLiquid = liquid.editLiquid(liquidOne, liquidTwo, liquidThree, liquidFour, liquidFive, dateOne, dateTwo, dateThree, dateFour, dateFive,id);
                    if (editLiquid)
                    {
                      
                        MessageBox.Show("Pomyślnie edytowano", "Edytuj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonClear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Edycja nie powidła się", "Edytuj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dataGridViewCar.CurrentRow.Cells[3].Value);
            int ID = Convert.ToInt32(textBoxID.Text);
            dataGridViewHistory.DataSource = liquid.displayData(ID);
            buttonClear.PerformClick();
            if (dataGridViewHistory.RowCount > 0)
            {
                textBoxLiquidOne.Text = dataGridViewHistory.CurrentRow.Cells[0].Value.ToString();
                textBoxLiquidTwo.Text = dataGridViewHistory.CurrentRow.Cells[1].Value.ToString();
                textBoxLiquidThree.Text = dataGridViewHistory.CurrentRow.Cells[2].Value.ToString();
                textBoxLiquidFour.Text = dataGridViewHistory.CurrentRow.Cells[3].Value.ToString();
                textBoxLiquidFive.Text = dataGridViewHistory.CurrentRow.Cells[4].Value.ToString();
                dateTimePickerOne.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[5].Value);
                dateTimePickerTwo.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[6].Value);
                dateTimePickerThree.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[7].Value);
                dateTimePickerFour.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[8].Value);
                dateTimePickerFive.Value = Convert.ToDateTime(dataGridViewHistory.CurrentRow.Cells[9].Value);
            }
            else
            { 
            
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLiquidOne.Text = "";
            textBoxLiquidTwo.Text = "";
            textBoxLiquidThree.Text = "";
            textBoxLiquidFour.Text = "";
            textBoxLiquidFive.Text = "";
            dateTimePickerOne.Value = DateTime.Now;
            dateTimePickerTwo.Value = DateTime.Now;
            dateTimePickerThree.Value = DateTime.Now;
            dateTimePickerFour.Value = DateTime.Now;
            dateTimePickerFive.Value = DateTime.Now;
        }
    }
}
