using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big is your array?");

            string userArray = Console.ReadLine();
            int convertedArr = Convert.ToInt32(userArray);

            int[] array = new int[convertedArr];

            int[] arrayValue = CreateArray(array);

            Console.WriteLine("Insert a new value");

            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);

            int[] finalArray = InsertShiftArray(arrayValue, userNum);

            Console.WriteLine("The final array is [{0}]", string.Join(", ", finalArray));
        }

        static int[] CreateArray(int[] create)
        {
            for (int i = 0; i < create.Length; i++)
            {
                Console.WriteLine($"Enter a value, {i + 1} of {create.Length}");

                string userNum = Console.ReadLine();
                int convertedNum = Convert.ToInt32(userNum);
                create[i] = convertedNum;
            }
            return create;
        }

        static int[] InsertShiftArray(int[] firstArr, int value)
        {
            int[] userArr = firstArr;
            int middleValue = userArr.Length / 2;

            int[] newArray = new int[userArr.Length + 1];

            for (int i = 0; i < middleValue; i++)
            {
                newArray[i] = userArr[i];
            }

            newArray[middleValue] = value;

            for (int i = middleValue + 1; i < newArray.Length; i++)
            {
                newArray[i] = userArr[i - 1];
            }
            return newArray;
        }
    }
}
