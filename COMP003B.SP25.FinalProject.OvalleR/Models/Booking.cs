using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.FinalProject.OvalleR.Models
{
    public class Booking 
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int ServiceId { get; set; } 

        public virtual Car? Car { get; set; }
        public virtual Service? Service { get; set; }
    }
}
