namespace Assignment_1_c__with_oop
{
    [Flags]


    enum SeasOn
    {
        Spring, Summer, Autumn, Winter

    }


    ////enum WeekDays:byte
    ////{
    ////    Monday = 1 , Tuesday = 2, Wednesday = 4, Thursday = 8 , Friday = 16 , Saturday = 32, sunday = 64 

    ////}

    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion 1 

            //WeekDays Day = (WeekDays) 127 ;

            //Console.WriteLine(Day);
            #endregion

            #region MyRegion 2



            Console.WriteLine("Please Enter The Month :");
            string month = Console.ReadLine();
            if (month == "march " || month == " april" || month == "may")
            {
                SeasOn season = SeasOn.Spring;
                Console.WriteLine(season);
            }


            else if (month == "june " || month == " july" || month == "august")
            {
                SeasOn season = SeasOn.Summer;
                Console.WriteLine(season);
            }

            else if (month == "septembar " || month == "october " || month == "november")
            {
                SeasOn season = SeasOn.Autumn;
                Console.WriteLine(season);
            }

            else
            {
                SeasOn season = SeasOn.Winter;
                Console.WriteLine(season);
            }

            #endregion

        }
    }
    }

