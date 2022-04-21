using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekvator_ASP.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int ExcursionId { get; set; }
        public virtual Excursion Excursion { get; set; }
        public int CountPeople { get; set; }

        
    }
}

