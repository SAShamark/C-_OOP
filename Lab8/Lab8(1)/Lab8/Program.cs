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
            int solution = int.Parse(Console.ReadLine() ?? string.Empty);
            switch (solution)
            {
                case 1:
                    BuyCar(garage);
                    break;
                case 2:
                    CostOutCar(garage);
                    break;
            }

            garage.GetCarForDrive(garage.Cars);
        }

        private static void BuyCar(Garage garage)
        {
            Console.WriteLine("By what index do you want to throw away the car?");

            Console.WriteLine("Chose car brand");
            string? carBrand = Console.ReadLine();

            Console.WriteLine("Chose car color");
            string? carColor = Console.ReadLine();

            Console.WriteLine("Chose car speed");
            string? carSpeed = Console.ReadLine();

            Console.WriteLine("Chose car year manufacture");
            string? carYearManufacture = Console.ReadLine();

            var newCar = new Car(carBrand, carColor, carSpeed, carYearManufacture);
            garage.AddCar(newCar);
            garage.ShowAutoPark();
        }

        private static void CostOutCar(Garage garage)
        {
            Console.WriteLine("By what index do you want to throw away the car?");
            int carIndex = int.Parse(Console.ReadLine() ?? string.Empty);
            garage.RemoveCar(garage.Cars[carIndex]);
            garage.ShowAutoPark();
        }
    }
}