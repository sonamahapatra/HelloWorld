using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Human
    {
        public string name;
        public int age;
        public float height, weight;

        public void Speek()
        {
            Console.WriteLine("Human can speak");
        }
        public void HumanDetails(string humanName, float humanHeight,float humanWeight,int age)
        {
            Console.WriteLine("HumanDetails:{0} {1} {2} {3}", humanName,humanHeight,humanWeight,age);
        }
    }
}
