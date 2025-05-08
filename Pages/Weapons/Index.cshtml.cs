using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CIDM_3312_Final_Project.Pages.Weapons
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Weapon> Weapons { get; set; } = default!;
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        public async Task OnGetAsync(int? pageNumber)
        {
            int pageSize = 10;
            CurrentPage = pageNumber ?? 1;

            var query = _context.Weapons
                        .Include(w => w.Manufacturer)
                        .AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(w => w.Name.Contains(SearchString));
            }

            switch (SortOrder)
            {
                case "name_desc":
                    query = query.OrderByDescending(w => w.Name);
                    break;
                default:
                    query = query.OrderBy(w => w.Name);
                    break;
            }

            int totalWeapons = await query.CountAsync();
            TotalPages = (int)System.Math.Ceiling(totalWeapons / (double)pageSize);

            Weapons = await query
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}
