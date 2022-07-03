using System;
using System.Windows.Forms;
using WFAEntitiesAndConcrete.Entities.Concrete;
using WFAEntitiesAndConcrete.Repositories.Concrete;

namespace WFAEntitiesAndConcrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _lastFindId = 0;
        private readonly CarRepositories _carRepositories = new CarRepositories();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCars.Columns.Clear();
            dgvCars.Rows.Clear();
            dgvCars.Columns.Add("Id", "Id");
            dgvCars.Columns.Add("Brand", "Brand");
            dgvCars.Columns.Add("Model", "Model");
            dgvCars.Columns.Add("Price", "Price");
            dgvCars.Columns.Add("CreateTime", "Create Time");
            UpdateDataGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string carBrand = txtBrand.Text.Trim();
            string carModel = txtModel.Text.Trim();
            string carPrice = txtPrice.Text.Trim();
            if (carBrand == "" || carModel == "" || carPrice == "")
            {
                MessageBox.Show("Please fill all fields !");
                return;
            }

            decimal.TryParse(carPrice, out var carPriceD);
            if (carPriceD == 0)
            {
                MessageBox.Show("Please enter car price decimal !");
                return;
            }
            int maxId = 0;
            foreach (var car in SeedData.cars)
            {
                if (maxId < car.Id)
                    maxId = car.Id;
            }
            Car newCar = new Car(maxId + 1, carBrand, carModel, carPriceD);
            _carRepositories.Add(newCar);
            MessageBox.Show($"ID: {newCar.Id}\r\nBrand: {newCar.Brand}\r\nModel: {newCar.Model}\r\nPrice: {newCar.Price}\r\nAdded !");
            UpdateDataGrid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _carRepositories.ClearTextBox(gbFindCar);
            int.TryParse(txtSearchId.Text, out int id);
            if (id == 0)
            {
                MessageBox.Show("Please enter car id as integer !");
                return;
            }

            Car car = _carRepositories.GetById(id);
            if (car == null)
            {
                MessageBox.Show("Car not found !");
                return;
            }
            txtUpdateBrand.Text = car.Brand;
            txtUpdateModel.Text = car.Model;
            txtUpdatePrice.Text = car.Price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_lastFindId != 0)
            {
                string carBrand = txtUpdateBrand.Text.Trim();
                string carModel = txtUpdateModel.Text.Trim();
                string carPrice = txtUpdatePrice.Text.Trim();
                if (carBrand != "" && carModel != "" && carPrice != "")
                {
                    _carRepositories.Update(_lastFindId, new Car(_lastFindId, carBrand, carModel, decimal.Parse(carPrice)));
                    UpdateDataGrid();
                    MessageBox.Show("Car updated !");
                    _carRepositories.ClearTextBox(gbFindCar);
                    return;
                }
                MessageBox.Show("Please fill all fields !");
            }
        }

        private void UpdateDataGrid()
        {
            dgvCars.Rows.Clear();
            foreach (Car car in SeedData.cars)
            {
                dgvCars.Rows.Add(car.Id, car.Brand, car.Model, car.Price, car.CreateTime);
            }
            dgvCars.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_lastFindId != 0)
            {
                _carRepositories.Delete(_lastFindId);
                // car delete succesfully
                MessageBox.Show("Car deleted !");
                UpdateDataGrid();
                _carRepositories.ClearTextBox(gbFindCar);
            }
        }
    }
}
