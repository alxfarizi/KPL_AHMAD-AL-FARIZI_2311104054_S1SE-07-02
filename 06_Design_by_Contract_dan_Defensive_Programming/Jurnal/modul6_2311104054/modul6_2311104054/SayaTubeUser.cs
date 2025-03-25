using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Random random = new Random();
        this.id = random.Next(10000, 100000); 
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }
        return totalPlayCount;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + username);
        int i = 1;
        foreach (var video in uploadedVideos)
        {
            Console.WriteLine("Video " + i + " judul: " + video.GetTitle());
            i++;
        }
    }
}
