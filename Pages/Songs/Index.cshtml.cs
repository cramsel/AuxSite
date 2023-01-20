using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AuxCordSite.Data;
using AuxCordSite.Models;

namespace AuxCordSite.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly AuxCordSite.Data.AuxCordSiteContext _context;

        public IndexModel(AuxCordSite.Data.AuxCordSiteContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Song != null)
            {
                Song = await _context.Song.ToListAsync();
            }
        }
    }
}
