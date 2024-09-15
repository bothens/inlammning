using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 // Huvudklass
 public abstract class Iphone
    {
        public abstract void camera();
    }
    //subklass
    public class Computer : Iphone
    {
        public override void camera()
        {
            Console.WriteLine("The computer has a camera");

        }
    }

}
