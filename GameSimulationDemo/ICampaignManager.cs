using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
