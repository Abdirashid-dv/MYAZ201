namespace Models;
using System;
public sealed class Video : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; } = DateTime.Now;
    public int Views { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}
