using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Phone
{
    class Call
    {
        private string _date;
        private string _startTime;
        private int _duration;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public Call( string date, string startTime, int duration)
        {
            Date = date;
            StartTime = startTime;
            Duration = duration;
        }
    }
}
