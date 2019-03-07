using System;

namespace DataBindingExample.Models
{
    public struct CarouselDataItemModel
    {
        public string Id { get; set; }
        public Uri CImage { get; set; }

        public CarouselDataItemModel(string id, Uri image)
        {
            Id = id;
            CImage = image;
        }
    }
}
