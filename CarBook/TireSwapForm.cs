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
    public partial class TairSwapForm : Form
    {
        CONNECT conn = new CONNECT();
        TIRESWAP tires = new TIRESWAP();

        public TairSwapForm()
        {
            InitializeComponent();
        }
        //Name dataGridView displayed user
        private void TairSwapForm_Load(object sender, EventArgs e)
        {
            
            dataGridViewCar.DataSource = tires.getCar();
            dataGridViewCar.Columns[3].Visible = false;
            dataGridViewCar.Columns[0].HeaderCell.Value = "Marka";
            dataGridViewCar.Columns[1].HeaderCell.Value = "Model";
            dataGridViewCar.Columns[2].HeaderCell.Value = "Numer rejestracyjny";
        }
        //DataGridView displayed in texBox

        private void dataGridViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxChoice.Text = dataGridViewCar.CurrentRow.Cells[0].Value.ToString();
            textBoxID.Text = dataGridViewCar.CurrentRow.Cells[3].Value.ToString();
            int id = Convert.ToInt32(textBoxID.Text);
            dataGridViewTire.DataSource = tires.DisplayTire(id);
            dataGridViewTire.Columns[3].Visible = false;
            dataGridViewTire.Columns[0].HeaderCell.Value = "Nazwa";
            dataGridViewTire.Columns[1].HeaderCell.Value = "Rozmiar";
            dataGridViewTire.Columns[2].HeaderCell.Value = "Data wymiany";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            { 
            string tireName = textBoxTireName.Text;
            string tireSize = textBoxTireSize.Text;
            int tireIdentityID = Convert.ToInt32(textBoxID.Text);
            DateTime tireSwap = dateTimePickerSwapTire.Value;

                if (textBoxChoice.Text == "Wybrany pojazd")
                {
                    MessageBox.Show("Nie wybrałeś pojazdu", "Dodaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tireName.Trim().Equals("") || tireSize.Trim().Equals(""))
                {
                    MessageBox.Show("Nie uzupełniłeś wszystkich pól", "Dodaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  bool insertTire = tires.insertTire(tireName, tireSize, tireSwap, tireIdentityID);
                    if (insertTire)
                    {
                        dataGridViewTire.DataSource = tires.getTire();
                        MessageBox.Show("Dodano oponę", "Dodaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonClear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Błąd zapisu", "Dodaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTireName.Text = dataGridViewTire.CurrentRow.Cells[0].Value.ToString();
            textBoxTireSize.Text = dataGridViewTire.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerSwapTire.Value = Convert.ToDateTime(dataGridViewTire.CurrentRow.Cells[2].Value);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewTire.CurrentRow.Cells[3].Value);
                if(tires.removeTire(id))
                {
                    dataGridViewTire.DataSource = tires.getTire();
                    MessageBox.Show("Usunięto pomyślnie", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonClear.PerformClick();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Usuń", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTireName.Text = "";
            textBoxTireSize.Text = "";
            dateTimePickerSwapTire.Value = DateTime.Now;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridViewTire.CurrentRow.Cells[3].Value);
            string tireName = textBoxTireName.Text;
            string tireSize = textBoxTireSize.Text;
            DateTime tireSwap = dateTimePickerSwapTire.Value;
            try
            {
                if (tireName.Trim().Equals("") || tireSize.Trim().Equals(""))
                {
                    MessageBox.Show("Wypełnij wszystkie pola", "Edytuj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool editTire = tires.editTire(tireName, tireSize, tireSwap,ID);
                        if (editTire)
                        {
                        dataGridViewTire.DataSource = tires.getTire();
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
                MessageBox.Show($"{ex.Message}", "Edytuj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
