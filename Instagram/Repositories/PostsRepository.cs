class PostsRepository
{
    private List<Posts> postList;


    public PostsRepository()
    {
        postList = new List<Posts>();
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