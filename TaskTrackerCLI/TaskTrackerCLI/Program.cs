using TaskTrackerCLI.BLL.TaskLogic;

namespace TaskTrackerCLI
{
    internal class Program
    {
        const string ExitCommand = "exit";
        const string HelpCommand = "help";

        static ITaskBll _task
        static void Main(string[] args)
        {
            /*
            #region Global variables

// Interface to logic

ITaskBll taskBll= new TaskBll();

// This flag inficates if the user wants to exit
var exit = false;


#endregion


Init();

while (!exit) 
{
    var text = Console.ReadLine();

    switch (text)
    {
        case HelpCommand:  break;
        case ExitCommand: exit = true; break; 
        default: Console.WriteLine("Command not foud"); break;
    }
}




            */
            Console.WriteLine("Hello World!");
        }
    
        ///<summary>
        ///    Wirte the text after the app is loaded
        ///</summary>
        static void Init()
        {
            try
            {    
                // First Step: Load the configuration
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

            Console.Clear();

            if (!Directory.Exists("TaskTrackerData"))
            {
                Console.WriteLine("Directory doesn't exist");
                Directory.CreateDirectory("TaskTrackerData");
            }

            Console.WriteLine("Task Tracker");
            Console.WriteLine("------------");
            Console.WriteLine("Please write a commad to start (write command help to get more info)");

            
        }

        ///<summary>
        ///     Show the commands and how they are used
        ///</summary>
        static void CommandHelp()
        { 
            Console.Clear();
            Console.WriteLine("This list contains the available commands:");
        }
    }

}