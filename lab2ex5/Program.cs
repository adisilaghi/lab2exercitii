/* Să se scrie un program care citeşte de la tastatură un şir de n numere
naturale şi determină media aritmetică a celor pare, n fiind citit de la
tastatra*/

Console.WriteLine("For how many numbers do you want to calculate their arithmetic mean?");
int number = int.Parse(Console.ReadLine());
int sum =  0;
int count  = 0;
for (int i = 0; i < number; i++) 

{
    Console.WriteLine("Enter a number");
   int n = int.Parse(Console.ReadLine());
    if (n%2 == 0) { sum += n; count++; }
    
}
if (count > 0)
{
    double average = (double) sum / count;
    Console.WriteLine("Arithmetic mean is" + average);
}
else
{
 Console.WriteLine("There are no numbers to calculate arithmetical mean");
}