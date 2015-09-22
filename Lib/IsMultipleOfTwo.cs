namespace Lib
{
    public class IsMultipleOfTwo : Command
    {
        public override bool Match(int number)
        {
            bool isDivisibleBy2 = number % 2 == 0;
            return isDivisibleBy2;
        }

        public override string Message => "Pop";
    }
}