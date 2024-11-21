namespace AbstractionPrinciple.MultiMedia;

//Concrete Implementations
//Implement the interface for different media types.
public class VideoPlayer:IMediaPlayer
{
    public void Play(string filePath)
    {
        Console.WriteLine($"Playing video from {filePath}");
    }
}