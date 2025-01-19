namespace Assignment_1_c__with_oop
{
    [Flags]

    enum Colours
    {

        Red = 1, Green = 2, Blue = 4

    }


    enum Premission : byte
    {
        Read = 1, write = 2, Delete = 4, Execute = 8, Test = 16
    }

    enum SeasOn
    {
        Spring, Summer, Autumn, Winter

    }


    enum WeekDays : byte
    {
        Monday = 1, Tuesday = 2, Wednesday = 4, Thursday = 8, Friday = 16, Saturday = 32, sunday = 64

    }

    internal class Program
    {
        static void Main(string[] args)
        {


            #region MyRegion 1 

            //foreach (WeekDays days  in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(days);
            //}
            #endregion

            #region MyRegion 2



            //Console.WriteLine("Please Enter The Month :");
            //string month = Console.ReadLine();
            //if (month == "march " || month == " april" || month == "may")
            //{
            //    SeasOn season = SeasOn.Spring;
            //    Console.WriteLine(season);
            //}


            //else if (month == "june " || month == " july" || month == "august")
            //{
            //    SeasOn season = SeasOn.Summer;
            //    Console.WriteLine(season);
            //}

            //else if (month == "septembar " || month == "october " || month == "november")
            //{
            //    SeasOn season = SeasOn.Autumn;
            //    Console.WriteLine(season);
            //}

            //else
            //{
            //    SeasOn season = SeasOn.Winter;
            //    Console.WriteLine(season);
            //}



            //SeasOn seasOn;
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true,out seasOn))
            //{
            //    switch (seasOn) { 

            //    case SeasOn.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case SeasOn.Summer:
            //            Console.WriteLine("June to Agust");
            //            break;
            //            case SeasOn.Autumn:
            //            Console.WriteLine("Septemaber to November"); 
            //            break;
            //            case SeasOn.Winter :
            //            Console.WriteLine("Decamber to Feburary");
            //            break;
            //            default:                    
            //            Console.WriteLine("Invalid Input ");
            //            break;
            //    }

            //}

            #endregion

            #region MyRegion 3
            //Premission myP = Premission.Read;
            //Console.WriteLine(myP);

            //myP |= Premission.write;
            //Console.WriteLine(myP);

            //myP &=~ Premission.write;
            //Console.WriteLine(myP);

            //if ((myP & Premission.Execute) == Premission.Execute)
            //    Console.WriteLine("Permission Is Exist");
            //else
            //    Console.WriteLine("Permission Not Exist");
            #endregion

            #region MyRegion 4

            //Console.WriteLine("Please Enter Colour Name :");
            //string input = Console.ReadLine();
            //Colours colour; 

            //if (Enum.TryParse(input , true , out colour))
            //{

            //    Console.WriteLine($"{colour} is primary colour");

            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not primary colour");
            //}


            #endregion
        }
    }
    }

