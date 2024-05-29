namespace Coursach
{
    public static class Validations
    {
        public static bool CountOfDecDigitsValid(string number)
        {
            int decimalNumIndex = number.IndexOf(',') + 1;
            if (decimalNumIndex != 0)
            {
                int countOfDecimalDigits = 0;
                while (decimalNumIndex < number.Length && char.IsDigit(number[decimalNumIndex]))
                {
                    countOfDecimalDigits++;
                    decimalNumIndex++;
                }
                //4 знаки після коми допустимі
                if (countOfDecimalDigits > 4)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool numberInRange(double number)
        {
            //обмеження від -1е6 до 1е6
            if (number > 1e6 || number < -1e6)
            {
                return false;
            }
            return true;
        }
    }
}