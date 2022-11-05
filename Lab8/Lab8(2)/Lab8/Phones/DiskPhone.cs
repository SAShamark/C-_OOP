namespace Lab8.Phones;

public class DiskPhone
{
    public int PhoneNumber { get; private set; }
    public int[] AvailableSymbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    protected DiskPhone(int phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    protected virtual void Call()
    {
        Console.Write("I'm calling from a DiskPhone");
    }

    protected virtual void PickUpPhone(int otherPhoneNumber)
    {
        Console.Write("Hi");
    }
}