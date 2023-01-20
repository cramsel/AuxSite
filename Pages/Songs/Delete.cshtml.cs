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
    public class DeleteModel : PageModel
    {
        private readonly AuxCordSite.Data.AuxCordSiteContext _context;

        public DeleteModel(AuxCordSite.Data.AuxCordSiteContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }
            var song = await _context.Song.FindAsync(id);

            if (song != null)
            {
                Song = song;
                _context.Song.Remove(Song);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
