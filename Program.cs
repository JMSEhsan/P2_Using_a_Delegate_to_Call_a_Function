/* 
P2: Using a Delegate to Call a Function
------------
Beginning C# Programming with Visual Studio 2017 by Benjamin et al. Wrox, 2018.
I slightly modified the code to be able to run with .Net 6
IDE: VS Code

*/

// See https://aka.ms/new-console-template for more information
class Program
{
    delegate double ProcessDelegate(double param1, double param2);
    static double Multiply (double param1, double param2) => param1 * param2;
    static double Divide (double param1, double param2) => param1 / param2;

    static void Main (string[] args)
    {   
        String x = "d";
        while (x == "D" || x == "d" || x == "M" || x == "m")
        {
        ProcessDelegate process;
        Console.WriteLine("Enter 2 numbers seperated with a comma:");
        string input = Console.ReadLine();
        int commaPos = input.IndexOf(',');
        double param1 = Convert.ToDouble(input.Substring(0, commaPos));
        double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos -1));
        
        Console.WriteLine("Enter M to multiply or D to divide:");
        input = Console.ReadLine();
        
        if (input == "M" || input == "m")
           process = new ProcessDelegate(Multiply);
        else
        process = new ProcessDelegate(Divide);
        
        Console.WriteLine($"Result: {process(param1, param2)}");
        Console.WriteLine(" ");
        Console.ReadKey();
        }        
    }
}
