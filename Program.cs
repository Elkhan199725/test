//#region Homework
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int a = 45;
//        int b = 125;
//        byte c = 15;
//        byte d = 17;
//        byte result = (byte)(c + d);
//        int result2 = (int)(b - a);
//        int temp = a;
//        a = b;
//        b = temp;
//        Console.WriteLine("first number" + " " + a);
//        Console.WriteLine("second number" + " " + b);
//        Console.WriteLine("third number " + c + " + " + "fourth number " + d + " = " + "result " + result);
//        Console.WriteLine("first number " + a + " - " + "second number " + b + " = " + "result " + result2);
//    }
//}
//#endregion

#region if else
double n = 15;

if (n % 2 == 0)
{
    Console.WriteLine("even number");
}
else if (n % 2 == 1)
{
    Console.WriteLine("odd number");
}
else
{
    Console.WriteLine("error");
}
#endregion

#region if else
double m = 70;
if (m >= 65 && m <= 100)
{
    Console.WriteLine("Passed");
}
else if (m>= 0 && m < 65)
{
    Console.WriteLine("Failed");
}
else
{
    Console.WriteLine("error");
}
#endregion

#region while
int start = 1;
while (start <= 10)
{
    Console.WriteLine(start);
    start++;
}
#endregion

#region for
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
#endregion