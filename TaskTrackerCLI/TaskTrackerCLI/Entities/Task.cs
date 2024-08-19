/*
Task Properties

Each task should have the following properties:

    id: A unique identifier for the task
    description: A short description of the task
    status: The status of the task (todo, in-progress, done)
    createdAt: The date and time when the task was created
    updatedAt: The date and time when the task was last updated

Make sure to add these properties to the JSON file when adding a new task and update them when updating a task.
*/

namespace TaskTrackerCLI.Entities
{
    public enum TaskStatus
    { 
        Todo = 0,
        InProgress = 1,
        Done = 2
    }

    public class Task
    {
        public int Id { get; set; }

        public string? Description { get; set; }
    
        public TaskStatus Status { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}