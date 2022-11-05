namespace Lab8.Phones.PhoneAbility;

public abstract class Camera : ICamera
{
    public string ParametersOfCamera { get; set; }

    public Camera(string parametersOfCamera)
    {
        ParametersOfCamera = parametersOfCamera;
    }

    public void TakeAPicture()
    {
        Console.WriteLine("I took a picture");
    }

    public void StartVideoRecording()
    {
        Console.WriteLine("I'm recording a video");
    }

    public void StopVideoRecording()
    {
        Console.WriteLine("Video recorded");
    }
}