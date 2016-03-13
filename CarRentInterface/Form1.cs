﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRent;

namespace CarRentInterface
{
    public partial class Form1 : Form
    {
        private Car[] _cars;
        CarService carService;
        public Form1(Car[] cars)
        {
            var repository = new CarRentRepository();
            carService = new CarService(_cars, repository);
            _cars = cars;
            InitializeComponent();
            carList.Items.AddRange(cars);
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            var rentedCar = (Car)carList.SelectedItem;
            if (rentedCar == null)
            {
                return;
            }
            var client = new Client(textBoxName.Text);
            var rentedFrom = dateTimePicerFrom.Value;
            var rentedTo = dateTimePickerTo.Value;
            var rent = new Rent(rentedFrom, rentedTo, client, rentedCar);
            carService.RentCar(rent);
        }

        private void carList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCar = (Car)carList.SelectedItem;
            labelDescription.Text = selectedCar.Description;
        }
    }
}