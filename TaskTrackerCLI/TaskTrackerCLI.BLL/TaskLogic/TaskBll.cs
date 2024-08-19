
namespace TaskTrackerCLI.BLL.TaskLogic
{
    public class TaskBll : ITaskBll
    {
        public Entities.Task Add(string description)
        {
            throw new NotImplementedException();
        }

        public Entities.Task Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public IObservable<Entities.Task> Get(Entities.TaskStatus filter)
        {
            throw new NotImplementedException();
        }

        public Entities.Task Update(int taskId, string description, Entities.TaskStatus status)
        {
            throw new NotImplementedException();
        }
    }
}