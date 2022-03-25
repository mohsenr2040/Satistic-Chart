using Chart_in_Core.Models.ChartModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Models.ViewModels
{
    public class SellerProductsViewModel
    {
        public List<SellerProductsDto> productsDtos { get; set; }
        public string CodMelli { get; set; }
        public int ddl_sourceId { get; set; }
        public List<SimpleReportViewModel> SimpleReports { get; set; }

        public List<ProductDetailsDto>  productDetailsDtos { get; set; }
        public int ProductId { get; set; }
    }
}
