namespace PoPRefactoring
{
    public class PopProject
    {
        public static void Main(string[] args)
        {
            const string ProvideDate = "Introdueix el dia, mes i any";
            const string FormatError = "El format no és correcte";
            const string CorrectDate = "La data és correcta";

            int day, month, year;

            Console.WriteLine(ProvideDate);
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(valida(day, month, year) ? FormatError : CorrectDate);
        }

        public static bool valida(int day, int month, int year)
        {
            const int MinDayMonth = 1, MaxDay = 31, MaxMonth = 12;
            const int Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6;
            const int Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12;
            const int ShortMonth = 30, LongMonth = 31, FebPass = 29, FebNotPass = 28;
            int totalDaysMonth = 0;

            if (day < MinDayMonth || day > MaxDay)

                return false;

            if (month < MinDayMonth || month > MaxMonth)

                return false;



            switch (month)
            {

                case Jan:

                case Mar:

                case May:

                case Jul:

                case Aug:

                case Oct:

                case Dec: totalDaysMonth = LongMonth; break;

                case Apr:

                case Jun:

                case Sep:

                case Nov: totalDaysMonth = ShortMonth; break;

                case Feb:

                    if (IsPassYear(year))
                        totalDaysMonth = FebPass;

                    else totalDaysMonth = FebNotPass;

                    break;

            }

            return day > totalDaysMonth;

        }
        public static bool IsPassYear(int year)
        {
            const int PassYear = 4;
            return year % PassYear == 0;
        }
    }
}


