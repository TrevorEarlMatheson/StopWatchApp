using System;

namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopwatch = new StopWatch();
            while (true)
            {

                if(stopwatch.StartTime == DateTime.MinValue)
                {
                    stopwatch.StartPrompt();
                }
                else
                {
                    stopwatch.RunningPrompt();
                }

                var keyPressed = Console.ReadKey().Key;

                if(keyPressed == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    stopwatch.ControlFlow(keyPressed);
                }
            }
        }
    }
}
