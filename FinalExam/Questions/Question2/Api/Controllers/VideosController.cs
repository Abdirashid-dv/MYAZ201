using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;

namespace Controllers;

[ApiController]
[Route("api/videos")]
public class VideosController : ControllerBase
{
    private readonly VideoRepository _videoRepository;

    public VideosController(VideoRepository videoRepository)
    {
        _videoRepository = videoRepository;
    }

    [HttpGet]
    public IActionResult GetAllVideos()
    {
        return Ok(_videoRepository.Videos);
    }

    [HttpPost]
    public IActionResult CreateOneVideo(Video video)
    {
        if (video == null)
        {
            return BadRequest();
        }

        _videoRepository.Add(video);
        return Created($"api/videos/{video.Id}", video);


    }

}