using System;

namespace övning2._3
{

    class övning2_3
    {

        static void Main(string[] args)
        {
            //300kr för att starta + 500kr för alla dagar efteråt.
            Console.WriteLine("Hur många dagar ska du hyra bilen?");
            string tidtext = Console.ReadLine();

            //+1kr för varje kilometer.
            Console.WriteLine("Hur många kilometer ska du köra den varje dag?");
            string distanstext = Console.ReadLine();

            double tid = double.Parse(tidtext);
            double distans = double.Parse(distanstext);

            double total_distans = (distans * tid);

            double kostnad_tid = ((tid * 500) - 200);

            double kostnad_total = (total_distans + kostnad_tid);   

            Console.WriteLine("Hyran kommer då att bli totalt " + kostnad_total + "kr");

        }

    }

}