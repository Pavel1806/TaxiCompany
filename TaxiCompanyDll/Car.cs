using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiCompanyDll
{
    public class Car
    {
        /// <summary>
        /// Идентификатор машины
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Марка машины
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// список поездок
        /// </summary>
        public List<Trip> Trips { get; set; } = new List<Trip>();
    }
}
