using eTickets.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public Moviecategory Moviecategory { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
