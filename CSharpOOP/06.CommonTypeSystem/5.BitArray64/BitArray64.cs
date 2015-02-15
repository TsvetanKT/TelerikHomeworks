namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        public ulong UlongValue { get; set; }

        public string Bits
        {
            get { return UlongToBinaryString(this.UlongValue); }
        }

        public ulong this[int tempIndex]
        {
            get
            {
                int index = 63-tempIndex;
                if (index >= 0 && index <= 63)
                {
                    // Check the bit at position index
                    if ((UlongValue & ((ulong)1 << index)) == 0)
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    throw new IndexOutOfRangeException(
                    String.Format("Index {0} is invalid!", index));
                }
            }
            set
            {
                int index = 63-tempIndex;
                if (index < 0 || index > 63)
                    throw new IndexOutOfRangeException(
                        String.Format("Index {0} is invalid!", index));
                if (value < 0 || value > 1)
                    throw new ArgumentException(
                        String.Format("Value {0} is invalid!", value));
                // Clear the bit at position index
                UlongValue &= ~(ulong)((1 << index));
                // Set the bit at position index to value
                UlongValue |= (ulong)(value << index);
            }
        }


        // Private method to convert ulong to bit array
        private static string UlongToBinaryString(ulong value)
        {
            int ulongsize = sizeof(ulong) * 8;
            StringBuilder ret = new StringBuilder(ulongsize);

            for (int i = 0; i < ulongsize; i++)
            {
                ret.Insert(0, value & 0x1);
                value >>= 1;
            }

            return ret.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                // Converts the 
                yield return (Bits[i] - '0');
                //yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object otherBitArray)
        {
            // If the cast is invalid, the result will be null
            BitArray64 bitArray = otherBitArray as BitArray64;
            // Check if we have valid not null Student object
            if (bitArray == null)
                return false;
            // Compare the reference type member fields
            if (!Object.Equals(this.UlongValue, bitArray.UlongValue))
                return false;
            return true;
        }

        public static bool operator ==(BitArray64 array1,
                                  BitArray64 array2)
        {
            return BitArray64.Equals(array1.UlongValue, array2.UlongValue);
        }

        public static bool operator !=(BitArray64 array1,
                                  BitArray64 array2)
        {
            return !(BitArray64.Equals(array1.UlongValue, array2.UlongValue));
        }

        public override int GetHashCode()
        {
            return this.UlongValue.GetHashCode() ^ this.Bits.GetHashCode();
        }
    }
}
