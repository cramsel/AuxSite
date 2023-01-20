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
    public class DetailsModel : PageModel
    {
        private readonly AuxCordSite.Data.AuxCordSiteContext _context;

        public DetailsModel(AuxCordSite.Data.AuxCordSiteContext context)
        {
            _context = context;
        }

      public Song Song { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }
            else 
            {
                Song = song;
            }
            return Page();
        }
    }
}
