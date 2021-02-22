using System;
using System.Collections.Generic;

namespace TaxiCompanyDll
{
    public class Driver
    {
        /// <summary>
        /// Идентификатор водителя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя водителя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список поездок
        /// </summary>
        public List<Trip> Trips { get; set; } = new List<Trip>();

    }
}
