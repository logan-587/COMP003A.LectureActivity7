/* 
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Array and List Activity Lecture
 * 
 */


namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays Section
            PrintSeparator("Arrays", '*');

            int[] array1 = new int[5];
            array1[0] = 5;
            array1[1] = 10;
            array1[2] = 15;
            array1[3] = 20;
            array1[4] = 25;

            Console.WriteLine($"Length of Array1: {array1.Length}\n");

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine("array2 Tranversal");
            ArrayTraversal(array2);



            //***********************************************************
            //Integer Array Traversal
            int[] grades = new int[] { 100, 85, 92, 87, 91, 78, 89 };
            Console.WriteLine($"\nAverage of grades: {GetAverage(grades)}");


            //*************************************************************
            //String Array Traversal
            Console.WriteLine("\nString Traversal");
            string message = "hello";
            ArrayTraversal(message);



            //*******************************************************************************
            //Lists Section
            PrintSeparator("Lists", '*');

            List<char> alphabet = new List<char>(); //empty list
            alphabet.Add('A');
            alphabet.Add('B');
            alphabet.Add('C');
            alphabet.Add('D');
            alphabet.Add('E');

            Console.WriteLine($"Count of alphabet: {alphabet.Count()}\n");
            Console.WriteLine($"alphabet[0]: {alphabet[0]}");
            Console.WriteLine($"alphabet[2]: {alphabet[2]}");
            Console.WriteLine($"alphabet[4]: {alphabet[4]}");

            alphabet.Remove('C');
            Console.WriteLine("\nContents of alphabet after removing 'C':");
            ListTraversal(alphabet);

        }







        //I like mine
        /// <summary>
        /// Method to make titles easy
        /// </summary>
        /// <param name="message">String Input</param>
        /// <param name="x">Char Input</param>
        static void PrintSeparator(string message, char x)
        {
            Console.WriteLine("\n\n".PadRight(102, x));
            Console.WriteLine($"\t{message}");
            Console.WriteLine("".PadRight(100, x));
        }



        /// <summary>
        /// Prints arrays element-by-element
        /// </summary>
        /// <param name="array">Array input</param>
        static void ArrayTraversal(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array at index {i}: {array[i]}");
            }
        }


        /// <summary>
        /// Calculates Average from array
        /// </summary>
        /// <param name="array">Array input</param>
        /// <returns>Double output</returns>
        static double GetAverage(int[] array)
        {
            int runningTotal = 0;

            foreach (int item in array)
            {
                runningTotal += item;
            }

            return (runningTotal / array.Length);
        }



        /// <summary>
        /// Prints arrays element-by-element
        /// </summary>
        /// <param name="array"></param>
        static void ArrayTraversal(string array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array at index {i}: {array[i]}");
            }
        }



        /// <summary>
        /// Prints Lists element-by-element using foreach loop
        /// </summary>
        /// <param name="list">Character list input</param>
        static void ListTraversal(List<char> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}