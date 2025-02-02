﻿using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMvcContext _context;

    public DepartamentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}


