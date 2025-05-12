using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.FinalProject.OvalleR.Models
{
    public class Service
    { 
        public int ServiceId { get; set; }
        
        [Required]
        public string ServiceType { get; set; }

        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
