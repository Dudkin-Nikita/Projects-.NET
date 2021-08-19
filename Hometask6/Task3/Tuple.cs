using System;

namespace Task3
{
    public class Tuple
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Tuple(DateTime first, DateTime second)
        {
            Start = first;
            End = second;
        }
    }

}
