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
                MessageBox.Show("Автомобиль для аренды не выбран");
            }
            var client = new Client(textBoxName.Text);
            var rentedFrom = dateTimePicerFrom.Value;
            var rentedTo = dateTimePickerTo.Value;
            if (rentedFrom.CompareTo(rentedTo) > 0)
            {
                MessageBox.Show("Неверный промежуток времени аренды");
            }
            else
            {
                var rent = new Rent(rentedFrom, rentedTo, client, rentedCar);
                MessageBox.Show(carService.RentCar(rent) ? String.Format($"Машина {rentedCar.Model} в вашем распоряжении!") : String.Format("Данный автомобиль уже арендован, выберите другой из списка"));
            }
        }

        private void carList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCar = (Car)carList.SelectedItem;
            labelDescription.Text = selectedCar.Description;
        }
    }
}