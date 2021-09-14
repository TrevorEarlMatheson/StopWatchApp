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
                if(stopwatch.StartTime != DateTime.MinValue)
                {
                    Console.WriteLine(Constants.RunningPrompt);
                }

                Console.WriteLine(Constants.StartPrompt);

                var keyPressed = Console.ReadKey().Key;

                if (stopwatch.ControlFlow(keyPressed) == false)
                    break;
            }
        }
    }
}
