using System.ComponentModel.DataAnnotations;

namespace examen_daw.Models
{
    public class Recenzie
    {
        public int RecenzieId { get; set; }
        public string Autor {  get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        
        // fk
        public Film Film { get; set; }
        public int FilmId {  get; set; }

        public Recenzie() { }

        public Recenzie(int recenzieId, string autor, int rating, Film film, int filmId)
        {
            RecenzieId = recenzieId;
            Autor = autor;
            Rating = rating;
            Film = film;
            FilmId = filmId;
        }
    }
}
