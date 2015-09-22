namespace Lib
{
    public class IsMultipleOfTwoAndThree : Command
    {

        public override bool Match(int number)
        {
            bool isDivisibleBy2 = number%2 == 0;
            bool isDivisibleBy3 = number%3 == 0;
            return isDivisibleBy3 && isDivisibleBy2;
        }

        public override string Message => "FizzPop";
    }
}