using System;
using System.Linq;

namespace Day2.ConsoleApp
{
    public static class Part2
    {
        public static int CalculateAnswer(string input)
        {
            var total = 0;
            var rows = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            foreach (var row in rows)
            {
                var columns = row.Split('\t').ToList();
                foreach (var column in columns)
                {
                    var item = int.Parse(column);
                    var others = columns.Except(new[] { column }).Select(int.Parse).ToList();
                    foreach (var other in others)
                    {

                        var isEvenlyDivisible = item % other == 0;
                        if (isEvenlyDivisible)
                        {
                            var dividend = item / other;
                            total += dividend;

                            break;
                        }
                    }
                }
            }

            return total;
        }
    }
}
