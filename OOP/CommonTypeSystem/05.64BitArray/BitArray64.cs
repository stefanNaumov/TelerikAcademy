using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    public class BitArray64: IEnumerable<int>
    {
        ulong value;
        int[] bits = new int[64];

        public BitArray64(ulong value)
        {
            this.value = value;
            for (int i = 0; i < 64; i++)
            {
                bits[i] = (int)value % 2;
                value /= 2;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() // Add System.Collections in the used namespaces in order to use IEnumerator
        {
            return this.GetEnumerator();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.bits[i];
            }
        }
        public override bool Equals(object obj)
        {
            BitArray64 bitArr = obj as BitArray64;
            if (bitArr == null)
            {
                return false;
            }
            if (this.value.Equals(bitArr.value))
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }
        public int this[int key]
        {
            get 
            {
                if (key < 0 || key > 63)
                {
                    throw new IndexOutOfRangeException("Bit index must be from 0 to 63 inclusive!");
                }
                    return this.bits[key]; 
            }
        }
        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return BitArray64.Equals(a, b);
        }
        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !(BitArray64.Equals(a, b));
        }
    }
}
