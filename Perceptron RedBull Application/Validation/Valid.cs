using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron_RedBull_Application.Validation
{
    class Valid
    {
        public static bool IsValidPositiveNumber(String text)
        {
            int number;
            return Int32.TryParse(text, out number) && number >= 0;
        }
    }
}
