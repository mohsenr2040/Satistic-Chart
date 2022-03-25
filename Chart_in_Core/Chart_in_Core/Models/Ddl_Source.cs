using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart_in_Core.Models
{
    public class Ddl_Source
    {
        public int Id { get; set; }
        //    public string item_Value { get; set; }
        public List<SelectListItem> Select { set; get; }
    }

}
