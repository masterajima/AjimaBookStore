using System;
using System.Collections.Generic;
using System.Text;



using System.Linq;

using System.Threading.Tasks;

namespace Azima1Books.Models.ViewModels
{
    class ProductVm
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
