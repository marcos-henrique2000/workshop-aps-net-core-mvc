using Microsoft.EntityFrameworkCore;
using SalesWebMcv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMcv.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMcvContext _context;

        public DepartmentService(SalesWebMcvContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
