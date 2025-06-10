using System.Text;
using static ResearchLibrary.Methods;

namespace ResearchLibrary;

public static class Globals
{
    public static void Start()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            WelcomeUser();
            PrintDino();
            var query = GetUserQuery();
            SendQuery(query);

            Console.WriteLine("\nPress any key to restart program...");

            Console.ReadKey();
            Console.Clear();
        }
    }
}