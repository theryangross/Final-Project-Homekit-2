using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_Homekit_2.Models;

namespace Final_Project_Homekit_2.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Final_Project_Homekit_2.Models.HomekitDbContext _context;

        public DetailsModel(Final_Project_Homekit_2.Models.HomekitDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Brand)
                .Include(p => p.Category).FirstOrDefaultAsync(m => m.ProductID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
