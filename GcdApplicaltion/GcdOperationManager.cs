using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcdApplicaltion
{
    class GcdOperationManager
    {

        public int GCDLogic(int fristNumber, int secondNumber)
        {
            int Remainder;

            while (secondNumber != 0)
            {
                Remainder = fristNumber % secondNumber;
                fristNumber = secondNumber;
                secondNumber = Remainder;
            }

            return fristNumber;
        }
    }
}
