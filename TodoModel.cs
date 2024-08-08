public class TodoModel{
    public int Id {get; set;}
    public string? Title {get; set;}
    public bool IsCompleted {get; set;}
    public DateTime? DateAdded {get; set;}
    public DateTime? Deadline {get; set;}
    public string? Description {get; set;}
    public string? Priority {get; set;}
    public TodoModel(int id, string title, string description, string priority, DateTime deadline)
    {
        Id = id;
        Title = title;
        Description = description;
        Priority = priority;
        DateAdded = DateTime.Now;
        Deadline = deadline;
        IsCompleted = false;
    }
    public TodoModel()
    {
        DateAdded = DateTime.Now;
        IsCompleted = false;
    }
}