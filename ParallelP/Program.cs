using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelP
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Program();
            int totalPrimes = 0;
            for (int i = 2; i < 1000000; i++)
            {
                if (k.IsPrime(i))
                {
                    totalPrimes++;
                }

            }
            Console.WriteLine(totalPrimes);
        }


        //static void Main(string[] args)
        //{
        //    List<int> p = new List<int>();
        //    int count = 0;
        //    var k = new Program();
        //    for (int i = 2; i < 1000000; i++)
        //    {
        //        p.Add(i);
        //    }
        //    var r = p.AsParallel().Select(v => k.IsPrime(v));
        //    foreach (var v in r)
        //    {
        //        if (v == true)
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);

        //}





        public bool IsPrime(int val)
        {
            int count = 0;
            for(int i=2;i <= Math.Ceiling((decimal)val/2);i++)
            {
                if(val%i == 0)
                {
                    count++;
                    if (count >= 1)
                    {
                        return false;
                    }
                }
            }
            return true;


        }
    }
}
