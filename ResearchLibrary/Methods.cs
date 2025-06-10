using System.Diagnostics;

namespace ResearchLibrary;

public static class Methods
{
    public static void WelcomeUser()
    {
        Console.WriteLine("\t\t\t\t\t\tWelcome to the Research Tool");
        Console.WriteLine("\t\t\t\t\t⚠️ Do not paste many lines of code there ⚠️");
        Console.WriteLine();
    }

    public static void PrintDino()
    {
        Console.WriteLine("              __");
        Console.WriteLine("             /o_)");
        Console.WriteLine("      .-^^^-/ /");
        Console.WriteLine("   __/       /");
        Console.WriteLine("  <__.|_|-|_|");
    }

    public static string GetUserQuery()
    {
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("[Your question] ➔  ");

        Console.ResetColor();
        return Console.ReadLine() ?? string.Empty;
    }

    public static void SendQuery(string userInput)
    {
        var userQuery = Uri.EscapeDataString(userInput);
        var urls = new List<string>()
        {
            $"https://chatgpt.com/?q={userQuery}",
            $"https://grok.com/?q={userQuery}",
            $"https://blackbox.ai/?q={userQuery}",
            $"https://phind.com/search/?q={userQuery}",
            $"https://copilot.microsoft.com/?q={userQuery}",
            $"https://www.perplexity.ai/?q={userQuery}",
        };

        try
        {
            foreach (var url in urls)
            {
                var process = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    }
                };
                process.Start();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception message: {ex}");
        }
    }
}