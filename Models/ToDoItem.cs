namespace ToDoListApi.Models;

public class ToDoItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Boolean? IsComplete { get; set; }
}