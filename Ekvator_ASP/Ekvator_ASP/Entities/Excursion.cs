using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekvator_ASP.Entities
{
    public class Excursion
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Transport { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
