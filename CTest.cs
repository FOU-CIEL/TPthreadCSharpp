using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPthreadCSharpp
{
    namespace CTest
    {
        public class CTest
        {
            public void AfficheB()
            {
                while (true)
                {
                    Console.WriteLine("AfficheB thread : " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }

            public void AfficheC()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("AfficheC thread : " + Thread.CurrentThread.Name + " iteration " + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
