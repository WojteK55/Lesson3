using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число = ");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число = ");
            float secondNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Выберете действие из предложенных: 'Sum', 'Mines', 'Multiply', 'Division', 'Fact', 'Rest' ");
            string action = Console.ReadLine();

            
            switch (action)
            {
                case "Sum":
                    Sum(firstNum,secondNum);
                    float resultSum = Sum(firstNum, secondNum);
                    Console.WriteLine(resultSum);
                    break;
                 
                case "Mines":
                    float resultMines = Mines(firstNum, secondNum);
                        Console.WriteLine(resultMines);
                    break;

                case "Multiply":
                    Multiply(firstNum, secondNum);
                    float resultMultiply = Multiply(firstNum, secondNum);
                    Console.WriteLine(resultMultiply);
                    break;
                case "Division":
                    Multiply(firstNum, secondNum);
                    float resultDivision = Division(firstNum, secondNum);
                    Console.WriteLine(resultDivision);
                    break;
                case "Fact":
                    Fact(ref firstNum);
                    float resultFact = Fact(ref firstNum);
                    Console.WriteLine(resultFact);
                    
                    break;
                case "Rest":
                    rest(firstNum, secondNum);
                    float resultRest = rest(firstNum, secondNum);
                    Console.WriteLine(resultRest);

                    break;

            }
            


        }


        public static float Sum(float firstNum, float secondNum)
        {

            return (firstNum + secondNum);
        }
        public static float Mines(float firstNum, float secondNum)
        {

            return (firstNum - secondNum);
        }
        public static float Multiply(float firstNum,float secondNum)
        {

            return (firstNum * secondNum);
        }
        public static float Division(float firstNum, float secondNum)
        {

            return (firstNum / secondNum);
        }
        public static float Fact(ref float firstNum)
        {
            Console.WriteLine("Факториал какого числа вы хотите узнать?");
             int limit = int.Parse(Console.ReadLine());
            firstNum = 1;
            for (int i = 1; i <= limit; i++)
            {
                 firstNum = firstNum * i;            
            }
            return firstNum;
        }

        public static float rest (float firstNum,float secondNum)
        {
            int aOne = Convert.ToInt32(firstNum);
            int bOne = Convert.ToInt32(secondNum);
            float intermediateFloat = firstNum / secondNum;
            int intermediateint = aOne / bOne;
            float resultRest = intermediateFloat - intermediateint;


            return resultRest;
        }




    }
}
