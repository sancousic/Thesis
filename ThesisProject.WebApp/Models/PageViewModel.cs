﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThesisProject.WebApp.Models
{
    public class PageViewModel
    {
        public PageViewModel(int page, int size, int count)
        {
            PageSize = size;
            Page = page;
            TotalPages = (int)Math.Ceiling(count / (double)size);
        }
        public int PageSize { get; set; } = 10;
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public bool HasPrebiousPage
        {
            get => Page > 1;
        }
        public bool HasNextPage { get => Page < TotalPages; }
    }
}
