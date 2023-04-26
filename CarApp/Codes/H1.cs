using CarApp.Codes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Codes
{
    internal class H1 : IHovedForloeb
    {
        public string[] Teachers { get; set; }
        public string[] Studends { get; set; }
        public string[] Corses { get; set; }

        public H1()
        {
            Teachers = new string[] { "Nils Olsen", "Stan Pines"};
            Studends = new string[0];
            Corses = new string[0];
        }
    }
}
