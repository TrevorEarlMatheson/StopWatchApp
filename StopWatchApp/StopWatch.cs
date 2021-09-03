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

        public void ControlFlow(System.ConsoleKey keyPressed)
        {
            Console.Clear();
            if(keyPressed == ConsoleKey.Enter && _startTime == DateTime.MinValue)
            {
                _startTime = DateTime.Now;
            }
            else if(keyPressed == ConsoleKey.Enter)
            {
                Duration();
                ResetWatch();
            }
            else
            {
                Console.WriteLine(Constants.InvalidPrompt);
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
