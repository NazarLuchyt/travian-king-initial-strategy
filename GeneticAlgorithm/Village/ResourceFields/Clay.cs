using InitialStrategy.Village.Abstract;
using InitialStrategy.Village.Additional;

namespace InitialStrategy.Village.ResourceFields
{
    public class Clay : ResourceField
    {
        public Clay(int id, int maxLvl = 5) : base(id, maxLvl, Enums.ResFieldType.Clay)
        {
            InitResTable();
        }

        public override void InitResTable()
        {
            upgradeTabel = new UpgradeItem[5]
            {
               new UpgradeItem(1, 70, new int[4] { 80, 40, 80, 50 }),
               new UpgradeItem(2, 180, new int[4] { 135, 65, 135, 85 }),
               new UpgradeItem(3, 360, new int[4] { 225, 110, 225, 140 }),
               new UpgradeItem(4, 640, new int[4] { 375, 185, 375, 235 }),
               new UpgradeItem(5, 1100, new int[4] { 620, 310, 620, 390 }),
            };
        }
    }
}
