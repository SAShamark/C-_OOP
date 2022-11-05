using Lab8.Phones.PhoneAbility;

namespace Lab8.Phones;

public class Smartphone : ColorScreenMobile
{
    private int _maxTouchCount;
    private int _camerasCount;
    private List<Camera> _cameras;

    protected Smartphone(int phoneNumber, string screenResolution, string screenSize, int phoneColor,
        int numberOfScreenColor, bool havingSecondSimCard, int secondPhoneNumber, int maxTouchCount, int camerasCount,
        List<Camera> cameras) :
        base(phoneNumber, screenResolution,
            screenSize, phoneColor, numberOfScreenColor, havingSecondSimCard, secondPhoneNumber)
    {
        _maxTouchCount = maxTouchCount;
        _camerasCount = camerasCount;
        _cameras = cameras;
    }

    protected override void Call()
    {
        Console.Write("I'm calling from a Smartphone");
    }

    private void UseCamera(int cameraIndex)
    {
        var camera = _cameras[cameraIndex];

        Console.WriteLine($"What do you want to do?\n" +
                          $"1) Take a picture" +
                          $"2) Start recording\n");
        string action = Console.ReadLine();

        switch (action)
        {
            case "Take a picture":
                camera.TakeAPicture();
                break;
            case "Start recording":
                camera.StartVideoRecording();
                ProposeToStopRecording(camera);
                break;
        }
    }

    private static void ProposeToStopRecording(Camera camera)
    {
        while (true)
        {
            Console.WriteLine($"Stop recording?\n" + $"1 - yes");
            string isStopRecording = Console.ReadLine();
            if (isStopRecording == "yes")
            {
                camera.StopVideoRecording();
            }
            else
            {
                continue;
            }

            break;
        }
    }
}