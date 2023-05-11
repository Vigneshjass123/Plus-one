using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //digits = [1,2,3]
            //Output: [1,2,4]
            int temp = 1;
            int[] array = { 1, 2, 3 };
            for (int i = 0; i < array.Length; i++)
            {
               
                if (array[i] == 3)
                {
                   
                    temp = temp + array[i];



                    Console.Write(array[0] +""+ i);

                    Console.Write(temp);
                }
            }
        }
    }
}
    
