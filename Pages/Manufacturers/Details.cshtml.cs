using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CIDM_3312_Final_Project.Pages.Manufacturers
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Manufacturer Manufacturer { get; set; }
        public List<Weapon> Weapons { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(m => m.ManufacturerID == id);

            if (Manufacturer == null)
            {
                return NotFound();
            }

            Weapons = await _context.Weapons
                .Where(w => w.ManufacturerID == id)
                .ToListAsync();

            return Page();
        }
    }
}
