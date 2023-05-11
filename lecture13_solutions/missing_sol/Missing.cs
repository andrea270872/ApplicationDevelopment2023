using System;
using System.Collections.Generic;

namespace Stack_test
{
    internal class MissingClass
    {
        public int[] missing(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            
            for (int i=0;i<arr1.Length;i++)
            {
                bool present = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        present = true;
                        break;
                    }
                }
                if (!present)
                {
                    result.Add(arr1[i]);
                }
            }

            return result.ToArray();
        }
    }
}