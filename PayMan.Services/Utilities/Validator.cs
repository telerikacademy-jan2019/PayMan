using PayMan.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayMan.Services.Utilities
{
    public static class Validator
    {
        public static void IsNull(object obj, string message)
        {
            if (obj == null)
            {
                throw new UserException(message);
            }
        }

        public static void IsNotNull(object obj, string message)
        {
            if (obj != null)
            {
                throw new UserException(message);
            }
        }

        public static void IsPositive(decimal amount)
        {
            if (amount < 0)
            {
                throw new UserException(ServiceConstants.RequiresPositive);
            }
        }

        public static void IsNotTrue(bool condition, string message)
        {
            if (!condition)
            {
                throw new UserException(message);
            }
        }
        
        public static void IsInRange(int number, int first, int second)
        {
            if (number < first || second < number)
            {
                throw new UserException(string.Format(ServiceConstants.IsInRange, first, second));
            }
        }
    }
}
