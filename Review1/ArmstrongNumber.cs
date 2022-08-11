using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    class ArmstrongNumber
    {
        public void ArmstrongNum()
        {
            Console.WriteLine("Enter the Number :");
            int Number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int r = 0;
            int temp = Number;
            while (Number > 0)
            {
                r = Number % 10;
                sum = sum + (r * r * r);
                Number = Number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Armstrong Number");
            }
            else
            {
                Console.WriteLine("Number is not an Armstrong number");
            }
        }
    }
}
