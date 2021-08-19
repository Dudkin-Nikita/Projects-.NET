using System;

namespace Task_2
{
    public sealed class Segment
    {
        private int left;
        private int right;
        private uint length;
        public int Left => left;

        public int Right => right;

        public uint Length => length;

        public Segment(int a, int b)
        {
            if (a <= b)
            {
                left = a;
                right = b;
            }
            else
            {
                left = b;
                right = a;
            }
            length = (uint)(right - left);
        }

        public override bool Equals(object obj)
        {
            if (obj is Segment s && length == s.length)
            {
                if (left == s.left && right == s.right)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (left + right) * (int)length;
        }

        public override string ToString()
        {
            return $"Left coordinate is {left}; right coordinate is {right}; length = {length}";
        }

        public static Segment operator +(Segment a, Segment b)
        {
            return new Segment(a.Left + b.Left, a.Right + b.Right);
        }

        public static explicit operator uint(Segment s)
        {
            return s.Length; 
        }

        public static implicit operator Segment((int a, int b) tuple)
        {
            return new Segment(tuple.a, tuple.b);
        }
            
    }
}
