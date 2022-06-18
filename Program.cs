using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("--------------Question 1--------------");
         Console.WriteLine("Enter your First Input:");
         string input1 = Console.ReadLine();
         int input1Length = input1.Length;
         Console.WriteLine("Enter your second Input:");
         string input2 = Console.ReadLine();
         int input2Length = input2.Length;
         Console.WriteLine("Your First Input has" + input1Length + " letters, while your Second input has " + input2Length + " letters");
         int TotalLength = input2Length + input2Length;
         Console.WriteLine("The addition of your First and Second Input is " + TotalLength);

         int True = TotalLength * 3;
         int False = TotalLength + 20;
         
         Console.WriteLine((TotalLength > 20) ? "The answer is true, so the length of the two input multiply by 3 is" + True: "The answer is false, so the length of the two input + 20 is " + False );



         Console.WriteLine("-----------------Question 2----------------");
         Console.WriteLine("Write a program to calculate the profit between the cost price of a product of $200.876 whose selling price is $255.425.");
         Console.WriteLine ("Solution");
         Console.WriteLine("Profit = Selling Price - Cost Price.");
         float SellingPrice = 255.425F;
         float CostPrice = 200.876F;
         Console.WriteLine ("Profit = 255.425 - 200.876");
         float profit = (float)(SellingPrice - CostPrice);
         Console.WriteLine("Profit = $" + Math.Round(profit, 2, MidpointRounding.ToEven));



         Console.WriteLine("-------------Question 3---------");
         string word = Console.ReadLine();
        
         int index = word.IndexOf( word[2]);
         int wordLength = word.Length;
         
         int result3 = index + wordLength;
         char result4 = (char)result3;

         Console.WriteLine($"The third character in {word} is :{word[2]}");
         Console.WriteLine($"The Length of the {word} is {wordLength}");

         


         Console.WriteLine("---------------Question 4--------------");
         Console.WriteLine("Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional or tenary operator statemants.");
         Console.WriteLine("Solution");
         Console.WriteLine("Enter your First Input:");

         int Input1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter your Second Input:");

         int Input2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Recorded");
         Console.Write("Your First Input is " + Input1 + ", Your Second Input is " + Input2);
         Console.WriteLine("The larger input is " + Math.Max(Input1, Input2) );
         

         Console.WriteLine("------------Question 6------------");
         Console.WriteLine("The sum of two numbers collected from user input, substracted from a constant value of 5.(Sample expression: number1 + number2 - 5). ");
         Console.WriteLine("Solution");
         int FirstInput = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Enter your Second Input:");

         int SecondInput = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Recorded");
         Console.WriteLine("Your First Input " + FirstInput + ", Your Second Input is" + SecondInput);
         Console.Write(FirstInput + " + " + SecondInput + " - 5 = ");
         int result = FirstInput + SecondInput - 5;

         Console.Write(result);
         
         
         

         

         
         
         

         

         
         

         

         





        
         
         
        
         
            
        }
    }
}


