using System.Drawing;

namespace Booking.DataTransferObjects
{
    public class HotelWriteDTO
    {
        public string Town { get; set; }

        public string Category { get; set; }

        public Image ImagePath { get; set; }

        public double Rate { get; set; }

    }
}
