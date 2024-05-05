using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ArraysSaver
    {
        private Dictionary <int, int[]> _arrays = new Dictionary <int, int[]>();

        public int[] GetArray(int index)
        {
            if (!_arrays.ContainsKey(index))
            {
                _arrays[index] = new int[index];
               
                for (int i = 0; i< index; i++)
                {
                    _arrays[index][i] = i + 1;
                }
            }
            return _arrays[index];
        }

    }
}
