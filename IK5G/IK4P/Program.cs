int n = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int count = 0;
while (n != 0)
{
    if (((n - x) % 10 == 0) | ((n - y) % 10 == 0))
    {
        count++;
    }
    n = n / 10;
}
Console.WriteLine(count);
