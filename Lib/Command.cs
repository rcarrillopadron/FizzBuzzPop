namespace Lib
{
    public abstract class Command
    {
        public abstract bool Match(int number);
        public abstract string Message { get; }
    }
}