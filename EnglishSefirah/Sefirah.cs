using Humanizer;

namespace EnglishSefirah
{
    public class Sefirah
    {
        /// <summary>
        /// Returns the number of full weeks within a certain number of days.
        /// </summary>
        /// <param name="day">A number of days.</param>
        /// <returns>The number of weeks that have elapsed.</returns>
        public static int GetWeeks(int day)
        {
            return day / 7;
        }

        /// <summary>
        /// Returns the number of days into the week of the given day.
        /// </summary>
        /// <param name="day">A number of days.</param>
        /// <returns>The number of days into the week of the day.</returns>
        public static int GetDay(int day)
        {
            return day % 7;
        }

        /// <summary>
        /// Takes a number of days and outputs a string representation.
        /// </summary>
        /// <param name="day">A number of days.</param>
        /// <returns>The string version of the given number.</returns>
        private static string StringifyDay(int day)
        {
            return $"{day.ToWords()} day{(day == 1 ? "" : 's')}";
        }

        /// <summary>
        /// Takes a number of weeks and outputs a string representation.
        /// </summary>
        /// <param name="week">A number of weeks.</param>
        /// <returns>The string version of the given number.</returns>
        private static string StringifyWeek(int week)
        {
            return $"{week.ToWords()} week{(week == 1 ? "" : 's')}";
        }

        /// <summary>
        /// Calculates and stringifies a representation of the number of weeks contained in a given number of days.
        /// </summary>
        /// <param name="day">A number of days.</param>
        /// <returns>The string version of number of weeks contained in the given number.</returns>
        private static string GetWeeksString(int day)
        {
            return StringifyWeek(GetWeeks(day));
        }

        /// <summary>
        /// Compiles the sefirah count of a given day.
        /// </summary>
        /// <param name="day">The day number.</param> 
        /// <returns>The English sefirah count of the day.</returns>
        public static string GetEnglishSefira(int day)
        {
            if (day is < 1 or > 49)
            {
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 49 (inclusive).");
            }

            const string sentenceEnd = " of the Omer.";
            var sentenceStart = "Today is " + StringifyDay(day);

            if (day > 6)
            {
                var sentenceMiddle = ", which are " + GetWeeksString(day);

                int dayOfWeek;
                if ((dayOfWeek = GetDay(day)) != 0)
                {
                    sentenceMiddle += " and " + StringifyDay(dayOfWeek);
                }

                sentenceStart += sentenceMiddle + ",";
            }

            return sentenceStart + sentenceEnd;
        }

        /// <summary>
        /// Compiles every sefirah count.
        /// </summary>
        /// <returns>The English sefirah count of each of the 49 days.</returns>
        public static string[] GetFullEnglishSefira()
        {
            var lines = new string[49];
            for (var i = 1; i < 50; i++)
            {
                lines[i - 1] = GetEnglishSefira(i);
            }

            return lines;
        }
    }
}