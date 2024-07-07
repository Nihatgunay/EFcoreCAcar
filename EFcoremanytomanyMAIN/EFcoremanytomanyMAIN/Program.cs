using Microsoft.EntityFrameworkCore;

namespace EFcoremanytomanyMAIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("""
                              1.Brand Methods
                              2.Model Methods
                              3.Color Methods
                              4.Car Methods
                                choose something:
                              """);
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("""
                              1.create brand
                              2.Get brand by id 
                              3.GetAll brands
                              4.update brand
                              5.delete brand
                                choose something:
                              """);
                        int brandchoice = int.Parse(Console.ReadLine());
                        switch (brandchoice)
                        {
                            case 1:
                                Console.Write("enter name of a brand: ");
                                string namebrand = Console.ReadLine();
                                if (namebrand != null)
                                {
                                    CreateBrand(new Brand
                                    {
                                        Name = namebrand
                                    });
                                    Console.WriteLine("brand created!");
                                }
                                break;
                            case 2:
                                Console.Write("enter brand id: ");
                                int brandid = int.Parse(Console.ReadLine());
                                Console.WriteLine(GetBrandById(brandid).Name);
                                break;
                            case 3:
                                GetAllBrands();
                                break;
                            case 4:
                                Console.Write("enter brand id: ");
                                int updbrandid = int.Parse(Console.ReadLine());
                                Console.Write("enter brand name: ");
                                string bname = Console.ReadLine();
                                if (bname != null)
                                {
                                    UpdateBrand(updbrandid,new Brand { Name = bname });
                                    Console.WriteLine($"brand name updated to {bname}");
                                }
                                break;
                            case 5:
                                Console.Write("enter brand id: ");
                                int delbrandid = int.Parse(Console.ReadLine());
                                DeleteBrand(delbrandid);
                                Console.WriteLine("brand deleted");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("""
                              1.create model
                              2.Get model by id 
                              3.GetAll models
                              4.update model
                              5.delete model
                                choose something:
                              """);
                        int modelchoice = int.Parse(Console.ReadLine());
                        switch (modelchoice)
                        {
                            case 1:
                                Console.Write("enter model name: ");
                                string namemodel = Console.ReadLine();
                                Console.Write("enter model branId: ");
                                int modelbrandId = int.Parse(Console.ReadLine());
                                if (namemodel != null)
                                {
                                    CreateModel(new Model
                                    {
                                        Name = namemodel,
                                        BrandId = modelbrandId
                                    });
                                    Console.WriteLine("model created!");
                                }
                                break;
                            case 2:
                                Console.Write("enter model id: ");
                                int modelid = int.Parse(Console.ReadLine());
                                Console.WriteLine(GetModelById(modelid).Name);
                                break;
                            case 3:
                                GetAllModels();
                                break;
                            case 4:
                                Console.Write("enter model id you want to update: ");
                                int updmodelid = int.Parse(Console.ReadLine());
                                Console.Write("enter model name: ");
                                string mname = Console.ReadLine();
                                Console.Write("enter model brandid: ");
                                int modelbrid = int.Parse(Console.ReadLine());
                                if (mname != null)
                                {
                                    UpdateModel(updmodelid, new Model { Name = mname, BrandId = modelbrid });
                                    Console.WriteLine($"model name updated to {mname}, and brand id to {modelbrid}");
                                }
                                break;
                            case 5:
                                Console.Write("enter model id: ");
                                int delmodelid = int.Parse(Console.ReadLine());
                                DeleteModel(delmodelid);
                                Console.WriteLine("model deleted");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("""
                              1.create color
                              2.Get color by id 
                              3.GetAll colors
                              4.update color
                              5.delete color
                                choose something:
                              """);
                        int colorchoice = int.Parse(Console.ReadLine());
                        switch (colorchoice)
                        {
                            case 1:
                                Console.Write("enter color name: ");
                                string namecolor = Console.ReadLine();
                                if (namecolor != null)
                                {
                                    CreateColor(new Color
                                    {
                                        Name = namecolor
                                    });
                                    Console.WriteLine("color created!");
                                }
                                break;
                            case 2:
                                Console.Write("enter color id: ");
                                int colorid = int.Parse(Console.ReadLine());
                                Console.WriteLine(GetColorById(colorid).Name);
                                break;
                            case 3:
                                GetAllColors();
                                break;
                            case 4:
                                Console.Write("enter color id: ");
                                int updclrid = int.Parse(Console.ReadLine());
                                Console.Write("enter color name: ");
                                string cname = Console.ReadLine();
                                if (cname != null)
                                {
                                    UpdateColor(updclrid, new Color { Name = cname });
                                    Console.WriteLine($"color name updated to {cname}");
                                }
                                break;
                            case 5:
                                Console.Write("enter color id: ");
                                int delcolorid = int.Parse(Console.ReadLine());
                                DeleteColor(delcolorid);
                                Console.WriteLine("color deleted");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("""
                              1.create car
                              2.Get car by id 
                              3.GetAll cars
                              4.update car
                              5.delete car
                                choose something:
                              """);
                        int carchoice = int.Parse(Console.ReadLine());
                        switch (carchoice)
                        {
                            case 1:
                                Console.Write("enter car maxspeed: ");
                                int maxspeed = int.Parse(Console.ReadLine());
                                Console.Write("enter car fuelTankCapacity: ");
                                int fueltank = int.Parse(Console.ReadLine());
                                Console.Write("enter car power: ");
                                int power = int.Parse(Console.ReadLine());
                                Console.Write("enter car coorcount: ");
                                int doorcount = int.Parse(Console.ReadLine());
                                Console.Write("enter car modelId: ");
                                int modelid = int.Parse(Console.ReadLine());
                                CreateCar(new Car
                                    {
                                        MaxSpeed = maxspeed,
                                        FuelTankCapacity = fueltank,
                                        Power = power,
                                        DoorCount = doorcount,
                                        ModelId = modelid
                                    });
                                    Console.WriteLine("car created!");                               
                                break;
                            case 2:
                                Console.Write("enter car id: ");
                                int carid = int.Parse(Console.ReadLine());
                                Console.WriteLine(GetCarById(carid));
                                break;
                            case 3:
                                GetAllCars();
                                break;
                            case 4:
                                Console.Write("enter car id: ");
                                //int updclrid = int.Parse(Console.ReadLine());
                                //Console.Write("enter color name: ");
                                //string cname = Console.ReadLine();
                                //if (cname != null)
                                //{
                                //    UpdateColor(updclrid, new Model { Name = cname });
                                //    Console.WriteLine($"color name updated to {cname}");
                                //}
                                break;
                            case 5:
                                Console.Write("enter color id: ");
                                int delcolorid = int.Parse(Console.ReadLine());
                                DeleteColor(delcolorid);
                                Console.WriteLine("color deleted");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #region BrandMethods
        static void CreateBrand(Brand brand)
        {
            DataContext dataContext = new DataContext();
            dataContext.Brands.Add(brand);
            dataContext.SaveChanges();
        }
        static Brand GetBrandById(int id)
        {
            DataContext dataContext = new DataContext();
            var wantedbrand = dataContext.Brands.FirstOrDefault(x => x.Id == id);
            if (wantedbrand == null)
            {
                throw new NullReferenceException();
            }
            return wantedbrand;
        }
        static List<Brand> GetAllBrands()
        {
            DataContext dataContext = new DataContext();
            return dataContext.Brands.ToList();
        }
        static void UpdateBrand(int id, Brand brand)
        {
            DataContext dataContext = new DataContext();
            var updbrand = dataContext.Brands.FirstOrDefault(x => x.Id == id);
            if (updbrand == null)
            {
                throw new NullReferenceException();
            }
            brand.Name = updbrand.Name;
            dataContext.SaveChanges();
        }
        static void DeleteBrand(int id)
        {
            DataContext dataContext = new DataContext();
            var delbrand = dataContext.Brands.FirstOrDefault(x => x.Id == id);
            if (delbrand == null)
            {
                throw new NullReferenceException();
            }
            dataContext.Brands.Remove(delbrand);
            dataContext.SaveChanges();
        }
        #endregion

        #region ModelMethods
        static void CreateModel(Model model)
        {
            DataContext dataContext = new DataContext();
            var brand = dataContext.Brands.FirstOrDefault(b => b.Id == model.BrandId);
            if (brand == null)
            {
                throw new Exception("there is not a brand with this id.");
            }
            dataContext.Models.Add(model);
            dataContext.SaveChanges();
        }
        static Model GetModelById(int id)
        {
            DataContext dataContext = new DataContext();
            var wantedmodel = dataContext.Models.FirstOrDefault(x => x.Id == id);
            if (wantedmodel == null)
            {
                throw new NullReferenceException();
            }
            return wantedmodel;
        }
        static List<Model> GetAllModels()
        {
            DataContext dataContext = new DataContext();
            return dataContext.Models.ToList();
        }
        static void UpdateModel(int id, Model model)
        {
            DataContext dataContext = new DataContext();
            var updmodel = dataContext.Models.FirstOrDefault(x => x.Id == id);
            if (updmodel == null)
            {
                throw new NullReferenceException();
            }
            model.Name = updmodel.Name;
            model.BrandId = updmodel.BrandId;
            dataContext.SaveChanges();
        }
        static void DeleteModel(int id)
        {
            DataContext dataContext = new DataContext();
            var delmodel = dataContext.Models.FirstOrDefault(x => x.Id == id);
            if (delmodel == null)
            {
                throw new NullReferenceException();
            }
            dataContext.Models.Remove(delmodel);
            dataContext.SaveChanges();
        }
        #endregion

        #region ColorMethods
        static void CreateColor(Color color)
        {
            DataContext dataContext = new DataContext();
            dataContext.Colors.Add(color);
            dataContext.SaveChanges();
        }
        static Color GetColorById(int id)
        {
            DataContext dataContext = new DataContext();
            var wantedcolor = dataContext.Colors.FirstOrDefault(x => x.Id == id);
            if (wantedcolor == null)
            {
                throw new NullReferenceException();
            }
            return wantedcolor;
        }
        static List<Color> GetAllColors()
        {
            DataContext dataContext = new DataContext();
            return dataContext.Colors.ToList();
        }
        static void UpdateColor(int id, Color color)
        {
            DataContext dataContext = new DataContext();
            var updcolor = dataContext.Colors.FirstOrDefault(x => x.Id == id);
            if (updcolor == null)
            {
                throw new NullReferenceException();
            }
            color.Name = updcolor.Name;
            dataContext.SaveChanges();
        }
        static void DeleteColor(int id)
        {
            DataContext dataContext = new DataContext();
            var delcolor = dataContext.Colors.FirstOrDefault(x => x.Id == id);
            if (delcolor == null)
            {
                throw new NullReferenceException();
            }
            dataContext.Colors.Remove(delcolor);
            dataContext.SaveChanges();
        }
        #endregion

        #region CarMethods
        static void CreateCar(Car car)
        {
            DataContext dataContext = new DataContext();
            dataContext.Cars.Add(car);
            dataContext.SaveChanges();
        }
        static Car GetCarById(int id)
        {
            DataContext dataContext = new DataContext();
            var wantedcar = dataContext.Cars.Include(x => x.Model).ThenInclude(x => x.Brand).Include(x => x.CarsColors)
                           .ThenInclude(x => x.Color).FirstOrDefault(x => x.Id == id);
            if (wantedcar == null)
            {
                throw new NullReferenceException();
            }
            return wantedcar;
        }
        static List<Car> GetAllCars()
        {
            DataContext dataContext = new DataContext();
            return dataContext.Cars.ToList();
        }
        static void UpdateCar(int id, Car car)
        {
            DataContext dataContext = new DataContext();
            var updcar = dataContext.Cars.FirstOrDefault(x => x.Id == id);
            if (updcar == null)
            {
                throw new NullReferenceException();
            }
            car.MaxSpeed = updcar.MaxSpeed;
            car.FuelTankCapacity = updcar.FuelTankCapacity;
            car.Power = updcar.Power;
            car.DoorCount = updcar.DoorCount;
            car.ModelId = updcar.ModelId;
            dataContext.SaveChanges();
        }
        static void DeleteCar(int id)
        {
            DataContext dataContext = new DataContext();
            var delcar = dataContext.Cars.FirstOrDefault(x => x.Id == id);
            if (delcar == null)
            {
                throw new NullReferenceException();
            }
            dataContext.Cars.Remove(delcar);
            dataContext.SaveChanges();
        }
        #endregion
    }
}
