// See https://aka.ms/new-console-template for more information
#region Lab day task 1
//Console.WriteLine("enter test result");
//decimal scoretest = Convert.ToInt32(Console.ReadLine());
//decimal first = scoretest * 40/100 ;
//Console.WriteLine("enter exam result");
//decimal scoreexam = Convert.ToInt32(Console.ReadLine());
//decimal second = scoreexam * 60/100 ;
//decimal result = (decimal)(first + second);
//if ( result >= 65 && result <=100)
//{
//    Console.WriteLine("Congratulations" + " you collected " + result + " poinst");
//}
//else if ( result >= 0  && result < 65)
//{
//    Console.WriteLine("Failed" + " you collected " + result + " poinst");
//}
//else
//{
//    Console.WriteLine("Enter correct number" + " you collected " + result + " poinst");
//}
#endregion
#region Lab day task 2
Console.WriteLine("enter first number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int m = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine("sum of odd numbers in n and m interval");
for ( int i = n; i <= m; i++)
{
    if ( i % 2 == 1 )
    {
        sum += + i;
    }
}
Console.WriteLine(sum);
#endregion