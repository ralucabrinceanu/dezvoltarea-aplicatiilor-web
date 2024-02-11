using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace examen_daw.Models
{
    public class Film
    {
        public int Filmid { get; set; }
        public string Titlu { get; set; }
        public int An {  get; set; }
        public string Gen { get; set; }
        public List<Recenzie> Recenzii { get; set; }


        public Film() { }
        
        public Film(int filmId, string titlu, int an, string gen, List<Recenzie> recenzii)
        {
            Filmid = filmId;
            Titlu = titlu;
            An = an;
            Gen = gen;
            Recenzii = recenzii;
        }
    }
}
