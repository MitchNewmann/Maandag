using System;
using System.Collections.Generic;
using System.Text;

namespace Gates.Model
{
    static class ChoiceGeneric
    {
        public static int makeChoice(string x)
        {
            string keuze = x;
            int choice = 0;

            Int32.TryParse(keuze, out choice);

            return choice;
        }
    }
}
