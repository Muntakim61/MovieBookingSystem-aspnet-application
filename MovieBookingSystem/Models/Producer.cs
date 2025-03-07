using System.ComponentModel.DataAnnotations;

namespace MovieBookingSystem.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProducerPictureProfile { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
