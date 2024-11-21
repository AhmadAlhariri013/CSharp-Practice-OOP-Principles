namespace AbstractionPrinciple.MultiMedia;

//Concrete Implementations
//Implement the interface for different media types.
public class AudioPlayer: IMediaPlayer
{
    public void Play(string filePath)
    {
        Console.WriteLine($"Playing audio from {filePath}");
    }
}