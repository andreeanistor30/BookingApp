using System.Dynamic;

namespace Booking.Pagination
{
    public class PaginationParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value > maxPageSize ? maxPageSize : value;
            }
        }


        public struct SortingParams
        {
            public string SortingCriteria;
            public bool AscendingOrder;
        }

        public SortingParams? SortingParameters { get; set; }


        public bool ValidParameters()
        {
            if (PageNumber < 0) { return false; }
            if (PageSize < 0) { return false; }
            return true;
        }
    }
}
