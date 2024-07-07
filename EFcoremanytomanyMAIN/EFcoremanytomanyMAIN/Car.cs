namespace EFcoremanytomanyMAIN
{
    public class Car
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        //public int ColorId { get; set; }
        public double MaxSpeed { get; set; }
        public double FuelTankCapacity { get; set; }
        public double Power { get; set; }
        public int DoorCount { get; set; }
        public Model Model { get; set; }
        //public Color Color { get; set; }
        public List<CarsColors> CarsColors { get; set; }

        //public override string ToString()
        //{
        //    return $"{Id} {MaxSpeed} {FuelTankCapacity} {Power} {DoorCount}";
        //}
    }
}
