namespace AbstractionPrinciple.MultiMedia;

/*
 * Consider a scenario where you are developing a multimedia application that can play different media files: Audio and Video.
 * Without abstraction, you might have separate methods to play each media type, like PlayAudio(), PlayVideo(), etc.
 * If you were to add support for more formats or media types, it would require significant changes to your application.
 */


//Abstraction Layer
//First, define an interface representing any media player.
public interface IMediaPlayer
{
    void Play(string filePath);
}