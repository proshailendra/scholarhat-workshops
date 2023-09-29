class DoWhileLoop
{
    /* 
        ======== Simple Calculator =======
        1. Addition
        2. Subtraction    
        3. Multiplication
        4. Division

        Choose Your Option: 1
        Please Enter First Number: 6
        Please Enter Second Number: 7

        The Sum of Number 6 and Number 7 is 13.

        Do you want to continue (y/n): y 
        // repeat
        Exit    
     */

    /* Enter a Number and convert it into words like 45200 => Fourty Five Thousand Two Hundred  */
    public static void Main()
    {
        char ch;
        do
        {
            Console.Clear();

            Console.WriteLine("Please Enter Your Name:");

            string? name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}");

            Console.WriteLine("Do you want to continue:(y/n)");
            ch = Convert.ToChar(Console.ReadLine());
        } while (ch == 'y');
        Console.WriteLine("Exit");
    }
}