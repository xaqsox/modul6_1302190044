public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 100000);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }
  
    public void PrintVideoDetails()
    {
        Console.WriteLine("Video Details");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}