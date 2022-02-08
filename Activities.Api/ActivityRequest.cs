﻿namespace Activities.Api
{
    public class ActivityRequest
    {
        private const int maxPageSize = 20;
        private int _pageSize = 10;

        public int PageNumber { get; set; } = 1;
        public int PageSize { 
            get => _pageSize; 
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value; }
    }
}
