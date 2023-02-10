using System;
using System.Collections.Generic;
using System.Text;

namespace lab_task1
{
    class Medicine
    {
        public string Category;
        private string _name;
        private double _price;
        private double _discountPrice;

        public double DiscountPrice
        {
            get
            {
                return _discountPrice;
            }
            set
            {
                if (value >= 0)
                {
                    value = (Price * value) / 100;
                    _discountPrice = value;
                }
            }


        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 1)
                {
                    _price = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3 && char.IsUpper(value[0]))
                {
                    _name = value;

                }
            }
        }
    }
}
