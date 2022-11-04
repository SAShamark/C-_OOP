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
        for (var i = 0; i < Cars.Count; i++)
        {
            Console.WriteLine($"Car index - {i}");
            Cars[i].GetCarData();
        }
    }
    
    
}