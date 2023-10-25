using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    private readonly PostsRepository postsRepository;

    public PostsController(PostsRepository postsRepository)
    {
        this.postsRepository = postsRepository;
    }

    [HttpGet]
    public List<Posts> GetAllPosts()
    {
        return postsRepository.GetAllPosts();
    }

    [HttpGet("{id:int}")]

    public Posts GetOnePost(int id)
    {
        return postsRepository.GetOnePost(id);
    }

    [HttpPost]
    public void CreateOnePost(Posts post)
    {
        postsRepository.CreateOnePost(post);
    }

    [HttpPut("{id:int}")]
    public void UpdateOnePost(int id, Posts post)
    {
        postsRepository.UpdateOnePost(id, post);
    }

    [HttpDelete("{id:int}")]
    public void DeleteOnePost(int id)
    {
        postsRepository.DeleteOnePost(id);
    }

    [HttpDelete]
    public void DeleteAllPosts()
    {
        postsRepository.DeleteAllPosts();
    }
}