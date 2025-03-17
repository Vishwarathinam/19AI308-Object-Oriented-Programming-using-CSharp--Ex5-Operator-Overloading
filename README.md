# 19AI308-Object-Oriented-Programming-using-CSharp--Ex5-Operator-Overloading
## AIM:
To write a C# program to pass values through constructors(default and parameterized) and also overload equal operators by checking whether objects are equal using operator overloading. 
## ALGORITHM:
### Step1:
Create a class named program.

### Step 2:
Create two constructors with different arguments to implement operator overloading

### Step 3:
Create boolean operators to check equals and not equal condition and to implement operator overloading.

### Step 4:
Create a Main function

### Step 5:
Create two objects. One without arguments & the other with arguments

### Step 6:
Check whether the objects are equal or not using if-else condition

## PROGRAM:
```cs
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
```

## OUTPUT:
![](https://github.com/Ronick2005/19AI308-Object-Oriented-Programming-using-CSharp--Ex5-Operator-Overloading/assets/83219341/63a5c209-b4a3-4d4d-835c-d376967e99bf)

## RESULT:
Thus, a C# program to find the volume of a box using operator overloading is implemented successfully.
