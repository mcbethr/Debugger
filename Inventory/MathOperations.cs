using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    using System.Collections;
    using System.Collections.Generic;


    public class MathOperations
    {

        public int AddTwoNumbers(int NumOne, int NumTwo)
        {

            return NumOne + NumTwo;

        }

        public bool IsPerfectNumber(int number)
        {
            int sum = 0;
            int n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

 }

  
    

