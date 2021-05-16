using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int  N = 15;
            ArrayList list1 = new ArrayList();
            ArrayList Zagl = new ArrayList();
            char[] copy = new char[N];
            int i = 0;
            for (i = 0; i < N; i++)
            {
                Console.Write("Введите добавляемые элемент: ");
                list1.Add(Console.ReadLine());
            }

            for (i = 0; i < list1.Count; i++)
            {
                char a = Convert.ToChar(list1[i]);
                if (!Char.IsDigit(a)&&(Char.IsLetter(a)&&Char.IsUpper(a)))
                {
                    Zagl.Add(a);
                } 
            }
            for(i = 0; i < list1.Count; i++)
            {
                copy[i] = Convert.ToChar(list1[i]);
            }
            list1.Clear();
            for (i = 0; i < copy.Length; i++)
            {
                if (!Char.IsLetter(copy[i]))
                {
                    list1.Add(copy[i]);
                }
            }
            Console.WriteLine();
            foreach(object f in Zagl)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            foreach (object f in list1)
            {
                Console.Write(f + " ");
            }
        }
    }
}

