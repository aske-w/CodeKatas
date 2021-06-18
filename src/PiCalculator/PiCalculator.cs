using System;

namespace PiCalculator
{
    public class PiCalculator
    {
        public string GetPi(int i)
        {
            var pi = Math.PI;
            return Math.Round(pi, i).ToString().Replace(',','.');
        }

        public int GetPiDigit(int i)
        {
            return int.Parse(GetPi(i)[i + 1] + "");
        }
    }
}
