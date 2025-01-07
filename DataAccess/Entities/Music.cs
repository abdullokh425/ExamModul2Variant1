namespace ExamModul2.DataAccess.Entities;

public class Music
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double MB { get; set; }
    public string AuthorName { get; set; }
    public string Describtion { get; set; }
    public int QuentityLikes { get; set; }
}