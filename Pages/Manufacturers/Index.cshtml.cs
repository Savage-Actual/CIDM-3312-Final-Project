using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM_3312_Final_Project.Models;
using CIDM_3312_Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIDM_3312_Final_Project.Pages.Manufacturers
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Manufacturer> ManufacturerList { get; set; }

        public async Task OnGetAsync()
        {
            ManufacturerList = await _context.Manufacturers.ToListAsync();
        }
    }
}
