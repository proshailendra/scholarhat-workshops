class IfElseLadderProgram
{
    public static void Main()
    {
        Console.WriteLine("Please Enter First Number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter Second Number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter Third Number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"Largst Number is: {num1}");
        }
        else if (num2 > num3)
        {
            Console.WriteLine($"Largst Number is: {num2}");
        }
        else
        {
            Console.WriteLine($"Largst Number is: {num3}");
        }
    }
}