using System;

    class SwitchConvertNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number between 0 and 999.");
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num >= 999)
            {
                Console.WriteLine("Wrong number");
            }
            else
            {
                int firstDigit = num % 10;
                int secondDigit = (num % 100) / 10;
                int thirdDigit = (num % 1000) / 100;
                string textNumber = "0";
                switch (firstDigit)
                {
                    case 0: if (secondDigit == 0 && thirdDigit == 0)
                            {
                                textNumber = "Zero"; 
                            }
                            else
                            {
                                textNumber = "";
                            }
                            break;
                    case 1: textNumber = "one"; break;
                    case 2: textNumber = "two"; break;
                    case 3: textNumber = "three"; break;
                    case 4: textNumber = "four"; break;
                    case 5: textNumber = "five"; break;
                    case 6: textNumber = "six"; break;
                    case 7: textNumber = "seven"; break;
                    case 8: textNumber = "eight"; break;
                    case 9: textNumber = "nine"; break;                    
                }
                    switch (secondDigit)
                    {
                        case 0: break;
                        case 1:
                            if (firstDigit >= 0 && firstDigit <= 5)
                            {
                                switch (firstDigit)
                                {
                                    case 0: textNumber = "ten"; break;
                                    case 1: textNumber = "eleven"; break;
                                    case 2: textNumber = "twelve"; break;
                                    case 3: textNumber = "thirthteen"; break;
                                    case 4: textNumber = "fourteen"; break;
                                    case 5: textNumber = "fifteen"; break;
                                }
                            }
                            else
                            {
                                textNumber = textNumber + "teen";
                            }
                            break;
                        case 2: textNumber = "twenty" + " " + textNumber; break;                       
                        case 3: textNumber = "thirty" + " " + textNumber; break;                        
                        case 4: textNumber = "fourty" + " " + textNumber; break;
                        case 5: textNumber = "fifty" + " " + textNumber; break;
                        case 6: textNumber = "sixty" + " " + textNumber; break;
                        case 7: textNumber = "seventy" + " " + textNumber; break;
                        case 8: textNumber = "eighty" + " " + textNumber; break;
                        case 9: textNumber = "ninety" + " " + textNumber; break;
                    }
                        switch (thirdDigit)
                        {
                            case 0: break;
                            case 1: textNumber = "One hundred and" + " " + textNumber; break;
                            case 2: textNumber = "Two hundred and" + " " + textNumber; break;
                            case 3: textNumber = "Three hundred and" + " " + textNumber; break;
                            case 4: textNumber = "Four hundred and" + " " + textNumber; break;
                            case 5: textNumber = "Five hundred and" + " " + textNumber; break;
                            case 6: textNumber = "Six hundred and" + " " + textNumber; break;
                            case 7: textNumber = "Seven hundred and" + " " + textNumber; break;
                            case 8: textNumber = "Eight hundred and" + " " + textNumber; break;
                            case 9: textNumber = "Nine hundred and" + " " + textNumber; break;
                        }
                Console.WriteLine(textNumber);                
            }
        }
    }

