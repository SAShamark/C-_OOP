namespace Lab8;

public interface ICamera
{
    public string ParametersOfCamera { get; set; }
    public void TakeAPicture();
    public void StartVideoRecording();
    public void StopVideoRecording();
}