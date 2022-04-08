using System.Collections.Generic;

namespace Chart_in_Core.Models
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int ViewCount { get; set; }
    }

    public class ProductDetailsModel
    {
        public List<ProductDetailsDto> productDetails { get; set; }
    }
}
