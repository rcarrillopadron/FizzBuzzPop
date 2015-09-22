namespace Lib
{
    public class IsMultipleOfFive : Command
    {
        public override bool Match(int number)
        {
            bool isDivisibleBy5 = number % 5 == 0;
            return isDivisibleBy5;
        }

        public override string Message => "Buzz";
    }
}