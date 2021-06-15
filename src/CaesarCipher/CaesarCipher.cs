using System;
using System.Text;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        private char GetUpperCharFromAlphaIndex(int i)
        {
            return (char) (i + 65);
        }
        private char GetLowerCharFromAlphaIndex(int i)
        {
            return (char) (i + 97);
        }

        private int GetAlphaIndexFromChar(char c)
        {
            return (int) c;
        }
        public string Encode(string s, int shift)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                var ascii = GetAlphaIndexFromChar(c);
                if(char.IsUpper(c))
                {
                    var shiftedIndex = ((ascii - 65) + shift) % 26;
                    sb.Append(GetUpperCharFromAlphaIndex(shiftedIndex));
                }
                else if(char.IsLower(c))
                {
                    var shiftedIndex = ((ascii - 97) + shift) % 26;
                    sb.Append(GetLowerCharFromAlphaIndex(shiftedIndex));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public string Decode(string s, int shift)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                var ascii = GetAlphaIndexFromChar(c);
                if(char.IsUpper(c))
                {
                    var shiftedIndex = (ascii - 65) - shift;
                    if(shiftedIndex < 0) shiftedIndex += 26;
                    Console.WriteLine(shiftedIndex);
                    sb.Append(GetUpperCharFromAlphaIndex(shiftedIndex));
                }
                else if(char.IsLower(c))
                {
                    var shiftedIndex = (ascii - 97) - shift;
                    if(shiftedIndex < 0) shiftedIndex += 26;
                    Console.WriteLine(shiftedIndex);
                    sb.Append(GetLowerCharFromAlphaIndex(shiftedIndex));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
