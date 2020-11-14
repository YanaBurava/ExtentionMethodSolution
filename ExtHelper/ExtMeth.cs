using System;

namespace ExtHelper
{
    public static class ExtMeth
    {
        public static bool GetBits(this int data, int position, int size)
        {
            if (position < 0 || position > size)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        public static int SetBits(this ref int data, int bit, int position, int size)
        {
            if (position < 0 || position > size)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (bit == 1)
            {
                return data = data | 1 << position;
            }
            else
            {
                return data = data & ~(1 << position);
            }

        }
    }
}
