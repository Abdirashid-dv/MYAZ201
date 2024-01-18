namespace Repositories;
using Models;

public class VideoRepository
{
    public IEnumerable<Video> Videos => _videos;
    private List<Video> _videos;
    public VideoRepository()
    {
        _videos = new List<Video>()
        {
            new Video
            {
                Id = 1,
                Title = "ASP.NET Core Web API",
                ReleaseDate = DateTime.Now.AddDays(-10),
                Views = 1000,
                Likes = 800,
                Dislikes = 50
            },
            new Video
            {
                Id = 2,
                Title = "Nesne Yönelimli Programlama",
                ReleaseDate = DateTime.Now.AddDays(-7),
                Views = 1200,
                Likes = 900,
                Dislikes = 30
            },
            new Video
            {
                Id = 3,
                Title = "SQL",
                ReleaseDate = DateTime.Now.AddDays(-5),
                Views = 800,
                Likes = 600,
                Dislikes = 20
            },
            new Video
            {
                Id = 4,
                Title = "Yapısal Programlama",
                ReleaseDate = DateTime.Now.AddDays(-3),
                Views = 1500,
                Likes = 1200,
                Dislikes = 70
            },
            new Video
            {
                Id = 5,
                Title = "Rekatik Programlama",
                ReleaseDate = DateTime.Now.AddDays(-1),
                Views = 2000,
                Likes = 1800,
                Dislikes = 100
            }
        };
    }

    // Add metoduna için yazdığınız kodu cevap kağına ekleyiniz.
    public void Add(Video video)
    {
        video.Id = _videos.Max(v => v.Id) + 1;
        _videos.Add(video);
    }

}