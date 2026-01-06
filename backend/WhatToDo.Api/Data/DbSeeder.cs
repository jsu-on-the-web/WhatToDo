namespace WhatToDo.Api;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {
        // Don't do anything if we already have data
        if (db.Projects.Any() || db.Tasks.Any())
        {
            return;
        }

        Project dummyProject1 = new Project
        {
            Id = Guid.NewGuid(),
            Name = "Project Alpha",
            Description = "This is the first dummy project.",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Tasks = new List<TaskItem>()
        };

        // Another dummy project with tasks
        Project dummyProject2 = new Project
        {
            Id = Guid.NewGuid(),
            Name = "Project Beta",
            Description = "This is the second dummy project.",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Tasks = new List<TaskItem>()
        };
        List<TaskItem> tasksForProject2 = new List<TaskItem>
        {
            new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = "Set up project repository",
                Description = "Create a Git repository for the project.",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsCompleted = false,
                Priority = TaskPriority.High,
                AssignedTo = "Alice",
                ProjectId = dummyProject2.Id,
            },
            new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = "Design database schema",
                Description = "Create an initial design for the database schema.",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsCompleted = false,
                Priority = TaskPriority.Medium,
                AssignedTo = "Bob",
                ProjectId = dummyProject2.Id
            }
        };

        // NOTE: AddRange adds the tasks to the end of the list
        dummyProject2.Tasks.AddRange(tasksForProject2);

        // Add projects (tasks will be added via cascade)
        await db.Projects.AddAsync(dummyProject1);
        await db.Projects.AddAsync(dummyProject2);

        await db.SaveChangesAsync();
    }
}