using System;
using System.Globalization;
using System.Text;
using static System.Console;
namespace OOP_2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //TypesA(); // Primitive types realization
            //TypesB(); // Explicit and implicit cast
            //TypesC(); // Packing and unpacking valuable types
            //TypesD(); // Implicity typed variables
            //TypesE(); // Nullable variables
            //TypesF(); // Get the error and explain why

            //StringsA(); // Compare strings
            //StringsB(); // String methods demonstrating
            //StringsC(); // Null string
            //StringsD(); // StringBuilder string

            //ArraysA(); // two-dimension array
            //ArraysB(); // one-dimension array with replacement
            //ArraysC(); // stepped array 
            //ArraysD(); //vars

            //TuplesABCD(); // 5-types tuple

            CheckedABCD();

            /*
            {
                var (minValue, maxValue, sumValue, firstSymbol) = localFunc(new int[5] { 0, 46, 478, -36, 2 }, "something");
                WriteLine($"Max value is {maxValue}");
                WriteLine($"Min value is {minValue}");
                WriteLine($"Sum value is {sumValue}");
                WriteLine($"First symbol is {firstSymbol}");
            } //LocalFunction
            */
            ReadKey();

            (int min, int max, int sum, char firstSym) localFunc(int[] arr, string str)
            {
                int min = 100000, max = -100000, sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                    if (arr[i] > max) max = arr[i];
                    sum += arr[i];
                }

                return (min, max, sum, str[0]);
            }
        }

        static void TypesA()
        {
            // Primitive Types

            // Value Types

            {
                bool boolExample = false;
                WriteLine("Enter bool example");
                boolExample = Convert.ToBoolean(ReadLine());
                WriteLine(boolExample + "\n");

            } //bool

            {
                byte byteExample = 255;
                WriteLine("Enter byte example");
                byteExample = Convert.ToByte(ReadLine());
                WriteLine(byteExample + "\n");
            } //byte

            {
                sbyte sbyteExample = -120;
                WriteLine("Enter sbyte example");
                sbyteExample = Convert.ToSByte(ReadLine());
                WriteLine(sbyteExample + "\n");
            } //sbyte

            {
                char charExample = 'a';
                WriteLine("Enter char example");
                charExample = Console.ReadLine()[0];
                WriteLine(charExample + "\n");
            } // char

            {
                decimal decimalExample = 255.476829M;
                WriteLine("Enter decimal example");
                decimalExample = Convert.ToDecimal(ReadLine());
                WriteLine(decimalExample + "\n");
            } // decimal

            {
                double doubleExample = -120.476d;
                WriteLine("Enter double example");
                doubleExample = Convert.ToDouble(ReadLine());
                WriteLine(doubleExample + "\n");
            } // double

            {
                float floatExample = 35.854725f;
                WriteLine("Enter float example");
                floatExample = float.Parse(ReadLine());
                WriteLine(floatExample + "\n");
            } // float

            {
                int intExample = 3262;
                WriteLine("Enter int example");
                intExample = Convert.ToInt32(ReadLine());
                WriteLine(intExample + "\n");
            } // int

            {
                uint uintExample = 3456895345;
                WriteLine("Enter uint example");
                uintExample = Convert.ToUInt32(ReadLine());
                WriteLine(uintExample + "\n");
            } // uint

            {
                long longExample = 32623866739;
                WriteLine("Enter long example");
                longExample = Convert.ToInt64(ReadLine());
                WriteLine(longExample + "\n");
            } // long

            {
                ulong ulongExample = 326238667393566;
                WriteLine("Enter ulong example");
                ulongExample = Convert.ToUInt64(ReadLine());
                WriteLine(ulongExample + "\n");
            } // ulong

            {
                short shortExample = 2364;
                WriteLine("Enter short example");
                shortExample = Convert.ToInt16(ReadLine());
                WriteLine(shortExample + "\n");
            } // short

            {
                ushort ushortExample = 2364;
                WriteLine("Enter ushort example");
                ushortExample = Convert.ToUInt16(ReadLine());
                WriteLine(ushortExample + "\n");
            } // ushort

            // Reference types

            {
                object objectExample = "156";
                objectExample = 573.35f;
                WriteLine("Enter object example");
                objectExample = ReadLine();
                WriteLine(objectExample);
            } // object

            {
                string stringExample = "egskwnf wclwm";
                WriteLine("Enter string example");
                stringExample = ReadLine();
                WriteLine(stringExample);
            } // string

            {
                dynamic dynamicExample = "egskwnf wclwm";
                dynamicExample = 36;
                WriteLine("Enter dynamic example");
                dynamicExample = ReadLine();
                WriteLine(dynamicExample);
            } // dynamic
        }
        static void TypesB()
        {

            {
                byte b = 5;
                short s = b; // 1
                int i = s; // 2
                long l = i; // 3
                decimal d = l; // 4
                object o = d; // 5
            } // Implicit cast

            {
                object strObj = "something";
                object numObj = -16;
                ushort ushrt = 5;

                short shrt = (short)ushrt; // 1
                byte bt = (byte)shrt; // 2
                sbyte sbt = (sbyte)bt; // 3
                string str = (string)strObj; // 4
                int num = (int)numObj; // 5
            } // Explicit cast

        }
        static void TypesC()
        {
            // packing
            int nt = 46;
            object a = nt;

            // unpacking
            nt = (int)a;
        }
        static void TypesD()
        {
            var a = 5;
            WriteLine(a);
            var b = "string";
            WriteLine(b);
        }
        static void TypesE()
        {
            Nullable<int> a = new Nullable<int>();
            a = 5;
            a = null;
            a = 16;
            WriteLine(a);
        }
        static void TypesF()
        {
            var a = 5;
            //a = "stur";
        }

        static void StringsA()
        {
            WriteLine(String.Compare("hello", "world"));
            WriteLine(String.Compare("hello", "hello"));
        }
        static void StringsB()
        {
            string a = "hello world!";
            string b = "zero";
            string c = "1828";

            WriteLine(a + b);
            WriteLine(String.Copy(c));
            WriteLine(a.Substring(0, 4));
            string[] words = a.Split(' ');
            foreach (string word in words)
            {
                WriteLine(word);
            }
            a = a.Remove(a.IndexOf(a.Substring(6, 6)));
            WriteLine(a);
            WriteLine($"{a} + {b} is {a + b}");
        }
        static void StringsC()
        {
            string emptyString = "";
            string nullString = null;
            if (String.IsNullOrEmpty(emptyString) && String.IsNullOrEmpty(nullString))
            {
                WriteLine("Both strings are null of empty");
            }
            else
            {
                WriteLine("One or two strings are not null or empty. Idk english ok<>");
            }
        }
        static void StringsD()
        {
            StringBuilder someString = new StringBuilder("something");
            WriteLine(someString);
            someString.Remove(0, 4);
            someString.Remove(4, 1);
            someString.Append(" ore");
            someString.Insert(0, "#");
            someString.Insert(someString.Length, "#");
            WriteLine(someString);
        }

        static void ArraysA()
        {
            int[,] arr = new int[2, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Write(arr[i, j] + " ");
                }
                WriteLine();
            }
        }
        static void ArraysB()
        {
            string[] arr = new string[3] { "hello", "world", "!" };
            foreach (string str in arr)
            {
                Write(str + " ");
            }
            WriteLine(arr.Length);
            WriteLine("Write some string and the index of element which will be replaced by your string");
            string temp = ReadLine();
            int index = Convert.ToInt32(ReadLine());
            arr[index] = temp;
            foreach (string str in arr)
            {
                Write(str + " ");
            }
            WriteLine();

        }
        static void ArraysC()
        {
            int[][] arr = new int[3][];
            arr[1] = new int[2] { 1, 2 };
            arr[2] = new int[3] { 1, 2, 3 };
            arr[3] = new int[4] { 1, 2, 3, 4 };
        }
        static void ArraysD()
        {
            var arrayValue = new int[3] { 1, 2, 3 };
            var stringValue = "hello";
        }

        static void TuplesABCD()
        {
            (int, string, char, string, ulong) some = (1, "hello", 'i', "world", 367483);
            WriteLine($"{some.Item1} {some.Item3} {some.Item4}");

            // first unpacking method
            (int num, string str, char sym, string str2, ulong num2) = some;
            WriteLine(str + str2);

            // second unpacking method
            var (anum, astr, asym, astr2, anum2) = some;
            WriteLine($"{anum} {anum2}");

            // third unpacking method
            (num, str, sym, str2, num2) = some;
            WriteLine(astr + asym);

            (int a, string b, char c, string d, ulong e) some2 = (1, "shr", 's', "fd", 356);

            WriteLine(some == some2);
        }

        static void CheckedABCD()
        {
            first();
            second();

            void first()
            {
                checked
                {
                    int a = int.MaxValue;
                }
            }
            void second()
            {
                unchecked
                {
                    int a = int.MaxValue;
                }
            }
        }
    }
}
