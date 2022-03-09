namespace Ex11
{
    internal class InvertNumber
    {
        public static void Main()
        {
            int[] list = { 90, 98, 99, 05, 11, 15, 17 };
            int[] temp = list;
            Console.Write("Array Original: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Array.Reverse(temp);
            Console.Write("Array Reverso: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}