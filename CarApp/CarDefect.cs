using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp;

internal class CarDefect
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public DateOnly ProductionDate { get; set; }
    public string Defect { get; set; }

    public CarDefect(string brand, string model, DateOnly prodouctionDate, string defect)
    {
        Brand = brand;
        Model = model;
        ProductionDate = prodouctionDate;
        Defect = defect;
    }
}
