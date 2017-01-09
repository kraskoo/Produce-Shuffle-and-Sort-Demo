namespace Conditions
{
    using Interfaces;

    public class NormalOddCheck : IOddCheckable
    {
        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}