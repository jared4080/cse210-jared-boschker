using System;


namespace Learning03
{    
    public class Fraction {
        int _top = 0;
        int _bottom = 0;


        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int topNumber)
        {
            _top = topNumber;
        }

        public Fraction(int topNumber, int bottomNumber)
        {
            _top = topNumber;
            _bottom = bottomNumber;
        }

        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        public double CalculateFraction()
        {
            double fractionNumber = Math.Round(_top / (double)_bottom, 1);
            return fractionNumber;
        }

        public string GetFractionString()
        {
            double fractionNumber = CalculateFraction();
            string fractionText = fractionNumber.ToString();
            
            return fractionText;
        }

        public double GetFractionDecimal()
        {
            double fractionNumber = CalculateFraction();
            
            return fractionNumber;
        }
    }
}