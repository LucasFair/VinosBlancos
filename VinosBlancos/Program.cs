namespace VinosBlancos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const int MAX_AMNT = 175388;
            const byte MAX_STAR_AMNT = 100;

            int[,] salesYears = new int[,]
            {
                {2009, 175134}, {2010, 175388}, {2011, 172818}, {2012, 142709}, {2013, 151437}, {2014, 152620}, 
                {2015, 150979}, {2016, 152210}, {2017, 149450}, {2018, 154398}, {2019, 150160}
            };
            

            /*
            const int MAX = 50000;
            const byte MAX_STAR = 24;

            int testVal = 44270;

            int star = MAX_STAR * testVal / MAX;
            
            Console.WriteLine(star);

            for (int i = 0; i < star; i++)
            {
                Console.WriteLine("*");
            }
            */

            /*
            for (int i = 0; i < salesYears.GetLength(0); i++)
            {
                int elmnt_0 = salesYears[i, 0];
                int elmnt_1 = salesYears[i, 1];

                Console.WriteLine("Year = {0}, Sale = {1}", elmnt_0, elmnt_1 );
            }
            */

            for (int i = 0; i < salesYears.GetLength(0); i++)
            {
                int elmnt_0 = salesYears[i, 0];
                Console.WriteLine("Year = {0}", elmnt_0);
                for (int j = 0; j < salesYears.GetLength(1); j++)
                {
                    
                }

            }
        }
    }
}