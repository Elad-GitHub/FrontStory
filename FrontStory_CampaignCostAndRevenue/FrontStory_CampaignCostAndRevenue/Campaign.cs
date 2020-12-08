using System;

namespace FrontStory_CampaignCostAndRevenue
{
    public class Campaign
    {
        public DateTime Date { get; set; }       
        public string Name { get; set; }
        public int Clicks { get; set; }
        public double Cost { get; set; }
        public double Revenue { get; set; }
        public double UV { get; set; }
        public double CPC { get; set; }
        public double ROI { get; set; }
        public double Profit { get; set; }
    }
}
