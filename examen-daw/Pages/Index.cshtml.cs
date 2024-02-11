using examen_daw.ContextModels;
using examen_daw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace examen_daw.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public int? AnCautare { get; set; }
        public List<Film> Filme { get; set; }

       // public void OnGet()
       // {
        //    Filme = _context.Filme.Include(f => f.Recenzii).ToList();
       // }

        public void OnGet(int? anCautare)
        {
            AnCautare = anCautare;
            if (AnCautare.HasValue)
            {
                Filme = _context.Filme.Include(f => f.Recenzii)
                    .Where(f => f.An == AnCautare.Value)
                    .ToList();
            }
            else
            {
                Filme = _context.Filme.Include(f => f.Recenzii).ToList();
            }
        }
    }
}
