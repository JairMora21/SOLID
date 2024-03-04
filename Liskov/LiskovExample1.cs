using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID.Liskov
{

    public static class Program
    {
        public static void Main(string[] args)
        {
            T t = new S1();
            Console.WriteLine(t.GetName());
            //OUTPUT: S1
            t = new S2();
            Console.WriteLine(t.GetName());
            //OUTPUT: S2
        }
    }
    public abstract class T
    {
        public abstract string GetName();
    }

    public class S1 : T
    {
        public override string GetName()
        {
            return "S1";
        }
    }
    public class S2 : T
    {
        public override string GetName()
        {
            return "S2";
        }
    }


}
