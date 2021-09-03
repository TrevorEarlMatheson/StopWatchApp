using System;

namespace StopWatchApp
{
    class StopWatch
    {
        private DateTime _startTime;

        public StopWatch()
        {
            _startTime = DateTime.MinValue;
        }

        public DateTime StartTime {  get { return _startTime; } }

        public bool ControlFlow(System.ConsoleKey keyPressed)
        {
            Console.Clear();
            if(keyPressed == ConsoleKey.Enter && _startTime == DateTime.MinValue)
            {
                _startTime = DateTime.Now;
                return true;
            }
            else if(keyPressed == ConsoleKey.Enter)
            {
                Duration();
                ResetWatch();
                return true;
            }
            else if (keyPressed == ConsoleKey.Escape)
            {
                return false;
            }
            else
            {
                Console.WriteLine(Constants.InvalidPrompt);
                return true;
            }
        }

        private void Duration()
        {
            Console.WriteLine(Constants.Elapsed + (DateTime.Now - _startTime));
        }

        private void ResetWatch()
        {
            _startTime = DateTime.MinValue;
        }
    }
}
