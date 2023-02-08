using System;

namespace RPP_Programirane
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());            
            }
            Console.WriteLine("Count ="+OptionsManager.CountLess100(arr));
            Console.WriteLine("Sum ="+OptionsManager.MaxNum(arr));
            arr = OptionsManager.ReverseArr(arr);
            OptionsManager.PrintEvensNum(arr);
            OptionsManager.PrintArr(arr);
            }
    }
}
