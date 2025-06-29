namespace TrainingHomeworks.Tema6
{
    public class Homework
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the size of the list:");
            int sizeOfList = int.Parse(Console.ReadLine());

            List<int> numberList = new List<int> (new int[sizeOfList]);

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine($"Please input a number for list[{i}]");
                numberList[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Your list contains the following items:");
            foreach(int i in numberList)
            {
                Console.Write($" {i};");
            }

            List<int> evenNumbers = [];
            int evenNumbersSum = 0;
            Console.Write("\nThe list of even numbers is:");
            foreach (int i in numberList)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                    evenNumbersSum += i;
                    Console.Write($" {i};");
                }
            }
            

            List<int> oddNumbers = [];
            int oddNumbersSum = 0;
            Console.Write("\nThe list of odd numbers is:");
            foreach (int i in numberList)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                    oddNumbersSum += i;
                    Console.Write($" {i};");
                } 
            }

            Console.Write($"\n\nThe sum of even numbers is: {evenNumbersSum}");
            Console.Write($"\nThe sum of odd numbers is: {oddNumbersSum}");

        }

    }
}