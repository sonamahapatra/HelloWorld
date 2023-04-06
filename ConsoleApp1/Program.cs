using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to 276 Batch");
            //Console.WriteLine("modifing to local");
            Human human = new Human();
            Console.WriteLine("Please Enter Human Name:");
            human.name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            human.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Height:");
            human.height =Convert.ToSingle( Console.ReadLine());
            Console.WriteLine(" Enter Your Weight:");
            human.weight = Convert.ToSingle(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
