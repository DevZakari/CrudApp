using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudApp.Data;
using CrudApp.Model;

namespace CrudApp.Pages.Etudiants
{
    public class IndexModel : PageModel
    {
        private readonly CrudApp.Data.CrudAppContext _context;

        public IndexModel(CrudApp.Data.CrudAppContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }

        public async Task OnGetAsync()
        {
            Etudiant = await _context.Etudiant.ToListAsync();
        }
    }
}
