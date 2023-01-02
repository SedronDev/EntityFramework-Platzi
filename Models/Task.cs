namespace efplatzi.Models;

public class Task {
    public Guid TaskID {get;set;}
    public string Title {get;set;}
    public string Description {get;set;}
    public Priority TaskPriority {get;set;}
    public DateTime TaskCreation {get;set;}
    public virtual Category Category {get;set;}
}

public enum Priority {
    Low,
    Mid,
    High
}