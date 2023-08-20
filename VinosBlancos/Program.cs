namespace VinosBlancos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             For the sake of brevity, I put them into methods. Now I know that is not something I was supposed to,
             however the code remains the same. The methods here are not meant for reducing redundancy, but to keep
             the assignments in one project.
             The comments will not be repeated, however.
            */

            //Assignment1();
            //Assignment2();
            //Assignment2Alt();
            Assignment3();
        }

        static void Assignment1()
        {
            const int MAX_AMNT = 175388;
            const byte MAX_STAR_AMNT = 100;  // Made into constants so the value cannot be changed during runtime 
            char starChar = '*';
            int[] yearArray = new int[]
            { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };
            int[] salesArray = new int[]
            { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            for (int arrayCnt = 0; arrayCnt < salesArray.Length; arrayCnt++)  // The for the array length, one list will be output
                                                                              // on the console with stars and sales information
            {
                Console.Write(yearArray[arrayCnt] + " - ");  // Formatting to make it look nicer
                int star = MAX_STAR_AMNT * salesArray[arrayCnt] / MAX_AMNT;  // This turns the actual amount into percentages
                for (byte starCnt = 0; starCnt < star; starCnt++)
                {
                    Console.Write(starChar);
                }
                Console.Write(" " + star + "%" + " |" + salesArray[arrayCnt] + "| ");  // Formatting, as well as adding percent and value
                Console.WriteLine(string.Empty);  // Makes a linebreak for each row
            }
        }

        static void Assignment2()
        {
            const int MAX_AMNT = 175388;
            const byte MAX_STAR_AMNT = 100;
            char starChar = '*';
            int[] yearArray = new int[]
            { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };
            int[] salesArray = new int[]
            { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            for (int arrayCnt = 0; arrayCnt < salesArray.Length; arrayCnt++)
            {
                if (yearArray[arrayCnt] == 2014)  // When the array hits the matching value it adds the
                                                  // number to the"yearArray"-array (2014) for that element
                                                  // This could also be done by salesArray, being 152620, instead
                {
                    salesArray[arrayCnt] = salesArray[arrayCnt] + 35432;
                }
                Console.Write(yearArray[arrayCnt] + " - ");
                int star = MAX_STAR_AMNT * salesArray[arrayCnt] / MAX_AMNT;
                for (byte starCnt = 0; starCnt < star; starCnt++)
                {
                    Console.Write(starChar);
                }
                Console.Write(" " + star + "%" + " |" + salesArray[arrayCnt] + "| ");
                Console.WriteLine(string.Empty);
            }
        }

        static void Assignment2Alt()
        {
            const int MAX_AMNT = 152620 + 35432;  // A constant can be edited outside runtime,
                                                  // therefore 188052 becomes the new max value,
                                                  // and it now goes up to 100% as the maximum percentage
            const byte MAX_STAR_AMNT = 100;
            char starChar = '*';
            int[] yearArray = new int[]
            { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };
            int[] salesArray = new int[]
            { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            for (int arrayCnt = 0; arrayCnt < salesArray.Length; arrayCnt++)
            {
                if (yearArray[arrayCnt] == 2014)
                {
                    salesArray[arrayCnt] = salesArray[arrayCnt] + 35432;
                }
                Console.Write(yearArray[arrayCnt] + " - ");
                int star = MAX_STAR_AMNT * salesArray[arrayCnt] / MAX_AMNT;
                for (byte starCnt = 0; starCnt < star; starCnt++)
                {
                    Console.Write(starChar);
                }
                Console.Write(" " + star + "%" + " |" + salesArray[arrayCnt] + "| ");
                Console.WriteLine(string.Empty);
            }
        }

        static void Assignment3()
        {
            const int MAX_AMNT = 152620 + 35432;
            const byte MAX_STAR_AMNT = 100;
            char starChar = '*';
            int[] yearArray = new int[]
            { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };
            int[] salesArray = new int[]
            { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            for (int arrayCnt = 0; arrayCnt < salesArray.Length; arrayCnt++)
            {
                if (salesArray[arrayCnt] == 152620)  // Using the salesArray value, instead of year
                {
                    salesArray[arrayCnt] = salesArray[arrayCnt] + 35432;
                }
                Array.Sort(salesArray, yearArray);  // By overloading the sort, it will use first array as a key,
                                                    // and the other as item, which will thusly be sorted according to the key,
                                                    // however since the value is added to 152620 within the loop,
                                                    // it has to be put after the if statement, to be sorted properly
                Console.Write(yearArray[arrayCnt] + " - ");
                int star = MAX_STAR_AMNT * salesArray[arrayCnt] / MAX_AMNT;
                for (byte starCnt = 0; starCnt < star; starCnt++)
                {
                    Console.Write(starChar);
                }
                Console.Write(" " + star + "%" + " |" + salesArray[arrayCnt] + "| ");
                Console.WriteLine(string.Empty);
            }
        }
    }
}