using System;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Exercise1());
            // Console.WriteLine(Exercise2());
            //Console.WriteLine(Exercise3());
            // Console.WriteLine(Exercise4());
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Console.WriteLine(Exercise11());
            //Console.WriteLine(Exercise12());
            //Exercise13();
            //Exercise14();
           //Exercise15();
        }

        private static int Exercise1()
        {

            int a = int.Parse(Console.ReadLine());



            int sum = 0;

            while (a != 0)
            {

                sum = sum + (a % 10);

                a = a / 10;


            }
            return sum;

        }

        private static int Exercise2()
        {
            int a = int.Parse(Console.ReadLine());

            int sum = 0;
            a /= 1000;

            while (a != 0)
            {

                sum = sum + (a % 10);

                a = a / 10;


            }
            return sum;


        }
        private static int Exercise3()
        {
            int a = int.Parse(Console.ReadLine());

            int sum = 0;
            a /= 1000;

            while (a > 1000)
            {

                sum = sum + (a % 10);

                a = a / 10;


            }
            return sum;


        }
        private static int Exercise4()
        {
        l1:

            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int a);


            if (!state)
            {

                goto l1;
            }
            else
            {
                int sum = 0;
                if (a >= 10000 && a <= 99999)
                {
                    while (a != 0)
                    {

                        sum = sum + (a % 10);

                        a = a / 10000;


                    }

                }

                else
                {
                    goto l1;
                }

                return sum * sum;
            }

        }

        static void Exercise5()
        {
            int number;

            do
            {
                Console.Write("Enter a 6-digit number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && IsSixDigitNumber(number))
                {
                    ProcessNumber(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid 6-digit number.");
                }

            } while (true);
        }

        static void ProcessNumber(int number)
        {
            int firstDigit = number / 100000;
            int newNumber = (number * 10) + firstDigit;

            Console.WriteLine($"First digit: {firstDigit}");
            Console.WriteLine($"New number: {newNumber}");
        }

        static bool IsSixDigitNumber(int number)
        {
            return number >= 100000 && number <= 999999;
        }

        private static int Exercise6()
        {

        l1:

            string aStr = Console.ReadLine();

            bool state = long.TryParse(aStr, out long a);


            if (!state)
            {

                goto l1;
            }
            else
            {

                if (a >= 10000000 && a <= 99999999)
                {
                    long divisor = (long)Math.Pow(10, (int)Math.Log10(a));

                    long result = (a % divisor) / 10;
                    Console.WriteLine(result);
                }

                else
                {
                    goto l1;
                }

                return 0;

            }

        }

        private static void Exercise7()
        {
        l1:
            Console.Write("Enter a 4-digit number: ");
            if (int.TryParse(Console.ReadLine(), out int originalNumber) && IsFourDigitNumber(originalNumber))
            {
                int reversedNumber = 0;
                int temp = originalNumber;


                while (temp > 0)
                {
                    reversedNumber = reversedNumber * 10 + temp % 10;
                    temp /= 10;
                }


                int result = int.Parse("8" + reversedNumber + "8");

                Console.WriteLine("Original Number: " + originalNumber);
                Console.WriteLine("Reversed and Modified Number: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid 4-digit number.");
                goto l1;
            }
        }

        static bool IsFourDigitNumber(int number)
        {
            // Check if the number has exactly four digits
            return number >= 1000 && number <= 9999;
        }

        static void Exercise8()
        {
        l1:
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int userInputNumber))
            {
                // Extract the last digit
                int lastDigit = userInputNumber % 10;

                // Remove the last digit and extract the 3rd digit from the end
                int thirdDigitFromEnd = (userInputNumber / 100) % 10;

                // Calculate the sum
                int sum = lastDigit + thirdDigitFromEnd;

                Console.WriteLine("Last Digit: " + lastDigit);
                Console.WriteLine("3rd Digit from the End: " + thirdDigitFromEnd);
                Console.WriteLine("Sum of the Last and 3rd Digit from the End: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto l1;
            }


        }

        static void Exercise9()
        {
        l1:
            Console.Write("Enter a number: ");
            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int number);

            if (!state && (IsNineDigitNumber(number)))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto l1;

            }
            else
            {
                int newNumber = 0;
                int position = 1;
                while (number > 0)
                {
                    int digit = (number % 10);

                    if (position % 2 != 0)
                    {
                        newNumber = digit * (int)Math.Pow(10, position / 2) + newNumber;
                    }

                    number /= 10;
                    position++;
                }


                Console.WriteLine("New Number with Digits in Odd Positions: " + newNumber);
            }


        }


        static void Exercise10()
        {

        l1:
            Console.Write("Enter a number: ");
            string aStr = Console.ReadLine();

            bool state = long.TryParse(aStr, out long number);

            if (!state && (IsNineDigitNumber(number)))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto l1;

            }
            else
            {
                string originalNumberString = number.ToString();
                string oddDigitsString = "";
                string evenDigitsString = "";

                
                for (int i = 0; i < originalNumberString.Length; i++)
                {
                    int digit = (int)(originalNumberString[i] - '0');

                    if (i % 2 == 0)
                    {
                        oddDigitsString += digit;
                    }
                    else
                    {
                        evenDigitsString += digit;
                    }
                }

                
                if (long.TryParse(oddDigitsString, out long oddDigitsNumber) &&
                    long.TryParse(evenDigitsString, out long evenDigitsNumber))
                {
                    
                    long sum = oddDigitsNumber + evenDigitsNumber;

                    Console.WriteLine("Original Number: " + number);
                    Console.WriteLine("Number with Digits in Odd Positions: " + oddDigitsNumber);
                    Console.WriteLine("Number with Digits in Even Positions: " + evenDigitsNumber);
                    Console.WriteLine("Sum of Numbers with Odd and Even Digits: " + sum);
                }
                else
                {
                    Console.WriteLine("Error creating numbers.");
                }
            }

        }


        static bool IsNineDigitNumber(long number)
        {

            return number >= 100000000 && number <= 999999999;
        }

        static double Exercise11()
        {
            l1:
            Console.Write("Enter an 8-digit number: ");

            
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int eightDigitNumber))
            {
                string numberString = eightDigitNumber.ToString();

                
                if (numberString.Length != 8)
                {
                    Console.WriteLine("Please enter a valid 8-digit number.");
                    return 0; 
                }

                int sum = 0;

                
                for (int i = 0; i < numberString.Length; i += 2)
                {
                    string group = numberString.Substring(i, 2);
                    sum += int.Parse(group);
                }

                
                sum += 99;

                
                double result = sum - (0.18 * sum);

                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid 8-digit number.");
                goto l1;

            }
            
        }

    
        static int Exercise12()
        {
            int firstNumber, secondNumber;

            
            Console.Write("Enter the first 5-digit number: ");
            while (!int.TryParse(Console.ReadLine(), out firstNumber) || firstNumber < 10000 || firstNumber > 99999)
            {
                Console.WriteLine("Invalid input. Please enter a valid 5-digit number.");
                Console.Write("Enter the first 5-digit number: ");
            }

            
            Console.Write("Enter the second 5-digit number: ");
            while (!int.TryParse(Console.ReadLine(), out secondNumber) || secondNumber < 10000 || secondNumber > 99999)
            {
                Console.WriteLine("Invalid input. Please enter a valid 5-digit number.");
                Console.Write("Enter the second 5-digit number: ");
            }

            
            int sumOfDigits = SumofDigits(firstNumber);
            int productOfDigits = ProductDigits(secondNumber);
            int lastDigitOfFirstNumber = firstNumber % 10;

            
            int result = sumOfDigits + productOfDigits + lastDigitOfFirstNumber;

            return result;
        }

        static int SumofDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static int ProductDigits(int number)
        {
            int product = 1;
            while (number != 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
        
        private static void Exercise13()
        {

            Console.WriteLine("Enter the first 5-digit number: ");
            string tStr = Console.ReadLine();
            Console.WriteLine("Enter the second 5-digit number: ");
            string t1Str = Console.ReadLine();
            Console.WriteLine("Enter the third 5-digit number: ");
            string t2Str = Console.ReadLine();
            if (int.TryParse(tStr, out int t) && tStr.Length == 5 && int.TryParse(t1Str, out int t1) && t1Str.Length == 5 && int.TryParse(t2Str, out int t2) && t2Str.Length == 5)
            {
                int tf = t / 10000;
                int t1f = t1 / 10000;
                int t2f = t2 / 10000;
                int tl = t % 10;
                int t1l = t1 % 10;
                int t2l = t2 % 10;
                int tr = (tf * 10) + tl;
                int t1r = (t1f * 10) + t1l;
                int t2r = (t2f * 10) + t2l;
                int sum13 = tr + t1r + t2r;
                int result13 = (sum13 * 50) / 100;
                int result13Main = sum13 + result13;
                Console.WriteLine(result13Main);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid 5-digit number. ");
            }


        }


        private static void Exercise14()
        {
            Console.WriteLine("Task 14");
            Console.Write("Ilk 6 reqemli ededi daxil edin: ");
        l20:
            string vStr = Console.ReadLine();
            if (int.TryParse(vStr, out int v) && vStr.Length == 6)
            {
                Console.Write("Ikinci 6 reqemli ededi daxil edin: ");
            l21: string xStr = Console.ReadLine();


                if (int.TryParse(xStr, out int x) && xStr.Length == 6)
                {
                    Console.Write("Ucuncu 6 reqemli ededi daxil edin: ");
                l22: string c1Str = Console.ReadLine();
                    if (int.TryParse(c1Str, out int c1) && c1Str.Length == 6)
                    {
                        Console.Write("7 reqemli eded daxil edin: ");
                    l23: string h1Str = Console.ReadLine();
                        if (int.TryParse(h1Str, out int h1) && h1Str.Length == 7)
                        {
                            int v1 = v / 1000;
                            int x1 = x / 1000;
                            int c321 = c1 / 1000;

                            Console.WriteLine($"6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededler: {v1} ve {x1} ve {c321}");
                            int cem = v1 + x1 + c321;
                            Console.WriteLine($"Bu ededlerin cemi: {cem} ");
                            int h2 = h1 % 10000;
                            Console.WriteLine($"7 reqemli ededin son 4 reqemi: {h2}");
                            int cem1 = cem + h2;
                            Console.WriteLine($"Bu ededin ve 7 reqemli ededin son 4 reqeminden alinan ededin cemi: {cem1}");
                            int h3 = h1 / 10000;
                            Console.WriteLine($"7 reqemli ededin ilk 3 reqemi: {h3}");
                            int sum1 = 1;
                            while (h3 > 0)
                            {
                                sum1 *= h3 % 10;
                                h3 /= 10;
                            }
                            Console.WriteLine($"7 reqemli ededin ilk 3 reqeminin hasili: {sum1} ");
                            int ferq = cem1 - sum1;
                            Console.WriteLine($"Ilk 3 reqemin hasili ile bayaqki cemin ferqi: {ferq}");
                            int h4 = (ferq * 60) / 100;
                            Console.WriteLine($"Bu ededin 60 faizi: {h4}");
                            int h5 = (h4 * 100) + 60;
                            Console.WriteLine($"Bu ededin axirina 60 artirildi: {h5}");
                            int h6 = h5 - (h5 * 18) / 100;
                            Console.WriteLine($"Bu ededden ozunun 18 faizini cixiriq: {h6}");

                        }
                        else
                        {
                            Console.WriteLine("Eded 7 reqemli deyil!");
                            goto l23;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Eded 6 reqemli deyil!");
                        goto l22;

                    }

                }
                else
                {
                    Console.WriteLine("Eded 6 reqemli deyil!");
                    goto l21;

                }
            }
            else
            {
                Console.WriteLine("Eded 6 reqemli deyil!");
                goto l20;
            }



        }


        private static void Exercise15()
        {


            long number1, number2,
                number3, number4;
               int number5;

            l1:
            number1 = ReadInt("3 reqemli eded daxil ed", null);
            if (number1<100||number1>=1000)
            {

                goto l1;
            }
            number2 = ReadInt("3 reqemli eded daxil ed", null);
            if (number2 < 100 || number2 >= 1000)
            {

                goto l1;
            }
            number3 = ReadInt("6 reqemli eded daxil ed", null);
            if (number3 < 100000 || number3 >= 1000000)
            {

                goto l1;
            }
            number4 = ReadInt("6 reqemli eded daxil ed", null);
            if (number4 < 100000 || number4 >= 1000000)
            {

                goto l1;
            }

            number5 = ReadInt("7 reqemli eded daxil ed", null);
            if (number5 < 1000000 || number5 >= 10000000)
            {                                           

                goto l1;
            }
            long sumofnum1num2 = number1 + number2;
            sumofnum1num2 %= 100;
            sumofnum1num2 = Convert.ToInt32(Math.Pow(sumofnum1num2,2));

            long joinNum1Num2 = number1 * 1000 + number2+ sumofnum1num2;

            joinNum1Num2 -= (number5 % 100000);
            long sumofnum3num4 = number3 + number4;

            sumofnum3num4 %= 1000;

            joinNum1Num2 += sumofnum3num4;

            long sumofdigitfornum5 = Reversedigit(SumofDigit(number5));

            joinNum1Num2 += sumofdigitfornum5;

            joinNum1Num2 = joinNum1Num2 * 100 + 11;

            long oddplacenumber = GetNumberFromOdd(number5) - joinNum1Num2;

            oddplacenumber = ((oddplacenumber / 100) * 100 + 88) * 10 + oddplacenumber % 10;

            Console.WriteLine(oddplacenumber);
        }

        static int SumofDigit(int value)
        {

            int sum = 0;

            while(value > 0)
            {

                sum += value%10;
                value /= 10;

            }
            return sum;
        }

        static long Reversedigit(int value)
        {

            int reverse = 0;

            while (value > 0)
            {

                reverse=reverse*10+ (value%10);
                value /= 10;

            }
            return reverse;
        }
        static long GetNumberFromOdd(int value)
        {

            int newNumber = 0;
            int position = 1;
            while (value > 0)
            {
                int digit = (value % 10);

                if (position % 2 != 0)
                {
                    newNumber = digit * (int)Math.Pow(10, position / 2) + newNumber;
                }

                value /= 10;
                position++;
            }
            return newNumber;
        }
        static int ReadInt(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;
        l1:

            string aStr = Console.ReadLine();
            bool state = int.TryParse(aStr, out int a);
            if (!state)
            {
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                }
                goto l1;
            }
            return a;
        }
    }




    }

    









    
     

    
    

  
   
