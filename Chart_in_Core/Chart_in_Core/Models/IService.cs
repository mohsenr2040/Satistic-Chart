using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Models
{
    public interface IService
    {
        Task<List<SellerProductsDto>> lookup(string ncode);
        public List<ProductDetailsDto> GetDetails(string id);
    }

}
