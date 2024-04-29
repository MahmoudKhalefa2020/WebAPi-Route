﻿namespace Talabat.Core.Specifications.ProductSpecs
{
    public class ProductSpecParams
    {
        private const int maxSize = 10;
        private int pageSize = 5;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > maxSize ? maxSize : value; }
        }

        public string? Sort { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }

        public int PageIndex { get; set; } = 1;
    }
}