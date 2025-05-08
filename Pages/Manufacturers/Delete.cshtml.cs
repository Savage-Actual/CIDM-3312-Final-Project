using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_Final_Project.Pages.Manufacturers
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manufacturer Manufacturer { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(m => m.ManufacturerID == id);

            if (Manufacturer == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Manufacturer = await _context.Manufacturers.FindAsync(id);

            if (Manufacturer != null)
            {
                _context.Manufacturers.Remove(Manufacturer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
