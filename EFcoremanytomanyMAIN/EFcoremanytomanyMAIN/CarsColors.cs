using System.ComponentModel.DataAnnotations.Schema;

namespace EFcoremanytomanyMAIN
{
    public class CarsColors
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public Color Color { get; set; }
    }
}
