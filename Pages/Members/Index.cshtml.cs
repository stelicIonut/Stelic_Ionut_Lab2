﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stelic_Ionut_Lab2.Data;
using Stelic_Ionut_Lab2.Models;

namespace Stelic_Ionut_Lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Stelic_Ionut_Lab2.Data.Stelic_Ionut_Lab2Context _context;

        public IndexModel(Stelic_Ionut_Lab2.Data.Stelic_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
