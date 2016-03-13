using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRent;

namespace CarRentInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var hardCodedCarList = new Car[]
            {
                new Car("BMW", "Description BWM"),
                new Car("Ford", "Description Ford"),
                new Car("Lada", "Description Lada"),
                new Car("Nissan", "Description Nissan")
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(hardCodedCarList));
        }
    }
}
