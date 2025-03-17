using System;
namespace OperatorOverloading
{
   class program
   {
       public int p1, p2;
       public program()
       {
           p1 = 10;
           p2 = 15;
       }
       public program(int p3, int p4)
       {
           p1 = p3;
           p2 = p4;
       }
       public static bool operator == (program p1, program p2)
       {
           return p1.Equals(p2);
       }
       public static bool operator != (program p1, program p2)
       {
           return !(p1 == p2);
       }
       public static void Main()
       {
           program o1 = new program();
           program o2 = new program(15,30);
           Console.WriteLine("Object P1: {0} {1}", o1.p1, o1.p2);
           Console.WriteLine("Object P2: {0} {1}", o2.p1, o2.p2);
           if (o1 == o2)
               Console.WriteLine("Objects are equal");
           else if (o1 != o2)
               Console.WriteLine("Objects are not equal");
       }
   }
}
