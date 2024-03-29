namespace arrays_david_conway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input from user and stor an array
            Console.WriteLine("enter a whole number for the array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            int sum = 0;
            Console.WriteLine("enter a whole number for the power of itself .");
            int arraySize2 = Convert.ToInt32(Console.ReadLine());
            int[] numbers2 = new int[arraySize];
            int sum2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("enter a whole number to add to the array.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of the array is {sum}");

            //sorts the array then prints each elements in the console 
            Array.Sort(numbers);
            Console.WriteLine("Array:" +
                "");
            foreach(int number in numbers)
            {

                Console.WriteLine(number);
            }
        }
    }
}