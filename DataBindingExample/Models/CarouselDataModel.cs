using System.Collections.Generic;

namespace DataBindingExample.Models
{
    public struct CarouselDataModel
    {
        public string CLabel { get; set; }
        public List<CarouselDataItemModel> CItems { get; set; }
    }
}
