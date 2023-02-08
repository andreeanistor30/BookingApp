using System.Dynamic;

namespace Booking.Pagination
{
    public class PaginationParameters
    {
        const int maxPageSize = 20;

        public int PageNumber { get; set; } = 1;

        public int pageSize = 6;
        public int PageSize
        {
            get
            {
                return pageSize;
            }

            set
            {
                pageSize = value > maxPageSize ? maxPageSize: value ;
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
            if(PageSize < 0) { return false; }
            return true;
        }
    }
}
