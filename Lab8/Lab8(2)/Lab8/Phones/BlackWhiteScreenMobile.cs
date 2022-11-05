namespace Lab8.Phones;

public class BlackWhiteScreenMobile : PushButtonPhone
{
    public new char[] AvailableSymbols =
    {
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#', '+', '-', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
        'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };

    private string _screenResolution;
    private readonly string _screenSize;
    private readonly int _phoneColor;


    protected BlackWhiteScreenMobile(int phoneNumber, string screenResolution, string screenSize, int phoneColor) :
        base(phoneNumber)
    {
        _screenResolution = screenResolution;
        _screenSize = screenSize;
        _phoneColor = phoneColor;
    }

    protected override void Call()
    {
        Console.Write("I'm calling from a BlackWhiteScreenMobile");
    }

    private void SendSMS()
    {
        Console.WriteLine("Enter the recipient's phone number");
        Console.ReadLine();
        Console.WriteLine("Enter the SMS");
        Console.ReadLine();
    }

    private void GetSMS(string contextSMS, int senderPhoneNumber)
    {
        Console.WriteLine("Sender:" + senderPhoneNumber);
        Console.WriteLine(contextSMS);
    }
}