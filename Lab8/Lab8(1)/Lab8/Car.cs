﻿namespace Lab8;

public class Car
{
    public string BrandCar { get; }
    public string ColorCar { get; }
    public string SpeedCar { get; }
    public string YearManufactureCar { get; }

    public Car(string brandCar, string colorCar, string speedCar, string yearManufactureCar)
    {
        BrandCar = brandCar;
        ColorCar = colorCar;
        SpeedCar = speedCar;
        YearManufactureCar = yearManufactureCar;
    }

    public void GetCarData()
    {
        Console.WriteLine(
            $"NAME: {BrandCar} --- COLOR: {ColorCar} --- SPEED: {SpeedCar} --- YEAR MANUFACTURE: {YearManufactureCar}");
    }
}