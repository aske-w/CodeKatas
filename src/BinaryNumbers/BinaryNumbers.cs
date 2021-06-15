using System;
using System.Linq;
using System.Text;

namespace BinaryNumbers
{
    public class BinaryNumbers
    {
        public string IntegerToBinary(int i)
        {
            var sb = new StringBuilder();

            var num = i;

            do
            {
                var bin = num % 2;
                sb.Append(bin.ToString());
                num = (int) Math.Floor(num / 2.0);
            } while (num > 0);

            while (sb.Length < 32)
            {
                sb.Append('0');
            }

            return new string(sb.ToString().Reverse().ToArray());
        }

        public int BinaryToInteger(string s)
        {
            throw new NotImplementedException();
        }
    }
}
