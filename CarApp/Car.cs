using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Car
    {
        #region Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public DateOnly ProductionDate { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public DateOnly LastCheckupDate { get; set; }
        
        #endregion

        public Car(string make, string model, DateOnly productionDate, DateOnly registrationDate, DateOnly lastCheckupDate) 
        {
            Make = make;
            Model = model;
            ProductionDate = productionDate;
            RegistrationDate = registrationDate;
            LastCheckupDate = lastCheckupDate;
        }
    }
}
