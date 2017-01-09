namespace Conditions
{
    using Interfaces;

    public class BinaryOddCheck : IOddCheckable
    {
        public bool IsOdd(int number)
        {
            return (number & 1) == 1;
        }
    }
}