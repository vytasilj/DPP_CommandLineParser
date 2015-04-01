using System;

namespace CommandLineParser.Options
{
    public class RangeOption<T> : AbstractOption<T> where T : IComparable<T>
    {

        private T _minValue;
        private T _maxValue;
        private bool _hasMin;
        private bool _hasMax;


        public RangeOption(string id) : base(id)
        {
            _hasMin = false;
            _hasMax = false;
        }


        public RangeOption<T> SetMinValue(T minValue)
        {
            _minValue = minValue;
            _hasMin = true;
            return this;
        }
        
        public RangeOption<T> SetMaxValue(T maxValue)
        {
            _maxValue = maxValue;
            _hasMax = true;
            return this;
        }

        protected override bool CheckValue(T value)
        {
            bool valid = true;
            if (_hasMin)
                valid &= value.CompareTo(_minValue) >= 0;

            if (_hasMax)
                valid &= value.CompareTo(_maxValue) <= 0;

            return valid;
        }
    }
}