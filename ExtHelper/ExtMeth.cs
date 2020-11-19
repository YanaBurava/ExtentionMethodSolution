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
        public static bool GetBit(this byte data, int position)
        {

            if (position < 0 || position > 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this sbyte data, int position)
        {

            if (position < 0 || position > 7)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this short data, int position)
        {

            if (position < 0 || position > 15)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this ushort data, int position)
        {

            if (position < 0 || position > 15)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this int data, int position)
        {

            if (position < 0 || position > 31)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (data >> position) & 1;
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this uint data, int position)
        {

            if (position < 0 || position > 31)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = (int)((data >> position) & 1);
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this long data, int position)
        {

            if (position < 0 || position > 63)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit =(int)((data >> position) & 1);
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод определения конкретного бита
        /// </summary>
        public static bool GetBit(this ulong data, int position)
        {

            if (position < 0 || position > 62)
            {
                throw new ArgumentOutOfRangeException();
            }

            int bit = ((int)((data >> position) & 1));
            return Convert.ToBoolean(bit);
        }

        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static byte SetBit(this ref byte data, int bit, int position)
        {
            if (position < 0 || position > 7)
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
        public static sbyte SetBit(this ref sbyte data, int bit, int position)
        {
            if (position < 0 || position > 7)
            {
                throw new ArgumentOutOfRangeException();
            }
                  

            if (bit == 1)
            {
                 return data = (sbyte)(data | (1 << position));
             
            }
            else
            {
                return data = (sbyte)(data & ~(1 << position));
            }
            

        }
       
        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>

        public static short SetBit(this ref short data, int bit, int position)
        {
            if (position < 0 || position > 15)
            {
                throw new ArgumentOutOfRangeException();
            }

           
            if (bit == 1)
            {
               
                return (short)(data | (short)(1 << position));
            }
            else
            {
                return data = (short)(data & ~(1 << position));
            }

        }

        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static ushort SetBit(this ref ushort data, int bit, int position)
        {
            if (position < 0 || position > 15)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (bit == 1)
            {
                return data |= (ushort)(1 << position);
            }
            else
            {
                return data = (ushort)(data & ~(1 << position));
            }

        }

        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static int SetBit(this ref int data, int bit, int position)
        {
            if (position < 0 || position > 31)
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

        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static uint SetBit(this ref uint data, int bit, int position)
        {
            if (position < 0 || position > 31)
            {
                throw new ArgumentOutOfRangeException();
            }


            if (bit == 1)
            {   
                return data = (uint)(data | (1U << position));
            }
            else
            {
                return data = (uint)(data & ~(1U << position));
            }

        }

        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static long SetBit(this ref long data, int bit, int position)
        {
            if (position < 0 || position > 63)
            {
                throw new ArgumentOutOfRangeException();
            }


            if (bit == 1)
            {
               return data = data | (1L << position);
              

            }
            else
            {
                return data = data & ~(1L << position);
            }

        }
        /// <summary>
        /// Метод установки/сброса конкретных битов
        /// </summary>
        public static ulong SetBit(this ref ulong data, int bit, int position)
        {
            if (position < 0 || position > 62)
            {
                throw new ArgumentOutOfRangeException();
            }


            if (bit == 1)
            {
              // return data = data | (1UL << position);
                return (ulong)(data| (ulong)(((ulong)1) << position));

            }
            else
            {
               return data = data & ~(1UL << position);
            
            }

        }


    }
}
