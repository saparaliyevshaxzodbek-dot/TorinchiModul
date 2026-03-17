namespace _4_2_Dars
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //1-misol
            //Thread thread = new Thread(Display);
            //thread.Start();
            //2-misol
            Thread threadA = new Thread(CouterA);
            threadA.Start();
            Thread threadB = new Thread(CouterB);
            threadB.Start();
        }

        //1-misol
        //public static void Display()
        //{
        //    for(int i = 1;  i <= 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //2-misol

        public static void CouterA()
        {
            for(int i = 1;  i <= 20; i++)
            {
                Console.WriteLine("A");
            }
        }

        public static void CouterB()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("B");
            }
        }
    }
}
