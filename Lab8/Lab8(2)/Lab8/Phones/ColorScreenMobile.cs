namespace Lab8.Phones;

public class ColorScreenMobile : BlackWhiteScreenMobile
{
    private int _numberOfScreenColor;
    private bool _havingSecondSimCard;
    private int _secondPhoneNumber;
    private int _usablePhoneNumber;

    protected ColorScreenMobile(int phoneNumber, string screenResolution, string screenSize, int phoneColor,
        int numberOfScreenColor, bool havingSecondSimCard, int secondPhoneNumber) : base(phoneNumber, screenResolution,
        screenSize, phoneColor)
    {
        _numberOfScreenColor = numberOfScreenColor;
        _havingSecondSimCard = havingSecondSimCard;
        _secondPhoneNumber = secondPhoneNumber;
        _usablePhoneNumber = phoneNumber;
    }

    protected override void Call()
    {
        Console.Write("I'm calling from a ColorScreenMobile");
    }

    protected void SendMMS()
    {
        OfferToChangePhoneNumber();
        Console.WriteLine("Enter the recipient's phone number");
        Console.ReadLine();
        Console.WriteLine("Enter the MMS");
        Console.ReadLine();
        Console.WriteLine("You have sent an mms from this number" + _usablePhoneNumber);
    }

    protected void GetMMS(string contextMMS, int senderPhoneNumber)
    {
        Console.WriteLine("Sender:" + senderPhoneNumber);
        Console.WriteLine(contextMMS);
    }

    protected void OfferToChangePhoneNumber()
    {
        Console.WriteLine($"Selected number: {_usablePhoneNumber}\n" +
                          $"Do you want to change the number? \n" +
                          $" 1- yes\n" +
                          $"2- no");
        int answer = int.Parse(Console.ReadLine());
        switch (answer)
        {
            case 1:
                ChooseNumber();
                break;
            default:
                return;
        }
    }

    private void ChooseNumber()
    {
        Console.WriteLine($"1) {PhoneNumber}\n" +
                          $"2) {_secondPhoneNumber}");
        int wantedNumber = int.Parse(Console.ReadLine());
        _usablePhoneNumber = wantedNumber;
    }
}