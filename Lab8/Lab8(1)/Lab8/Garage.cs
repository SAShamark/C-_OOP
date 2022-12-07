namespace Lab8;

public class Garage
{
    public List<Car> Cars { get; } = new();

    public void Init()
    {
        AddCar(new Car("Audi", "Orange", "250", "2003"));
        AddCar(new Car("Audi", "Black", "350", "2020"));
        AddCar(new Car("Nissan", "Orange", "300", "2010"));
        AddCar(new Car("Mustang", "White", "450", "2022"));
    }

    public void AddCar(Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        Cars.Remove(car);
    }

    public void ShowAutoPark()
    {
        Console.WriteLine("Your car park:");
        for (int i = 0; i < Cars.Count; i++)
        {
            Console.WriteLine($"Car index - {i}");
            Cars[i].GetCarData();
        }
    }

    public void GetCarForDrive(List<Car> cars, string parameters)
    {
        while (true)
        {
            var carsByParameter = SearchCarByParameters(parameters, cars);

            switch (carsByParameter.Count)
            {
                case 0:
                {
                    Console.WriteLine("According to the entered parameters, the car was not found");
                    continue;
                }

                case 1:
                    Console.WriteLine("You take car: ");
                    carsByParameter[0].GetCarData();
                    Console.WriteLine("Have a nice trip!");
                    break;
                case >= 2:
                {
                    Console.WriteLine("Several machines were found according to the entered parameters:");
                    foreach (var car in carsByParameter)
                    {
                        car.GetCarData();
                    }

                    cars = carsByParameter;
                    continue;
                }
            }

            break;
        }
    }

    private List<Car> SearchCarByParameters(string parameters, IEnumerable<Car> cars)
    {
        return cars.Where(car =>
            parameters == car.BrandCar || parameters == car.ColorCar || parameters == car.SpeedCar ||
            parameters == car.YearManufactureCar).ToList();
    }
}