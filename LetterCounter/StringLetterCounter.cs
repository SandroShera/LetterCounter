namespace LetterCounter
{
    public static class StringLetterCounter
    {
        public static int UnequalConsecutiveLettersCounter(string input)
        {
            int count = 0;
            int innerCount = 0;

            if (input is null)
            {
                throw new ArgumentNullException("input");
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("input");
            }

            if (input.Length == 1 && char.IsLetter(input[0]))
            {
                return 1;
            }

            for (int i = 0; i < input.Length - 1; i ++)
            {
                if (!char.IsLetter(input[i]))
                {
                    innerCount = 0;

                    continue;
                }

                if (!char.IsLetter(input[i + 1]))
                {
                    if(innerCount > count)
                    {
                        count = innerCount;
                    }

                    innerCount = 0;

                    continue;
                }

                if (input[i] != input[i + 1])
                {
                    if (innerCount == 0)
                    {
                        innerCount += 2;
                    }
                    else
                    {
                        innerCount++;
                    }

                    if (innerCount > count)
                    {
                        count = innerCount;
                    }
                }
                else
                {

                    innerCount = 0;
                }
            }

            return count;
        }

        public static int EqualConsecutiveLettersCounter(string input)
        {
            int count = 0;
            int innerCount = 0;

            if (input is null)
            {
                throw new ArgumentNullException("input");
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("input");
            }

            if (input.Length == 1 && char.IsLetter(input[0]))
            {
                return 1;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    innerCount = 0;

                    continue;
                }

                if (!char.IsLetter(input[i + 1]))
                {
                    if (innerCount > count)
                    {
                        count = innerCount;
                    }

                    innerCount = 0;

                    continue;
                }

                if (input[i] == input[i + 1])
                {
                    if (innerCount == 0)
                    {
                        innerCount += 2;
                    }
                    else
                    {
                        innerCount++;
                    }

                    if (innerCount > count)
                    {
                        count = innerCount;
                    }
                }
                else
                {

                    innerCount = 0;
                }
            }

            return count;
        }

        public static int EqualConsecutiveDigitsCounter(string input)
        {
            int count = 0;
            int innerCount = 0;

            if (input is null)
            {
                throw new ArgumentNullException("input");
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("input");
            }

            if (input.Length == 1 && char.IsDigit(input[0]))
            {
                return 1;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    innerCount = 0;

                    continue;
                }

                if (!char.IsDigit(input[i + 1]))
                {
                    if (innerCount > count)
                    {
                        count = innerCount;
                    }

                    innerCount = 0;

                    continue;
                }

                if (input[i] == input[i + 1])
                {
                    if (innerCount == 0)
                    {
                        innerCount += 2;
                    }
                    else
                    {
                        innerCount++;
                    }

                    if (innerCount > count)
                    {
                        count = innerCount;
                    }
                }
                else
                {

                    innerCount = 0;
                }
            }

            return count;
        }

    }
}