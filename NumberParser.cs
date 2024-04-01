using System.Runtime.Serialization;

namespace NumberParser
{
    [DataContract(Namespace = "")]
    public class NumberParser
    {
        #region Constructor

        public NumberParser(string inputString)
        {
            Numbers = ToIntArray(inputString);
            SortNumbersInDescendingOrder();
        }

        #endregion

        #region Public Properties

        [DataMember]
        public int[] Numbers { get; }

        #endregion

        #region Private Members

        private static int[] ToIntArray(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            var numbers = new List<int>();
            foreach (var value in input.Split(','))
            {
                if (int.TryParse(value, out var num))
                {
                    numbers.Add(num);
                }
                else
                {
                    throw new ArgumentException(value, nameof(input));
                }
            }
            return numbers.ToArray();
        }

        private void SortNumbersInDescendingOrder()
        {
            Array.Sort(Numbers, new Comparison<int>((a, b) => b.CompareTo(a)));
        }

        #endregion
    }
}
