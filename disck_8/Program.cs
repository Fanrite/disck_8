using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Direte;

namespace disck_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int k = 6;
            Console.WriteLine("//----1-----//");
            for (int x = 0; x < k; x++)
                for (int y = 0; y < k; y++)
                    Console.WriteLine($"|X={x}|Y={y}|F={Bag.ModulP(Bag.InverLuk(x, k), (Math.Max(y, x)), k)}|");
            //2
            Console.WriteLine("//------2-------//");
            for (int x = 0; x < k; x++)
                for (int y = 0; y < k; y++)
                    for (int z = 0; z < k; z++)
                        Console.WriteLine($"|X={x}|Y={y}|Z={z}|G={Bag.ModulM(x,(Bag.ModulP(Math.Min(z,y),x,k)),k)}|");
            //3
            Console.WriteLine("//--------3---------//");
            for (int x = 0; x < k; x++)
                for (int y = 0; y < k; y++)
                    for (int z = 0; z < k; z++)
                        for (int t = 0; t < k; t++)
                            Console.WriteLine($"|X={x}|Y={y}|Z={z}|T={t}|H={Bag.ModulM((Bag.ShtrShef(Math.Min(t,x),y,k)),Math.Max(y,z),k)}|");

            Console.ReadKey();
        }
    }
}
