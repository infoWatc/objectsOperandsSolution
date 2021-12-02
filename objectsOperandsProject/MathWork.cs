using System;

namespace objectsOperandsProject
{
    public class MathWork
    {
        // Define fields of the class constructors
        public decimal LeftOperand { get; set; }
        public decimal RightOperand { get; set; }

        // Defining MathWork Method
        public MathWork(dynamic leftOperand, dynamic rightOperand)
        {
            // Setting the field values
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
        }

        // Defining Addition Method
        public dynamic Addition()
        {
            // Returning Addition value
            return LeftOperand + RightOperand;
        }

        // Defining Subtraction Method
        public dynamic Subtraction()
        {
            // Returning Subtraction value
            return LeftOperand - RightOperand;
        }

        // Defining Multiplication Method
        public dynamic Multiply()
        {
            // Retgurn Multiplication value
            return LeftOperand * RightOperand;
        }

        // Defining Division Method
        public dynamic Divide()
        {
            // Return Division value
            return LeftOperand / RightOperand;
        }
        
        // Defining Modulus Method
        public dynamic Modulus()
        {
            // Return Modulus value
            return LeftOperand % RightOperand;
        }

        public int convertThisNumToInt(dynamic num)
        {
            int IntegerValue = Convert.ToInt32(num);

            return IntegerValue;             
        }
        
        public float convertThisNumToFloat(dynamic num)
        {
            float floatValue = Convert.ToSingle(num);

            return floatValue;
        }

        public byte convertThisNumToByte(dynamic num)
        {
            byte byteValue = Convert.ToByte(num);
            return byteValue;
        }
        public bool isMathWorkPossibleInteger()         
        {
            int minIntValue = int.MaxValue;
            int maxIntValue = int.MaxValue;
            bool canConvert = (int)LeftOperand >= minIntValue || (int)RightOperand <= maxIntValue;
            return (int)LeftOperand >= (int)RightOperand && (int)LeftOperand - (int)RightOperand 
                > 0 && canConvert == true;
        }

        public long convertThisNumToLong(dynamic num)
        {
            long longValue = Convert.ToInt64(num);

            return longValue;
        }
        public bool isMathWorkPossibleByte()
        {
            byte minByteValue = byte.MinValue;
            byte maxByteValue = byte.MaxValue;

            return (byte)LeftOperand >= minByteValue && (byte)RightOperand >= minByteValue &&
                (byte)LeftOperand <= maxByteValue && (byte)RightOperand <= maxByteValue;
        }

        public bool isMathWorkPossibleFloat()
        {
            float minFloatValue = float.MinValue;
            float maxFloatValue = float.MaxValue;
            
            return (float)LeftOperand >= minFloatValue && (float)RightOperand >= minFloatValue && 
                (float)LeftOperand <= maxFloatValue && (float)RightOperand <= maxFloatValue; 
        }

        public bool isMathWorkPossibleLong()
        {
            long minLongValue = long.MinValue;
            long maxLongValue = long.MaxValue;

            return (long)LeftOperand >= minLongValue && (long)RightOperand >= minLongValue &&
                (long)LeftOperand <= maxLongValue && (long)RightOperand <= maxLongValue;
        }


    }
}
