int num = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(" ", Tribonacci(num)));


static int[] Tribonacci(int a)
{
    int[] tribonacciSequence = new int[a];
    if (a == 1)
    {
        tribonacciSequence[0] = 1;
        return tribonacciSequence;
    }
    if (a == 2)
    {
        tribonacciSequence[0] = 1;
        tribonacciSequence[1] = 1;
        return tribonacciSequence;
    }
    if (a == 3)
    {
        tribonacciSequence[0] = 1;
        tribonacciSequence[1] = 1;
        tribonacciSequence[2] = 2;
        return tribonacciSequence;
    }
    int numA = 0;
    int numB = 0;
    int numC = 0;
    tribonacciSequence[0] = 1;
    tribonacciSequence[1] = 1;
    tribonacciSequence[2] = 2;
    for (int i = 3; i < a; i++)
    {
        numA = tribonacciSequence[i - 3];
        numB = tribonacciSequence[i - 2];
        numC = tribonacciSequence[i - 1];
        tribonacciSequence[i] = numA + numB + numC;

    }


    return tribonacciSequence;
}