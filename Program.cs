namespace Lab4_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex com1 = new Complex();
            Complex com2 = new Complex(5, 6);
            Complex com3 = new Complex(6);

            Console.WriteLine(com1.PrintComplex());
            Console.WriteLine(com2.PrintComplex());
            Console.WriteLine(com3.PrintComplex());


            //---------------------------------------------------------------
            Console.WriteLine("================================================ ");

            string reverse = "this is a test";

            string[] wordReve = reverse.Split(' ');

            for (int i = wordReve.Length - 1; i >= 0; i--)
            {
                Console.Write(wordReve[i] + " ");
            }

            //---------------------------------------------------------------
            Console.WriteLine("\n================================================ ");

            int[] arr = { 1, 2, 3, 4, 1, 5, 6, 1, 8, 9, 10, 1, 44, 55, 66, 77 };

            int maxDis = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int disc = j - i - 1;

                        if (disc > maxDis)
                        {
                            maxDis = disc;
                        }
                    }
                }
            }

            Console.WriteLine(maxDis);
        }
    }
}
