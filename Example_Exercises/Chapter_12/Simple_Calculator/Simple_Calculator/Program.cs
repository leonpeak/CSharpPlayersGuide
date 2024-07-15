namespace Simple_Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first number: ");
        string num1Input = Console.ReadLine();
        int num1 = int.Parse(num1Input);

        Console.Write("Please enter your second number: ");
        string num2Input = Console.ReadLine();
        int num2 = int.Parse(num2Input);

        Console.Write("What would you like to do with your numbers? Enter +,-,%,x,^ to choose your operation: ");
        string userOperation = Console.ReadLine();

        switch (userOperation)
        {
            case "+":
            Console.WriteLine(num1 + num2);
            break;
            case "-":
            Console.WriteLine(num1 - num2);
            break;
            case "%":
            Console.WriteLine(num1 / num2);
            break;  
            case "x":
            Console.WriteLine(num1 * num2);
            break;
            case "^":
            Console.WriteLine(Math.Pow(num1, num2));
            break;
            default: 
            Console.WriteLine("That is not an operator, please try again!"); 
            break;  
        }

    }
}
