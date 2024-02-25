/*Ex 1: Scrieti un program care va calcula valoarea urmatoarei functii pentru
x citit de la tastatura*/

Console.WriteLine("Enter a value: ");
double realNumber = double.Parse(Console.ReadLine());
double result;

if (realNumber <= -2)
{
    result = 7 * Math.Pow(realNumber, 2);

}

else if (realNumber <= 0.5)

{
    result = 4 * realNumber - 5;
}

else
{
    result = 14 * realNumber - 7;
}

Console.WriteLine("Result" +result);