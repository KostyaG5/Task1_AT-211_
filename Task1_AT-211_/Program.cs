namespace Task1_AT_211_
///Вариант - 5. Реализовать функцию вычисления суммы двух вещественных чисел .
///Исходные данные вводятся при помощи генератора случайных чисел(с возможностью получения как положительных, так и отрицательных значений)

{
    internal class Program
    {
        private static double SumofTwoRealNumbers(double number1, double number2)
        {
               return number1 + number2;
        }


        static void Main(string[] args)
        {

            Random random = new ();
            double number1 = random.NextDouble()*50-25 , number2 = random.NextDouble() * 50 - 25;
            Console.WriteLine($"{number1} + {number2} = {SumofTwoRealNumbers(number1, number2)}") ;
        }
    }
}
