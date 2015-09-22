namespace Lib
{
    public class IsMultipleOfThreeAndFive : Command
    {
        public override bool Match(int number)
        {
            bool isDivisibleBy3 = number % 3 == 0;
            bool isDivisibleBy5 = number % 5 == 0;
            return isDivisibleBy3 && isDivisibleBy5;
        }

        public override string Message => "FizzBuzz";
    }
}