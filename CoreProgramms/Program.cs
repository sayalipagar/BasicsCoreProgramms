namespace CoreProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect program\n 1.FlipCoin\n 2.SwapTwoNo\n 3.EvenOdd");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.ReadInput();
                        break;
                    case 2:
                        SwapNo swap= new SwapNo();
                        swap.NumberSwaping();
                        break;
                    case 3:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.Findno();
                        break;


                        


                      


                }
            }
        }
    }
}