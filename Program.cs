// See https://aka.ms/new-console-template for more information

string name = "Brad Lloyd";
int age = 47;
string address = "177 Cedar Way Hamilton GA 31811";

Console.WriteLine("User's name is: " + name);
Console.WriteLine("User's age is: " + age);
Console.WriteLine("User's address is: " + address);

// Write a C# program to print the sum of two numbers. Get the input from user.

Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

//  Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user.

Console.WriteLine("Enter dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());
int quotient = dividend / divisor;
int remainder = dividend % divisor;
Console.WriteLine("The quotient of " + dividend + " divided by " + divisor + " is: " + quotient);
Console.WriteLine("The remainder of " + dividend + " divided by " + divisor + " is: " + remainder);
