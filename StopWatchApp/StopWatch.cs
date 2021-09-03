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

        public void StartPrompt()
        {
            Console.WriteLine(_startPrompt);
        }

        public void InvalidKeyPrompt()
        {
            Console.Clear();
            Console.WriteLine(_invalidPrompt);
        }

        public void RunningPrompt()
        {
            Console.WriteLine(_runningPrompt);
        }

        public void Duration()
        {
            Console.Clear();
            Console.WriteLine("Elapsed Time: " + (DateTime.Now - _startTime));
            ResetWatch();
        }

        private void ResetWatch()
        {
            _startTime = DateTime.MinValue;
        }
    }
}
