public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments = new List<Comment>();
    public int NumComments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        NumComments = 0;
    }

    public void DisplayNumComments()
    {
        NumComments = Comments.Count();
        Console.WriteLine($"Number of Commments: {NumComments}");
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"{Title}, {Author}, {Length} seconds");
        DisplayNumComments();
        DisplayComments();
        Console.WriteLine();
    }
    public void DisplayComments()
    {
        foreach(Comment c in Comments)
        {
            Console.WriteLine($"{c.CommenterName} \"{c.CommentText}\"");
        }
    }
}