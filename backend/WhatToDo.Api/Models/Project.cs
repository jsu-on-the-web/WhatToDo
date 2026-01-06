namespace WhatToDo.Api
{
    public class Project
    {
        // Should be randomly generated unique identifier
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsCompleted { get; set; } = false;
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    }
}
