class SwitchProgram
{
    public static void Main()
    {
        Console.WriteLine("Please Enter an Alphabet:");
        char ch = (char)Console.Read();

        //u
        // if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        // {
        //     Console.WriteLine("Entered alphabet is an Vowel");
        // }
        // else
        // {
        //     Console.WriteLine("Entered alphabet is a Consonent");
        // }

        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Entered alphabet is an Vowel");
                break;
            default:
                Console.WriteLine("Entered alphabet is a Consonent");
                break;
        }
    }
}

// check wheather a year is leap year or not
// 366 Days, 365 Days