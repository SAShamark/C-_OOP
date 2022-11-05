namespace Lab8.Phones;

public class PushButtonPhone : DiskPhone
{
    public new char[] AvailableSymbols =
    {
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#'
    };

    protected PushButtonPhone(int phoneNumber) : base(phoneNumber)
    {
    }

    protected override void Call()
    {
        Console.Write("I'm calling from a PushButtonPhone");
    }

    protected override void PickUpPhone(int otherPhoneNumber)
    {
        base.PickUpPhone(otherPhoneNumber);
        DisplayInputPhoneNumber(otherPhoneNumber);
    }

    private void DisplayInputPhoneNumber(int otherPhoneNumber)
    {
        Console.WriteLine(otherPhoneNumber);
    }
}