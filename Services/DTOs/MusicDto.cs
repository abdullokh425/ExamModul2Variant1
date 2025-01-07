using ExamModul2.Repositories;

namespace ExamModul2.Services.DTOs;

public class MusicDto
{
    public string Name { get; set; }
    public double MB { get; set; }
    public string AuthorName { get; set; }
    public string Describtion { get; set; }
    public int QuentityLikes { get; set; }
}