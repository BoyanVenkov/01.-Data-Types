int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

MultiplicationSign(num1, num2, num3);

static void MultiplicationSign(int a, int b, int c)
{
    int negativeCount = 0;
    if (a == 0 || b == 0 || c == 0)
    {
        Console.WriteLine("zero");
        return;
    }
    if (a < 0)
    {
        negativeCount++;
    }
    if (b < 0)
    {
        negativeCount++;
    }
    if (c < 0)
    {
        negativeCount++;
    }
    if (negativeCount % 2 != 0)
    {
        Console.WriteLine("negative");
    }
    if (negativeCount % 2 == 0)
    {
        Console.WriteLine("positive");
        return;
    }
    if (a > 0 && b > 0 && c > 0)
    {
        Console.WriteLine("positive");
    }
}



