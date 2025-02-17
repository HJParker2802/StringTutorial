using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to encrypt:");
            string strUserInput = Console.ReadLine();

            try
            {
                //EncryptString(UserInput);
                Console.WriteLine(EncryptString(strUserInput));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);   
            }
            finally
            {
                ExitOrContinue();
            }

        }

        static void ExitOrContinue()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string EncryptString(string strinputString)
        {
            // Guard clause to check if input is a valid string
            if (strinputString == null) { Console.WriteLine("String must be correct"); Console.WriteLine("Returning users given input! "); return strinputString; }//Is this not already done though in the try catch finally???
            else {

                // Reverse the string
                char[] charInputArray = strinputString.ToCharArray();
                Array.Reverse(charInputArray);
                char[] charReversedChars = charInputArray;

                // Convert every second charatcer to uppercase
                for (int x = 0; x < charReversedChars.Length; x = x + 2)
                {
                    string ChangeChar = charReversedChars[x].ToString();
                    ChangeChar = ChangeChar.ToUpper();
                    charReversedChars[x] = char.Parse(ChangeChar);
                }
                char[] charReversedEncryptionChars = charReversedChars;

                // Interpolateion and concatenation
                //C.	Add “Secret-” at the start and “-Code” at the end.
                string strStart = "Secret-";
                string strEnd = "-Code";
                char[] charConcatEncryptionChars = charReversedEncryptionChars;

                string strConcatEncryptionString = strStart + String.Concat(charConcatEncryptionChars) + strEnd;


                charConcatEncryptionChars = strConcatEncryptionString.ToCharArray();
                // String conversion using ASCII values to shift each character by 1
                char[] ASCII_ConcatEncryptionChars = charConcatEncryptionChars;
                string strConversionEncryptionChars = String.Concat(charConcatEncryptionChars);//Concat creates representation of array

                
                for (int i = 0; i< ASCII_ConcatEncryptionChars.Length; i++)
                {
                    if (ASCII_ConcatEncryptionChars[i] == char.Parse("a"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("b");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("A"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("B");
                    }

                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("b"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("c");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("B"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("C");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("c"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("d");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("C"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("D");
                    
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("d"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("e");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("D"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("E");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("e"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("f");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("E"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("F");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("f"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("g");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("F"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("G");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("g"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("h");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("G"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("H");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("h"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("i");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("H"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("I");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("i"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("j");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("I"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("J");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("j"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("k");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("J"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("K");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("k"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("l");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("K"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("L");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("l"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("m");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("L"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("M");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("m"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("n");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("M"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("N");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("n"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("o");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("N"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("O");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("o"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("p");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("O"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("P");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("p"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("q");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("P"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("Q");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("q"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("r");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("Q"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("R");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("r"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("s");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("R"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("S");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("s"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("t");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("S"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("T");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("t"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("u");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("T"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("U");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("u"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("v");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("U"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("V");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("v"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("w");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("V"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("W");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("w"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("x");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("W"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("X");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("x"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("y");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("X"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("Y");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("y"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("z");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("Y"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("Z");
                    }
                    
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("z"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("a");
                    }
                    else if (ASCII_ConcatEncryptionChars[i] == char.Parse("Z"))
                    {
                        ASCII_ConcatEncryptionChars[i] = char.Parse("A");
                    }
                }

                
                string FinalEncryptionChars = String.Concat(ASCII_ConcatEncryptionChars);
                string finalEncryption = FinalEncryptionChars;
                return finalEncryption;
            }
        }
    }
}
