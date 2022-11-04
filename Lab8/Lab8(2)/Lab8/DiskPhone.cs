namespace Lab8;

public class DiskPhone
{
    private int _phoneNumber;
    public int[] AvailableSymbols = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    protected DiskPhone(int phoneNumber)
    {
        _phoneNumber = phoneNumber;
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

public class ColorScreenMobile : BlackWhiteScreenMobile
{
    private int _numberOfScreenColor;
    private bool _havingSecondSimCard;
    private int _secondPhoneNumber;

    protected ColorScreenMobile(int phoneNumber, string screenResolution, string screenSize, int phoneColor,
        int numberOfScreenColor, bool havingSecondSimCard, int secondPhoneNumber) : base(phoneNumber, screenResolution,
        screenSize, phoneColor)
    {
        _numberOfScreenColor = numberOfScreenColor;
        _havingSecondSimCard = havingSecondSimCard;
        _secondPhoneNumber = secondPhoneNumber;
    }

    protected override void Call()
    {
        Console.Write("I'm calling from a ColorScreenMobile");
    }
    /*private void SendMMS()
    {
        Console.WriteLine("Enter the recipient's phone number");
        Console.ReadLine();
        Console.WriteLine("Enter the SMS");
        Console.ReadLine();
    }

    private void GetMMS(string contextSMS, int senderPhoneNumber)
    {
        Console.WriteLine("Sender:" + senderPhoneNumber);
        Console.WriteLine(contextSMS);
    }*/
}

public class Smartphone : ColorScreenMobile
{
    private int _maxTouchCount;
    private int _camerasCount;

    protected Smartphone(int phoneNumber, string screenResolution, string screenSize, int phoneColor,
        int numberOfScreenColor, bool havingSecondSimCard, int secondPhoneNumber, int maxTouchCount, int camerasCount) :
        base(phoneNumber, screenResolution,
            screenSize, phoneColor, numberOfScreenColor, havingSecondSimCard, secondPhoneNumber)
    {
        _maxTouchCount = maxTouchCount;
        _camerasCount = camerasCount;
    }

    protected override void Call()
    {
        Console.Write("I'm calling from a Smartphone");
    }
}