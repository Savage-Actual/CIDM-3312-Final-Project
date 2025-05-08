using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIDM_3312_Final_Project.Data;
using CIDM_3312_Final_Project.Models;

namespace CIDM_3312_Final_Project.Pages_Weapons
{
    public class DetailsModel : PageModel
    {
        private readonly CIDM_3312_Final_Project.Data.AppDbContext _context;

        public DetailsModel(CIDM_3312_Final_Project.Data.AppDbContext context)
        {
            _context = context;
        }

        public Weapon Weapon { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapons.FirstOrDefaultAsync(m => m.WeaponID == id);

            if (weapon is not null)
            {
                Weapon = weapon;

                return Page();
            }

            return NotFound();
        }
    }
}
