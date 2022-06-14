class Program
{
    static int n = 10;
    static void Main()
    {
        Random rnd = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.Next(1, 100);
        }
        print(array);
        sort(array);
        print(array);
    }
    static void sort(int[] data)
    {
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            int j = rnd.Next(i + 1);
            var temp = data[j];
            data[j] = data[i];
            data[i] = temp;
        }
    }
    static void print(int[] data)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", data[i]);
        }
        Console.WriteLine();
    }

}
