using System.Collections.Generic;

namespace Lib
{
    public class FizzBuzzPopCalculator
    {
        public string[] GenerateValues()
        {
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 100;

            Command[] commands =
            {
                new IsMultipleOfTwoThreeAndFive(),
                new IsMultipleOfTwoAndFive(),
                new IsMultipleOfTwoAndThree(),
                new IsMultipleOfThreeAndFive(),
                new IsMultipleOfThree(),
                new IsMultipleOfFive(),
                new IsMultipleOfTwo(),
                new IsNotMultiple()
            };

            var results = new List<string>();
            for (int i = MIN_VALUE; i <= MAX_VALUE; i++)
            {
                foreach (Command command in commands)
                {
                    if (command.Match(i))
                    {
                        results.Add(command.Message);
                        break;
                    }
                }
            }

            return results.ToArray();
        }
    }
}