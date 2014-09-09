namespace Methods
{
    using System;

    public class Methods
    {   
        public static void Main()
        {
            Console.WriteLine("The area is: " + CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToString(5));
            
            Console.WriteLine("Maximal number is: " + FindMaxNumber(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontalOrVertical(3, 3));
            Console.WriteLine("Vertical? " + IsHorizontalOrVertical(-1, 2.5));

            Student peter = new Student()
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                BirthDate = "12.03.1992",
                OtherInfo = "From Sofia, born at 03.17.1992"
            };

            Student stella = new Student()
            {
                FirstName = "Stella",
                LastName = "Markova",
                BirthDate = "03.11.1993",
                OtherInfo = "From Vidin, gamer, high results, born at"
            };
            bool isOlder = Student.IsOlderThan(peter.BirthDate, stella.BirthDate);
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, isOlder);
        }
        
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {                
                throw new ArgumentException("Wrong input!!!Sides should be positive.");
            }

            double perimeter = (a + b + c) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            return area;
        }

        public static string NumberToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number!");
            }
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("Empty entry!!!");
            }
            
            int maxNumber = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        public static void PrintAsNumber(object number, string format) 
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static bool IsHorizontalOrVertical(double firstCoord, double secondCoord)
        {
            if (firstCoord == secondCoord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)           
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }
    }
}