int NatureDistance(int m, int n)
{
    if(n >= m)
    {
        return n + NatureDistance(m, n - 1);
    }
    else return 0;
}

Console.WriteLine("Num");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Num");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NatureDistance(m, n));