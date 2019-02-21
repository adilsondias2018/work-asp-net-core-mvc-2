using SalesWebMvc01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc01.Services
{
    public class SellerService
    {

        private readonly SalesWebMvc01Context _context;

        public SellerService(SalesWebMvc01Context context)
        {
            _context = context;

            
        }

        // buscando o dados no banco e exibindo em uma lista.
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }



    }
}
