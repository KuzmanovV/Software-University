using System;

namespace ValidationAttributes
{
    public class MyRangeAttribute: MyValidationAttribute
    {
        private int min;
        private int max;
        public MyRangeAttribute(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public override bool IsValid(object obj)
        {
            if (!(obj is int))
            {
                throw new ArgumentException();
            }

            int valueAsInt = (int) obj;
            if (!(valueAsInt>=min && valueAsInt<=max))
            {
                return false;
            }

            return true;
        }
    }
}