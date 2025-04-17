using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
       
        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // ID random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
       
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public string GetTitle()
    {
        return title;
    }

    public int GetPlayCount()
    {
        return playCount;
    }
}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
       
        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // ID random 5 digit
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
       
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
        
    }
}

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Nita");

            List<string> videoTitles = new List<string>
            {
                "Review Film Interstellar oleh Nita",
                "Review Film Inception oleh Nita",
                "Review Film The Dark Knight oleh Nita",
                "Review Film Parasite oleh Nita",
                "Review Film The Godfather oleh Nita",
                "Review Film Whiplash oleh Nita",
                "Review Film Fight Club oleh Nita",
                "Review Film Joker oleh Nita",
                "Review Film The Martian oleh Nita",
                "Review Film Gravity oleh Nita"
            };

            foreach (var title in videoTitles)
            {
                SayaTubeVideo video = new SayaTubeVideo(title);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlaycount();

    }
}