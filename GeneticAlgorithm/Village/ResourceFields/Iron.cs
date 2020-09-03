using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy.Village.ResourceFields
{
    public class Iron : ResourceField
    {
        public Iron(int id, int maxLvl = 5) : base(id, maxLvl, Enums.ResFieldType.Iron)
        {
            InitResTable();
        }

        public override void InitResTable()
        {
            upgradeTabel = new UpgradeItem[5]
            {
               new UpgradeItem(1, 150, new int[4] { 100, 80, 30, 60 }),
               new UpgradeItem(2, 310, new int[4] { 165, 135, 50, 100 }),
               new UpgradeItem(3, 560, new int[4] { 280, 225, 85, 165 }),
               new UpgradeItem(4, 960, new int[4] { 465, 375, 140, 280 }),
               new UpgradeItem(5, 1600, new int[4] { 780, 630, 235, 465 }),
            };
        }
    }
}
