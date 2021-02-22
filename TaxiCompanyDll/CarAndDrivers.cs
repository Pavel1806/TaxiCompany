using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiCompanyDll
{
    public class CarAndDrivers
    {
        /// <summary>
        /// Добавление данных в базу данных
        /// </summary>
        public void EntryCarAndDrivers()
        {
            using (AppDatabase db = new AppDatabase())
            {
                //Базу данных подключил на хостинге из за этого закоментировал все добавление пользователей.
                //В базе есть данные

                //Driver Alex = new Driver { Name = "Алексей" };
                //Driver Ivan = new Driver { Name = "Иван" };
                //Driver Anatoly = new Driver { Name = "Анатолий" };
                //Driver Evgen = new Driver { Name = "Евгений" };
                //Driver Vasiliy = new Driver { Name = "Василий" };
                //Driver Dmitriy = new Driver { Name = "Дмитрий" };
                //Driver Alexandr = new Driver { Name = "Александр" };

                //db.Drivers.AddRange(Alex, Ivan, Anatoly, Evgen, Vasiliy, Dmitriy, Alexandr);

                //Car Niva = new Car { Brand = "Нива" };
                //Car Toyota = new Car { Brand = "Тойота" };
                //Car BMW = new Car { Brand = "BMW" };
                //Car KIA = new Car { Brand = "KIA" };

                //db.Cars.AddRange(Niva, Toyota, BMW, KIA);

                //Trip Moscow = new Trip() { City = "Москва", dateTime = new DateTime(2021, 03, 03, 03, 03, 03), Car = Niva, Driver= Dmitriy };
                //Trip Pushkino = new Trip() { City = "Пушкино", dateTime = new DateTime(2021, 05, 05, 03, 03, 03), Car = BMW, Driver = Dmitriy };
                //Trip Korolev = new Trip() { City = "Королев", dateTime = new DateTime(2021, 06, 06, 03, 03, 03), Car = Niva, Driver = Vasiliy };
                //Trip Korolev2 = new Trip() { City = "Королев", dateTime = new DateTime(2021, 08, 08, 03, 03, 03), Car = BMW, Driver = Vasiliy };
                //Trip Pushkino2 = new Trip() { City = "Пушкино", dateTime = new DateTime(2021, 05, 05, 04, 04, 04), Car = Toyota, Driver = Alexandr };
                //Trip Moscow2 = new Trip() { City = "Пушкино", dateTime = new DateTime(2021, 06, 06, 04, 04, 04), Car = KIA, Driver = Anatoly };

                //db.Trips.AddRange(Moscow);

                //db.SaveChanges();
            }
        }


    }
}

