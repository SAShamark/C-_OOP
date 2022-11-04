namespace Lab8
{
    public static class Program
    {
        private static void Main()
        {
            var garage = new Garage();
            garage.Init();
            garage.ShowAutoPark();


            Console.WriteLine("Do you want to buy or cast out one of the cars?");
            Console.WriteLine(" Buy - 1 \n Cast out - 2");
            var solution = int.Parse(Console.ReadLine());
            switch (solution)
            {
                case 1:
                    BuyCar(garage);
                    break;
                case 2:
                    CostOutCar(garage);
                    break;
            }

            GetCarForDrive(garage.Cars);
        }

        private static void BuyCar(Garage garage)
        {
            Console.WriteLine("By what index do you want to throw away the car?");

            Console.WriteLine("Chose car brand");
            string carBrand = Console.ReadLine();

            Console.WriteLine("Chose car color");
            string carColor = Console.ReadLine();

            Console.WriteLine("Chose car speed");
            string carSpeed = Console.ReadLine();

            Console.WriteLine("Chose car year manufacture");
            string carYearManufacture = Console.ReadLine();

            var newCar = new Car(carBrand, carColor, carSpeed, carYearManufacture);
            garage.AddCar(newCar);
            garage.ShowAutoPark();
        }

        private static void CostOutCar(Garage garage)
        {
            Console.WriteLine("By what index do you want to throw away the car?");
            int carIndex = int.Parse(Console.ReadLine());
            garage.RemoveCar(garage.Cars[carIndex]);
            garage.ShowAutoPark();
        }

        private static void GetCarForDrive(List<Car> cars)
        {
            while (true)
            {
                Console.WriteLine("Enter the parameters of the car you want to drive");
                var parameters = Console.ReadLine();
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

        private static List<Car> SearchCarByParameters(string parameters, List<Car> cars)
        {
            var carsByParameters = new List<Car>();
            foreach (var car in cars)
            {
                if (parameters == car.BrandCar || parameters == car.ColorCar || parameters == car.SpeedCar ||
                    parameters == car.YearManufactureCar)
                {
                    carsByParameters.Add(car);
                }
            }

            return carsByParameters;
        }
    }
}