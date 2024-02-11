using examen_daw.ContextModels;
using examen_daw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace examen_daw.Pages
{
    public class StergereModel : PageModel
    {
        [BindProperty]
        public Film Film { get; set; } = new Film();

        [TempData]
        public string ConfirmareMesaj { get; set; }


        private readonly ApplicationDbContext _context;

        public StergereModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id, string userConfirmare)
        {
            Film = _context.Filme.FirstOrDefault(f => f.Filmid == id);

            if(userConfirmare == "true")
            {
                _context.Remove(Film);
                _context.SaveChanges();
            }

            return Page();
        }

    }
}
