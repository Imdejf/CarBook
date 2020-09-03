using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarBook
{
    public partial class FormAddCar : Form
    {
        public FormAddCar()
        {
            InitializeComponent();
        }
        CAR car = new CAR();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string carBrand = textBoxBrand.Text;
            string carBody = textBoxBody.Text;
            string carMilage = textBoxMilage.Text;
            string carEngine = textBoxEngine.Text;
            string carNumberEnigne = textBoxNumberEngine.Text;
            string carRegistration = textBoxRegistration.Text;
            string carModel = textBoxModel.Text;
            string carPathImage = textBoxPath.Text;
            DateTime carProduction = dateTimePickerProduction.Value;
            DateTime carBuy = dateTimePickerBuy.Value;
            byte[] carImage = null;
            try
            {
                FileStream fstream = new FileStream(this.textBoxPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                carImage = br.ReadBytes((int)fstream.Length);
                if (carBrand.Trim().Equals("") || carBody.Trim().Equals("") || carMilage.Trim().Equals("") || carRegistration.Trim().Equals("") || carModel.Trim().Equals(""))
                {
                    MessageBox.Show("Nie uzupełniłeś wszystkich pól", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool insertCar = car.insertCar(carBrand, carBody, carMilage, carEngine, carNumberEnigne, carRegistration, carModel, carBuy, carProduction, carImage, carPathImage);
                    if (insertCar)
                    {
                        dataGridView1.DataSource = car.getCars();
                        MessageBox.Show("Dodano pojazd", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nie zapisano danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Musiz wybrać zdjęcie", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBody.Text = "";
            textBoxBrand.Text = "";
            textBoxEngine.Text = "";
            textBoxMilage.Text = "";
            textBoxModel.Text = "";
            textBoxNumberEngine.Text = "";
            textBoxRegistration.Text = "";
            dateTimePickerProduction.Value = DateTime.Now;
            dateTimePickerBuy.Value = DateTime.Now;
            pictureBoxAdd.Image = null;

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFd = new OpenFileDialog();
                openFd.Filter = "Images only.(*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

                DialogResult dr = openFd.ShowDialog();

                pictureBoxAdd.Image = Image.FromFile(openFd.FileName);

                textBoxPath.Text = openFd.FileName;
            }
            catch (Exception)
            {

            }
        }
        //DataGridView displayed in texBox and pictureBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
            try
            {
                byte[] data = new byte[0];
                data = (byte[])dataGridView1.SelectedCells[9].Value;
                MemoryStream mem = new MemoryStream(data);
                pictureBoxAdd.Image = Image.FromStream(mem);
                textBoxBrand.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxModel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxRegistration.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerBuy.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                dateTimePickerProduction.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                textBoxBody.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxMilage.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxNumberEngine.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBoxEngine.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBoxPath.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
              
            }
            catch (Exception)
            { 
            }

        }
        //Name dataGridView displayed user
        private void FormAddCar_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = car.getCars();
            dataGridView1.Columns[0].HeaderCell.Value = "Marka";
            dataGridView1.Columns[1].HeaderCell.Value = "Model";
            dataGridView1.Columns[2].HeaderCell.Value = "Numer rejestracyjny";
            dataGridView1.Columns[3].HeaderCell.Value = "Data zakupu";
            dataGridView1.Columns[4].HeaderCell.Value = "Rok produkcji";
            dataGridView1.Columns[5].HeaderCell.Value = "Numer nadwozia";
            dataGridView1.Columns[6].HeaderCell.Value = "Przebieg";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
                if (car.removeCar(id))
                {
                    dataGridView1.DataSource = car.getCars();
                    MessageBox.Show("Pojazd usunięty", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonClear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Nie udało się usunąć pojazdu", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string carBrand = textBoxBrand.Text;
            string carBody = textBoxBody.Text;
            string carMilage = textBoxMilage.Text;
            string carEngine = textBoxEngine.Text;
            string carNumberEnigne = textBoxNumberEngine.Text;
            string carRegistration = textBoxRegistration.Text;
            string carModel = textBoxModel.Text;
            DateTime carProduction = dateTimePickerProduction.Value;
            DateTime carBuy = dateTimePickerBuy.Value;
            string carPathImage = textBoxPath.Text;
            byte[] carImage = null;
            try
            {
                FileStream fstream = new FileStream(this.textBoxPath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                carImage = br.ReadBytes((int)fstream.Length);
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
                if (carBrand.Trim().Equals("") || carBody.Trim().Equals("") || carMilage.Trim().Equals("") || carRegistration.Trim().Equals("") || carModel.Trim().Equals(""))
                {
                    MessageBox.Show("Nie uzupełniłeś wszystkich pól", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool editCar = car.editCar(carBrand, carBody, carMilage, carEngine, carNumberEnigne, carRegistration, carModel, carProduction, carBuy, carPathImage, carImage, id);
                    if (editCar)
                    {
                        dataGridView1.DataSource = car.getCars();
                        MessageBox.Show("Wprowadzono nowe zmiany", "Edytowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się wprowadzić zmian", "Edytowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Edytowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}


