using System;

namespace ForEach_and_Switch
{
    /*Foreach Loops and Switch Statement challenge
Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String

Press 2 for integer

Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not.Hereby we even want to check, if it is a complete alphabetic entry(so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement.To check the valid string you can write your custom logic.

For example:

Enter a value: {here you can enter any value}

Select the Data type to validate the input you have entered.

Press 1 for String

Press 2 for Integer

Press 3 for Boolean

Here, if you enter 1 it should return below message

You have entered a value: Denis Panjuta

It is a valid: String

Here, if you enter 2 it should return below message

You have entered a value: Denis Panjuta

It is an invalid: Integer
*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isValid = false;
            string userInputType;

            Console.WriteLine("Please enter a value: ");
            string userInputValue = Console.ReadLine();

            Console.WriteLine("Please enter the data type you would like to validate your value against:");
            Console.WriteLine("Press 1 for String data type");
            Console.WriteLine("Press 2 for Integer data type");
            Console.WriteLine("Press 3 for Boolean data type");
            Console.WriteLine("----------------------------------------------");

            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    // check to see if the input value is a String type
                    isValid = IsString(userInputValue);
                    userInputType = "String Data Type";
                    break;

                case 2:
                    // check to see if the input value is a Int type
                    int outputValue = 0;
                    isValid = int.TryParse(userInputValue, out outputValue);
                    userInputType = "Integer Data Type";
                    break;

                case 3:
                    // check to see if the input value is a Boolean type
                    Boolean flag = false;
                    isValid = Boolean.TryParse(userInputValue, out flag);
                    userInputType = "Boolean Data Type";
                    break;

                default:
                    userInputType = "Unknown Data Type";
                    Console.WriteLine("Unable to determine the correct data type!");
                    break;
            }
            Console.WriteLine("Your entry was : {0}",userInputValue);
            if (isValid)
            {
                Console.WriteLine("{0} is a valid {1}",userInputValue, userInputType);
            }
            else
            {
                Console.WriteLine("{0} is not a valid {1}",userInputValue,userInputType);
            }
            Console.Read();
        }

        static bool IsString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
