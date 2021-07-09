using System;
using System.Collections;

namespace duplicate
{
    class Program
    {
     public  static void ArrayList()
        {
            Console.WriteLine("Enter the length of array");
            int ArrayLength = Convert.ToInt32(Console.ReadLine());
            var myArrayList = new ArrayList();
            Console.WriteLine("Enter the elements of the array:");
            var ArrayList = Convert.ToInt32(Console.ReadLine());
            myArrayList.Add(44);
             myArrayList.Add(75);
           Console.WriteLine("Duplicate elements in given Array");
           for(int i=0;  i<ArrayLength;  i++)
           {
                for(int j=0;  j<ArrayLength;  j++)
                {
                    if(myArrayList[i] == myArrayList[j])
                    Console.WriteLine(myArrayList[j]);
                }
           }




        
             

        
            


        }
    }
}
