using System;

namespace Gates.Model
{
    class Logo
    {
        public static void printLogo()
        {
        string upperPattern = "    =========    ";
        string anglePattern = "  //  Gates  \\\\  ";
        string sidePattern = "  ||         ||  ";


            Console.WriteLine(string.Format("{0}{0}{0}{0}{0}{0}{0}", upperPattern));
            Console.WriteLine(string.Format("{0}{0}{0}{0}{0}{0}{0}", anglePattern));

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(string.Format("{0}{0}{0}{0}{0}{0}{0}", sidePattern));
            }

        }
    }
}
