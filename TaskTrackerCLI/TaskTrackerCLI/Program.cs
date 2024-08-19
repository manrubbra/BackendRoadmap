using TaskTrackerCLI.BLL.TaskLogic;

#region Global variables

// Interface to logic

ITaskBll taskBll= new TaskBll();

// This flag inficates if the user wants to exit
var exit = false;

const string ExitCommand = "exit";
const string HelpCommand = "help";

#endregion


Init();

while (!exit) 
{
    var text = Console.ReadLine();

    switch (text)
    {
        case HelpCommand: /* TO DO */ break;
        case ExitCommand: exit = true; break; 
        default: Console.WriteLine("Command not foud"); break;
    }
}

///<summary>
///    Wirte the text after the app is loaded
///</summary>
static void Init()
{
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

