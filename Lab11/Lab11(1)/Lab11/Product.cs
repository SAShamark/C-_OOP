namespace Lab11;

public class Product
{
    public bool IsDimensionsRemoved { get; set; }
    public bool IsCutOff { get; set; }
    public bool IsSharpened { get; set; }
    public bool IsCutThread { get; set; }
    public bool IsDrilled { get; set; }
    public bool IsPainted { get; set; }
    public bool IsTested { get; set; }
    public bool IsPacked { get; set; }

    public void PrintProductInfo()
    {
        Console.WriteLine($"IsDimensionsRemoved--{IsDimensionsRemoved}\n" +
                          $"IsCutOff--{IsCutOff}\n" +
                          $"IsSharpened--{IsSharpened}\n" +
                          $"IsCutThread--{IsCutThread}\n" +
                          $"IsDrilled--{IsDrilled}\n" +
                          $"IsPainted--{IsPainted}\n" +
                          $"IsTested--{IsTested}\n" +
                          $"IsPacked--{IsPacked}\n");
    }
}