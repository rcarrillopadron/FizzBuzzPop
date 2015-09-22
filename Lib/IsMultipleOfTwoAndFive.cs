namespace Lib
{
    public class IsMultipleOfTwoAndFive : Command
    {
        public override bool Match(int number)
        {
            bool isDivisibleBy2 = number % 2 == 0;
            bool isDivisibleBy5 = number % 5 == 0;
            return isDivisibleBy2 && isDivisibleBy5;
        }

        public override string Message => "BuzzPop";
    }
}