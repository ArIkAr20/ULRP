int R1 = int.Parse(Console.ReadLine());
int R2 = int.Parse(Console.ReadLine());
int type = int.Parse(Console.ReadLine());
double R = 0;
if (type == 1) // Последовательное
{
    R = R1 + R2;
}
else if (type == 2) // Параллельное
{
    R = (double)(R1 * R2) / (R1 + R2); 
}
Console.WriteLine(R);