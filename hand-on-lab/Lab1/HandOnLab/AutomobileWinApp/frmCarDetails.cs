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
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public ICarRepository carRepository { get; set; }
        public bool insertOrUpdate { get; set; }
        public Car carInfo { get; set; }
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !insertOrUpdate;
            if (insertOrUpdate == true)
            {
                txtCarID.Text = carInfo.CarID.ToString();
                txtCarName.Text = carInfo.CarName;
                txtPrice.Text = carInfo.Price.ToString();
                txtReleaseYear.Text = carInfo.ReleaseYear.ToString();
                cboManufacturer.Text = carInfo.Munafacturer.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car()
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (insertOrUpdate == false)
                {
                    carRepository.insertCar(car);
                }
                else
                {
                    carRepository.updateCar(car);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, insertOrUpdate == false ? "add new car " : "update new car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
