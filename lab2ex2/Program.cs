/*Ex 2: Scrieti un program care va determina daca un numar negativ citit de
la tastatura este divizibil cu 2 si nu este divizibil cu 6*/



Console.WriteLine("Enter a negative value");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0 && number % 6 != 0) 
{
    Console.WriteLine("Divisible");
}
else
{
    Console.WriteLine("Indivisible");

}
