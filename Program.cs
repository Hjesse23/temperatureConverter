Console.WriteLine("Console-based Temperature Converter App");
Console.Write("Enter a whole number: ");

int wholeNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the desired conversion type by choosing a number");
Console.WriteLine("1. Fahrenheit to Celsius");
Console.WriteLine("2. Celsius to Fahrenheit");
Console.WriteLine("3. Celsius to Kelvin");

string choice = Console.ReadLine();
double calculate;

switch (choice)
{
    case "1":
        calculate = (wholeNumber - 32) * 5 / 9;
        Console.WriteLine($"The conversion from {wholeNumber}° fahrenheit to celsius is {calculate}");
        break;
    case "2":
        calculate = (wholeNumber * 9 / 5) + 32;
        Console.WriteLine($"The conversion from {wholeNumber}° celsius to fahrenheit is {calculate}");
        break;
    case "3":
        calculate = wholeNumber + 273.15;
        Console.WriteLine($"The conversion from {wholeNumber}° celsius to Kelvin is {calculate}");
        break;
    default:
        Console.WriteLine("Error: You've entered invalid input.");
        break;
}


