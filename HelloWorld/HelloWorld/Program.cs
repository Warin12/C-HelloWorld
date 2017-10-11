using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write 2 numbers");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("select an option\n1.-add\n2.-Subtract\n3.-Multiply\n4.-Divide");
            int option = int.Parse(Console.ReadLine());
            
            EvaluateOption (option); 
            
            Console.WriteLine(number1 + number2);
        }

        public static float AddTwoNmbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        
        } 
   public staticvoid EvaluateOption(int opton)
    }
}
