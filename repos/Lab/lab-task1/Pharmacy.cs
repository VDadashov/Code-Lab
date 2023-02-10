using System;
using System.Collections.Generic;
using System.Text;

namespace lab_task1
{
    class Pharmacy
    {
        public Medicine[] medicines = new Medicine[0];

        public void AddMedicine(Medicine md)
        {
            Array.Resize(ref medicines, medicines.Length + 1);
            medicines[medicines.Length - 1] = md;

        }

        public Medicine[] ShowRange(int min,int max)
        {
            Medicine[] newMd = new Medicine[0];

            for (int i = 0; i < medicines.Length; i++)
            {
                if (medicines[i].DiscountPrice >= min && medicines[i].DiscountPrice < max)
                {
                    Array.Resize(ref newMd, newMd.Length + 1);
                    newMd[newMd.Length - 1] = medicines[0];
                }
            }
            return newMd;
        }
    }
}
