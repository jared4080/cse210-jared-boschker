using System;


namespace Learning03
{    
    public class Fraction {
        int _top = 0;
        int _bottom = 0;


        public Fraction()
        {
            return;
        }
        public Fraction(int wholeNumber)
        {
            return;
        }
        public Fraction(int topNumber, int bottomNumber)
        {
            return;
        }

        int GetTop()
        {
            return _top;
        }

        void SetTop(int top)
        {
            _top = top;
        }

        int GetBottom()
        {
            return _bottom;
        }

        void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        double CalculateFraction()
        {
            double fractionNumber = _bottom / _top;
            return fractionNumber;
        }

        string GetFractionString()
        {
            double fractionNumber = CalculateFraction();
            string fractionText = fractionNumber.ToString();
            
            return fractionText;
        }

        double GetDecimalValue()
        {
            double fractionNumber = CalculateFraction();
            
            return fractionNumber;
        }
    }
}