using System;

namespace Fieserv
{
    public class Campaign
    {
        int DayCount { get; set; }
        List<of DailyOrder> DailyOrder DailyOrder { get; set; }

        void Campaign(int Days){
            DayCount = Days;

        }

    }

    public class DailyOrder
    {
        int NoOfOrder { get; set; }
        double[] OrderAmount { get; set; }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The first line of the input contains the duration of the campaign in days" + 
                              Environment.NewLine + 
                              "The integers in the(i + 1) th line are the details of the orders placed on the i th day of the campaign."
                             );



            int campaignDays = GetCampaignDays();

            if (!(campaignDays >= 1 && campaignDays <= 5000))
            {
                Console.WriteLine("Campaign days must be between 1 and 5000.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < campaignDays; i++)
            {

            }

            string inputDays = Console.ReadLine();

            Int32.TryParse(inputDays,out daysCampaignDuration);

            if (!(daysCampaignDuration >= 1 && daysCampaignDuration <=5000))
            {
                Console.WriteLine("Campaign days must be between 1 and 5000.");
                Console.ReadKey();
                return;
            }



        }

        //Returns campaign days, or 0
        static int GetCampaignDays() {
            int daysCampaignDuration = 0;
            string inputDays = Console.ReadLine();

            Int32.TryParse(inputDays, out daysCampaignDuration);

            return daysCampaignDuration;
        }
    }
}
