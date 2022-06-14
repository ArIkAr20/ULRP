int num = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1; i <= num; i = i + 2)
{
    if (num % i == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
