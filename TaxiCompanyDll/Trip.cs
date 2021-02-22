using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiCompanyDll
{
    public class Trip
    {
        /// <summary>
        /// Идентификатор поездки
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Город поездки
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Время поездки
        /// </summary>
        public DateTime dateTime { get; set; }

        /// <summary>
        /// Внешний ключ для идентификатора машины
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// навигационное свойство для выбора машин
        /// </summary>
        public Car Car { get; set; }

        /// <summary>
        /// Внешний ключ для идентификатора водителя
        /// </summary>
        public int DriverId { get; set; }

        /// <summary>
        /// навигационное свойство для выбора водителей
        /// </summary>
        public Driver Driver { get; set; }



    }
}
