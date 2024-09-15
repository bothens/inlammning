using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        //attribut
        string name;
        //metod
        public virtual void Eat()
        {
            Console.WriteLine("animal eat");
          
           
        }

    }
    //subclass
    public class Dog : Animal
    {
        //attribut
        public string breed;
        public override void Eat()

        {
            Console.WriteLine("dogs eat");
        }
    }
}
