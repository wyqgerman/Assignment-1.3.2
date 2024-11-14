namespace Assignment_1._3._2 {
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Array Declaration and Initialization Examples\n");

            int[] array1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("1. Declaring and initializing with known values:");

            int[] array2 = new int[5];
            array2[0] = 10;
            array2[1] = 20;
            array2[2] = 30;
            array2[3] = 40;
            array2[4] = 50;
            Console.WriteLine("\n2. Declaring with a specified size and assigning values:");
        }
    }
}

