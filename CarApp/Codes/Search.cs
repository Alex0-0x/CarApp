using CarApp.Codes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Codes
{
    internal class Search
    {
        private readonly IHovedForloeb _hovedForloeb;

        // Search constructor to instanciate the felds
        public Search(IHovedForloeb hovedForloeb) => _hovedForloeb = hovedForloeb;

        public string[] GetTeachers()
        {
            return _hovedForloeb.Teachers;
        }
    }
}
