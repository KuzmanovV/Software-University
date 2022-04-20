using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _4.Froggy
{
    public class Lake: IEnumerable<int>
    {
        private List<int> Stones;

        public Lake(List<int> stones) 
        {
            Stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Count; i+=2)
            {
                yield return Stones[i];
            }

            int index = Stones.Count - 1;

            if (index%2==0)
            {
                index--;
            }

            for (int i = index; i >= 0; i-=2)
            {
                yield return Stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
