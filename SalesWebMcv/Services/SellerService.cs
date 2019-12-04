using SalesWebMcv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMcv.Services
{
    public class SellerService
    {
        private readonly SalesWebMcvContext _context;

        public SellerService(SalesWebMcvContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
