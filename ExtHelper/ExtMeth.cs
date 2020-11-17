using System;

namespace ExtHelper
{
    /// <summary>
    /// Класс ExtMeth, включает в себя 2 метода расширения
    /// </summary>
    public static class ExtMeth
    {
        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBits(this byte data, int position)
        {

            if (position < 0 || position >= 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

       
        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>

        public static bool GetBits(this int data, int position)
        {

            if (position < 0 || position >= 31)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static byte SetBits(this ref byte data, int bit, int position)
        {
            if (position < 0 || position >= 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (bit == 1)
            {
                return data = (byte)(data | (1 << position));
            }
            else
            {
                return data = (byte)(data & ~(1 << position));
            }

        }
        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static int SetBits(this ref int data, int bit, int position)
        {
            if (position < 0 || position >= 31)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (bit == 1)
            {
                return data |= (1 << position);
            }
            else
            {
                return data & ~(1 << position);
            }

        }

       
    }
}
