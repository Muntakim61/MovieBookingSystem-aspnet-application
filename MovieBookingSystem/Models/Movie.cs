using MovieBookingSystem.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBookingSystem.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public double MoviePrice { get; set; }
        public string MovieImageURL { get; set; }
        public DateTime MovieStartDate { get; set; }
        public DateTime MovieEndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
