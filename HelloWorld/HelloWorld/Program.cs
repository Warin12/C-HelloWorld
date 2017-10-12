using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start()
        }
        public static void Start()
        {

			Console.WriteLine("Write 2 numbers");
			float number1 = float.Parse(Console.ReadLine());
			float number2 = float.Parse(Console.ReadLine());

			Console.WriteLine("select an option\n1.-add\n2.-Subtract\n3.-Multiply\n4.-Divide");
			int option = int.Parse(Console.ReadLine());

			EvaluateOption(option, number1, number2);

			Console.WriteLine(number1 + number2);
        }
        public static float AddTwoNmbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result; 
        
        }
		public static float SubtractTwoNmbers(float n1, float n2)
		{
			float result = n1 - n2;

			return result;

		}
		public static float MultiplyTwoNmbers(float n1, float n2)
		{
			float result = n1 * n2;

			return result;

		}
		public static float DivideTwoNmbers(float n1, float n2)
		{
			float result = n1 / n2;

			return result;

		}
		public static void EvaluateOption(int option, float n1, float n2)
        {
            if (option == 1)
            {
                Console.WriteLine ("Result of the addition " + AddTwoNmbers(n1, n2) ); 
            }
            else if (option == 2)
            {
               Console.WriteLine("Result of the subtraction " + SubtractTwoNmbers(n1, n2)); 
            }
			else if (option == 3)
			{
				Console.WriteLine("Result of the multiplication " + MultiplyTwoNmbers(n1, n2));
			}
			else if (option == 4)
			{
				Console.WriteLine("Result of the Division " + DivideTwoNmbers(n1, n2));
			}
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
          
    }
}
