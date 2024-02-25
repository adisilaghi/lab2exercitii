/*Ex 3: Scrieti un program care va afisa suma cifrelor unui n n, n fiind
citit de la tastatura.*/




Console.WriteLine("Write n digit number:");
int n = int.Parse(Console.ReadLine());

int sum = 0;
int initial = n;

while (n > 0)
{
    sum += n % 10;
    n /= 10;
}

Console.WriteLine($"Sum of the digits {initial} is: {sum}");