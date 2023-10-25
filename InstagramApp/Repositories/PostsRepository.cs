
public class PostsRepository
{
    private List<Posts> postList;


    public PostsRepository()
    {
        postList = new List<Posts>();
        postList.Add(new Posts()
        {
            Id = 1,
            Title = "ASP.NET Core",
            Location = "Samsun University",
            PostDate = DateTime.Now,
            Tag = new Tags()
            {
                Id = 1,
                TagName = "Programming"
            }

        });

        postList.Add(new Posts()
        {
            Id = 2,
            Title = "Samsun University",
            PostDate = DateTime.Now.AddDays(1),
            Location = "Samsun",
            Tag = new Tags()
            {
                Id = 2,
                TagName = "University"
            }
        });
    }

    public List<Posts> GetAllPosts()
    {
        return postList;
    }

    public Posts GetOnePost(int id)
    {
        foreach (var post in postList)
        {
            if (post.Id.Equals(id))
            {
                return post;
            }
        }
        throw new Exception("Not Found");
    }

    public void CreateOnePost(Posts post)
    {
        postList.Add(post);
    }

    public void UpdateOnePost(int id, Posts post)
    {
        foreach (var item in postList)
        {
            if (item.Id == id)
            {
                item.Title = post.Title;
                item.Location = post.Location;
                item.PostDate = post.PostDate;
            }
        }
    }

    public void DeleteOnePost(int id)
    {
        foreach (var post in postList)
        {
            if (post.Id.Equals(id))
            {
                postList.Remove(post);
            }
        }
        throw new Exception("Not Found");
    }

    public void DeleteAllPosts()
    {
        postList.Clear();
    }
}