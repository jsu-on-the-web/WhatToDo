namespace WhatToDo.Api
{
    public class Project
    {
        // Should be randomly generated unique identifier
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = "";
        public DateOnly CreatedAt { get; set; }
        public DateOnly UpdatedAt { get; set; }
        public bool IsCompleted { get; set; } = false;
        public List<Task> Tasks { get; set; } = new List<Task>();

    }
}
