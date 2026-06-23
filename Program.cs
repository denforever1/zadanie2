namespace zadanie2 
{
    public class ArrayHelper
    {
        public int[] TakeFirstN(int[] numbers, int n)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            if (n < 0 || n > numbers.Length)
                throw new ArgumentOutOfRangeException(nameof(n));

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = numbers[i];
            }

            return result;
        }
    }
}