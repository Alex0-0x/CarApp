using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp;

internal struct Checkup
{
    public bool NeedsCheckup { get; init; }

    public Checkup(DateOnly registrationDate, DateOnly lastCheckupDate)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);        

        if (today < registrationDate.AddYears(5))
        {
            NeedsCheckup = false;
        }
        else if (today < lastCheckupDate.AddYears(2))
        {
            NeedsCheckup = false;
        }
        else
        {
            NeedsCheckup = true;
        }
    }
}
