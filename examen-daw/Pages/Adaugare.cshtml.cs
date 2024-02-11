using examen_daw.ContextModels;
using examen_daw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace examen_daw.Pages
{
    public class AdaugareModel : PageModel
    {
        [BindProperty]
        public Film Film { get; set; } = new Film();

        private readonly ApplicationDbContext _context;


        public AdaugareModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            _context.Add(Film);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
       
    }
}
