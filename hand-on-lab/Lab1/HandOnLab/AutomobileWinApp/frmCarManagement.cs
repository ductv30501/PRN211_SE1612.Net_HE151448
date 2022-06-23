using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarManagement : Form
    {
        ICarRepository carRepository = new CarRepository();
        public frmCarManagement()
        {
            InitializeComponent();
        }

        BindingSource source;

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvCarList.CellDoubleClick += dgvCarList_CellClick;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadCarList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Add car",
                insertOrUpdate = false,
                carRepository = carRepository
            };
            if (frmCarDetails.ShowDialog()== DialogResult.OK)
            {
                loadCarList();
                source.Position = source.Count - 1;
            }

        }

        private void dgvCarList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails
            {
                Text = "Update Car",
                insertOrUpdate = true,
                carInfo = GetCarObject(),
                carRepository = carRepository
            };
            if (frmCarDetails.ShowDialog()== DialogResult.OK)
            {
                loadCarList();
                source.Position = source.Count - 1;
            }
        }

        private void loadCarList()
        {
            var cars = carRepository.GetCars();
            try
            {
                source = new BindingSource();
                source.DataSource = cars;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtManufacturer.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text",source,"CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManufacturer.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;
                if (cars.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void ClearText()
        {
            txtCarID.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }

        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Munafacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Get car");
            }
            return car;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.deleteCar(car.CarID);
                loadCarList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
