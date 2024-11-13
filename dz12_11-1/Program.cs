namespace dz12_11_1
{
    internal class Program
    {
        public static int CountOccurrences(int[] numbers, int target)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number == target)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть числа через пробіл:");

            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            int[] numbers = new int[numbersStr.Length];

            for (int i = 0; i < numbersStr.Length;
     i++)
            {
                if (int.TryParse(numbersStr[i], out int number))
                {
                    numbers[i] = number;

                }
                else
                {
                    Console.WriteLine($"Помилка: '{numbersStr[i]}' не число.");
                    return;
                }
            }

            Console.Write("Введіть число для підрахунку: ");
            int targetNumber = int.Parse(Console.ReadLine());

            int occurrences = CountOccurrences(numbers, targetNumber);

            Console.WriteLine($"Число {targetNumber} зустрічається {occurrences} разів.");
        }
    }
}
