using System;
using System.Numerics;


Console.WriteLine("Wecome to the Console Calculator");

Console.Write("Enter the first Number: ");
string firstNumberInput = Console.ReadLine();

int firstNumber = Convert.ToInt32(firstNumberInput);
Console.WriteLine($"You entered: {firstNumber}");

Console.Write("Enter the second Number: ");
string secondNumberInput = Console.ReadLine();

int secondNumber = Convert.ToInt32(secondNumberInput);
Console.WriteLine($"You entered: {secondNumber}");

Console.WriteLine("Enter an operator (+, -, *, /): ");
string Operator = Console.ReadLine();

switch (Operator)
{
    case "+" :
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        break;
    case "-" :
        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        break;
    case "*" :
        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        break;
    case "/":
        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        break;
    default:
        Console.WriteLine("Please Enter a valid number");
        break;
}
















Console.ReadLine();
