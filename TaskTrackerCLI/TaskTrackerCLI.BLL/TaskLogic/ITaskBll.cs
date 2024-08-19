using Entities = TaskTrackerCLI.BLL.Entities;

namespace TaskTrackerCLI.BLL.TaskLogic
{
    public interface ITaskBll
    {
        ///<summary>
        /// Create a new task in the JSON file
        ///</summary>
        Entities.Task Add(string description);

        ///<summary>
        /// Update an existing task. It can change the description and the status
        ///</summary>
        Entities.Task Update(int taskId, string description, Entities.TaskStatus status);

        ///<summary>
        /// Delete the task from the JSON file
        ///</summary>
        Entities.Task Delete(int taskId);

        ///<summary>
        /// Retrieve from the JSON file these task which fit with the filter (status)
        ///</summary>
        IObservable<Entities.Task> Get(Entities.TaskStatus filter);
        
    }
}