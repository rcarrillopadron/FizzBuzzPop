namespace Lib
{
    public class IsNotMultiple : Command
    {
        private int _number;

        public override bool Match(int number)
        {
            _number = number;
            var command = new IsMultipleOfTwoThreeAndFive();
            return !command.Match(number);
        }

        public override string Message => _number.ToString();
    }
}