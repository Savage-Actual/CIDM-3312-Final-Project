using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIDM_3312_Final_Project.Pages.Weapons
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Weapon> WeaponList { get; set; }

        public async Task OnGetAsync()
        {
            WeaponList = await _context.Weapons
                .Include(w => w.Manufacturer)
                .ToListAsync();
        }
    }
}

