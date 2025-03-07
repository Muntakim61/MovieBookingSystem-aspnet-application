using System.ComponentModel.DataAnnotations;

namespace MovieBookingSystem.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string CinemaName { get; set; }

        public string CinemaLogo { get; set; }

        public string CinemaDescription { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
