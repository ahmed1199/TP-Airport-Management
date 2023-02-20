using AM.Application.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.Interfaces
{
    internal interface IServiceFlight
    {
        public IEnumerable<DateTime> GetFlightDates(string destination);
    }
}
