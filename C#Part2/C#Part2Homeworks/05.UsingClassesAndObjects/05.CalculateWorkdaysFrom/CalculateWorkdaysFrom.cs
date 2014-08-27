using System;
using System.Threading;

class CalculateWorkdaysFrom
{
    static void Main()
    {
        Console.WriteLine("Enter date in format(day.month): ");// samo za 2014
        string date = Console.ReadLine();
        DateTime dateNow = DateTime.Now;
        int result = CalculateWorkdays(date, dateNow);
        Console.WriteLine("Workdays between {0:dd.MM.yyyy} is: {1} days.", dateNow, result);
    }

    static int CalculateWorkdays(string date, DateTime dateNow)
    {
        int result = 0;        
        string[] split = date.Split('.', ',');
        string day = split[0];
        string month = split[1];
        DateTime inputDate = new DateTime(2014, int.Parse(month), int.Parse(day));
        bool isValidDate = false;

        
        isValidDate = validateInput(day, month);
        if (isValidDate == false)
        {
            Console.WriteLine("Wrong date!!!");
        }
        if (dateNow >= inputDate)
        {
            Console.WriteLine("Enter date bigger than today!!!");
            return result;
        }
        for (int i = 0; i < 365; i++)
        {
            bool holiday = false;
            holiday = isHoliday(dateNow);
            if ((dateNow.DayOfWeek != DayOfWeek.Sunday) && 
                (dateNow.DayOfWeek != DayOfWeek.Saturday) && !holiday)
            {
                result++;
            }
            dateNow = dateNow.AddDays(1);           
            if (dateNow.Date == inputDate.Date)
            {
                break;
            }
        }


        return result;
    }
    static bool isHoliday(DateTime inputDate)
    {
        DateTime[] officialHolidays = 
        {
            new DateTime(2014, 1, 1), // Нова година
            new DateTime(2014, 3, 3), // Ден на Освобождението на България 
            new DateTime(2014, 4, 18), // Великден
            new DateTime(2014, 4, 19), // Великден - събота
            new DateTime(2014, 4, 20), // Великден - неделя
            new DateTime(2014, 5, 6), // Великден
            new DateTime(2014, 5, 1), // Ден на труда 
            new DateTime(2014, 5, 2), // Отработва се на 10,05
            new DateTime(2014, 5, 5), // Отработва се на 31,05
            new DateTime(2014, 5, 6), // Гергьовден, Ден на храбростта и Българската армия
            new DateTime(2014, 5, 24), // Ден на българската просвета и култура и на славянската писменост - събота
            new DateTime(2014, 9, 6), // Ден на Съединението на България - събота
            new DateTime(2014, 9, 22), // Ден на Независимостта на България
            new DateTime(2014, 11, 1), // Ден на народните будители - събота
            new DateTime(2014, 12, 24), // Бъдни вечер
            new DateTime(2014, 12, 25), // Рождество Христово (Коледа)
            new DateTime(2014, 12, 26), // Рождество Христово (Коледа)
            new DateTime(2014, 12, 31), // Отработва на 13,12
        };
        for (int i = 0; i < officialHolidays.Length; i++)
        {
            if (inputDate.Day == officialHolidays[i].Day && inputDate.Month == officialHolidays[i].Month)
            {
                return true;
            }
            else
            {
                continue;
            }
        }
        return false;
    }

    static bool validateInput(string day, string month)
    {
        if (int.Parse(day) < 1 || int.Parse(day) > 31)
        {
            return false;
        }
        else if (int.Parse(month) < 1 || int.Parse(month) > 12)
        {
            return false;
        }
        else
        {
            return true;
        }        
    }

    
}

