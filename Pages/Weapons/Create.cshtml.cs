using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace CIDM_3312_Final_Project.Pages.Weapons
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Weapon Weapon { get; set; }

        public SelectList ManufacturerOptions { get; set; }

        public void PopulateManufacturers()
        {
            ManufacturerOptions = new SelectList(_context.Manufacturers, "ManufacturerID", "Name", Weapon?.ManufacturerID);
        }

        public void OnGet()
        {
            PopulateManufacturers();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PopulateManufacturers();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Weapons.Add(Weapon);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}

