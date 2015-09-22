namespace Lib
{
    public class IsMultipleOfThree : Command
    {
        public override bool Match(int number)
        {
            bool isDivisibleBy3 = number % 3 == 0;
            return isDivisibleBy3;
        }

        public override string Message => "Fizz";
    }
}