namespace CoreProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n select program\n 1.FlipCoin\n 2.SwapTwoNo\n 3.EvenOdd\n 4.Vowel OR Constant");
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
                    case 4:
                        VowelConsonant vowelConsonant=new VowelConsonant();
                        vowelConsonant.VowelOrConsonant();
                        
  break;






                }
            }
        }
    }
}