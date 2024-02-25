/*Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.*/



Console.WriteLine("Enter a number to calculate its factorial:");
int n = int.Parse(Console.ReadLine());

long factorial = 1;


for (int i = 2; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine($"Factorial of {n} is: {factorial}");