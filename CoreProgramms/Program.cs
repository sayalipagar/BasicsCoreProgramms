namespace CoreProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect program\n 1.FlipCoin\n 2.SwapTwoNo");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.ReadInput();
                         break;
                    case 2:
                        SwapTwoNumbers swap= new SwapTwoNumbers();
                        swap.NumberSwaping();
                       break;


                        


                      


                }
            }
        }
    }
}