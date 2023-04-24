using CarApp;
using System.Runtime.Intrinsics.X86;
using System;

const string VERSION = "Car app ver. 0.1 ";


CarDefect[] carDefectsList = new CarDefect[]
{
    new CarDefect("fiat", "punto", new DateOnly(2010,1,1), "Udstøning"),
    new CarDefect("alfa romeo", "giulia", new DateOnly(2019, 8, 1), "Styretøjet")
};

string carBrand;
string carModel;
DateOnly carProductionDate;
DateOnly carRegistrationDate;
DateOnly carLastCheckupDate;


do
{
    ResetScreen();
    Console.Write("Car Mærke : ");
}
while (string.IsNullOrEmpty(carBrand = Console.ReadLine()));

do
{
    ResetScreen();
    Console.Write("Car Model : ");
}
while (string.IsNullOrEmpty(carModel = Console.ReadLine()));

GetDateFromUser("Productions", out carProductionDate);
GetDateFromUser("Registraring", out carRegistrationDate);
GetDateFromUser("Sidste syn", out carLastCheckupDate);

ResetScreen();

Checkup checkup = new Checkup(carRegistrationDate, carLastCheckupDate);

if (checkup.NeedsCheckup) Console.WriteLine("Bilen skal til syn");
else Console.WriteLine("Bilen skal ikke til syn");

foreach (CarDefect defect in carDefectsList)
{
    if (carBrand.ToLower() == defect.Brand && carModel.ToLower() == defect.Model && carProductionDate < defect.ProductionDate)
    {
        Console.WriteLine($"Bilen har følgende fabriksfejl: {defect.Defect}");
        break;
    }
}




#region Methods

static void ResetScreen()
{
    Console.Clear();
    Console.WriteLine(VERSION);
    for (int i = Console.WindowWidth - 1; i >= 0; i--)
        Console.Write("=");
}

static void GetDateFromUser(string dateTitle, out DateOnly Date)
{
    int year = 1801;
    int month = 1;
    int day = 1;
    bool validInput = true;

    do
    {
        ResetScreen();
        if (!validInput)
            Console.WriteLine("Jeg forstod ikke Hvad du skrav");

        
        Console.Write($"{dateTitle} dato år : ");
        validInput = (int.TryParse(Console.ReadLine(), out year) && year <= 9999 && year > 1800);
    }
    while (!validInput);

    do
    {
        ResetScreen();
        if (!validInput)
            Console.WriteLine("Jeg forstod ikke Hvad du skrav");
        Console.Write($"{dateTitle} dato måned : ");
        validInput = (int.TryParse(Console.ReadLine(), out month) && month <= 12 && month > 0);
    }
    while (!validInput);

    do
    {
        ResetScreen();
        if (!validInput)
            Console.WriteLine("Jeg forstod ikke Hvad du skrav");
        Console.Write($"{dateTitle} dato dag : ");
        validInput = (int.TryParse(Console.ReadLine(), out day) && day <= 31 && day > 0);
    }
    while (!validInput);

    Date = new DateOnly(year, month, day);
}


#endregion