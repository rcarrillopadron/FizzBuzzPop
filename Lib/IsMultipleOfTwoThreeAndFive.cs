namespace Lib
{
    class IsMultipleOfTwoThreeAndFive : Command
    {
        public override bool Match(int number)
        {
            bool isDivisibleBy2 = number % 2 == 0;
            bool isDivisibleBy3 = number % 3 == 0;
            bool isDivisibleBy5 = number % 5 == 0;
            return isDivisibleBy2 && isDivisibleBy5 && isDivisibleBy3;
        }

        public override string Message => "FizzBuzzPop";
    }
}