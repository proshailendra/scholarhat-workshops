//A Program to Add Two Numbers
/*int num1, num2;

Console.WriteLine("Please Enter First Number:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Second Number:");
num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;
Console.WriteLine("Sum:" + sum);
*/

/* Swapping Two Numbers Values */
/*
int num1, num2;

Console.WriteLine("Please Enter First Number:");
num1 = Convert.ToInt32(Console.ReadLine()); //4

Console.WriteLine("Please Enter Second Number:");
num2 = Convert.ToInt32(Console.ReadLine()); //5

//TO DO:
num1 = num1 + num2; //9

num2 = num1 - num2; //9-5=4
num1 = num1 - num2; //9-4 =5
*/

/* Print the table of a number */
// Console.WriteLine("Please Enter Number For Table:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} X 1= {num * 1}");
// Console.WriteLine($"{num} X 2= {num * 2}");
// Console.WriteLine($"{num} X 3= {num * 3}");
// Console.WriteLine($"{num} X 4= {num * 4}");
// Console.WriteLine($"{num} X 5= {num * 5}");
// Console.WriteLine($"{num} X 6= {num * 6}");
// Console.WriteLine($"{num} X 7= {num * 7}");
// Console.WriteLine($"{num} X 8= {num * 8}");
// Console.WriteLine($"{num} X 9= {num * 9}");
// Console.WriteLine($"{num} X 10= {num * 10}");

//3495 => Sum of digit is 21
Console.WriteLine("Please Enter a 4 Digit Number:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int ld = 0;

ld = num % 10; //5
sum = sum + ld; //0+5 = 5
num = num / 10; //349

ld = num % 10; //9
sum = sum + ld;
num = num / 10;

ld = num % 10; //4
sum = sum + ld;
num = num / 10;

ld = num % 10; //3
sum = sum + ld;

Console.WriteLine($"Sum of Digits: {sum}");