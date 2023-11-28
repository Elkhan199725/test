
#region

//string customReplace(string word, char oldChar, char newChar)
//{
//    string result = String.Empty;
//    for (int i = 0;i<word.Length; i++)
//    {
//        if (word[i] == oldChar)
//        {
//            oldChar = newChar;
//            result = result + newChar;
//        }
//        else
//        {
//            result = result + word[i];
//        }
//    }
//    return result;
//}

//string name = "Ulvi";
//Console.WriteLine(customReplace(name, 'U','i'));

//Ulvi => ilvi

#endregion
#region
//10 kimi hem 3e hem 5e qaliqsiz bolunen ededlerin cemi

//using System.Diagnostics.CodeAnalysis;
//using System.Diagnostics.Tracing;
//using System.Threading.Channels;

//int sum = 0;

//for (int i = 1;i<= 10; i++)
//{
//    if (i % 3 == 0 || i % 5 == 0  )
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);
#endregion
#region
//Console.Write("input: ");
//int input = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("prime numbers up to " + input + ": ");
//for (int i = 2; i <= input; i++)
//{
//    if (input % i == 0)
//    {
//        Console.WriteLine("is prime: " + i);
//    }
//    else
//    {
//        Console.WriteLine("is not prime: " + i);
//    }

//}
#endregion
#region Task 1 ucus Bileti
// Constants
const double basePricePerKm = 12.0d;
const double childDiscount = 0.5d;
const double adultDiscount = 0.1d;
const double seniorDiscount = 0.3d;
const double roundTripDiscount = 0.2d;
//Input: Distance in kilometers and passenger age
Console.WriteLine("Enter the distance in kilometers: ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter passanger's age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("is it a round trip? (yes/no): ");
string roundTripInput = Console.ReadLine();
bool isRoundTrip = roundTripInput.ToLower() == "yes";
//calculate ticket price
double basePrice = distance * basePricePerKm;
double discount = 0;
if (age < 12)
{
    discount = childDiscount;
}
else if (age >= 12 &&  age <= 65)
{
    discount = adultDiscount;
}
else if (age > 65)
{
    discount = seniorDiscount;
}
if (isRoundTrip)
{
    distance += roundTripDiscount;
}
double discountedPrice = basePrice * (1 - discount);
//output the result
Console.WriteLine($"Base Price: ${basePrice}");
Console.WriteLine($"Discount: {discount * 100}%");
Console.WriteLine($"Final Price: ${discountedPrice}");
#endregion