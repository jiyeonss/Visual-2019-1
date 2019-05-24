using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A020_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic(일반화) 프로그램
            List<int> a = new List<int>();
            a.Add(10);
            a.Add(20);
            a.Add(50);
            a.Add(40);
            a.Add(30);

            for (int i = 0; i < a.Count; i++) //0부터 5보다 작은 동안
            {
               Console.WriteLine(a[i]);
            }

            foreach (var item in a) //컬렉션 안에 있는 아이템 각각에 대해서(컬렉션은 a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n정렬 후");
            a.Sort(); //정렬 끝
            foreach (var item in a) 
            {
                Console.WriteLine(item);
            }

            List<string> b = new List<string>();
            b.Add("HELLO");
            b.Add("hello");
            b.Add("Hello");


            foreach (var s in b)
            {
                Console.WriteLine(s);
            }

            b.Sort();
            Console.WriteLine("\n정렬 후");
            foreach (var s in b)
            {
                Console.WriteLine(s);
            }
        }
    }
}
