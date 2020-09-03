using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialStrategy.Village.ResourceFields
{
    class Crop : ResourceField
    {
        public Crop(int id, int maxLvl = 5) : base(id, maxLvl, Enums.ResFieldType.Crop)
        {
            InitResTable();
        }

        public override void InitResTable()
        {
            upgradeTabel = new UpgradeItem[5]
            {
               new UpgradeItem(1, 50, new int[4] { 70, 90, 70, 20 }),
               new UpgradeItem(2, 120, new int[4] { 115, 150, 115, 35 }),
               new UpgradeItem(3, 300, new int[4] { 195, 250, 195, 55 }),
               new UpgradeItem(4, 550, new int[4] { 325, 420, 325, 95 }),
               new UpgradeItem(5, 940, new int[4] { 545, 700, 545, 155 }),
            };
        }
    }
}
