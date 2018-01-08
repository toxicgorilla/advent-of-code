using System;
using System.Linq;

namespace Day2.ConsoleApp
{
    public static class ChecksumGenerator
    {
        public static int Generate(string input)
        {
            var total = 0;
            var rows = input.Split(new [] { Environment.NewLine }, StringSplitOptions.None).ToList();
            rows.ForEach(row =>
            {
                var columns = row.Split('\t').ToList();
                var lowestNumber = int.MaxValue;
                var highestNumber = int.MinValue;
                columns.ForEach(column =>
                {
                    var currentValue = int.Parse(column);
                    if (currentValue < lowestNumber)
                    {
                        lowestNumber = currentValue;
                    }

                    if (currentValue > highestNumber)
                    {
                        highestNumber = currentValue;
                    }

                });

                var difference = highestNumber - lowestNumber;
                total += difference;
            });

            return total;
        }
    }
}
