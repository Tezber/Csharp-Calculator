// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Calculator.");

while (true)
{
    Console.WriteLine("Enter first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Select operator: +, -, *, /: ");
    char op = Convert.ToChar(Console.ReadLine());

    double ans = 0;

    switch (op)
    {
        case '+':
            ans = num1 + num2;
            break;
        case '-':
            ans = num1 - num2;
            break;
        case '*':
            ans = num1 * num2;
            break;
        case '/':
            ans = num1 / num2;
            break;
        default:
            Console.WriteLine("Invalid operation!");
            break;
    }

    Console.WriteLine($"Result: {ans}");

    Console.WriteLine("Do you want to do another calculation? y/n\n");
    string redo = Console.ReadLine();

    if (redo != "y")
        break;
}
