namespace WhatToDo.Api;

public class Task
{
    // Should be randomly generated unique identifier
    public int Id { get; set; }
    public required string Title { get; set; }
    public string Description { get; set; } = "";
    public required DateOnly CreatedAt { get; set; }
    public DateOnly UpdatedAt { get; set; }
    public bool IsCompleted { get; set; } = false;
    public TaskPriority Priority { get; set; } = TaskPriority.Medium;
    // For now we just use a string for AssignedTo, can change to proper user class later
    public string AssignedTo { get; set; } = "Unassigned";
}