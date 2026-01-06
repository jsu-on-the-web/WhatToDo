namespace WhatToDo.Api;

public class TaskItem
{
    // Should be randomly generated unique identifier
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string Description { get; set; } = "";
    public required DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsCompleted { get; set; } = false;
    public TaskPriority Priority { get; set; } = TaskPriority.Medium;
    // For now we just use a string for AssignedTo, can change to proper user class later
    public string AssignedTo { get; set; } = "Unassigned";

    // Project related properties
    public Guid ProjectId { get; set; }
}