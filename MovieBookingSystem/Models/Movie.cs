using Microsoft.EntityFrameworkCore;
using MovieBookingSystem.Data.Enums;
using MovieBookingSystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Movie
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    public string MovieName { get; set; }

    [MaxLength(500)]
    public string MovieDescription { get; set; }

    [Precision(18, 2)]
    public double MoviePrice { get; set; }

    [MaxLength(1000)]
    public string MovieImageURL { get; set; }

    public DateTime MovieStartDate { get; set; }

    public DateTime MovieEndDate { get; set; }

    [MaxLength(100)]
    public MovieCategory MovieCategory { get; set; }

    // Relationships
    public List<Actor_Movie> Actors_Movies { get; set; }

    // Cinema Relationship
    public int CinemaId { get; set; } // Foreign Key

    [ForeignKey("CinemaId")]
    public Cinema Cinema { get; set; } // Navigation Property

    // Producer Relationship
    public int ProducerId { get; set; } // Foreign Key

    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; } // Navigation Property
}
