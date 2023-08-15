// See https://aka.ms/new-console-template for more information
Console.Title = "Calculator";
string go;
go = "go";
float num1, num2;
char marck;
s:
Console.WriteLine("Enter number");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter marck");
marck = char.Parse(Console.ReadLine());
Console.WriteLine("Enter number");
num2 = float.Parse(Console.ReadLine());
if (marck == '+')
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
else if (marck == '-')
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
else if (marck == '*')
    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
else if (marck == '/')
    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
else if (marck == '%')
    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
else
    Console.WriteLine("Error");
Console.WriteLine("go out enter 'go'");
string oo = Console.ReadLine();
if (go == oo)
    return;
else
    goto s;
Console.ReadKey();

