namespace P07.HappinessIndex
{
    using System;
    using System.Text.RegularExpressions;

    public class HappinessIndex
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var happyRegex = new Regex(@":\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;");
            var sadRegex = new Regex(@":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|]:|];");

            var happyCount = happyRegex.Matches(input).Count;
            var sadCount = sadRegex.Matches(input).Count;

            var happinessIndex = (double)happyCount / sadCount;

            var resultEmoticon = string.Empty;

            if (happinessIndex >= 2)
            {
                resultEmoticon = ":D";
            }
            else if (happinessIndex > 1)
            {
                resultEmoticon = ":)";
            }
            else if (happinessIndex == 1)
            {
                resultEmoticon = ":|";
            }
            else
            {
                resultEmoticon = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:f2} {resultEmoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}