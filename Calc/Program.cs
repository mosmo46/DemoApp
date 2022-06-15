using Calc;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace CalculatorApp
{
    internal class Program : Calculator
    {


        static void Main(string[] args)
        {


     
            


            Console.WriteLine("This program performs basic math operation on 2 numbers");
            Console.WriteLine("Please insert the first number");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the second number");
            Console.WriteLine("Please insert the second number");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select your operation");
            Console.WriteLine("+: for addition");
            Console.WriteLine("-: for subtraction");
            Console.WriteLine("*: for multiplication");
            Console.WriteLine("/: for division");

            var operand = Console.ReadLine();

            if (operand == "+")
            {
                var result = Add(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "-")
            {
                var result = Subtract(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "*")
            {
                var result = Multiply(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "/")
            {
                var result = Divide(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("You have made an invalid selection");
            }
        }

        public class Serializer
        {
            public ReadingXmlFile.testrun Deserialize<T>(string input) where T : class
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                using (StringReader sr = new StringReader(input))
                {
                    return (ReadingXmlFile.testrun)ser.Deserialize(sr);
                }
            }

            public string Serialize<T>(T ObjectToSerialize)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

                using (StringWriter textWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                    return textWriter.ToString();
                }
            }
        }
    }
}