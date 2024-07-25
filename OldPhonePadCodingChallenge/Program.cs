using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePadCodingChallenge
{
	public class OldPhonePad
	{
        public static void Main(string[] args)
        {
            //Test case 1
            Console.WriteLine("Test case 1 \n");
            string input1 = "4433555 555666096667775553#";
            string output1 = OldPhonePadMethod(input1);
            Console.WriteLine($"Input: {input1} => Output: {output1}\n");

            //Test case 2
            Console.WriteLine("Test case 2 \n");
            string input2 = "4433555 555344488833777 7777#";
            string output2 = OldPhonePadMethod(input2);
            Console.WriteLine($"Input: {input2} => Output: {output2}\n");

            //Test case 3
            Console.WriteLine("Test case 3 \n");
            string input3 = "8 88777444666 * 664#";
            string output3 = OldPhonePadMethod(input3);
            Console.WriteLine($"Input: {input3} => Output: {output3} \n");

            //Test case 4
            Console.WriteLine("Test case 4 \n");
            string input4 = "55544466887777 083322244 084447 7777#";
            string output4 = OldPhonePadMethod(input4);
            Console.WriteLine($"Input: {input4} => Output: {output4} \n");

            //Test case 5
            Console.WriteLine("The Author of this code is: \n");
            string input5 = "5337773369990 333 33777662663 339999";
            string output5 = OldPhonePadMethod(input5);
            Console.WriteLine($"Input: {input5} => Output: {output5} \n");
        }
        public static string OldPhonePadMethod(string input)
        {
            Dictionary<char, string> keypad = new Dictionary<char, string>
            {
                {'1', ""},
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"},
                {'0', " "},
                {'*', "BACKSPACE"},
                {'#', "SEND"}
            };

            StringBuilder result = new StringBuilder();
            int count = 0;
            char lastChar = '\0';

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '#')
                {
                    break;
                }

                if (c == '*')
                {
                    if (result.Length > 0)
                    {
                        result.Length--;
                    }
                    lastChar = '\0'; // Reset lastChar to avoid misinterpretation
                    continue;
                }

                if (c == ' ')
                {
                    if (count > 0 && keypad.ContainsKey(lastChar))
                    {
                        string letters = keypad[lastChar];
                        if (letters != "")
                        {
                            result.Append(letters[(count - 1) % letters.Length]);
                        }
                    }
                    count = 0;
                    lastChar = '\0';
                    continue;
                }

                if (c == lastChar)
                {
                    count++;
                }
                else
                {
                    if (count > 0 && keypad.ContainsKey(lastChar))
                    {
                        string letters = keypad[lastChar];
                        if (letters != "")
                        {
                            result.Append(letters[(count - 1) % letters.Length]);
                        }
                    }

                    count = 1;
                    lastChar = c;
                }
            }

            if (count > 0 && keypad.ContainsKey(lastChar))
            {
                string letters = keypad[lastChar];
                if (letters != "")
                {
                    result.Append(letters[(count - 1) % letters.Length]);
                }
            }

            return result.ToString();
        }
    }
}
