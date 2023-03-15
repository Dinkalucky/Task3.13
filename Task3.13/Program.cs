using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3._13
{
    internal class Program
    {
        public static void createRandomString(int Length)
        {
            string _allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
            Random randNum = new Random();
            char[] chars = new char[Length];

            for (int i = 0; i < Length; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }

            int koordinateX = randNum.Next(20, 1900);
            int koordinateY = randNum.Next(20, 900);
            Console.SetCursorPosition(koordinateX, koordinateY);
            for (int i = 0; i < chars.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 1: Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    default: Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }

                Console.SetCursorPosition(koordinateX, koordinateY - i);
                Console.WriteLine(chars[i]);
            }
            
            Console.WriteLine();
            ThreadStart newThreadStart = () => { createRandomString(randNum.Next(5, 20)); };
            newThreadStart();
        }
        static void Main(string[] args)
        {
                Random rand = new Random();
                createRandomString(rand.Next(5,20));
        }
    }
}
