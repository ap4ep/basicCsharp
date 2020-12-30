using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lesson4._2
{
    class StaticClass
    {
        

        public static int CalculatePairsInArray(int[] array)
        {
            int pairs = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && i < array.Length - 1)
                {
                    if (array[i + 1] % 3 != 0)
                    {
                        pairs++;
                    }
                }

                if (array[i] % 3 != 0 && i < array.Length - 1)
                {
                    if (array[i + 1] % 3 == 0)
                    {
                        pairs++;
                    }
                }
            }

            return pairs;
        }

        public static int[] ReadArrayFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            int row = int.Parse(sr.ReadLine());
            int[] array = new int[row];
            
            for(int i = 0; i < row; i++)
            {
                array[i] = int.Parse(sr.ReadLine());
            }

            sr.Close();
            return array;
        }
    }
}
