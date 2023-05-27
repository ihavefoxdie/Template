using Template.Classes;

namespace Template
{
    public static class Client
    {
        public static void ExecuteRoutine(RoutineAI routine)
        {
            System.Console.WriteLine("======================================");
            routine.StartRoutine("burger", "Town Square");
            System.Console.WriteLine("======================================");
        }
    }
}
