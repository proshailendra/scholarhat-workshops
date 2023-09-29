class IfElseProgram
{
    public static void Main()
    {
        /**** If..Else Example *****/
        Console.WriteLine("Please Enter a Number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} Number is Even");
        }
        else
        {
            Console.WriteLine($"{num} Number is Odd");
        }
        Console.WriteLine("Exit!");
    }
}