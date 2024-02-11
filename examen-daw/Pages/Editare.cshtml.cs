using examen_daw.ContextModels;
using examen_daw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace examen_daw.Pages
{
    public class EditareModel : PageModel
    {
        [BindProperty]
        public Film Film { get; set; } = new Film();

        private readonly ApplicationDbContext _context;


        public EditareModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Film = _context.Filme.FirstOrDefault(f => f.Filmid == id);
        }

        public IActionResult OnPost()
        {
            _context.Update(Film);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
