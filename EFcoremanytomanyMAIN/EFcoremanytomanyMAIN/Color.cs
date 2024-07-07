namespace EFcoremanytomanyMAIN
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarsColors> CarsColors { get; set; }
    }
}
