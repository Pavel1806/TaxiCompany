using System;
using TaxiCompanyDll;

namespace TaxiCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAndDrivers carsDrivers = new CarAndDrivers();

            //carsDrivers.EntryCarAndDrivers();

            OutputDB output = new OutputDB();

            output.OutputDbConsole();


        }
    }
}
