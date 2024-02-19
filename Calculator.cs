using Newtonsoft.Json.Linq;
using System;
using System.Numerics;

namespace CalculatorApp
{
    public class Functions
    {
        public static T Addition<T>(T input1, T input2)
        {
            bool isValid = ValidateInput(input1, input2);
            if (isValid)
            {
                dynamic value1 = input1;
                dynamic value2 = input2;
                return  value1 + value2;
            }
            else
            {
                throw new ArgumentException("Invalid input - Both inputs must be numeric types");

            }
            
        }

        public static string AcheckString(string value1, string value2)
        {
            throw new ArgumentException("Invalid input - Both inputs must be numeric types");
        }

        public static T Subtract<T>(T input1, T input2)
        {
            bool isValid = ValidateInput(input1, input2);
            if (isValid)
            {
                dynamic value1 = input1;
                dynamic value2= input2;
                return value1 - value2;
            }
            else
            {
                throw new ArgumentException("Invalid input - Both inputs must be numeric types");

            }


        }

        public static T Multiply<T>(T input1, T input2)
        {
            bool isValid = ValidateInput(input1, input2);
            if (isValid)
            {
                dynamic value1 = input1;
                dynamic value2 = input2;
                return value1 * value2;
            }
            else
            {
                throw new ArgumentException("Invalid input - Both inputs must be numeric types");

            }
        }

        public static T Divide<T>(T input1, T input2)
        {
            bool isValid = ValidateInput(input1, input2);
            if (isValid)
            {
                dynamic value1 = input1;
                dynamic value2  = input2;
                
                return value1 / value2; 
            }
           else
            {
                throw new ArgumentException("Invalid input - Both inputs must be numeric types");
            }
        }

        private static bool ValidateInput<T>(T input1, T input2)
        {
            return IsNumeric(input1) && IsNumeric(input2);
        }

        private static bool IsNumeric<T>(T value)
        {
            return value is sbyte || value is byte ||
                   value is short || value is ushort ||
                   value is int || value is uint ||
                   value is long || value is ulong ||
                   value is float || value is double || value is decimal ||
                   value is BigInteger;
        }
    }
}
