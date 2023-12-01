using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ExamCCI_2023.Pages.Teacher
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Model.Teacher> Teachers { get;set; } = default!;

        public async Task OnGetAsync() {
            if (_context.Teachers != null)
            {
                Teachers = await _context.Teachers.ToListAsync();
            }
        }
    }
}
