using System;
using System.Collections.Generic;

namespace StopWatchApp
{
    class StopWatch
    {
        private DateTime _startTime;
        private readonly string  _startPrompt;
        private readonly string _runningPrompt;
        private readonly string _invalidPrompt;

        public StopWatch()
        {
            _startPrompt = "\nEnter: Start/Stop Timer\nEscape: Quit Program";
            _runningPrompt = "\nStopwatch Running...";
            _invalidPrompt = "\nInvalid key pressed.";
            _startTime = DateTime.MinValue;
        }

        public DateTime StartTime 
        {
            set { _startTime = value; }
            get { return _startTime; }
        }

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
                Console.WriteLine(_invalidPrompt);
            }
        }

        public void StartPrompt()
        {
            Console.WriteLine(_startPrompt);
        }

        public void RunningPrompt()
        {
            Console.WriteLine(_runningPrompt);
        }

        private void Duration()
        {
            Console.WriteLine("\nElapsed Time: " + (DateTime.Now - _startTime));
        }

        private void ResetWatch()
        {
            _startTime = DateTime.MinValue;
        }
    }
}
