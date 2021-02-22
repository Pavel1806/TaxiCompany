using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxiCompanyDll
{
   public  class OutputDB
    {
        /// <summary>
        /// Запрос выводящий на консоль "Имя водителя"-"город поездки"-"время поездки"-"марка машины"
        /// </summary>
       public void OutputDbConsole()
        {
            using (AppDatabase db = new AppDatabase())
            {
                var t = db.Trips.Join(db.Drivers, p => p.DriverId, c => c.Id, 
                    (p, c)=> new { 
                    
                        p.City,
                        p.Id,
                        p.dateTime,
                        c.Name,
                        p.CarId
                    
                    }).Join(db.Cars, b=>b.CarId, a=>a.Id, 
                    (b, a)=>new { 
                    
                        b.Name,
                        a.Brand,
                        b.City,
                        b.dateTime
                    });

                foreach(var item in t)
                {
                    Console.WriteLine($"Имя водителя-{item.Name}; город поездки-{item.City}; время поездки-{item.dateTime}; машина-{item.Brand}");
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
       
    }
}
