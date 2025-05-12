using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP25.FinalProject.OvalleR.Models
{
    public class Car
    {
       public int CarId { get; set; }
        public string OwnerName { get; set; }
        public string ModelCar { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
