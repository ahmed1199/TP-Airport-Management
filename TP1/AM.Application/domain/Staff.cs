using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Application.domain
{
    internal class Staff : Passenger
    {
        public DateTime? EmploymentDate { get; set; }
        public string? Function { get; set; }
        public float? Salary { get; set; }


        public override string? ToString()
        {
            return base.ToString();
        }

        public override void PassengerType() {
            base.PassengerType();
            Console.WriteLine(" I'am a Staff Memeber");
        }

    }
}
