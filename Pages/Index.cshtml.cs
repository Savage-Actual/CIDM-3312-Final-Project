using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIDM_3312_Final_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Weapon> FeaturedWeapons { get; set; }

        public async Task OnGetAsync()
        {
            FeaturedWeapons = await _context.Weapons
                .Include(w => w.Manufacturer)
                .OrderByDescending(w => w.DamageRating)
                .Take(5)
                .ToListAsync();
        }
    }
}

