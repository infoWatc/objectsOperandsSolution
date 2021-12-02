// Project in build-mode

using System;

namespace objectsOperandsProject
{
    class Program
    {
        // .NET can only read single characters or entire lines from the console.
        // The following function safely reads a double value.
        private static double ReadValue()
        {
            double resultVal;
            while (!double.TryParse(Console.ReadLine(), out resultVal)) ;
            return resultVal;
        }

        static void Main(string[] args)
        {
            var answerIs = "The answer is ";
            var processType = (
                byteType: "Byte Conversion: ", integerType: "Integer Conversion: ",
                longType: "Long Conversion: ", decimalType: "Decmial Conversion: ",
                floatType: "Float Conversion: "
                );
            var mathWorkType = (
                additionWork: "Addition: " + answerIs,
                subtractionWork: "Subtracting: " + answerIs,
                multiplicationWork: "Multiplication: " + answerIs,
                divisionWork: "Division: " + answerIs,
                modulusWork: "Modulus: " + answerIs
                );
            var warningMsg = (
                belowZero: "numbers combined must not be below zero.",
                mustBeGreaterThan: "the left operand must be greater than right operand."
                );
            var inputFromLine = (
                leftInput: "Enter the Left-Operand:    ",
                rightInput: "Enter the Right-Operand:   "
                );
            var astrickLine = "************************************************************************";
            var errMsgFloat = "Value was either too large or too small for a Float.";

  
            decimal leftInput = 0;
            decimal rightInput = 0;

            try
            {
                Console.Write(inputFromLine.leftInput);
                leftInput = (decimal)ReadValue();

                Console.Write(inputFromLine.rightInput);
                rightInput = (decimal)ReadValue();
            }
            catch (Exception ex)
            {
                Console.WriteLine(astrickLine);
                Console.WriteLine(ex.Message.ToString() + "\n" + astrickLine);

            }


            Console.WriteLine(astrickLine);
            // Creating New MathWork object and setting values
            // operMath now has two values that are defined
            // from the MathWork Class field and MathWork Class Method
            MathWork operMath = new MathWork(leftInput, rightInput);

            // DECIMAL PROCESSING ---------------------------------->
            try
            {
                decimal dAnswer = operMath.Addition();


                // Decimal: Calling Addition Method
                Console.WriteLine($"{processType.decimalType}" +
                            $"      {mathWorkType.additionWork}{dAnswer}");


                // Decimal: Calling Subtraction Method
                dAnswer = operMath.Subtraction();
                Console.WriteLine($"{processType.decimalType}" +
                            $"      {mathWorkType.subtractionWork}{dAnswer}");


                // Decimal: Calling Multiply Method
                dAnswer = operMath.Multiply();
                Console.WriteLine($"{processType.decimalType}" +
                            $"      {mathWorkType.multiplicationWork}{dAnswer}");


                // Decimal: Calling Division Method
                dAnswer = operMath.Divide();
                Console.WriteLine($"{processType.decimalType}" +
                            $"      {mathWorkType.divisionWork}{dAnswer}");


                // Decimal: Calling Modulus Method
                dAnswer = operMath.Modulus();
                Console.WriteLine($"{processType.decimalType}" +
                            $"      {mathWorkType.modulusWork}{dAnswer}");
            }
            catch (Exception ex1)
            {
                Console.WriteLine(astrickLine);
                Console.WriteLine(ex1.Message.ToString() + "\n" + astrickLine);

            }

            // Declare decimal variable and initialize 



            // INTEGERS PROCESSING --------------------------------->
            try
            {
                // Integer: Caling Addition Method
                int mAnswer = (operMath.convertThisNumToInt(operMath.Addition()));
                Console.WriteLine($"{astrickLine}\n" +
                            $"{processType.integerType}" +
                            $"      {mathWorkType.additionWork} {mAnswer}");


                // Calling Subtraction Method            
                if (operMath.isMathWorkPossibleInteger() == true)
                {
                    mAnswer = operMath.convertThisNumToInt(operMath.Subtraction());
                    Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.subtractionWork}{mAnswer}");

                }
                else
                    Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.subtractionWork}{warningMsg.mustBeGreaterThan}");


                // Integer: Calling Multiply Method
                mAnswer = operMath.convertThisNumToInt(operMath.Multiply());
                Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.multiplicationWork}{mAnswer}");


                // Integer: Calling Division Method
                if (operMath.isMathWorkPossibleInteger() == true)
                {
                    mAnswer = operMath.convertThisNumToInt(operMath.Divide());
                    Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.divisionWork}{mAnswer}");

                }
                else
                    Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.divisionWork}{warningMsg.belowZero}");


                // Integer: Calling Modulus Division
                if (operMath.isMathWorkPossibleInteger() == true)
                {
                    mAnswer = operMath.convertThisNumToInt(operMath.Modulus());
                    Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.modulusWork}{mAnswer}");
                }
                else
                    Console.WriteLine($"{processType.integerType}" +
                            $"      {mathWorkType.modulusWork}{warningMsg.mustBeGreaterThan}");
            }
            catch (Exception ex2)
            {
                Console.WriteLine(astrickLine);
                Console.WriteLine(ex2.Message.ToString() + "\n" + astrickLine);

            }
            


            // FlOAT PROCESSING ------------------------------------>

            // Float Try Catch
            try
            {
                if (operMath.isMathWorkPossibleFloat() == true)
                {

                    // Float: Calling Addition Method
                    float fAnswer = (operMath.convertThisNumToFloat(operMath.Addition()));
                    Console.WriteLine($"{astrickLine}\n" +
                                $"{processType.floatType}" +
                                $"        {mathWorkType.additionWork} {fAnswer}");


                    // Float: Calling Subtraction Method            
                    fAnswer = operMath.convertThisNumToFloat(operMath.Subtraction());
                    Console.WriteLine($"{processType.floatType}" +
                                $"        {mathWorkType.subtractionWork}{fAnswer}");


                    // Float: Calling Multiply Method
                    fAnswer = operMath.convertThisNumToFloat(operMath.Multiply());
                    Console.WriteLine($"{processType.floatType}" +
                                $"        {mathWorkType.multiplicationWork}{fAnswer}");


                    // Float: Calling Division Method
                    fAnswer = operMath.convertThisNumToFloat(operMath.Divide());
                    Console.WriteLine($"{processType.floatType}" +
                                $"        {mathWorkType.divisionWork}{fAnswer}");


                    // Float: Calling Modulus Division            
                    fAnswer = operMath.convertThisNumToFloat(operMath.Modulus());
                    Console.WriteLine($"{processType.floatType}" +
                                $"        {mathWorkType.modulusWork}{fAnswer}");
                }
                else
                {
                    Console.WriteLine(astrickLine);
                    Console.WriteLine(errMsgFloat + "\n" + astrickLine);
                }

            }
            catch (Exception ex3)
            {
                Console.WriteLine(astrickLine);
                Console.WriteLine(ex3.Message.ToString() + "\n" + astrickLine);
            }



            // BYTE PROCESSING --------------------------------->
            
            // Byte Try Catch
            try
            {
                // Byte:  Caling Addition Method
                byte bAnswer = (operMath.convertThisNumToByte(operMath.Addition()));
                Console.WriteLine($"{astrickLine}\n" +
                            $"{processType.byteType}" +
                            $"         {mathWorkType.additionWork} {bAnswer}");


                // Byte:  Calling Subtraction Method            
                if (operMath.isMathWorkPossibleInteger() == true)
                {
                    bAnswer = operMath.convertThisNumToByte(operMath.Subtraction());
                    Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.subtractionWork}{bAnswer}");

                }
                else
                    Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.subtractionWork}{warningMsg.mustBeGreaterThan}");


                // Byte:  Calling Multiply Method
                bAnswer = operMath.convertThisNumToByte(operMath.Multiply());
                Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.multiplicationWork}{bAnswer}");


                // Byte:  Calling Division Method
                if (operMath.isMathWorkPossibleInteger() == true)
                {
                    bAnswer = operMath.convertThisNumToByte(operMath.Divide());
                    Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.divisionWork}{bAnswer}");

                }
                else
                    Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.divisionWork}{warningMsg.belowZero}");


                // Byte:  Calling Modulus Division
                if (operMath.isMathWorkPossibleFloat() == true)
                {
                    bAnswer = operMath.convertThisNumToByte(operMath.Modulus());
                    Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.modulusWork}{bAnswer}");
                }
                else
                    Console.WriteLine($"{processType.byteType}" +
                            $"         {mathWorkType.modulusWork}{warningMsg.mustBeGreaterThan}");
            }
            catch (Exception ex4)
            {
                Console.WriteLine(astrickLine);
                Console.WriteLine(ex4.Message.ToString() + "\n" + astrickLine);

            }
            
            // LONG PROCESSING ---------------------------------->
            
            try
            {
                long lAnswer = (operMath.convertThisNumToLong(operMath.Addition()));
                Console.WriteLine($"{astrickLine}\n" +
                            $"{processType.longType}" +
                            $"         {mathWorkType.additionWork} {lAnswer}");


                // Calling Subtraction Method          
          
                lAnswer = operMath.convertThisNumToLong(operMath.Subtraction());
                Console.WriteLine($"{processType.longType}" +
                            $"         {mathWorkType.subtractionWork}{lAnswer}");

               

                // Integer: Calling Multiply Method
                lAnswer = operMath.convertThisNumToLong(operMath.Multiply());
                Console.WriteLine($"{processType.longType}" +
                            $"         {mathWorkType.multiplicationWork}{lAnswer}");


                // Integer: Calling Division Method
                
                lAnswer = operMath.convertThisNumToLong(operMath.Divide());
                Console.WriteLine($"{processType.longType}" +
                            $"         {mathWorkType.divisionWork}{lAnswer}");




                // Integer: Calling Modulus Division
                
                lAnswer = operMath.convertThisNumToLong(operMath.Modulus());
                Console.WriteLine($"{processType.longType}" +
                            $"         {mathWorkType.modulusWork}{lAnswer}");

            }
            catch (Exception ex5)
            {
                Console.WriteLine(astrickLine);
                Console.WriteLine(ex5.Message.ToString() + "\n" + astrickLine);

            }









































        }



    }
}


