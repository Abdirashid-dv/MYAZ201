using System.ComponentModel.DataAnnotations;

namespace ChatEntities;

public class Chats
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    [MinLength(3)]
    public string Username { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime SendDate { get; set; }
}
