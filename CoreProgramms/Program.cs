namespace CoreProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n\nselect program   \n 1.FlipCoin\n 2.SwapTwoNo\n 3.EvenOdd\n 4.Vowel OR Constant\n 5.Check Leap Year\n 6.PowerOfTwo\n 7.LargestNo\n 8.QuotientReminder");
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
                    case 5:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Year();
                        break;
                    case 6:
                        PowerTwo powerTwo = new PowerTwo();
                        powerTwo.PowerOfTwoSolution();
                        break;
                    case 7:
                        LargestNo largestNo = new LargestNo();
                        largestNo.FindLargestNumber();
                        break;
                    case 8:
                       QuotientR quotientr = new QuotientR();
                        quotientr.QuotientReminder();
                        break;
                    case 9:
                        default:
                        Console.WriteLine("Enter Correct no");
                        break;







                }
            }
        }
    }
}