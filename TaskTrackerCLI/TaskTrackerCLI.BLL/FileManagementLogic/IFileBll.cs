using TaskTrackerCLI.BLL.Entities;

namespace TaskTrackerCLI.BLL.FileManagementLogic
{
    public interface IFileBll
    {
        Configuration CreateConfiguration();
        
        Configuration LoadConfiguration();
    }
}